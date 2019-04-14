using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_ASSIGNMENT2
{

    public class program
    {

        static void Main()
        {
            // Student Name: Sukhdeep Singh  Student ID: C0725204
            // Student Name: Gurkirat Singh Student ID: C0731773
            // Assignment 2
            // March 6, 2019


            DelegateExercises a = new DelegateExercises();
            a.Method2();
        }
    }


    public class DelegateExercises
    {

        public delegate void MyDelegate();

        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}