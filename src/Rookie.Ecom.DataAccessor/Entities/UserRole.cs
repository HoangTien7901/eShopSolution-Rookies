﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class UserRole : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public bool Status { get; set; }
    }
}
