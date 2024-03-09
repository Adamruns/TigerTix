using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Data;
using TigerTix.Web.Data.Entities;

// Other necessary using directives

namespace TigerTix.Web.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly TigerTixContext _context;

        public UserRepository(TigerTixContext context)
        {
            _context = context;
        }

        // Add your methods to interact with the database here
        public void SaveUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        //Returns all users
        public IEnumerable<User> GetAllUsers() 
        {
            var users = from u in _context.Users   
                            select u;
            return users.ToList();
        }

        // Return a single User by ID
        public User GetUsersByID(int userID)
        {
            var user = (from u in _context.Users
                        where u.Id == userID
                        select u).FirstOrDefault();
            return user;
        }
        // Update a user
        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();

        }
        // Delete a user
        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }
        // Save All
        public bool SaveAll()
        {
            // Save changes returns the number of rows affected
            return _context.SaveChanges() > 0;
        }
    }
}
