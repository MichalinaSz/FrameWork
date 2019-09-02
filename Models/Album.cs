using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public partial class Album
    {
        public Album()
        {
            Artist Artist = new Artist();
           
            
        }


        public int AlbumId { get; set; }
     
        public string Title { get; set; }
        public decimal Price { get; set; }
        
       public virtual Artist Artist { get; set; }
       

    }
}
