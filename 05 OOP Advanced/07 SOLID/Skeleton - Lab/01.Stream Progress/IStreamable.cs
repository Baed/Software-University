namespace _01.Stream_Progress
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IStreamable
    {
        int Length { get; }

        int BytesSent { get; }
    }
}
