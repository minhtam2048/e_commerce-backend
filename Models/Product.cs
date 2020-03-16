using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop_API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}