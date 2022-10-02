using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    internal class GuestModel
    {
        public int orderID { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public int dogs { get; set; }
    }
}
