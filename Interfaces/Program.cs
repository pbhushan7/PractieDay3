using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            //Method 1 for calling Interface
            o.Insert();
            o.Display();    

            //method 2 - Explicit
            IDbfunctions OIDb;
            OIDb = o;
            o.Delete(); 

            //Method 3 -- Implicit 
            ((IDbfunctions)o).Delete();

            //method 4
            (o as IDbfunctions).Update();

            Console.ReadLine();
        }
        public interface IDbfunctions
        {
            void Insert();
            void Update();
            void Delete();
            
        }
        public class Class1 : IDbfunctions
        {
            public void Insert()
            {
                Console.WriteLine("Class1 - IDb.Insert");
            }

            public void Update()
            {
                Console.WriteLine("Class1 - IDb.Update");
            }

            public void Delete()
            {
                Console.WriteLine("Class1 - IDb.Delete");
            }
            public void Display()
            {
                Console.WriteLine("Display");
            }
        }
    }
}

namespace Interfaces2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();

            IFilefunctions S;
            S = o;
            S.Delete();

            (o as IDbfunctions).Delete();

            IFilefunctions OIfile;
            OIfile = o;
            OIfile.Open();

            IDbfunctions IDb;
            IDb = o;
            IDb.Delete();

            Console.ReadLine();
        }

        public interface IDbfunctions
        {
            void Insert();
            void Update();
            void Delete();

        }
        public interface IFilefunctions
        {
            void Open();
            void Close();
            void Delete();

        }
        public class Class1 : IDbfunctions, IFilefunctions
        {
            public void Insert()
            {
                Console.WriteLine("Class1 - IDb.Insert");
            }

            public void Update()
            {
                Console.WriteLine("Class1 - IDb.Update");
            }

            
            public void Display()
            {
                Console.WriteLine("Display");
            }

            //Wrote down code explicitly to avoid confusion for methods having same name


            public void Open()
            {
                Console.WriteLine("Class1 - IFile.Open");
            }

            public void Close()
            {
                Console.WriteLine("Class1 - IFile.Close");
            }

            void IDbfunctions.Delete()
            {
                Console.WriteLine("Class1 - IDb.Delete");
            }
            void IFilefunctions.Delete()
            {
                Console.WriteLine("Class1 - IFile.Delete");
            }
        }
    }
}

namespace InheritanceInInterface
{
    public class Program
    {
        static void Main1()
        {
            Implement imp = new Implement();
            imp.Insert();
            imp.Update();
            imp.Delete();
            Console.ReadLine() ;

        }

        public interface IBase
        {
            void Insert();
            void Update();
        }
        public interface IDerived : IBase 
        {
            void Delete();
        }
        public class Implement : IBase, IDerived
        {
            public void Delete()
            {
                Console.WriteLine("Delete");
            }

            public void Insert()
            {
                Console.WriteLine("Insert");
            }

            public void Update()
            {
                Console.WriteLine("Update");
            }
        }
    }
}

namespace Bhushan
{
    public class Program
    {
        public static void Main1()
        {
            class1 o = new class1();
            (o as Interface2).Delete();


            o.Insert();
            o.Update();
            

            Console.ReadLine();
        }
        public interface Interface1
        {
            void Insert();
            void Update();
            void Delete();
        }
        public interface Interface2 : Interface1
        {
            void Delete();
        }
        public class class1 : Interface1, Interface2
        {
            void Interface1.Delete()
            {
                Console.WriteLine("Byee1");
            }

            void Interface2.Delete()
            {
                Console.WriteLine("Byee2");
            }

            public void Insert()
            {
                Console.WriteLine("Inserted");
            }

            public void Update()
            {
                Console.WriteLine("Updated");
            }
        }

    }
}

