using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todoWebApi.Interfaces;
using todoWebApi.Models;

namespace todoWebApi.Controllers
{
    [Route("api/[Controller]")]
    public class TasksController : Controller
    {
        private readonly ITasksRepository _tasksRepository;
        public TasksController(ITasksRepository tasklist)
        {
            _tasksRepository = tasklist;
        }

        [HttpGet]
        public IEnumerable<Tasks> GetAll()
        {
            return _tasksRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetTask")]
        public IActionResult GetById([FromRoute] long id)
        {
            var task = _tasksRepository.Find(id);
            if (task == null)
                return NotFound();

            return new ObjectResult(task);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Tasks task)
        {
            if (task == null)
                return BadRequest();

            _tasksRepository.Add(task);

            return CreatedAtRoute("GetTask", new {id = task.Id}, task);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Tasks task)
        {
            if (task == null)
                return BadRequest();

            _tasksRepository.Update(task);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _tasksRepository.Remove(id);
            return new NoContentResult();
        }




    }
}
