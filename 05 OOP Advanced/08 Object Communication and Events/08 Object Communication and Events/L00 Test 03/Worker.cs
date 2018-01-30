using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public event WorkPerformedHandler WorkPerformed;
    public event EventHandler WorkCompleted;

    public Worker()
    {
        WorkPerformed += OnWorkPerformed;

        WorkCompleted += OnWorkCompleted;
    }

    private void OnWorkCompleted(object sender, EventArgs eventArgs) // EventHandler --> object sender, EventArgs e;
    {
        WorkCompletedEventArgs args = eventArgs as WorkCompletedEventArgs;

        Console.WriteLine(args.WorkType + " is done!");
    }

    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed.Invoke(i + 1, workType);
            }
        }

        if (WorkCompleted != null)
        {
            WorkCompleted.Invoke(this, new WorkCompletedEventArgs(workType));
        }
    }

    private void OnWorkPerformed(int hours, WorkType workType)
    {
        Console.WriteLine("Work Performed: " + workType + ", Hours: " + hours);
    }
    //TODO: Add method for taising event (next slide)


}
