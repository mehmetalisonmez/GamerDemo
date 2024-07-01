using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Abstract
{
    public interface ICheckService
    {
        bool isValidate(Gamer gamer);
    }
}
