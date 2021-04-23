﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlogApp.Models
{
    public class Comment
    {

        public int Id { get; set; }

        [Required]
        [DisplayName("コメント")]
        public string Body { get; set; }

        [Required]
        [DisplayName("投稿日")]
        public string Created { get; set; }

        public virtual Article Article { get; set; }

        [NotMapped]
        public int ArticleId { get; set; }//コメント登録時にどの記事か特定するため
    }
}