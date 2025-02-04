﻿using AutoServiceManagementSystem.Models;
using AutoServiceManagementSystem.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoServiceManagementSystem.ViewModels.Cars
{
    public class CreateCarViewModel
    {
        [Required()]
        public string Manufacturer { get; set; }

        [MaxLength(20)]
        public string Model { get; set; }

        [Display(Name = "Plate Number")]
        [StringLength(maximumLength: 12, MinimumLength = 8,
            ErrorMessage = "Plate numbers consist of between 8 and 12 symbols.")]
        public string PlateCode { get; set; }

        
        [Vin]
        [Required]
        public string VIN { get; set;}

        [DisallowSpecialCharacters(allowDigits: true)]
        [Display(Name = "Engine Code")]
        public string EngineCode { get; set; }

        [Range(1950, 2021)]
        public int? Year { get; set; }

        [Display(Name = "Fuel Type")]
        public Fuel FuelType { get; set; }
    }
}