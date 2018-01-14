﻿using System;
using System.Collections.Generic;

namespace LAB3_2.DAL.Model
{
    public partial class ProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; }
        public int ProductDescriptionId { get; set; }
        public string CultureId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Culture Culture { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
