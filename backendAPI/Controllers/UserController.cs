using System;
using System.Collections.Generic;
using System.Linq;
using backendAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace backendAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class UserController : ControllerBase
    {
        // property for users DB conf 
        private readonly UserDBContext _context;
        
        // for initializing Users DB
        public UserController(UserDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Authenticate(AuthenticateRequest model)
        {

            var response = UserService.Authenticate(model);

            if (response == null)
                return BadRequest(new {message = "Username or password is incorrect"});

            return Ok(new
            {
                response.Token,
                personalDetails = new
                {
                    response.Name,
                    response.Team,
                    response.JoinedAt,
                    response.Avatar
                }
            });
        }

    
    [HttpGet("/info")]
    public IActionResult GetUserProjects()
    {
        string tokenStr = "Token";
        var token = Request.Headers[tokenStr];
        /* checking if token is valid */
        if(UserService.validateToken(token)) {
            List<User> users = UserDBContext.get();
            foreach (User user in users) {
                if (token == user.Token) {
                    Array filteredProjects = FilteringProjects(UserDBContext.getProjects(), user.Email);
                    return Ok(filteredProjects);
                }
            }
        }
        return BadRequest(new {message = "Invalid Token/Token is out of Date"});
    }

    /**/
    private Array FilteringProjects(List<Project> projects, string email)
    {
        List<Project> userProjects = projects.Where(project => project.UserEmail == email).ToList();
        return userProjects.Select(p => new {id=p.Id, name=p.Name, score=p.Score, durationInDays= p.DurationInDays, bugsCount=p.BugsCount, madeDadeline=p.MadeDadeline }).ToArray();
    }
    
    }
}