using System;

namespace App
{
    class UsingDecl
    {
        class MyDisposable : IDisposable
        {
            public bool IsDisposed { get; private set; }

            public void Dispose()
            {
                this.IsDisposed = true;
            }
        }

        static MyDisposable _disposable;

        public static void UseAndDispose()
        {
            using var disp = new MyDisposable();
            _disposable = disp;

            Console.WriteLine("IsDisposed: " + disp.IsDisposed); // false
        }
        
        public static void CheckDisposal()
        {
            Console.WriteLine("IsDisposed: " + _disposable.IsDisposed);  // true
        }
    }
}