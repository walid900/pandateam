using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_CondidateMap : EntityTypeConfiguration<t_Condidate>
    {
        public t_CondidateMap()
        {
            // Primary Key
            this.HasKey(t => t.idCandidate);

            // Properties
            this.Property(t => t.idCandidate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adresse)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.fatherName)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.motherName)
                .HasMaxLength(255);

            this.Property(t => t.occupation)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Condidate");
            this.Property(t => t.idCandidate).HasColumnName("idCandidate");
            this.Property(t => t.adresse).HasColumnName("adresse");
            this.Property(t => t.dateOfBirth).HasColumnName("dateOfBirth");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.fatherName).HasColumnName("fatherName");
            this.Property(t => t.fatherNumCin).HasColumnName("fatherNumCin");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.motherName).HasColumnName("motherName");
            this.Property(t => t.motherNumCin).HasColumnName("motherNumCin");
            this.Property(t => t.numCin).HasColumnName("numCin");
            this.Property(t => t.occupation).HasColumnName("occupation");
            this.Property(t => t.tel).HasColumnName("tel");
            this.Property(t => t.candidates_idList).HasColumnName("candidates_idList");

            // Relationships
            this.HasOptional(t => t.t_condidatelist)
                .WithMany(t => t.t_Condidate)
                .HasForeignKey(d => d.candidates_idList);

        }
    }
}
