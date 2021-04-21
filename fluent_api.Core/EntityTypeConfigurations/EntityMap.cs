using fluent_api.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations
{
    public class EntityMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public EntityMap()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
