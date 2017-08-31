﻿using SaafiApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaafiApp.Core.Contracts.Services
{
    public interface IUserDataService
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);

        User GetActiveUser();
    }
}
