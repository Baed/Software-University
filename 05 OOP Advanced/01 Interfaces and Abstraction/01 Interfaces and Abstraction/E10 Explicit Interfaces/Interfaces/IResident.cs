namespace E10_Explicit_Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IResident
    {
        string Name { get; }

        string Country { get; }

        string GetName();
    }
}
