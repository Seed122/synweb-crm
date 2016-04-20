namespace SynWebCRM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estimate")]
    public partial class Estimate
    {
        public Estimate()
        {
            Items = new HashSet<EstimateItem>();
        }

        public int EstimateId { get; set; }

        [Display(Name = "���� ��������")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "GUID")]
        public Guid Guid { get; set; }

        public int DealId { get; set; }

        [Display(Name = "������")]
        public int? Discount { get; set; }

        [Display(Name = "���� ��� ������")]
        public decimal Total { get; set; }

        public virtual Deal Deal { get; set; }
        [Display(Name = "���������")]
        public string Creator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstimateItem> Items { get; set; } 
    }
}
