
using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace UniversityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int id { get; set; }
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdateAt { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; } = false;



    }
}
