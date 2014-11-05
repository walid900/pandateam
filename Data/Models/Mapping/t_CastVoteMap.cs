using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class t_CastVoteMap : EntityTypeConfiguration<t_CastVote>
    {
        public t_CastVoteMap()
        {
            // Primary Key
            this.HasKey(t => t.idVote);

            // Properties
            this.Property(t => t.idVote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("t_CastVote");
            this.Property(t => t.idVote).HasColumnName("idVote");
            this.Property(t => t.candidateList_idList).HasColumnName("candidateList_idList");
            this.Property(t => t.fkelec).HasColumnName("fkelec");
            this.Property(t => t.observerc_idObserver).HasColumnName("observerc_idObserver");
            this.Property(t => t.session_idSession).HasColumnName("session_idSession");

            // Relationships
            this.HasMany(t => t.t_Elector1)
                .WithMany(t => t.t_CastVote1)
                .Map(m =>
                    {
                        m.ToTable("t_Elector_t_CastVote");
                        m.MapLeftKey("castVotes_idVote");
                        m.MapRightKey("t_Elector_idElector");
                    });

            this.HasOptional(t => t.t_Elector)
                .WithMany(t => t.t_CastVote)
                .HasForeignKey(d => d.fkelec);
            this.HasOptional(t => t.t_Observer)
                .WithMany(t => t.t_CastVote)
                .HasForeignKey(d => d.observerc_idObserver);
            this.HasOptional(t => t.t_condidatelist)
                .WithMany(t => t.t_CastVote)
                .HasForeignKey(d => d.candidateList_idList);
            this.HasOptional(t => t.t_Session)
                .WithMany(t => t.t_CastVote)
                .HasForeignKey(d => d.session_idSession);

        }
    }
}
