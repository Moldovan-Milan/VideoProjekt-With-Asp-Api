﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoProjektAspApi.Model
{
    [Table("video")]
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Column("path")]
        [Required]
        public string Path { get; set; }

        [Column("extension")]
        [Required]
        public string Extension { get; set; }

        [Column("created")]
        [Required]
        public DateTime Created { get; set; }
    }
}