using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Prod_ProductionMessageMapConfig : EntityMappingConfiguration<Prod_ProductionMessage>
    {
        public override void Map(EntityTypeBuilder<Prod_ProductionMessage>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

