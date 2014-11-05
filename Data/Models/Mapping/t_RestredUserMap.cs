using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_RestredUserMap : EntityTypeConfiguration<t_RestredUser>
    {
        public t_RestredUserMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_RestredUser");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.party_idParty).HasColumnName("party_idParty");

            // Relationships
            this.HasOptional(t => t.t_Party)
                .WithMany(t => t.t_RestredUser)
                .HasForeignKey(d => d.party_idParty);

        }
    }
}
