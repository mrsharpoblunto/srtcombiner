using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.IO;
using System.Web;

namespace srtProcessor.Impl
{
    class SrtCollection : BaseSubtitleCollection
    {
        public SrtCollection(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            try
            {
                while (!reader.EndOfStream)
                {
                    string indexLine = reader.ReadLine().Trim();

                    if (!string.IsNullOrEmpty(indexLine))
                    {
                        ISubtitle sub = new Subtitle();
                        sub.Index = int.Parse(indexLine);
                        string[] timeCodesLine = reader.ReadLine().Split(' ');
                        sub.StartTime = FormatStringToTimeCode(timeCodesLine[0]);
                        sub.EndTime = FormatStringToTimeCode(timeCodesLine[2]);
                        sub.Content = string.Empty;
                        while (!reader.EndOfStream)
                        {
                            string contentLine = reader.ReadLine();
                            if (!string.IsNullOrEmpty(contentLine.Trim()))
                            {
                                sub.Content += contentLine;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Subtitles.Add(sub);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            finally
            {
                reader.Close();
                fs.Close();
            }
        }

        public override void Save(string filename)
        {
            FileStream fs = new FileStream(filename,FileMode.Create,FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            foreach (ISubtitle subtitle in Subtitles)
            {
                writer.WriteLine(subtitle.Index);
                writer.WriteLine(string.Format("{0} --> {1}",TimeCodeToFormatString(subtitle.StartTime),TimeCodeToFormatString(subtitle.EndTime)));
                writer.WriteLine(subtitle.Content);
                writer.WriteLine();
            }

            writer.Close();
            fs.Close();
        }

        private static long FormatStringToTimeCode(string timeCode)
        {
            timeCode = timeCode.Replace(",", string.Empty);
            string[] components = timeCode.Split(':');

            long hours = long.Parse(components[0]);
            long minutes = long.Parse(components[1]);
            long seconds = long.Parse(components[2]);

            return (hours*3600000) + (minutes*60000) + seconds;
        }

        private static string TimeCodeToFormatString(long timeCode)
        {
            long hours = timeCode/3600000;
            timeCode = timeCode - ((timeCode/3600000)*3600000);
            long minutes = timeCode/60000;
            timeCode = timeCode - ((timeCode / 60000) * 60000);
            long seconds = timeCode / 1000;
            long milliseconds = timeCode - ((timeCode / 1000) * 1000);

            return string.Format("{0:00}:{1:00}:{2:00},{3:000}", hours, minutes, seconds, milliseconds);
        }
    }
}
