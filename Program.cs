using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    class Program 
    {
        class Data
        {
            public string Name;
            public int Age;
            public string Month;

            public void Display()
            {
                Console.WriteLine($"Your name is {Name}");
                Console.WriteLine($"Your age is {Age}");
                Console.WriteLine($"Your birth month is {Month}");
            }
        }
        static public event Action Posted;
        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();
            var data = new Data();
             Console.WriteLine("What is your name?");
            data.Name = tryGetParam();
            

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(tryGetParam());
                        
            Console.WriteLine("What month were you born in?");
            data.Month = tryGetParam();
            if(Posted!=null)
            Posted();
            data.Display();
     
        }

        static string tryGetParam()
        {
            var inputParam  = Console.ReadLine();
            if (inputParam == "")
            {
                Console.WriteLine("You didn't type anything please try again"); 
                tryGetParam();
            }
            return inputParam;
        }


        }
    }

