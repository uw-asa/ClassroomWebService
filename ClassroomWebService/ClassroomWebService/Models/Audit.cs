namespace ClassroomWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Audit")]
    public partial class Audit
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ObjectType { get; set; }

        public int ObjectID { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Field { get; set; }

        [Column(TypeName = "text")]
        public string OldValue { get; set; }

        [Column(TypeName = "text")]
        public string NewValue { get; set; }

        [StringLength(255)]
        public string Data { get; set; }

        public int? Creator { get; set; }

        public DateTime? Created { get; set; }
    }
}
