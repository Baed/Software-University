using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Employees.Client.Commands;
using Employees.DtoModels;
using Employees.Models;

namespace Employees.Client
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();

            CreateMap<EmployeeDto, Employee>();

            CreateMap<Employee, EmployeePersonalDto>();
        }
    }
}
