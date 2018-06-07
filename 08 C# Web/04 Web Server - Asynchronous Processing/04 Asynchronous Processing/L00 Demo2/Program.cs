using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace L00_Demo2
{
    class Program
    {
        private const string ResultDir = @"..\..\..\Result";

        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            var dirInfo = new DirectoryInfo(currentDirectory + "\\Images");

            var files = dirInfo.GetFiles();

            if (Directory.Exists(ResultDir))
            {
                Directory.Delete(ResultDir, true);
            }

            Directory.CreateDirectory(ResultDir);

            var tasks = new List<Task>();

            foreach (var fileInfo in files)
            {
                var task = Task.Run(() =>
                {
                    var image = Image.FromFile(fileInfo.FullName);

                    image.RotateFlip(RotateFlipType.RotateNoneFlipY);

                    image.Save($"{ResultDir}\\{fileInfo.Name}");

                    Console.WriteLine($"{fileInfo.Name} processed...");
                });

                tasks.Add(task);
            }

            try
            {
                Task.WaitAll(tasks.ToArray());
                Console.WriteLine("Finished!");
            }
            catch (AggregateException e)
            {
                foreach (var exp in e.InnerExceptions)
                {
                    Console.WriteLine(exp);
                }
            }
        }
    }
}
