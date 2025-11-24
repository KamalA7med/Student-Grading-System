using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class Grades_Report<T>
    {
        public static void Generate_Report(string Report_name,List<Student<T>> Students_List, double Pass_Degree, Del Header
            , Func<List<T>, double> Avg, Func<double, double, bool> CheckPass,
            Action<Student<T>, double, bool> Display_Mode)
        {
            Console.WriteLine($"Report Name :{Report_name}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("           Students Degrees");
           
          (int Passing_Counter,int Failed_Counter)Counter=  Student_Grading_System<T>.Dispaly_Grading_Info(Students_List,Pass_Degree,Header,Avg,CheckPass,Display_Mode);

            Console.WriteLine($"Number Of Successfull Students Is :{Counter.Passing_Counter}");
            Console.WriteLine($"Number Of Failed Students Is :{Counter.Failed_Counter}");
          

        }
    }
}
