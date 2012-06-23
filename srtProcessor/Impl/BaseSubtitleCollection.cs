using System;
using System.Collections.Generic;
using System.Text;

namespace srtProcessor.Impl
{
    abstract class BaseSubtitleCollection : ISubtitleCollection
    {
        private List<ISubtitle> _subtitles = new List<ISubtitle>();

        public void AppendCollection(ISubtitleCollection collection,long timeOffset)
        {
            int newStartingPoint = Subtitles[Subtitles.Count - 1].Index;

            foreach (ISubtitle subtitle in collection.Subtitles)
            {
                subtitle.Index = ++newStartingPoint;
                subtitle.StartTime += timeOffset;
                subtitle.EndTime += timeOffset;
                Subtitles.Add(subtitle);
            }
        }

        public List<ISubtitle> Subtitles
        {
            get { return _subtitles; }
        }

        public abstract void Save(string filename);
    }
}
