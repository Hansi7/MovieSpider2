using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSpider2
{
    class Class1
    {
        public Class1()
        {
   
        
        }

public string GetHtml()
{
    using (System.Net.WebClient wc = new System.Net.WebClient())
    {
        var data = wc.DownloadData("http://baidu.com/");
        var html = Encoding.UTF8.GetString(data);
        return html;
    }
}

    }
}
