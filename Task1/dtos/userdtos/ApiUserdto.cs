using System.ComponentModel.DataAnnotations;

namespace Task1.dtos.userdtos
{
    public class ApiUserdto:LoginDto
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
    }
}
