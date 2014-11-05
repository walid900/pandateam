using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_condidatelistMap : EntityTypeConfiguration<t_condidatelist>
    {
        public t_condidatelistMap()
        {
            // Primary Key
            this.HasKey(t => t.idList);

            // Properties
            this.Property(t => t.idList)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.region)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_condidatelist");
            this.Property(t => t.idList).HasColumnName("idList");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.num).HasColumnName("num");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.fkpar).HasColumnName("fkpar");
            this.Property(t => t.fksess).HasColumnName("fksess");

            // Relationships
            this.HasOptional(t => t.t_Party)
                .WithMany(t => t.t_condidatelist)
                .HasForeignKey(d => d.fkpar);
            this.HasOptional(t => t.t_Session)
                .WithMany(t => t.t_condidatelist)
                .HasForeignKey(d => d.fksess);

        }
    }
}
