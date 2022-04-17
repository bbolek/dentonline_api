using System;
using Bolek.Dentonline.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Bolek.Dentonline.Employee;

public class EmployeeAppService :
    CrudAppService<
        Employee,
        EmployeeDto, 
        Guid,
        PagedAndSortedResultRequestDto, 
        CreateUpdateEmployeeDto>,
    IEmployeeAppService
{
    public EmployeeAppService(IRepository<Employee, Guid> repository)
        : base(repository)
    {
        GetPolicyName = EmployeePermissions.Employees.Default;
        GetListPolicyName = EmployeePermissions.Employees.Default;
        CreatePolicyName = EmployeePermissions.Employees.Create;
        UpdatePolicyName = EmployeePermissions.Employees.Edit;
        DeletePolicyName = EmployeePermissions.Employees.Delete;
    }
}