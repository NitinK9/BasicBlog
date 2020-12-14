using System;
namespace BasicBlog.Models
{
    public class BgModel
    {
        public BgModel()
        {
        }


        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string AuthorEmail { get; set; }
    }
}
