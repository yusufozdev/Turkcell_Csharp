using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s_Name, s_LastName, s_Department, s_Lesson,exam_Info;
            int examOne, examTwo, examThree, examAverage;

            s_Name = "Yusuf ";
            s_LastName = "Öz";
            s_Department = "Bilgisayar Programcılığı";
            s_Lesson = "Veri Tabanı";

            examOne = 87;
            examTwo = 68;
            examThree = 92;

            examAverage = (examOne + examTwo + examThree) / 3;
            exam_Info = "Sayın " + s_Name + s_LastName + ", " + s_Department + " bölümündeki " + s_Lesson + " adlı dersinizin ortalaması " + examAverage + " .";

            Console.WriteLine(exam_Info);
            Console.Read();


        }
    }
}
