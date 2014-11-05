using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_QuizMap : EntityTypeConfiguration<t_Quiz>
    {
        public t_QuizMap()
        {
            // Primary Key
            this.HasKey(t => t.idQuiz);

            // Properties
            this.Property(t => t.idQuiz)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.answer)
                .HasMaxLength(255);

            this.Property(t => t.question)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_Quiz");
            this.Property(t => t.idQuiz).HasColumnName("idQuiz");
            this.Property(t => t.answer).HasColumnName("answer");
            this.Property(t => t.question).HasColumnName("question");

            // Relationships
            this.HasMany(t => t.t_RestredUser)
                .WithMany(t => t.t_Quiz)
                .Map(m =>
                    {
                        m.ToTable("t_Quiz_t_RestredUser");
                        m.MapLeftKey("quizs_idQuiz");
                        m.MapRightKey("regestredUsers_idUser");
                    });


        }
    }
}
