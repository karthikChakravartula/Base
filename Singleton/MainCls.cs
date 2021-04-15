using System;

namespace Singleton
{
    class MainApp

    {
        static void Main()
        {
            // Constructor is protected -- cannot use new

            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            s1.printdetails();
            // Test for same instance

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user

            Console.ReadKey();
        }
    }
    public class Calculate
    {
        private Calculate()
        {
        }
        private static Calculate instance = null;
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }
                return instance;
            }
        }
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }
        public double Addition()
        {
            return ValueOne + ValueTwo;
        }
        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }
        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }
        public double Division()
        {
            return ValueOne / ValueTwo;
        }
    }
}
