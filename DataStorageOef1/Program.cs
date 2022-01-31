using DataStorageOef1.Data;
using DataStorageOef1.Views;
using SMUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorageOef1
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DataStore();
            var menu = new Menu();

            menu.AddOption('1',"Set Student Details", () => store.SetStudent(StudentViews.CreateStudent()));
            menu.AddOption('2', "Show Student Details", () => StudentViews.ShowStudents(store.Students));
            menu.Start();
            store.SaveData();
        }
    }
}
