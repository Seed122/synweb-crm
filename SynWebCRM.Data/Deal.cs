namespace SynWebCRM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deal")]
    public partial class Deal
    {
        public int DealId { get; set; }

        [Display(Name="���� ��������", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        [Display(Name="�����")]
        public decimal? Sum { get; set; }

        [Display(Name="������")]
        public int CustomerId { get; set; }

        [StringLength(200)]
        [Display(Name="��������")]
        public string Name { get; set; }

        [Display(Name="��������")]
        public string Description { get; set; }
        
        [Display(Name = "������� ��������")]
        public bool NeedsAttention { get; set; }

        [Required]
        [EnumDataType(typeof(DealType))]
        [Display(Name="���")]
        public DealType Type { get; set; }

        [Required]
        [Display(Name = "���������")]
        public int DealStateId { get; set; }

        [ForeignKey("DealStateId")]
        [Display(Name = "���������")]
        public virtual DealState DealState { get; set; }

        [Display(Name = "������")]
        public virtual Customer Customer { get; set; }
        [Display(Name = "���������")]
        public string Creator { get; set; }
    }
}
