using fluent_api.Core.Entities.Interface;
using fluent_api.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Abstract
{
    public class BaseEntity : IBaseEntity<int>
    {
        public int Id { get; set; }
    }
}
