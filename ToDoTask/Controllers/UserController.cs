﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoTask.Models;
using ToDoTask.Models.ViewModes;

namespace ToDoTask.Controllers
{
    [Route("api/UserController")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        private ApplicationContext _db;
        public UserController(ApplicationContext db)
        {
            _db = db;
        }

        [Route("CreateUser")]
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] UserViewModel model)
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, User>()
                            .ForMember("Name", opt => opt.MapFrom(c => c.FirstName + " " + c.LastName))
                            );
                var mapper = new Mapper(config);
                var result = mapper.Map<User>(model);
                _db.Add(result);
                _db.SaveChangesAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }

        }
    }
}
