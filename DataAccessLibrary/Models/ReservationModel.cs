﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    internal class ReservationModel
    {
        public int orderID { get; set; }
        public int reservationStart { get; set; }
        public int reservationEnd { get; set; }
    }
}
