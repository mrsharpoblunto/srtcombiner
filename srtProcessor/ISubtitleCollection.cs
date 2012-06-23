using System;
using System.Collections.Generic;
using System.Text;

namespace srtProcessor
{
    public interface ISubtitleCollection
    {
        void Save(string filename);
        void AppendCollection(ISubtitleCollection collection, long timeOffset);
        List<ISubtitle> Subtitles { get; }
    }
}
