using employeeAPI.models;
using employeeAPI.services;
using first_.net_task.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace first_.net_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        public employeeinterface _employeeserves;

        public employeeController(employeeinterface employeeservice)
        {
            _employeeserves = employeeservice;

            var x = 1;
        }
        [HttpGet("GetById/{id}")]
        public ActionResult<employee> GetById(int id)
        {
            return Ok(_employeeserves.GetById(id));
        }
        [HttpGet]
        public async Task<ActionResult<List<employee>>> GET()
        {
            return Ok(_employeeserves.GET());  
        }
        [HttpPost]

        public ActionResult Create(employee employee)
        {
            return Ok(_employeeserves.Create(employee));
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, employee employee)
        {
            return Ok(_employeeserves.Update(id,employee));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_employeeserves.Delete(id));


        }
    }
}
