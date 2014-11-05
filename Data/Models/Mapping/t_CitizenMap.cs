using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_CitizenMap : EntityTypeConfiguration<t_Citizen>
    {
        public t_CitizenMap()
        {
            // Primary Key
            this.HasKey(t => t.idCitizen);

            // Properties
            this.Property(t => t.idCitizen)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("t_Citizen");
            this.Property(t => t.idCitizen).HasColumnName("idCitizen");
            this.Property(t => t.isnotBankrupt).HasColumnName("isnotBankrupt");
            this.Property(t => t.isnotCriminal).HasColumnName("isnotCriminal");
            this.Property(t => t.isnotDead).HasColumnName("isnotDead");
            this.Property(t => t.isnotMentalRetarded).HasColumnName("isnotMentalRetarded");
            this.Property(t => t.isnotMilitary).HasColumnName("isnotMilitary");
            this.Property(t => t.numCin).HasColumnName("numCin");
        }
    }
}
