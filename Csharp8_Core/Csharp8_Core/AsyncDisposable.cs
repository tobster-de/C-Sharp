using System;
using System.IO;
using System.Threading.Tasks;

namespace App
{
    public class AsyncDisposable : IAsyncDisposable
    {
        private static readonly string filePath = Path.GetTempFileName();
        private TextWriter? textWriter = File.CreateText(filePath);

        public async ValueTask DisposeAsync()
        {
            if (textWriter != null)
            {
                textWriter = null;
            }

            await Task.Delay(1000);

            Console.WriteLine("DisposeAsync finished!");
        }
    }
}