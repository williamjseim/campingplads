using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    internal class CustomerModel
    {
        public int lotID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
    }
}
