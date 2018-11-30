// Carlos Fuentes
// ITSE 1430
// November 23, 2018
// ProductDatabase.cs

using System;
using System.Collections.Generic;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
			//TODO: Check arguments
			if (product == null)
				throw new ArgumentNullException("product");
			ObjectValidator.TryValidate(product);

			//TODO: Validate product
			try
			{
				//_database.Add(
				AddCore(product);
			}
			catch (Exception e)
			{
				throw new Exception("Add failed", e);
			};

            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
			//TODO: Check arguments
			var existing = Get(id);
			if (existing == null)
				throw new ArgumentOutOfRangeException("id");

			return GetCore(id);
        }
        
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }
        
        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
			//TODO: Check arguments
			var existing = Get(id);
			if (existing == null)
				throw new ArgumentOutOfRangeException("id");
			
			RemoveCore(id);
        }
        
        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( Product product )
        {
			//TODO: Check arguments
			var exists = product.Name;
			//if (product == null)
			//	throw new ArgumentNullException("product");
			//else 
			if (exists != product.Name)
				throw new ArgumentException("product");

			ObjectValidator.TryValidate(product);

			//TODO: Validate product
			try
			{
				Update(product);      // double check this it may be UpdateCare(product); but it gave an error
			}
			catch (Exception e)
			{
				throw new Exception("Updated failed", e);
			};


			//Get existing product
			var existing = GetCore(product.Id);
			return UpdateCore(existing, product);

		}
		
		#region Protected Members

		protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );
        #endregion
    }
}
