using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_ElectorMap : EntityTypeConfiguration<t_Elector>
    {
        public t_ElectorMap()
        {
            // Primary Key
            this.HasKey(t => t.idElector);

            // Properties
            this.Property(t => t.idElector)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.identify)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.region)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Elector");
            this.Property(t => t.idElector).HasColumnName("idElector");
            this.Property(t => t.identify).HasColumnName("identify");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.numCin).HasColumnName("numCin");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.region).HasColumnName("region");
        }
    }
}
