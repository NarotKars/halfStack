﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class UserCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
