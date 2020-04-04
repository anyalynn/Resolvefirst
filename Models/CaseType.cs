﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Resolve.Models
{
    public class CaseType
    {
        public int CaseTypeID { get; set; }

        [Display(Name = "Case Type Title")]
        public string CaseTypeTitle { get; set; }

        [Display(Name = "Description")]
        public string LongDescription { get; set; }

        [Display(Name = "Default Approver")]
        public int LocalUserID { get; set; }
        public LocalUser LocalUser { get; set; }

        public ICollection<Case> Cases { get; set; }
    }
}
