using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Models
{
    public interface IUserGuidGenerator
    {
        Guid Guid { get; }

    }
}
