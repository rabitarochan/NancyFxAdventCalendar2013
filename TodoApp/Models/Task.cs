using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        [Required]
        [StringLength(128)]
        [DisplayName("タイトル")]
        public string Title { get; set; }

        [StringLength(1024)]
        [DisplayName("詳細")]
        public string Detail { get; set; }

        [DisplayName("期限日")]
        public DateTime DueDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } 
    }
}