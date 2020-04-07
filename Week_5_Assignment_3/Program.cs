using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter name of course: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter number of students: ");
            int numberofStudents = int.Parse(Console.ReadLine());

            int average = 0;
            int highestGrade = 0;
            int highestGradeIndex = 0;

            string[] studentName = new string[numberofStudents];
            int[] studentGrade = new int[numberofStudents];


            for (int i = 0; i < numberofStudents; i++)
            {
                Console.Write("Enter name for student {0}: ", i+1);
                studentName[i] = Console.ReadLine();
            }

            for (int i =0; i < numberofStudents; i++)
            {
                Console.Write("Enter grade for {0}(Course: {1}): ", studentName[i], courseName);
                studentGrade[i] = int.Parse(Console.ReadLine());
                average += studentGrade[i];

                if(studentGrade[i] > highestGrade)
                {
                    highestGrade = studentGrade[i];
                    highestGradeIndex = i;
                }
            }
            average /= numberofStudents;

            Console.WriteLine("\n\nStudent {0} had the highest grade: {1}", studentName[highestGradeIndex], studentGrade[highestGradeIndex]);
            Console.WriteLine("\nAverage Grade was: {0}", average);

            for(int i =0; i <numberofStudents; i++)
            {
                Console.WriteLine("Student {0} had a grade of {1} (Course: {2})", studentName[i], studentGrade[i], courseName);
            }
            Console.ReadKey();
        }
    }
}
