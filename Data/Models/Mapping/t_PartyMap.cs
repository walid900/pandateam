using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_PartyMap : EntityTypeConfiguration<t_Party>
    {
        public t_PartyMap()
        {
            // Primary Key
            this.HasKey(t => t.idParty);

            // Properties
            this.Property(t => t.idParty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.creatorMail)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.foundingMember)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.nbrAdhe)
                .HasMaxLength(255);

            this.Property(t => t.news)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.politicalAffiliation)
                .HasMaxLength(255);

            this.Property(t => t.valuess)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Party");
            this.Property(t => t.idParty).HasColumnName("idParty");
            this.Property(t => t.creatorMail).HasColumnName("creatorMail");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.foundingMember).HasColumnName("foundingMember");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.nbrAdhe).HasColumnName("nbrAdhe");
            this.Property(t => t.news).HasColumnName("news");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.politicalAffiliation).HasColumnName("politicalAffiliation");
            this.Property(t => t.valuess).HasColumnName("valuess");
        }
    }
}
