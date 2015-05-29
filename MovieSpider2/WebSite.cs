using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSpider2
{
    public class WebSite
    {
        public string URL { get; set; }
        protected string removeTN(string str)
        {
            return str.Replace("\t", "").Replace("\n", "");
        }
        public string getPageUrl(int p)
        {
            return URL.Replace("###", p.ToString());
        }
    }
}
