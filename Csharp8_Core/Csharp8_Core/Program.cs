using System;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await AsyncStream.EnumerateAsync();

            // await using (var disposableObject = new AsyncDisposable())
            // {
            //     Console.WriteLine("In Using");
            // } // DisposeAsync method called implicitly
            
            IndicesAndRanges.Do();

            Console.WriteLine("Main Method End");
        }

        // static void Main(string[] args)
        // {
        //     
        // }
    }
}