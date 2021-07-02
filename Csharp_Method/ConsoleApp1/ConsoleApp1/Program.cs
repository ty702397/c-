using System;

namespace ConsoleApp1
{
    /* class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Hello World!");
         }
     }*/
    /*
     * 方法调用：返回值；
     * 返回值，方法必须声明 返回类型
     * 如果方法不返回值，必须声明void返回类型
     */
    /*  class Myclass
       {
           public int GetHour()            //int返回值类型
           {
               DateTime dt = DateTime.Now; //获取当期日期和世界
               int hour = dt.Hour;         //获取小时

               return hour;                //返回一个int
           }
       }


       class Myclass_1
       {
           void TimeUpdate()               //void返回类型
           {
               DateTime dt = DateTime.Now;
               if (dt.Hour < 12)
                   return;
               Console.WriteLine("It's afternoon!");
           }

           static void Main()
           {
               Myclass_1 mc_1 = new Myclass_1();
               mc_1.TimeUpdate();
           }
       }

       class Program
       {
           static void Main()
           {
               Myclass mc = new Myclass();
               Console.WriteLine("Hour: {0}", mc.GetHour()); //mc.GetHour() 方法调用;mc：实例名称，Gethour：方法名称

           }
       }*/
    /*
      5.10 值参数
        值参数的实参不一定变量。它可以是任何能计算成相应数据类型的表达式

      class MyClass
        {
            public int Val = 20;
        }
        class Program
        {
            static void MyMethod( MyClass f1, int f2) //形参  MyClass f1, int f2
            {
                f1.Val = f1.Val + 5;                  //参数字段加5
                f2 = f2 + 5;                          //另一个参数加5
                Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
            }
            static void Main()
            {
                MyClass a1 = new MyClass();
                int a2 = 10;

                MyMethod(a1, a2);                      //a1,a2 实参
                Console.WriteLine("f1.Val: {0}, f2: {1}", a1.Val, a2);
            }
        }
    */
    /*
     5.11 引用参数
        必须在声明和调用中使用ref修饰符。
        实参必须是变量，在做实参前必须被赋值。如果引用类型变量，可以赋值为一个引用或null
     */

}
