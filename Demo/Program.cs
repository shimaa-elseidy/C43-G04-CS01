namespace Demo
{
    //data Type 
    /* Enum   Struct     */ //Value type
    /* Class  Interface */ //reference type
    internal class Program
    {
            static void Main(string[] args)
            {
            #region Struct01
            // Struct  : Value type ==> Stack

            //Employee
            //Id , Name ,Salary 

            //Point P01;// create data mn type point  // 3mlna kda declare ll object direct msh ll refrence from type 'Point'.
            //P01: object 
            //Allocate unintialized 8 bytes at stack ===> ( x==> 4bytes,y ==> 4bytes).
            //Console.WriteLine(P01.x);// unassigned

            //P01.X = 1;
            //P01.Y = 2;
            //Console.WriteLine(P01.x );
            //Console.WriteLine(P01.y);

            //P01 = new Point();// CLR : paramterless , has defalut value
            //Console.WriteLine(P01);// namespace Demo.point

            // New for : Used for Select Constructor
            //Console.WriteLine(P01.x);// 0 ==> default value

            // b3d ama 3mlt constructor b values gowah
            //Console.WriteLine(P01.x);// 20  kda la5eet el CLR elly bytb3 el default value.

            //P01 = new Point(2,3);
            //Console.WriteLine(P01.X);//2
            //Console.WriteLine(P01.Y);//3


            //P01.PrintPoint();
            //Console.WriteLine(P01.ToString()); //======name space

            // b3d ama 3mlt override 
            //Console.WriteLine(P01.ToString()); //(1.2)

            //Point[] points = new Point[10];// 10 instance 

            #endregion
            #region OOP overview
            //OOP : object oriented programming
            //    : programming paradigm 
            //    : the best paradigm used for build any business
            //    : Class ==> Blueprint of the object.
            //    : Object===> specific instance from class
            //     =====================================================
            //     : Has 4 pillars
            //       1. Encapsulation
            //       2. Inheritance
            //       3. Ploymorphism
            //       4. Abstraction
            //     =====================================================
            #endregion
            #region  03 Encapsulation using Setter Getter Methods
            // Encapsulation :
            // class struct
            // Seperate The Data (Attributes) Defination From Its Use
            // By [Setter & Getter Method - Propertise]

            // Employee =====> Id Name Salary

            //Employee E01 = new Employee();
            //E01.id = 1;        //* it has problems ==> End user access data itself
            //E01.salary = -10; //* it has problems ==> No data validation
            //* it has problems ==>No Reed only field
            // ....................So we Apply Encapsulation.............
            // 1. make all data (attribute) private.
            // 2. Access data from
            //   2.1. Setter Getter Method
            //   2.2. Properties

            //E01.SetId(1);
            //E01.SetName("shimaa");
            //E01.SetSalary(10000.5);
            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());

            //Employee E02 = new Employee(1,"ahmed",12345);

            // id ==> Read only attributes

            //E02.SetId(1);
            //E02.SetName("shimaa");
            //E02.SetSalary(10000.5);
            //Console.WriteLine(E02.GetId());
            //Console.WriteLine(E02.GetName());
            //Console.WriteLine(E02.GetSalary());
            //Console.WriteLine(E02);
            #endregion
            #region 04 Encapsulation using Properties [Recommended]
            //Employee E01 = new Employee();
            //E01.Id = 1;
            //E01.Name = " Shimaa ";
            //E01.Salary = -16000;
            //E01.Address = "Cairo";
            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);// Default ==> 0
            //Console.WriteLine(E01.Address);
            #endregion
        }
    }
}
                                                                                            