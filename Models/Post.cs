using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Titan_Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public string Slug { get; set; }

        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}