using System;
using System.Collections.Generic;
using System.Text;

namespace srtProcessor
{
    public interface ISubtitle
    {
        long StartTime
        {
            get; set;
        }

        long EndTime
        {
            get; set;
        }

        string Content
        {
            get; set;
        }

        int Index
        {
            get; set;
        }
    }
}
