using Day1.DTOs;
using Day1.Models;
using Mapster;

namespace Day1.Mapping
{
    public static class MapsterConfig
    {
        public static void RegisterMapping()
        {
            TypeAdapterConfig<Student, StudentDTO>.NewConfig()
                .Map(dest => dest.ID, src => src.ID)
                .Map(dest => dest.SSN, src => src.SSN)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Age, src => src.Age)
                .Map(dest => dest.Address, src => src.Address)
                .Map(dest => dest.Image, src => src.Image)
                .Map(dest => dest.Level, src => src.Level)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.DateOfBirth, src => src.DateOfBirth);

            TypeAdapterConfig<StudentDTO, Student>.NewConfig()
                .Map(dest => dest.ID, src => src.ID)
                .Map(dest => dest.SSN, src => src.SSN)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Age, src => src.Age)
                .Map(dest => dest.Address, src => src.Address)
                .Map(dest => dest.Image, src => src.Image)
                .Map(dest => dest.Level, src => src.Level)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.DateOfBirth, src => src.DateOfBirth);


            TypeAdapterConfig<Department, DepartmentDTO>.NewConfig()
                .Map(dest => dest.ID, src => src.ID)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Location, src => src.Location)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Manager, src => src.Manager);

            TypeAdapterConfig<DepartmentDTO, Department>.NewConfig()
                .Map(dest => dest.ID, src => src.ID)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Location, src => src.Location)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Manager, src => src.Manager);


            TypeAdapterConfig<Department, DepartmentWithStudentsDTO>.NewConfig()
                .Map(dest => dest.DepartmentName, src => src.Name)
                .Map(dest => dest.StudentsNames, src => src.Students.Select(s => s.Name).ToList())
                .Map(dest => dest.StudentsCount, src => src.Students.Count)
                .Map(dest => dest.Msg, src => src.Students.Count > 1 ? "Overloaded" : "Normal");

        }
    }
}
