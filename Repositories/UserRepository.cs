using DesafioBalta.Context;
using DesafioBalta.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DesafioBalta.Repositories 
{ 
    public class UserRepository
    {
        private readonly ApiContext _context;

        public UserRepository(ApiContext context)
        {
            _context = context;
        }
    }
}