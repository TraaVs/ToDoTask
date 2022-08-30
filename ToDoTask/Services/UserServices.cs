﻿using AspBackend.Interface;
using AspBackend.Models.Entity;
using AspBackend.Models.ViewModel;
using AspBackend.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoTask.Models;

namespace AspBackend.Services
{
    public class UserServices : IUserService
    {
        private ApplicationContext _db;

        public UserServices(ApplicationContext db)
        {
            _db = db;
        }
        public async Task<Account> CreateAccount(User user)
        {
            try
            {
                var createdUser = await _db.User.AddAsync(user);

                await _db.SaveChangesAsync();

                var created = await _db.User
                  .Include(u => u.Account)
                  .SingleOrDefaultAsync(u => u.Id == createdUser.Entity.Id);

                return created.Account;

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<User> UpdateUser(UserViewModel model)
        {
            try
            {

                var result = AutomapperUtil<UserViewModel, User>.Map(model);
                _db.User.Update(result);
                await _db.SaveChangesAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}