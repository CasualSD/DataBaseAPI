using DataStorageOef1.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorageOef1.Data
{
    class DataStore
    {
        ProjectData data;

        public List<Student> Students => data.StudentDetails;

        public void SetStudent(Student student)
        {
            data.StudentDetails.Add(student);
        }

        public DataStore()
        {
            if (System.IO.File.Exists("data.json"))
            {
                var input = System.IO.File.ReadAllText("data.json");
                data = JsonConvert.DeserializeObject<ProjectData>(input);
            }else
            {
                data = new ProjectData();
            }
        }

        public void SaveData()
        {
            var content = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText("data.json", content);
        }
    }
}
