using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }  = string.Empty;
        [Required , StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required , StringLength(500)]
        public string LongDescription { get; set; } = string.Empty;
        [Required]
        public string TargeAaudiences { get; set; } = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public string Level { get; set; } = string.Empty;




    }
}
