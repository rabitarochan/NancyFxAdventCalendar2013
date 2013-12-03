using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required]
        [DisplayName("コメント")]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}