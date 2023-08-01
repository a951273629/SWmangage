using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Store_ProviderRegularMapConfig : EntityMappingConfiguration<Store_ProviderRegular>
    {
        public override void Map(EntityTypeBuilder<Store_ProviderRegular>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

