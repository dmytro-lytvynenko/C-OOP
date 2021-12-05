﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            facade.MethodC();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem ClassA" 
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine(" SubSystemOne Method");
        }
    }

    // Subsystem ClassB" 
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine(" SubSystemTwo Method");
        }
    }


    // Subsystem ClassC" 
    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine(" SubSystemThree Method");
        }
    }
    // Subsystem ClassD" 
    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine(" SubSystemFour Method");
        }
    }

    class SubSystemFive
    {
        public void MethodFive()
        {
            Console.WriteLine(" SubSystemFive Method");
        }
    }
    // "Facade" 
    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        //5th subsystem added
        SubSystemFive five;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
            five = new SubSystemFive();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
            three.MethodThree();
        }
        //added methodC that uses all four SubSystems
        public void MethodC()
        {
            Console.WriteLine("\nMethodC() ---- ");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
            four.MethodFour();
            five.MethodFive();
        }
    }
}
