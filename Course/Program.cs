using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setCourseA = new HashSet<int>();
            HashSet<int> setCourseB = new HashSet<int>();
            HashSet<int> setCourseC = new HashSet<int>();
            HashSet<int>[] setCourses = { setCourseA, setCourseB, setCourseC };



            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Student code: ");
                int code = int.Parse(Console.ReadLine());

                setCourseA.Add(code);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Student code: ");
                int code = int.Parse(Console.ReadLine());

                setCourseB.Add(code);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Student code: ");
                int code = int.Parse(Console.ReadLine());

                setCourseC.Add(code);
            }

            HashSet<int> allCourses = new HashSet<int>(setCourseA);
            allCourses.UnionWith(setCourseB);
            allCourses.UnionWith(setCourseC);
            Console.WriteLine("Total students: " + allCourses.Count);
            
        }
    }
}
