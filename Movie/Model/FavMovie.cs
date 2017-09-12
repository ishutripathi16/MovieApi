using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Model
{
    public class FavMovie
    {
        [Key]
        public int movieid { get; set; }
        public string overview { get; set; }
        public string moviename { get; set; }
        public string posterpath { get; set; }
        public string daterelease { get; set; }
    }
}
