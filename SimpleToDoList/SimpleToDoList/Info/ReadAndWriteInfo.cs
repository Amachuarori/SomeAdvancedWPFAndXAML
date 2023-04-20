using Newtonsoft.Json;
using SimpleToDoList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.Info
{
    internal class ReadAndWriteInfo
    {
        private readonly string PATH;

        public ReadAndWriteInfo(string path)
        {
            PATH = path;
        }
        public BindingList<ToDoModel> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<ToDoModel>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoModel>>(fileText);  
            }
        }

        public void WriteData(object toDoDataList) 
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(toDoDataList);
                writer.Write(output);
            }
            
        }
    }
}
