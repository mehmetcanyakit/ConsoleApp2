using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[]
            {
                "Java", "C#"
            };
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine(i);
            }
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            

           
        }

        
	

	}
    }

