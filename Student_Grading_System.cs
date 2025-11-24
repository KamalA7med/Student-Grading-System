using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    
    internal class Student_Grading_System<T>
    {
       public static  ValueTuple<int,int> Dispaly_Grading_Info(List<Student<T>>Students_List,double Pass_Degree,Del Header
            ,Func<List<T>,double>Avg,Func<double,double,bool>CheckPass,
            Action<Student<T>,double,bool>Display_Mode)
        {
            int Passing_Counter = 0;
            Header();
            foreach(var St in Students_List)
            {
                double avg = Avg(St.Grades);
                Display_Mode(St,avg,CheckPass(avg,Pass_Degree));
                 Passing_Counter ++;
            }
            return ValueTuple.Create(Passing_Counter, Students_List.Count- Passing_Counter);
        }
    }
}
