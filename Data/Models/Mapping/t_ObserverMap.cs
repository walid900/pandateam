using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_ObserverMap : EntityTypeConfiguration<t_Observer>
    {
        public t_ObserverMap()
        {
            // Primary Key
            this.HasKey(t => t.idObserver);

            // Properties
            this.Property(t => t.idObserver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Observer");
            this.Property(t => t.idObserver).HasColumnName("idObserver");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.numCin).HasColumnName("numCin");
        }
    }
}
