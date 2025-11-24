using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student<int>> Students_list=new List<Student<int>>();
            int i = 1;
            char Add_Another_Student;
            do
            {
                Console.WriteLine($"Student [{i}] : ");
                Console.Write("Enter Student Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Degrees : ");
                Console.WriteLine("----------------------------------");
                List<int> degrees = new List<int>();
                for (int j = 0; j < 6; j++)
                {
                    int sub_Val;
                    do
                    {
                        Console.Write($"Subject [{j + 1}] : ");
                        sub_Val = int.Parse(Console.ReadLine());
                    } while (sub_Val<0||sub_Val>100);
                   
                    degrees.Add(sub_Val);
                }
                Students_list.Add(new Student<int>(name,degrees));
                Console.WriteLine("Do You Want To Enter Another Student Degree ? [Y/N] :");

                Add_Another_Student = char.Parse(Console.ReadLine());
                ++i;
            } while (char.ToUpper(Add_Another_Student) == 'Y');
            Student_Grading_System<int>.Dispaly_Grading_Info(Students_list, 50, Normal_Header, Calculate_Avg, Check_Passing, Normal_Mode);

        }
       public static void Normal_Header()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"|{"Name".PadRight(20)} | {"Avgerage".PadRight(10)} | {("Status").PadRight(15)} |");
            Console.WriteLine("-------------------------------------------------------");
        }
        public static double Calculate_Avg<T>(List<T>Grades)
        {
            double Sum = 0;
            foreach (T Grade in Grades)
                Sum += Convert.ToDouble(Grade);
            return (Sum / Grades.Count);
        }
        public static bool Check_Passing(double avg,double Val)
        {
            return avg >= Val;
        }
        public static void Normal_Mode<T>(Student<T> st,double avg,bool Is_Pass)
        {
           
            Console.WriteLine($"|{st.Name.PadRight(20)} | {Convert.ToString(Math.Round(avg,2)).PadRight(10)} | {(Is_Pass ? "Success" : "Failed").PadRight(15)} |");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
