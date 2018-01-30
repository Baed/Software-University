using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class FileReader : IReader
{
    public string ReadLine()
    {
        return File.ReadAllText("test.txt");
    }
}

