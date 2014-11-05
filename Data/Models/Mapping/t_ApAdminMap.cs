using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_ApAdminMap : EntityTypeConfiguration<t_ApAdmin>
    {
        public t_ApAdminMap()
        {
            // Primary Key
            this.HasKey(t => t.idAdmin);

            // Properties
            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_ApAdmin");
            this.Property(t => t.idAdmin).HasColumnName("idAdmin");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.password).HasColumnName("password");
        }
    }
}
