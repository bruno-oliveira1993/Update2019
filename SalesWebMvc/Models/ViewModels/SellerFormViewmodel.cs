﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewmodel
    {
    
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
