using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_ASSIGNMENT2
{
    public delegate void MyDelegate();
    public class DelegateExercises : MyDelegate
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
    public class program
    {

        static void Main()
        {



            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }
    }



}