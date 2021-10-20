using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(PrintTeacherDetails, PrintStudentDetails);
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            var fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            var fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }

    public sealed class Singleton
    {
        private static int _counter = 0;
        private static Singleton _instance = null;
        public static Singleton GetInstance => _instance ??= new Singleton();

        private Singleton()
        {
            _counter++;
            Console.WriteLine("Counter Value " + _counter);
        }
        public void PrintDetails(string message) => Console.WriteLine(message);
    }

}
