﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entities
{
    public class RelatedMovie
    {
        public int ReleatedMovieId { get; set; }
        public int MovieId { get; set; }
        public int  UserId { get; set; }
        public int  IsWatch { get; set; }
    }
}
