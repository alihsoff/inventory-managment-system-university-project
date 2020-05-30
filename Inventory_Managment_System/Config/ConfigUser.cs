using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Config
{
    class ConfigUser
    {
        private T_USER user;
        public static ConfigUser configUser;

        public T_USER User { get => user; set => user = value; }

        public ConfigUser(T_USER user)
        {
            this.user = user;
        }
    }
}
