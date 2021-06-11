using WindowsInput.Native;
using WindowsInput;
using System;
using System.Threading;

namespace NoBlockMyPc
{
    static class Program
    {

        static void Main()
        {
            InputSimulator sim = new InputSimulator();
            Console.WriteLine("Started...");

            while (true)
            {
                try
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.OEM_CLEAR);
                    Thread.Sleep(60000); // 1 min
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}
