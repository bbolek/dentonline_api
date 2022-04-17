using System;
using Bolek.Dentonline.Employee;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bolek.Dentonline.Employee;

public class Employee : AuditedAggregateRoot<Guid>, IMultiTenant, IHasConcurrencyStamp
{
    public Guid? TenantId { get; }

    public string FirstName { get; set; }
    
    public string LastName { get;set; }
    
    public EmployeeType EmployeeType {get;set;}

}