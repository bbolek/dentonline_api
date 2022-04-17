using AutoMapper;
using Bolek.Dentonline.Employee;

namespace Bolek.Dentonline;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Employee.Employee, EmployeeDto>();
        CreateMap<CreateUpdateEmployeeDto, Employee.Employee>();

    }
}