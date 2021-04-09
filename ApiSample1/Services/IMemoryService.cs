using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample1.Services
{
    public interface IMemoryService
    {
        int TotalSize { get; }

        int Allocate(int size);
        void Clear();
    }
}
