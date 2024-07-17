﻿using Domain.Entities;
using Domain.Interfaces;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)

        {
            _userRepository = userRepository;
        }
        public User Get(string name)
        {
            return _userRepository.Get(name);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
