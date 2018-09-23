using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = tryGetParam();
            

            Console.WriteLine("What is your age?");
            var age = tryGetParam();
                        
            Console.WriteLine("What month were you born in?");
            var month = tryGetParam();
     
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

