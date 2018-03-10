using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TG Recover";
            try
            {
                string PathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TGR\Path.File";
                File.Move(File.ReadAllText(PathFile) + @"\log.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TGR\" + DateTime.Now.ToString().Replace('/', '-').Replace(':', ',') + ".txt");
            }
            catch(Exception ex)
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Telegram.log", ex.Message);
            }
        }
    }
}
