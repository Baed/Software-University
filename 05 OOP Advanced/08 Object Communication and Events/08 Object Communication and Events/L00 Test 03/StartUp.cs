using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        Worker worker = new Worker();

        worker.DoWork(7, WorkType.Sport);
    }

    // public static void WorkPerformed(int hours, WorkType workType)
    // {
    //     Console.WriteLine($"{workType} for {hours} hours");
    // }
}

