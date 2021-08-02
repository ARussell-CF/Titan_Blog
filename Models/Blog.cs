using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Titan_Blog.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        //public virtual BlogUser Author { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}