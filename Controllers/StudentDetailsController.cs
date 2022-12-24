using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using studentdetails.Dtos.Student;
using studentdetails.Services.StudentDetailsService;

namespace studentdetails.Controllers
{   
    [ApiController]
    [Route("api/controller")]
    public class StudentDetailsController : ControllerBase
    {
        private readonly IStudentDetailsService _studentService;
        public StudentDetailsController(IStudentDetailsService studentService)
        {
            _studentService = studentService;
            
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetStudentDto>>>> Get()
        {
            return Ok(await _studentService.GetAllStudents()); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetStudentDto>>> GetSingle(int id)
        {
            return Ok(await _studentService.GetStudentById(id)); 
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetStudentDto>>>> Delete(int id)
        {
            var response = await _studentService.DeleteStudent(id);
            if(response.Data == null)
            {
            return NotFound(response);
            }
            return Ok(response); 
            
        }
        [HttpPost("Add")]
        public async Task<ActionResult<ServiceResponse<List<GetStudentDto>>>> AddStudent(AddStudentDto newStudent)
        {
            return Ok(await _studentService.AddStudent(newStudent));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<GetStudentDto>>> UpdateStudent(UpdateStudentDto updatedStudent)
        {
            var response = await _studentService.UpdateStudent(updatedStudent);
            if(response.Data == null)
            {
            return NotFound(response);
            }
            return Ok(response); 
            }
        }
        
        
}