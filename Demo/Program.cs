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
            }
    }
}


