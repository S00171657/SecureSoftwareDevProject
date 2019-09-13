using System;
using System.Collections.Generic;
using System.Text;

namespace SecureSoftwareDevProject
{
    public class UserRole
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public enum Role
        {
            Admin,
            Manager,
            Employee
        }

        public Role Position { get; set; }
    }
}
