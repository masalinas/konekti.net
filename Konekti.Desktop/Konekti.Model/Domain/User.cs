using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Konekti.Framework.Data;

namespace Konekti.Model.Domain
{
    public class User : Entity<int>
    {
        public virtual string Name { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual byte[] Photo { get; set; }
        public virtual string Language { get; set; }
        public virtual bool Active { get; set; }
        public virtual IList<Role> Roles  { get; set; }

        public User()
        {
            Active = true;
            Roles = new List<Role>();
        }

        public virtual void AddRole(Role role)
        {
            if (role != null && !Roles.Contains(role))
                Roles.Add(role);            
        }

        public virtual void RemoveRole(Role role)
        {
            if (role != null && Roles.Contains(role))
                Roles.Remove(role);
        }

        public virtual void ClearRoles()
        {
            Roles.Clear();
        }

        public override string ToString()
        {
            return "User [Id=" + Id.ToString() + "]";
        }
    }
}
