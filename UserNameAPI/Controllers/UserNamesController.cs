using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserNameAPI;
using UserNameLibrary;

namespace UserNameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserNamesController : ControllerBase
    {
        private readonly UserNameDbContext _context;

        public UserNamesController(UserNameDbContext context)
        {
            _context = context;
        }

        // GET: api/UserNames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserName>>> GetUserNames()
        {
            return await _context.UserNames.ToListAsync();
        }

        // GET: api/UserNames/5
        [HttpGet("{id}", Name = "GetUserName")]
        public async Task<ActionResult<UserName>> GetUserName(int id)
        {
            var userName = await _context.UserNames.FindAsync(id);

            if (userName == null)
            {
                return NotFound();
            }

            return userName;
        }

        // PUT: api/UserNames/5
        [HttpPut]
        public async Task<IActionResult> PutUserName(UserName userName)
        {
            _context.Entry(userName).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/UserNames
        [HttpPost]
        public async Task<ActionResult<UserName>> PostUserName(UserName userName)
        {
            _context.Add(userName);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetUserName", new { id = userName.NameId }, userName);
        }

        // DELETE: api/UserNames/5
        [HttpDelete("{id}", Name = "DeleteUserName")]

        public async Task<ActionResult> DeleteUserName(int id)
        {
            var userName = new UserName { NameId = id };
            if (userName == null)
            {
                return NotFound();
            }

            _context.UserNames.Remove(userName);
            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        private bool UserNameExists(int id)
        {
            return _context.UserNames.Any(e => e.NameId == id);
        }
    }
}
