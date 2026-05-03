using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySharedLibrary.Models
{
    public class Trainee
    {
        [Key] 
        public int ID { get; set; }

        [Required]
        [MinLength(3)]
        public string? Name { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? MobileNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        [Required]
        public bool IsGraduated { get; set; }

        [Required]
        public int? TrackID { get; set; }
    }
}
