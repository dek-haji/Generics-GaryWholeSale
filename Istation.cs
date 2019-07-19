using System.Collections.Generic;

namespace GaryWholesale
{
    public interface Istation<T>
    {
        void Refuel(string name, T item);
    }
}