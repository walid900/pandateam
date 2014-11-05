using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_ResultMap : EntityTypeConfiguration<t_Result>
    {
        public t_ResultMap()
        {
            // Primary Key
            this.HasKey(t => t.idResult);

            // Properties
            this.Property(t => t.idResult)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.result)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Result");
            this.Property(t => t.idResult).HasColumnName("idResult");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.result).HasColumnName("result");
        }
    }
}
