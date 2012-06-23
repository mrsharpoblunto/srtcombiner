using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace srtProcessor
{
    public static class SubtitleCollectionFactory
    {
        public static ISubtitleCollection LoadSrtFile(string subtitleFilename)
        {
            return new Impl.SrtCollection(subtitleFilename);
        } 
    }
}
