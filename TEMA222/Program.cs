using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("print text from file:");
                string file = System.IO.File.ReadAllText(@"C:\WINDOWS\win.ini");
                Console.Write($"text from file win from directory C:\\WINDOWS\\win.ini is: {file} ");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("fisierul nu a fost gasit.",ex);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("folderul nu a fost gasit",ex);

            }
            
            catch ( Exception ex)
            {
                Console.WriteLine("ignore that", ex);
                
            }

           Console.ReadLine();
        }
        
        

    }
   
    
}
