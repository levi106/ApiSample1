using System.Collections.Concurrent;
using System.Threading;

namespace ApiSample1.Services
{
    public class MemoryService : IMemoryService
    {
        public int TotalSize { 
            get
            {
                return totalSize;
            }        
        }

        private int totalSize = 0;
        private readonly ConcurrentQueue<byte[]> cb = new ConcurrentQueue<byte[]>();

        public int Allocate(int size)
        {
            cb.Enqueue(new byte[size]);
            return Interlocked.Add(ref totalSize, size);
        }

        public void Clear()
        {
            cb.Clear();
            Interlocked.Exchange(ref totalSize, 0);
        }
    }
}
