namespace WebApiCrecheRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Creche")]
    public partial class Creche
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string ChildName { get; set; }

        [Required]
        public string ChildAddress { get; set; }

        [Required]
        [StringLength(60)]
        public string GuardianName { get; set; }

        [Required]
        [StringLength(30)]
        public string TelNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string EmergencyNumber { get; set; }

        public string Email { get; set; }
    }
}
