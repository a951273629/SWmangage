using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Org_WorkPostMapConfig : EntityMappingConfiguration<Org_WorkPost>
    {
        public override void Map(EntityTypeBuilder<Org_WorkPost>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

