﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{

    public class program
    {

        static void Main()
        {
            // Student Name: Sukhdeep Singh  Student ID: C0725204
            // Student Name: Gurkirat Singh Student ID: C0731773
            // CSD3354 Section 2
            // Assignment 2

            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }
    }


    public class DelegateExercises
    {

        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}