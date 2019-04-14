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



            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {

            System.Console.WriteLine(MyDelegate.ToString());
        }
    }


}