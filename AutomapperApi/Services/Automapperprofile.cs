using AutoMapper;
using AutomapperApi.Models;

namespace AutomapperApi.Services
{
    public class Automapperprofile:Profile
    {
        public Automapperprofile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
        }
    }
}
 