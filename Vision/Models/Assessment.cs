using System;

namespace Vision.Models
{
    public class Assessment
    {
        public Guid id { get; set; }
        public int Rating { get; set; }
        public Guid ArticleId { get; set; }
    }
}
