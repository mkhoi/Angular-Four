﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private static List<User> Users { get; set; }
        static UsersController()
        {

        }

        [Route("")]
        [HttpGet]
        public IList<User> GetUsers()
        {
            DatabaseContext db = new DatabaseContext();
            Users = db.Users.ToList();
            return Users;
        }

        [HttpPost]
        [Route("")]
        public User CreateUser(User user)
        {
            DatabaseContext db = new DatabaseContext();
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }
    }
}
