using System;
using System.Collections.Generic;

namespace Shop_API.Dtos
{
    public class ProductForListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public String PhotoUrl { get; set; } // main photo
    }
}