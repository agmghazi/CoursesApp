using System.Linq;
using CoursesApp.MapDBEntities;

namespace CoursesApp.Services
{
    public interface IAdminService
    {
        bool Login(string Email, string Password);
        bool ChangePassword(string Email, string Password);
        bool ForgetPassword(string Email);
    }


    public class AdminService : IAdminService
    {
        public Courses_DBEntities context { get; set; }

        public AdminService()
        {
            context = new Courses_DBEntities();
        }
        public bool ChangePassword(string Email, string Password)
        {
            throw new System.NotImplementedException();
        }

        public bool ForgetPassword(string Email)
        {
            throw new System.NotImplementedException();
        }

        public bool Login(string Email, string Password)
        {
            return context.Admins
                .Any(x => x.Email == Email && x.Password == Password);
        }
    }
}