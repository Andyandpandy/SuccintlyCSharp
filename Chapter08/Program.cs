using System;

namespace Chapter08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Location Bin/Debug/test.txt
            //To prevent deadlock, never call Wait(), use async and await instead.
            FileCreation.CreateFileAsync("test.txt").Wait();

            /*
             * Async is important cause of UI and generally you might aswell
             * use the processing power of several cores instead of forcing
             * all of it onto the single one of the main thread.
             */
        }
    }
}
