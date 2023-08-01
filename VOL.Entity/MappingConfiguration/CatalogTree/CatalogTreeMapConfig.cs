using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class CatalogTreeMapConfig : EntityMappingConfiguration<CatalogTree>
    {
        public override void Map(EntityTypeBuilder<CatalogTree>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

