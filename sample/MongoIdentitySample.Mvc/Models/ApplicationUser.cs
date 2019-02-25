﻿using System;
using AspNetCore.Identity.MongoDbCore.Models;

namespace MongoIdentitySample.Mvc.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : MongoIdentityUser
    {
        public DateTime BirthDate { get; set; }

        public MongoIdentityRole UserRole { get; set; }
    }
}
