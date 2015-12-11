namespace ClassroomWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resource
    {
        public int ID { get; set; }

        public int? RoomID { get; set; }

        public int? ResourceCategoryID { get; set; }

        public int? ResourceTypeID { get; set; }

        public int? Length { get; set; }

        public int? Width { get; set; }

        public int? Quantity { get; set; }

        [StringLength(256)]
        public string Notes { get; set; }

        [StringLength(50)]
        public string entry_user { get; set; }

        public DateTime? entry_time { get; set; }

        [StringLength(50)]
        public string modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ResourceType ResourceType { get; set; }

        public virtual Room Room { get; set; }
    }
}
