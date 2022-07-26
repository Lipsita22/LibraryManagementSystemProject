using LibraryManagementProject.Models;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("UserPolicy")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly LibraryContext _context;
        public UserController(IConfiguration config, LibraryContext context)
        {
            _config = config;
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("CreateUser")]
        public IActionResult Create(Users user)
        {
            if (_context.Users.Where(u => u.Email == user.Email).FirstOrDefault() != null)
            {
                return Ok("Already Exist");
            }
            user.MemberSince = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Success");
        }

        [AllowAnonymous]
        [HttpPost("LoginUser")]
        public IActionResult Login(Logins user)
        {
            var userAvailable = _context.Users.Where(u => u.Email == user.Email && u.Pwd == user.Pwd).
                    FirstOrDefault();
            if (userAvailable != null)
            {
                return Ok("Success");

            }
            return Ok("Failure");
        }
    }
}
