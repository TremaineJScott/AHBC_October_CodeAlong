using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public static class ExportDataManager
    {
        public static void ExportData(string data, string fileName)
        {
            // Logic to write data to a file
        }

        public static void ExportData(string data, DataRepository dataRepository)
        {
            // Logic to write data to a database
        }

        public static DataRepository ExportData(string data)
        {
            // Logic to write data to a database
            DataRepository database = new DataRepository();
            // Write to database
            // Return repository object
            return database;
        }
    }
}
