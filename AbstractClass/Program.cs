using System;

namespace AbstractClass
{
    abstract class MyBase                   //抽象和非抽象成员组合
    {
        public int SideLength = 10;         //数据成员
        const int TriangleSideCount = 3;    //数据成员

        abstract public void PrintStuff(string s);  //抽象方法
        abstract public int MyInt { get; set; }     //抽象属性

        public int PerimeterLength()               //普通的非抽象方法
        {
            return TriangleSideCount * SideLength;   
        }
    }

    class MyClass:MyBase             //派生类
    {
        public override void PrintStuff(string s)  //覆盖抽象方法
        {
            Console.WriteLine(s);
        }
        private int _myInt;

        public override int MyInt        //覆盖抽象属性
        {
            get
            {
                return _myInt;
            }
            set
            {
                _myInt = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PrintStuff("This is a string.");
            mc.MyInt = 28;
            Console.WriteLine(mc.MyInt);
            Console.WriteLine("Perimeter Length:{0}", mc.PerimeterLength());
            int a = 0;

        }
    }
}
