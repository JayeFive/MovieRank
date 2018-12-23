using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRank.Services;

namespace MovieRank.Controllers
{
    [Route("movies")]
    public class MovieController : Controller
    {
        private readonly IMovieRankService _movieRankService;

        MovieController(IMovieRankService movieRankService)
        {
            _movieRankService = movieRankService;
        }
    }
}