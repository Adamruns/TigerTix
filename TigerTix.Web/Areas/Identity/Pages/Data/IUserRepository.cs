using TigerTix.Web.Data.Entities;

public interface IUserRepository
{
    void DeleteUser(User user);
    IEnumerable<User> GetAllUsers();
    User GetUsersByID(int userID);
    void SaveUser(User user);
    void UpdateUser(User user);
    bool SaveAll();
    
}