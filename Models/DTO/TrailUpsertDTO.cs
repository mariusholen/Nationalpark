using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ParkyAPI.Models.Trail;

namespace ParkyAPI.Models.DTO
{
    public class TrailUpsertDTO
    {
        public int TrailId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Distance { get; set; }
        public DifficultyType Difficulty { get; set; }
        [Required]
        public int NationalParkId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
