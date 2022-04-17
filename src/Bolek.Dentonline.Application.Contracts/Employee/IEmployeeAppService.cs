using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Bolek.Dentonline.Employee;

public interface IEmployeeAppService : ICrudAppService< 
    EmployeeDto,
    Guid, 
    PagedAndSortedResultRequestDto,
    CreateUpdateEmployeeDto>
{
    
}