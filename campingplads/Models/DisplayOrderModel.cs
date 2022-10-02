using System.ComponentModel.DataAnnotations;

namespace campingplads.Models
{
    public class DisplayOrderModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
    }
}
