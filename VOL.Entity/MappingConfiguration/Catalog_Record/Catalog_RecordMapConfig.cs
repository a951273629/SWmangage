using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Catalog_RecordMapConfig : EntityMappingConfiguration<Catalog_Record>
    {
        public override void Map(EntityTypeBuilder<Catalog_Record>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

