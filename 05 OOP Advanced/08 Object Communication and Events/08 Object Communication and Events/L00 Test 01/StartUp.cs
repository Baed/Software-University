using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public delegate void WorkPerformedDelegate(int hours, WorkType workType);

    public static void Main(string[] args)
    {
        WorkPerformedDelegate deleFirst = new WorkPerformedDelegate(WorkPerformed);
        deleFirst(51, WorkType.Meetings);

        Console.WriteLine(new string('=', 20));

        WorkPerformedDelegate deleSecond = (hour, type) => WorkPerformed(hour, type);
        deleSecond(20, WorkType.Sport);

        Console.WriteLine(new string('=', 20));

        WorkPerformedDelegate deleThird = delegate (int hour, WorkType type)
        {
            Console.WriteLine("WorkPerformed " + type);
        };

        deleFirst += deleSecond;
        deleFirst += deleThird;
        deleFirst(666, WorkType.Exam);

        Console.WriteLine(new string('=', 20));

        WorkPerformedDelegate deleFourth = new WorkPerformedDelegate(WorkPerformedSecond);

        deleFirst += deleFourth;
        deleFirst(777, WorkType.Sport);
    }

    public static void WorkPerformed(int hours, WorkType workType)
    {
        Console.WriteLine($"{workType} for {hours} hours");
    }

    public static void WorkPerformedSecond(int hours, WorkType workType)
    {
        Console.WriteLine($"{hours} hours for {workType} workperformed");
    }
}

