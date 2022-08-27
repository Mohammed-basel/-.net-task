using employeeAPI.models;
using employeeAPI.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace first_.net_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<employee>> GETALL() => employeeservice.GETALL();
        [HttpGet("{id}")]
        public ActionResult<employee> GET(int id)
        {
            var employee = employeeservice.GET(id);
            if(employee == null)
                return NotFound();
            return employee;
        }
        [HttpPost]

        public ActionResult Create(employee employee)
        {
            employeeservice.Add(employee);
            return CreatedAtAction(nameof(Create), new {id = employee.Id},employee);
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, employee employee)
        {
            if (id != employee.Id)
                return BadRequest();

            var existingemployee = employeeservice.GET(id);
            if (existingemployee == null)
                return NotFound();
            employeeservice.Update(employee);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employee = employeeservice.GET(id);
            if (employee == null)
                return NotFound();
            employeeservice.Delete(id);
            return NoContent();

        }
    }
}
