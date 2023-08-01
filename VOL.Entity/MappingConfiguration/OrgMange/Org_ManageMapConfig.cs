using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Org_ManageMapConfig : EntityMappingConfiguration<Org_Manage>
    {
        public override void Map(EntityTypeBuilder<Org_Manage>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

