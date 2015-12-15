namespace ClassroomWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Building
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            Rooms = new HashSet<Room>();
        }

        [Key]
        [StringLength(4)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? NumCode { get; set; }

        [StringLength(50)]
        public string entry_user { get; set; }

        public DateTime? entry_time { get; set; }

        [StringLength(50)]
        public string modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
