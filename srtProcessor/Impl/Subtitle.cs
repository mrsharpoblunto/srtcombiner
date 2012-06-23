using System;
using System.Collections.Generic;
using System.Text;

namespace srtProcessor.Impl
{
    class Subtitle: ISubtitle
    {
        private int _index;
        private long _startTime;//milliseconds
        private long _endTime;
        private string _content;

        public long StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public long EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

    }
}
