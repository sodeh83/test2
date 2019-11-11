using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FileFunctions
    {
        public void CreateFile(string content, string path)
        {
            FileStream stream = 
                new FileStream(path, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(content);
            }
        }

        public void WriteByBinaryWriter(string content, string path)
        {
            FileStream stream =
                new FileStream(path, FileMode.Create);

            using (BinaryWriter binaryWriter = new BinaryWriter(stream))
            {
                binaryWriter.Write(content);
            }

        }

        public string ReadFile(string path)
        {
            string fileContent = string.Empty;

            using (StreamReader reader = new StreamReader(path))
            {
                fileContent = reader.ReadToEnd();               
            }

            return fileContent;
        }

        public string ReadByBinaryReader(string path)
        {
            FileStream stream =
                new FileStream(path, FileMode.Open);

            using (BinaryReader binaryReader = new BinaryReader(stream))
            {
                return binaryReader.ReadString();
            }
            
        }

       

        public bool DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exc)
            {
                //Log system
                Console.Write(exc.Message);
                return false;
            }
            return true;
        }

        
    }
}
