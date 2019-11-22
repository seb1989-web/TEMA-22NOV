using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Net;
using System.Media;


namespace downloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = null;
            try
            {
                string folder = @"C:\Users\seb\Desktop\download\a.JPG";
                bool FileExists = File.Exists(@"C:\Users\seb\Desktop\downlad\a.JPG");
                using ( client = new WebClient())
                {
                    if (FileExists == false)
                    {
                        client.DownloadFile(@"http://wallpapers-best.com/uploads/posts/2016-04/27_ninja_gaiden.jpg", folder);
                        Console.WriteLine("salvare reusita");
                    }
                    else
                    {
                        Console.WriteLine("poza exista");
                    }
                    
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine("nu aveti acces la folder", ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine("eroare de sistem", ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ignore that", ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                client.Dispose();
                Console.WriteLine("Program inchis.");
            }



            Console.ReadLine();

        }
        
       
    }
    
}
