﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace InventarVali.Models.ViewModel
{
    public class InvoiceVM
    {
        public int Id { get; set; }
        public string? InvoiceNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime? InvoiceDate { get; set; }
        [DataType(DataType.Date)]
        public string? DisplayInvoiceDate { get; set; }
        [DataType(DataType.Currency)]
        public double? TotalPrice { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public string? CardNumber { get; set; }
        [ValidateNever]
        public string? InvoiceUrl { get; set; }
        [ValidateNever]
        public List<AutovehiculeVM> Autovehicule { get; set; }
    }
}
