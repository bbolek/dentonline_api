using System;
using Volo.Abp.Application.Dtos;

namespace Bolek.Dentonline.Employee;

public class EmployeeDto: AuditedEntityDto<Guid>
{
    public string FirstName { get; set; }

    public EmployeeType EmployeeType { get; set; }

    public string LastName { get; set; }
}