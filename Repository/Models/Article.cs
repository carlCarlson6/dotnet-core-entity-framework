using System;
using Core.Models;

namespace Repository.Models
{
    public class Article : IArticle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text {get; set;} 
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
