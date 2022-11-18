
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace UniversityApiBackend.Models.DataModels
{
    public class User : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Email { get; set; }= string.Empty;

        [Required, StringLength(50)]
        public string Password { get; set; }=string.Empty;

    }
}
