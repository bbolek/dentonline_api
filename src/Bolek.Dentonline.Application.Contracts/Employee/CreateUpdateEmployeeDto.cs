using System.ComponentModel.DataAnnotations;

namespace Bolek.Dentonline.Employee;

public class CreateUpdateEmployeeDto
{
    [Required]
    [StringLength(128)]
    public string FirstName { get; set; }

    [Required]
    public EmployeeType EmployeeType { get; set; }
    
    [Required]
    [StringLength(128)]
    public string LastName { get; set; }

}