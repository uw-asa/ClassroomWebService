namespace ClassroomWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Resources = new HashSet<Resource>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BuildingCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Number { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public short? Capacity { get; set; }

        public bool Active { get; set; }

        public int? ResourceTypeID { get; set; }

        [StringLength(1024)]
        public string Notes { get; set; }

        public DateTime? modify_time { get; set; }

        [StringLength(50)]
        public string modify_by { get; set; }

        [StringLength(50)]
        public string entry_user { get; set; }

        public DateTime? entry_time { get; set; }

        public virtual Building Building { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource> Resources { get; set; }

        public virtual ResourceType ResourceType { get; set; }
    }
}
