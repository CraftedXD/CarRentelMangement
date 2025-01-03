﻿using Microsoft.AspNetCore.Identity;

namespace CarRentelMangement.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRentelMangementUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
