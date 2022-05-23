using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces
{
    public interface IUser
    {
        Task<IList<User>> getAll();
        Task creatUser(string name, string SexGender, int Age, string Phone);
        Task deleteUser(Guid UserID);
        Task editUser(User user);
    }
}
