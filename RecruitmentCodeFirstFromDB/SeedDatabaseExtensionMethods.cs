using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentCodeFirstFromDB
{
	public static class SeedDatabaseExtensionMethods
	{
		/// <summary>
		/// extension method of RecruitmentEntities to 
		/// zero out the db tables, then seed all tables with initial data
		/// </summary>
		public static void SeedDatabase(this RecruitmentEntities context)
		{
			// set up database log to write to output window in VS
			context.Database.Log = (s => Debug.Write(s));

			//Remove everything
			context.Database.Delete();

			// Create() creates a table for each entity. It even does this
			context.Database.Create();

			// Read script file from SQLScripts folder inside solution folder
			string seedScript = File.ReadAllText(@"./../../../SQLScripts/SeedData.sql");

			//Run script
			context.Database.ExecuteSqlCommand(seedScript);

		}

		public static void SaveDatabaseToXML(this RecruitmentEntities context)
		{
		
			//TODO
		}
	}
}
