using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_str_431
{
    class Excuse
    {
        public string ExcusePath { get; set; }
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }

        public Excuse (string fileName)
        {
            OpenFile(fileName);
        }
        public Excuse ()
        {
            ExcusePath = "";
        }
        public Excuse (Random random, string folderPath )
        {
            string[] excuses = Directory.GetFiles(folderPath, "*.txt");
            string randomExcuse = excuses[random.Next(excuses.Length)];
            OpenFile(randomExcuse);
            
        }
        
        public void OpenFile (string fileName)
        {
            ExcusePath = fileName;

            using (StreamReader sr = new StreamReader(fileName))
            {
                Description = sr.ReadLine();
                Results = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine()); 
            }
        }

        public void SaveFile(string fileName)
        {
            
            using (StreamWriter sw = new StreamWriter(fileName))
            {

                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);


            }
        }


    }
}
