using System;
namespace Idisposableee
{
    class Unmanaged : IDisposable
    {
        private IntPtr unmanaged;
        private bool Disposed = false;

        public Unmanaged()
        {
            unmanaged = new IntPtr(123);
            Console.WriteLine("Resource Acquired");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposed)
            {
                if (Disposing)
                {
                    Console.WriteLine("Managed resources cleaned up.");
                }
                Console.WriteLine("Unmanaged resources cleaned up.");
                Disposed = true;

            }
        }

        ~Unmanaged(){

            Console.WriteLine("Finalize called by GC.");
            Dispose(false);
        }
    }

    public class Program
    {
        public static void Main()
        {
            using (var obj = new Unmanaged())
            {
                Console.WriteLine("using Resource");
            }
            var obj2 = new Unmanaged();

            obj2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }

}