﻿using Blog.Core.Entities;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase
    {
      
        public string FileName { get; set; }

        public string FileType { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}
