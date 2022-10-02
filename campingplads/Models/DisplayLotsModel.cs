using System.ComponentModel.DataAnnotations;

namespace campingplads.Models
{
    public class DisplayLotsModel
    {
        [Required]
        [MinLength(1, ErrorMessage ="asd")]
        public int rented { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "asd")]
        public int lotSize { get; set; }

        //asdasd
    }
}
