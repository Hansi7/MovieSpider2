using MovieSpider2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MovieSpider2
{
    public class Youku : WebSite,MovieSpider2.ISite
    {
        public readonly string MovieURL_HK = "http://www.youku.com/v_olist/c_96_g__a_香港_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_TW = "http://www.youku.com/v_olist/c_96_g__a_台湾_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_KR = "http://www.youku.com/v_olist/c_96_g__a_韩国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_US = "http://www.youku.com/v_olist/c_96_g__a_美国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_FR = "http://www.youku.com/v_olist/c_96_g__a_法国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_UK = "http://www.youku.com/v_olist/c_96_g__a_英国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_GE = "http://www.youku.com/v_olist/c_96_g__a_德国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_IT = "http://www.youku.com/v_olist/c_96_g__a_意大利_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_CA = "http://www.youku.com/v_olist/c_96_g__a_加拿大_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_IN = "http://www.youku.com/v_olist/c_96_g__a_印度_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_RU = "http://www.youku.com/v_olist/c_96_g__a_俄罗斯_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_TA = "http://www.youku.com/v_olist/c_96_g__a_泰国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string MovieURL_OTHERS = "http://www.youku.com/v_olist/c_96_g__a_其他_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";


        public readonly string TvShow_HK = "http://www.youku.com/v_olist/c_97_g__a_香港_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_TW = "http://www.youku.com/v_olist/c_97_g__a_台湾_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_KR = "http://www.youku.com/v_olist/c_97_g__a_韩国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_JP = "http://www.youku.com/v_olist/c_97_g__a_日本_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_US = "http://www.youku.com/v_olist/c_97_g__a_美国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_UK = "http://www.youku.com/v_olist/c_97_g__a_英国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_TA = "http://www.youku.com/v_olist/c_97_g__a_泰国_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";
        public readonly string TvShow_SG = "http://www.youku.com/v_olist/c_97_g__a_新加坡_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_4_p_###.html";


        public List<string> URLs = null;

        public Youku()
        {
            URLs = new List<string>() {
            MovieURL_HK,
            MovieURL_TW,
            MovieURL_KR,
            MovieURL_US,
            MovieURL_FR,
            MovieURL_UK,
            MovieURL_GE,
            MovieURL_IT,
            MovieURL_CA,
            MovieURL_IN,
            MovieURL_RU,
            MovieURL_TA,
            MovieURL_OTHERS,
            "以下是电视剧",
            TvShow_HK,
            TvShow_TW,
            TvShow_KR,
            TvShow_JP,
            TvShow_US,
            TvShow_UK,
            TvShow_TA,
            TvShow_SG
            };
        }


        public Entities.MovieInfo GetMovie(MovieInfo mInfo)
        {
            int reTry = 0;
            var doc = DownLoader.GetDocument(mInfo.Url);
            while (doc==null && reTry < 5)
            {
                reTry++;
                Thread.Sleep(1000);
                doc = DownLoader.GetDocument(mInfo.Url);
            }
            if (reTry >= 5)
            {
                return null;
            }
            var title=removeTN(doc.DocumentNode.SelectSingleNode(".//h1[@class='title']/span[@class='name']").InnerText).Trim();
            var alias ="-";
            var publish = "-";
            var publish2 = "-";
            var location = "-";
            var type = "-";
            var director = "-";
            var actor = "-";
            var play = "-";


            try 
	        {
                alias = removeTN(doc.DocumentNode.SelectSingleNode(".//li[@class='row1 alias']").InnerText).Replace("别名:", "").Trim();
	        }
	        catch { }

            try
            {
                publish = removeTN(doc.DocumentNode.SelectNodes(".//span[@class='pub']")[1].InnerText).Replace("上映:", "").Trim();
            }
            catch { }

            try
            {
                publish2 = removeTN(doc.DocumentNode.SelectNodes(".//span[@class='pub']")[2].InnerText).Replace("优酷上映:", "").Trim();
            }
            catch { }

            try
            {
                location = removeTN(doc.DocumentNode.SelectSingleNode(".//span[@class='area']").InnerText).Replace("地区:", "").Trim();
            }
            catch { }


            try
            {
                 type = removeTN(doc.DocumentNode.SelectNodes(".//span[@class='type']")[1].InnerText).Replace("类型:", "").Trim();
            }
            catch { }
            try
            {
                director = removeTN(doc.DocumentNode.SelectSingleNode(".//span[@class='director']").InnerText).Replace("导演:", "").Trim();
            }
            catch { }


            try
            {

                actor = removeTN(doc.DocumentNode.SelectSingleNode(".//span[@class='actor']").InnerText).Replace("主演:", "").Trim();
            }
            catch { }

            try
            {
                play = removeTN(doc.DocumentNode.SelectSingleNode(".//span[@class='play']").InnerText).Replace("总播放:", "").Trim();
            }
            catch { }

            Entities.MovieInfo movieInfo = new Entities.MovieInfo()
            {
                Title = title,
                Alias = alias,
                Publish = publish,
                Publish2 = publish2,
                Location = location,
                Type = type,
                Director = director,
                Actors = actor,
                TotalPlay = play,
                Url = mInfo.Url,
                MovieType=mInfo.MovieType
            };
            return movieInfo;
        }
        public List<Entities.MovieInfo> GetMovieList(string url)

        {
            List<Entities.MovieInfo> list = new List<Entities.MovieInfo>();
            int reTry = 0;
            var doc = DownLoader.GetDocument(url);
            while (doc == null && reTry < 5)
            {
                reTry++;
                Thread.Sleep(1000);
                doc = DownLoader.GetDocument(url);
            }
            if (reTry >= 5)
            {
                return list;
            }

            var nodes=doc.DocumentNode.SelectNodes("//div[@class='yk-col3']");
            if (nodes == null)
            {
                return list;
            }
            foreach (var item in nodes)
            {
                var title = item.SelectSingleNode(".//div[@class='p-meta-title']").InnerText.Trim();
                var movieUrl = item.SelectSingleNode(".//div[@class='p-link']/a").Attributes["href"].Value.ToString().Trim();
                var movietype = item.SelectSingleNode(".//span[@class='p-status']").InnerText.Trim();
                Entities.MovieInfo m = new Entities.MovieInfo()
                {
                    Title = title,
                    Url = movieUrl,
                    MovieType = movietype
                };
                list.Add(m);
            }
            return list;
        }


    }
}
