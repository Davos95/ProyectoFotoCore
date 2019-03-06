using RepositoryPictureManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioPictureManager.Repositories
{
    public interface IRepositoryLogin
    {
        USER GetUser(String nick, String pwd);

    }
}
