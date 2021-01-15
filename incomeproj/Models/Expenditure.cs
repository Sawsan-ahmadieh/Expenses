using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace incomeproj.Models
{
    [XmlRoot("Expenditure",IsNullable =false,Namespace ="http://www.cpandl.com")]
    public class Expenditure :IEquatable<Expenditure>
    {
        public int Id { get; set; }
        [Required]
        [XmlAttribute]
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        [XmlElement]
        public decimal TotalAmount { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        
        [Required]
        public DateTime DateTaken { get; set; }


        public bool Equals(Expenditure exp)
        {
            if (exp.ItemName == ItemName)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            int hashProductName = ItemName == null ? 0 : ItemName.GetHashCode();
            return hashProductName;

        }
    }
}
