namespace _04.Recharge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            IRechargeable robot = new RobotAdapter("id", 23);
            robot.Recharge();

        }
    }
}
