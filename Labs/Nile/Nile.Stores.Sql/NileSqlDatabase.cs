using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
	public class NileSqlDatabase : ProductDatabase
	{
		public NileSqlDatabase(string connectionString)
		{
			// Validate
			if (connectionString == null)
				throw new ArgumentNullException(nameof(connectionString));
			if (connectionString == "")
				throw new ArgumentException("Connection string cannot be empty."
							, nameof(connectionString));

			_connectionString = connectionString;
		}
		private readonly string _connectionString;

		protected override Product AddCore(Product product)
		{
			using (var conn = CreateConnection())
			{
				var cmd = new SqlCommand("AddProduct", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@name", product.Name);
				cmd.Parameters.AddWithValue("@description", product.Description);
				cmd.Parameters.AddWithValue("@price", product.Price);
				cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

				conn.Open();
				var result = cmd.ExecuteScalar();
				var id = Convert.ToInt32(result);
			};

			return null;
		}

		protected override IEnumerable<Product> GetAllCore()
		{
			var ds = new DataSet();

			using (var conn = CreateConnection())
			{
				var da = new SqlDataAdapter();
				var cmd = new SqlCommand("GetAllProducts", conn);
				cmd.CommandType = CommandType.StoredProcedure;

				da.SelectCommand = cmd;
				da.Fill(ds);
			}

			var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
			if (table == null)
				return Enumerable.Empty<Product>();

			var products = new List<Product>();
			foreach (var row in table.Rows.OfType<DataRow>())
			{
				var product = new NileSql()
				{
					Id = Convert.ToInt32(row["Id"]),
					Name = row.Field<string>("Name"),
					Description = Convert.ToString(row[2]),
					Price = Convert.ToInt32(row[3]),
					IsDiscontinued = Convert.ToBoolean(row[4]),
				};
				products.Add(product);
			}
				return products;
		}

		protected override Product GetCore(int id)
		{
			return null;
		}

		protected override void RemoveCore(int id)
		{
			//var product =					net to figure our Get(or FindByName in Section 4)
		}

		//protected override Product Get (int id)
		//{
		//	return null;
		//}

		protected override Product UpdateCore(Product existing, Product newItem)
		{
			using (var conn = CreateConnection())
			{
				var cmd = conn.CreateCommand();
				cmd.CommandText = "UpdateProduct";
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				var id = GetProductId(existing);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.Parameters.AddWithValue("@name", newItem.Name);
				cmd.Parameters.AddWithValue("@description", newItem.Description);
				cmd.Parameters.AddWithValue("@price", newItem.Price);
				cmd.Parameters.AddWithValue("@isDiscontinued", newItem.IsDiscontinued);

				conn.Open();
				cmd.ExecuteNonQuery();
			};

			return newItem;
		}

		private SqlConnection CreateConnection() => new SqlConnection(_connectionString);

		private object GetProductId(Product product)
		{
			var sql = product as NileSql;

			return sql?.Id ?? 0;
		}
	}
}
