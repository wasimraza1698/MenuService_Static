using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuService.Models;
using MenuService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MenuService.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class MenuController : ControllerBase
    {
        private readonly IRepository _menuRepo;

        public MenuController(IRepository menuRepo)
        {
            _menuRepo = menuRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return new OkObjectResult(_menuRepo.GetAll());
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                MenuItem item = _menuRepo.Get(id);
                return Ok(item);
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult Edit(MenuItem item)
        {
            try
            {
                MenuItem item1 = _menuRepo.Edit(item);
                return Ok(item1);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}