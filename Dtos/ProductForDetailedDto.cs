using System;
using System.Collections.Generic;
using Shop_API.Models;

namespace Shop_API.Dtos
{
    public class ProductForDetailedDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public String PhotoUrl { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}