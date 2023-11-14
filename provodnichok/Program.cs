using System.Globalization;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using provodnichok;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace provodnichok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int position;
            string path;
            List<DriveInfo> drives = new List<DriveInfo>();
            Pochemy arrow = new Pochemy(0, 0);
            while (true)
            {
                drives = Zachem.GetDrives();
                arrow = new Pochemy(2, drives.Count + 1);
                position = arrow.CheckPos();
                path = drives[position - 2].Name;
                do
                {
                    Zachem.GetFiles(path);
                }
                while (position != 0);
            }
        }
    }
}