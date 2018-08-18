using System;
using System.ComponentModel.DataAnnotations;

namespace AlvaChien.HIH.OData.Models
{
    public class DBVersion
    {
        [Key]
        public Int32 VersionID { get; set; }
        [Required]
        public DateTime ReleasedDate { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}
