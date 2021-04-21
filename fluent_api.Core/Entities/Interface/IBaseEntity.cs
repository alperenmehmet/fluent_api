using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Interface
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
    }
}
