﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Stack
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public ICollection<StudySession> StudySessions { get; set; } = new List<StudySession>();
        public User User { get; set; }
    }
}