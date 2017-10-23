
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBackend.Models
{
    public class Flower
    {
        [Key]
        public int FlowerId { get; set; }
        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(50,ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        [Index("Flower_Description_Index_Index",IsUnique = true)]
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

    }
}