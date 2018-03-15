using System;
using System.IO;
using System.Threading.Tasks;

namespace Chapter08
{
    public class FileCreation
    {

        public void create(){
            
        }

        //Task 
        public static async Task CreateFileAsync(string filename)
        {
            using (StreamWriter writer = File.CreateText(filename))
                await writer.WriteAsync("This is a test.");
        }


        //Task<T> for return values
        public async Task<string> ReturnGreeting()
        {
            //Delay sleeps the thread for 1000 milisec
            await Task.Delay(1000);
            return "Hello";
        }

        //void
        /*
         * This method executes asynchronously, 
         * but async void methods have important caveats you must be aware of: 
         * they aren’t awaitable, 
         * and they don’t protect against exceptions, 
         * but they are necessary for scenarios like 
         * event handling where the method must be void.
         */
        public async void SayGreeting()
        {
            await Task.Delay(1000);
            Console.WriteLine("Hello");
        }

        /*
         * The largest problem with async void methods is 
         * that you can’t throw an exception back to the calling code. 
         * With Task and Task<T> returning methods, 
         * you can await and wrap the async method call in a try-catch, 
         * but you can’t do that with async void methods. 
         * If an async void method throws an unhandled exception, 
         * the application will crash. 
         * 
         * The C# language designers added async void for one specific reason: 
         * to support event handling
        */
    }
}
