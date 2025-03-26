using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Constructors in inheritance
namespace Day3_InheritanceExample1
{
    public class Program
    {
        static void Main1()
        {
            //DerivedClass o1 = new DerivedClass();

            DerivedClass o2 = new DerivedClass(110, 10);
           
            Console.WriteLine(o2.j);
            Console.ReadLine();
        }
    }

    public class Baseclass
    {
        public int i;

        public Baseclass()
        {
            Console.WriteLine("Base class no Param Cons called..");
            i = 10;
        }
        public Baseclass(int i)
        {
            Console.WriteLine("Base class Int Cons");
            this.i = i;
        }

    }

    public class DerivedClass : Baseclass
    {
        public int j;

        public DerivedClass()
        {
            Console.WriteLine("Derived class no Param Cons called..");
            int j = 11;
            
        }
        public DerivedClass(int i, int j) : base(i) 
        {
            Console.WriteLine("Derived class int, int cons");
            this.j = j;
        }
    }
}

// Overloading,Hidding and Overridding
namespace Day3_InheritanceExample2
{
    public class program
    {
        public static void Main1()
        {
            derived o = new derived();
            o.Display();// base class method got called
            o.Display(" ");// Derived class method got called

            o.Display1();//only display derived class method as base class method is hidden
            o.Display2();//only display derived class method as base class method is overridden

            Subderived o1 = new Subderived();
            o1.Display1();

            Console.ReadLine();


            
        }
        public class baseClass
        {
            public void Display() //Over loading
            {
                Console.WriteLine("Display Baseclass method");
            }
            public void Display1() // Hidding
            {
                Console.WriteLine("Display Baseclass method 1");
            }
            public virtual void Display2() // Overridding
            {
                Console.WriteLine("Display Baseclass method 2");
            }
        }
        public class derived : baseClass
        {
            public void Display (string s) // here parameter is different
            {
                Console.WriteLine("Display DerivedClass method");
            }
            public void Display1() //hinding base class method
            {
                Console.WriteLine("Display Derived class method 1");
            }
            public override void Display2() //overridding base class method in derived class
            {
                Console.WriteLine("Display Derived class method 2");
            }
        }
        public class Subderived : derived
        {
            public override void Display2() 
            {
                Console.WriteLine("Display sudderived method");
            }
        }

    }

}

namespace Day3_InheritanceExample3
{
    public class program
    {
        public static void Main()
        {
            //BaseClass O1 = new BaseClass();
            Derived o = new Derived();
            o.Display();
            o.Show();
            Class2 o2 = new Class2();   
            o2.Display();
            o2.Show();

            Console.ReadLine() ;

        }
        public abstract class BaseClass
        {
            public void Display()
            {
                Console.WriteLine("Displayyyy one");    
            }


        }
        public class Derived : BaseClass
        {
            public void Show()
            {
                Console.WriteLine("Showwww one");
            }
        }
        public abstract class AbstractClass1
        {
            public abstract void Display();
            public abstract void Show();
        }
        public class Class2 : AbstractClass1
        {
            public override void Display()
            {
                Console.WriteLine("Display");
            }
            public override void Show()
            {
                Console.WriteLine("Show");
            }
        }
    }
}
