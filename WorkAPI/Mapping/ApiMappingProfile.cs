using AutoMapper;
using Work.Core.DTOs;
using Work.Core.Entities;
using WorkAPI.Models;

namespace WorkAPI.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<EmployeePostModel, Employee>().ReverseMap();
            

        }
    }
}
