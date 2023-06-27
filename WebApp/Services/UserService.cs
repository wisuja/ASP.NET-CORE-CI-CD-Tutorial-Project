using WebApp.Models;

namespace WebApp.Services
{
    public class UserService
    {
        public List<User> FilterUserByFirstName(string name, List<User> users)
        {
            return users.Where(x => x.FirstName == name).ToList();
        }
    }
}
