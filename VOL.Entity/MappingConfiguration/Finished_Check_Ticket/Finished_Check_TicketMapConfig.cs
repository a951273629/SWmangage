using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Finished_Check_TicketMapConfig : EntityMappingConfiguration<Finished_Check_Ticket>
    {
        public override void Map(EntityTypeBuilder<Finished_Check_Ticket>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

