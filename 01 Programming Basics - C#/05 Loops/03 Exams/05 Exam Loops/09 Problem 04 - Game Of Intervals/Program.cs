using System;

namespace _09_Problem_04___Game_Of_Intervals
{
    class Program
    { 
        static void Main(string[] args)
        {
            int move = int.Parse(Console.ReadLine());

            var result = 0.0; //•	1ви ред: "{Краен резултат}"
            var from0to9 = 0.0;//•	2ри ред: "From 0 to 9: {процент в интервала}%"
            var from10to19 = 0.0;//•	3ти ред: "From 10 to 19: {процент в интервала}%"
            var from20to29 = 0.0;//•	4ти ред: "From 20 to 29: {процент в интервала}%"
            var from30to39 = 0.0;//•	5ти ред: "From 30 to 39: {процент в интервала}%"
            var from40to50 = 0.0;//•	6ти ред: "From 40 to 50: {процент в интервала}%"
            var invalid = 0.0;//•	7ми ред: "Invalid numbers: {процент в интервала}%"


            for (int i = 1; i <= move; i++)
            {
                int number = int.Parse(Console.ReadLine());


                if (number <= 50)
                {

                }
                else if (number < 40)
                {

                }
                else if (number < 30)
                {

                }
                else if (number < 20)
                {

                }
                else if (number < 10)
                {

                }
                else if (number < 0 && number > 50)
                {

                }



            }



        }
    }
}
