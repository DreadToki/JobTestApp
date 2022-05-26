using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JobTestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCreationController : ControllerBase
    {
        private DataContext _context;

        public UserCreationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserCreation>>> Get() // Getting all the users from DB
        {
            return Ok(await _context.UserCreations.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<UserCreation>>> PostUserCreation(UserCreation user)
        {
            
            var dbUserNameChecker = await _context.UserCreations.Where(m => m.UserName == user.UserName).SingleOrDefaultAsync();
            var dbUserEmailChecker = await _context.UserCreations.Where(m => m.Email == user.Email).SingleOrDefaultAsync();
            if (dbUserNameChecker == null) // if acc name is not in the system -> 404
            {
                return NotFound("Good shit, good shit, but u can do better");
            }
            else if (dbUserEmailChecker!= null) // If Email is in the system(DB) -> UPDATE
            // From this goes PUT method on updating FirstName & LastName
            {
                dbUserEmailChecker.FirstName = user.FirstName;
                dbUserEmailChecker.LastName = user.LastName;
                await _context.SaveChangesAsync();
                return Ok(await _context.UserCreations.ToListAsync());
            }
            else // Creating new User, initially deleting the previous one for unique UserName in db
            {
                _context.UserCreations.Remove(dbUserNameChecker);
                _context.UserCreations.Add(user);
                await _context.SaveChangesAsync();
                return Ok(await _context.UserCreations.ToListAsync());
            }
        }
    }
}
