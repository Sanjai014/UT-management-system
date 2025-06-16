using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;
using UnicomTicManagementSystem.View;

namespace UnicomTICManagementSystem.Controllers
{
    public class LoginController
    {
        private readonly DatabaseManager db;

        public LoginController()
        {
            db = DatabaseManager.Instance;
        }

        public async Task<User> ValidateLoginAsync(string username, string password)
        {
            return await db.GetUserByUsernameAndPasswordAsync(username, password);
        }
    }
}