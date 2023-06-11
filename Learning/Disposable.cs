using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class File {
        public string Name;

        public File(string name)
        {
            Name = name;
        }
    }
    public class FileHandler:IDisposable
    {
        private File File_file;
        private bool disposedObject;
        private int total = 0;
        public FileHandler(string fileName)
        {
            if (File_file == null)
            {
                File_file = new File(fileName);
                total++;
            }
        }

        public void GetFileDetails() {
            Console.WriteLine("Total no of file: {0}", total);
            Console.WriteLine("file Name: {0}", File_file.Name);
        }
        public void Dispose(bool dispose)
        {
            if (!disposedObject)
            {
                if (dispose)
                {
                    total = 0;
                }
                Console.WriteLine("Disposing file");
                disposedObject = true;
                File_file = null;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~FileHandler()
        {
            Dispose(false);
        }
    }
}
