using Microsoft.AspNetCore.Mvc;
using SchoolManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(AddStudentInputModel model)
        {
            return CreatedAtAction(nameof(Get), new { id = 1 }, model);
        }
    }
}
