﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupport.DAL.Models
{
    public class Enquire: BaseEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string InquiryType { get; set; }
        public string Description { get; set; }
        public bool AgreeTerms { get; set; }
    }
}
