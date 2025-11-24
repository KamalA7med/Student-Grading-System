using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    public delegate void Del();
    internal class Student_Grading_System<T>
    {
       public static  void Dispaly_Grading_Info(List<Student<T>>Students_List,double Pass_Degree,Del Header
            ,Func<List<T>,double>Avg,Func<double,double,bool>CheckPass,
            Action<Student<T>,double,bool>Display_Mode)
        {
            Header();
            foreach(var St in Students_List)
            {
                double avg = Avg(St.Grades);
                Display_Mode(St,avg,CheckPass(avg,Pass_Degree));
            }

        }
    }
}
