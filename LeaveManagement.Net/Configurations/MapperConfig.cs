using AutoMapper;
using LeaveManagement.Net.Data;
using LeaveManagement.Net.Models;

namespace LeaveManagement.Net.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
