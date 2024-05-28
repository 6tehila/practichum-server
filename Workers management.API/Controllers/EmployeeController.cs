using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Workers_management.Core;
using Workers_management.Core.DTOs;
using Workers_management.Core.Entities;
using Workers_management.Core.Services;
using Workers_management.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workers_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }



        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var emp = await _employeeService.GetEmployeesAsync();
            var empDto = _mapper.Map<IEnumerable<EmployeeDto>>(emp);
            return Ok(empDto);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var emp = await _employeeService.GetByIdAsync(id);
            var empDto = _mapper.Map<EmployeeDto>(emp);
            return Ok(empDto);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> Post([FromBody] Employee employee)
        {
            var newEmp = await _employeeService.AddEmployeeAsync(employee);
            var newEmpDto = _mapper.Map<EmployeeDto>(newEmp);
            return Ok(newEmpDto);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Employee employeeDto)
        {
            var empToUpdate = _mapper.Map<Employee>(employeeDto);
            var emp = await _employeeService.UpdateEmployeeAsync(id, empToUpdate);
            var newEmp = await _employeeService.GetByIdAsync(emp.Id);
            var empDTO = _mapper.Map<EmployeeDto>(newEmp);
            return Ok(empDTO);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var emp = await _employeeService.GetByIdAsync(id);
            if (emp is null)
            {
                return NotFound();
            }
            await _employeeService.DeleteEmployeeAsync(id);
            return NoContent();
        }
    }
}
