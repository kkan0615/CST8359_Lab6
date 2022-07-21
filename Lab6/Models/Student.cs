using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace Lab6.Models
{
    public class Student
    {
        [SwaggerSchema(ReadOnly = true)]
        public Guid Id { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string Program { get; set; }
    }
}
