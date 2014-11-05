using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_AgentMap : EntityTypeConfiguration<t_Agent>
    {
        public t_AgentMap()
        {
            // Primary Key
            this.HasKey(t => t.idAgent);

            // Properties
            this.Property(t => t.idAgent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Agent");
            this.Property(t => t.idAgent).HasColumnName("idAgent");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.numCin).HasColumnName("numCin");
            this.Property(t => t.observer_idObserver).HasColumnName("observer_idObserver");

            // Relationships
            this.HasOptional(t => t.t_Observer)
                .WithMany(t => t.t_Agent)
                .HasForeignKey(d => d.observer_idObserver);

        }
    }
}
