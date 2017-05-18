using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynWebCRM.Contract.Models
{
    [Table("Website")]
    public partial class Website
    {
        public int WebsiteId { get; set; }

        [Display(Name = "���� ����������")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        [Display(Name = "������")]
        public int OwnerId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "�����")]
        public string Domain { get; set; }

        [Display(Name = "��������� ��������")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? HostingEndingDate { get; set; }

        [Display(Name = "��������� ������")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DomainEndingDate { get; set; }

        [Display(Name = "������������")]
        public decimal? HostingPrice { get; set; }

        [Display(Name = "������")]
        public virtual Customer Customer { get; set; }

        [Display(Name = "���������")]
        public string Creator { get; set; }

        [Display(Name = "�������������")]
        public bool IsActive { get; set; }
    }
}
