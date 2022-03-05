using System;
using System.Threading.Tasks;

namespace Threat_Safe_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetSingletonInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetSingletonInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
