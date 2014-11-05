using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_SessionMap : EntityTypeConfiguration<t_Session>
    {
        public t_SessionMap()
        {
            // Primary Key
            this.HasKey(t => t.idSession);

            // Properties
            this.Property(t => t.idSession)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typeOfElection)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Session");
            this.Property(t => t.idSession).HasColumnName("idSession");
            this.Property(t => t.closingDate).HasColumnName("closingDate");
            this.Property(t => t.openingDate).HasColumnName("openingDate");
            this.Property(t => t.typeOfElection).HasColumnName("typeOfElection");
        }
    }
}
