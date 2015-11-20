using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MyResearch
{
    [Serializable]
    class FileManager
    {
        
        public static void WriteToFile(string path, object employees)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream filesStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                binaryFormatter.Serialize(filesStream, employees);
            }
            Console.WriteLine("Saved in binary format");
        }

        
    }
}
