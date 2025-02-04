﻿using AutoServiceManagementSystem.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AutoServiceManagementSystem.Models
{
    public class Car
    {
        // fields
        private string vin;

        // constructor
        public Car()
        {
            Jobs = new List<Job>();
            Customer = new Customer();
        }

        // properties
        public int CarId { get; set; }

        [Required()]
		[MaxLength(32)]
        public string Manufacturer { get; set; }

        [MaxLength(20)]
        public string Model { get; set; }

        
        [Display(Name = "Plate Code")]
        [StringLength(maximumLength: 12, MinimumLength = 8,
            ErrorMessage = "Plate codes consist of between 8 and 12 symbols.")]
        public string PlateCode { get; set; }

        
        [Vin]
		[MaxLength(17)]
        public string VIN
        {
            get { return vin; }
            set
            {
                vin = value.ToString().ToUpper();
            }
        }

        [DisallowSpecialCharacters(allowDigits: true)]
        [Display(Name = "Engine Code")]
		[MaxLength(12)]
        public string EngineCode { get; set; }

        [Range(1950, 2021)]
        public int? Year { get; set; }

        [Display(Name = "Fuel Type")]
        public Fuel FuelType { get; set; }

        [Display(Name = "Owner")]
        public Customer Customer { get; set; }

        public ApplicationUser User { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
