using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace incomeproj.Models
{
    public class Income
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Desc { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
