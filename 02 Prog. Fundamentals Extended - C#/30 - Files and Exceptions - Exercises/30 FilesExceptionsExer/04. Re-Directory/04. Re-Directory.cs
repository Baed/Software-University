using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Re_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"./Exercises-Resource/04. Re-Directory/input");

            foreach (var file in files)
            {
                string extention = file.Substring(file.LastIndexOf(".") + 1);
                Console.WriteLine(extention);

                if (!Directory.Exists(extention + "s"))
                {
                    Directory.CreateDirectory(extention + "s");
                }
                string name = file.Substring(file.LastIndexOf("\\"));
                Directory.Move(file, extention + "s/" + name);

            }


        }
    }
}
