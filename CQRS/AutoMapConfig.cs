using AutoMapper;
using CQRS.Commands;
using CQRS.Entities;

namespace CQRS
{
    public class AutoMapConfig
    {
        public static void Regisger()
        {
            Mapper.CreateMap<CreateStudentCommand, Student>();
        }
    }
}
