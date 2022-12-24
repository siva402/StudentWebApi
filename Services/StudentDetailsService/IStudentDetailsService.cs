using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using studentdetails.Dtos.Student;

namespace studentdetails.Services.StudentDetailsService
{
    public interface IStudentDetailsService
    {
        Task<ServiceResponse<List<GetStudentDto>>> GetAllStudents();
        Task<ServiceResponse<GetStudentDto>> GetStudentById(int id);
        Task<ServiceResponse<List<GetStudentDto>>> AddStudent(AddStudentDto newStudent);
        Task<ServiceResponse<GetStudentDto>> UpdateStudent(UpdateStudentDto updatedStudent);
        Task<ServiceResponse<List<GetStudentDto>>> DeleteStudent(int id);
    }
}