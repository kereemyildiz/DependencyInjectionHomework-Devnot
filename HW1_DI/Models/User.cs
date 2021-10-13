using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Models
{
    public class User : IUserGuidGenerator
    {
        private Guid guid;

        public User()
        {
            guid = Guid.NewGuid();
        }
        public Guid Guid => guid;
    }
}
