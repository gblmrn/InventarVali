﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarVali.Models.ViewModel
{
    public class AutovehiculeVM
    {
        public Autovehicule Autovehicule { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }
    }
}
///TODO  Create a automapper situation
