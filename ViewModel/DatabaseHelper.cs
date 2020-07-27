using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.ViewModel
{
    class DatabaseHelper
    {
        private static string  dbFile = Path.Combine(Environment.CurrentDirectory, "notesDb.db3");

        public static bool Insert<T>(T item)
        {
            bool result = false;
            using(SQLiteConnection conn= new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows=conn.Insert(item);
              if(numberOfRows>0)
                {
                    result = true;
                }
            }


            return result;
        }
        public static bool Update<T>(T item)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                //update , insert and delete return the number of rows that were modified 
                int numOfRows=conn.Update(item);
                if (numOfRows > 0)
                {
                    result = true;
                }
            }


            return result;
        }

        public static bool Delete<T>(T item)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows=conn.Delete(item);
                if (numberOfRows > 0)
                {
                    result = true;
                }
            }


            return result;
        }
    }
}
