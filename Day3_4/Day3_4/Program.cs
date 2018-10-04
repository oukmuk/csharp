// #define SOUNDCARD // 이 부분을 지운 후 실행 해 보자
using System;
using System.Runtime.InteropServices;


class Test
{
    [DllImport("User32.Dll")]
    public static extern int MessageBox(int h, string m, string c, int type);

    static void Main()
    {
        MessageBox(0, "hello", "in c#", 0);
    }
}