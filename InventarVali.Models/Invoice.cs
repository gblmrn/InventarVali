﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarVali.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public  string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double Price { get; set; }
        public string CardNumber { get; set; }
        public int? AutovehiculeFKId { get; set; }
        [ForeignKey("AutovehiculeFKId")]
        [ValidateNever]
        public Autovehicule Autovehicule { get; set; }
        
    }
}
