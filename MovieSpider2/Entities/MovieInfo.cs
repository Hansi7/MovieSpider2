using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSpider2.Entities
{
    public class MovieInfo
    {
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Publish { get; set; }
        public string Publish2 { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string TotalPlay { get; set; }
        public string Url { get; set; }
        public string MovieType { get; set; }
        public override string ToString()
        {
            return Title + "\t" + Alias + "\t" + Publish + "\t" + Publish2 + "\t" + Location + "\t" + Type + "\t" + Director + "\t" + Actors + "\t" + TotalPlay + "\t" + Url + "\t" + MovieType;
        }

    }
}
