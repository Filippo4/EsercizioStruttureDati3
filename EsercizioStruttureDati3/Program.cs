using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioStruttureDati3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire il nome del file");
            string file1=Console.ReadLine();
            Console.WriteLine("inserire il nome del file su cui vuoi copiarlo");
            string file2 = Console.ReadLine();
            if(File.Exists(file1))
            {
                using (StreamReader sr = new StreamReader(file1, Encoding.UTF8))
                {
                    string line;
                    using (StreamWriter sw = new StreamWriter(file2, false, Encoding.UTF8))
                    {
                       
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(line);
                        }
                    }
                    
                }
            }
        }
    }
}
