using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pjatk_wyklad3_webApi.DAL;
using Pjatk_wyklad3_webApi.Models;

namespace Pjatk_wyklad3_webApi.Controllers 

{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;
        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }


        [HttpGet]
        public IActionResult GetStudent(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudet(int id)
        {
            if (id == 1)
                return Ok("Kowalski");
            if (id == 2)
                return Ok("Malewski");
            return NotFound("Nie znaleziono studenta");
        }
        [HttpPost]
        public IActionResult CreateStudent(Models.Students student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        [HttpPut("{id}")]
        public IActionResult AddStudent(int id)
        {
            if (id == 0)
                return NotFound("Brak Id Studenta");
            return Ok("Aktualizacja zakończona");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (id == 0)
                return NotFound("Brak Id Studenta");
            else
                return Ok("Usuwanie zakończone");
        }
    }
}