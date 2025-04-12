using System;
using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers;

[ApiController]
[Route("dating/[controller]")] // dating/users
public class UsersController(DataContext context) : ControllerBase
{

    // synchronous call
    // [HttpGet]
    // public ActionResult<IEnumerable<AppUser>> GetUsers(){
    //     var users = context.Users.ToList();
    //     return users;
    // }

    // [HttpGet("{id}")] // dating/users/id
    // public ActionResult<AppUser> GetUser(int id){
    //     var user = context.Users.Find(id);
    //     if(user == null) return NotFound();
    //     return user;
    // }

    // Asynchronous call
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
        var users = await context.Users.ToListAsync();
        return users;
    }

    [HttpGet("{id}")] // dating/users/id
    public async Task<ActionResult<AppUser>> GetUser(int id){
        var user = await context.Users.FindAsync(id);
        if(user == null) return NotFound();
        return user;
    }
}
