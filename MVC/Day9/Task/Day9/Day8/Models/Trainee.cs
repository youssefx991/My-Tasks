using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day9.Models
{
    [Table("Trainee")]
    public class Trainee 
    {
        /*
         * Trainee should have the following properties:
        - int ID
        - string Name
        - Gender Gender
        - string Email
        - string MobileNo
        - DateTime Birthdate
        [ForeignKey("Trk")]
        - int TrackID
        - Track Trk
         */

        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set;}


        [EnumDataType(typeof(Gender))]
        public Gender? Gender { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? MobileNo { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        [ForeignKey("Trk")]
        public int TrackID { get; set; }
        public virtual Track? Trk { get; set; }

    }

    public enum Gender { Male, Female }
}
