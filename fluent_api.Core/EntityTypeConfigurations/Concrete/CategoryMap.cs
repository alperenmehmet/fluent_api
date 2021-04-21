using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class CategoryMap : EntityMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");

            Property(x => x.Name).IsOptional();
            Property(x => x.Description).IsOptional();

            HasMany(x => x.Products)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
