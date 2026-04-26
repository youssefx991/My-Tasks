using Day9.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day9.Models
{
    [Table("TraineeCourse")]
    public class TraineeCourse
    {
        /*
         * TraineeCourse should have the following properties:
        - int TraineeID
        - int CourseID
        - float Grade
        - Trainee? Trainee --> Nullable
        - Course? Course --> Nullable
         */

        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }

        [ForeignKey("Course")]
        public int? CourseID { get; set; }

        [Range(0, 100)]
        public float? Grade { get; set; }

        public virtual Trainee? Trainee { get; set; }
        public virtual Course? Course { get; set; }
    }
}
