/*
Carlos Fuentes
ITSE 1430
 */

using EventPlanner.Memory;
using System;

namespace EventPlanner.Mvc.App_Start
{
	public static class DatabaseFactory
	{		
		static DatabaseFactory()
		{
			eventDatabase = new MemoryEventDatabase();

			//var db = new MemoryEventDatabase();

			eventDatabase.Add(new ScheduledEvent()
			{
				Name = "Doctor Apportionment",
				Description = "Yearly Exam",
				StartDate = DateTime.Parse("12/15/18"),
				EndDate = DateTime.Parse("12/15/18"),
				IsPublic = false
			});

			//Database = db;
		}

		private static MemoryEventDatabase eventDatabase;
		//private DatabaseFactory() { }

		//public static IEventDatabase Database { get; }
		public static MemoryEventDatabase GetMemoryEventDatabase()
		{
			return eventDatabase;
		}
	}	
}