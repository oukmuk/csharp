/*
using System;

public delegate void Callback();

class Program
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();

        //Direct call

        my.MyMethod1();

        my.MyMethod2();

        Console.WriteLine("------------");

        // Call via a delegate

        // MyClass의 GetCallback(Callback callBack) 메소드를 호출하여

        // MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요
        my.GetCallback(new Callback(my.MyMethod1));
        my.GetCallback(new Callback(my.MyMethod2));
    }
}

public class MyClass
{
    public MyClass() { }

    public void GetCallback(Callback callBack)
    {
        callBack();
    }

    public void MyMethod1()
    {
        Console.WriteLine("My Method 1");
    }

    public void MyMethod2()
    {
        Console.WriteLine("My Method 2");
    }
}

*/
using System;
using System.IO;

namespace DelegateAppl
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        // 델리게이트 선언
        public delegate void printString(string s);

        // 콘솔화면에 출력
        public static void WriteToScreen(string str)
        {
             Console.WriteLine("The String is: {0}", str);
        }
        //파일에 출력
        public static void WriteToFile(string s)
        {

                fs = new FileStream("d:\\message.txt",

                FileMode.Append, FileAccess.Write);

                sw = new StreamWriter(fs);

                sw.WriteLine(s);

                sw.Flush();

                sw.Close();

                fs.Close();

        }

        // 델리게이트를 인자로 받아 실행
        // 결국 델리게이트가 참조하는 메소드 실행된다.
        public static void sendString(printString ps)
        {
            ps("test");
        }

        static void Main(string[] args)
        {
            // 델리게이트 인자 객체를 선언(어떤 함수를 실행할 지 설정) 
            printString p1 = new printString(WriteToScreen);
            printString p2 = new printString(WriteToFile);

            sendString(p1);

            sendString(p2);

            Console.ReadKey();

        }
    }
}