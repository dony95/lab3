﻿using System;
using System.Collections.Generic;

namespace LAB3_2.DAL.Model
{
    public partial class ProductCostHistory
    {
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal StandardCost { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
