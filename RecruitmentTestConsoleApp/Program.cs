using RecruitmentCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RecruitmentEntities context = new RecruitmentEntities())
            {
                //context.SeedDatabase();

                DisplayTable(context.Jobs);
                DisplayTable(context.Perks);
                DisplayTable(context.Applications);
                DisplayTable(context.Candidates);
                DisplayTable(context.Companies);
                DisplayTable(context.Interviews);
                
                Console.Read();

            }

        }

        /// <summary>
        /// Display all the table rows 
        /// </summary>
        /// <param name="table"></param>
        public static void DisplayTable(DbSet table)
        {
            Console.WriteLine($"{table.ElementType.Name}s \n");
            foreach (var row in table)
                Console.WriteLine(row.ToString());
            Console.WriteLine("------------ END -----------");
        }
    }
}
