using System;
namespace MovieSpider2
{
    interface ISite
    {
        MovieSpider2.Entities.MovieInfo GetMovie(MovieSpider2.Entities.MovieInfo minfo);
        System.Collections.Generic.List<MovieSpider2.Entities.MovieInfo> GetMovieList(string url);
    }
}
