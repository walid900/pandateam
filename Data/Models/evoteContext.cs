using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;

namespace Data.Models
{
    public partial class evoteContext : DbContext
    {
        static evoteContext()
        {
            Database.SetInitializer<evoteContext>(null);
        }

        public evoteContext()
            : base("Name=evoteContext")
        {
        }

        public DbSet<t_Agent> t_Agent { get; set; }
        public DbSet<t_ApAdmin> t_ApAdmin { get; set; }
        public DbSet<t_CastVote> t_CastVote { get; set; }
        public DbSet<t_Citizen> t_Citizen { get; set; }
        public DbSet<t_Condidate> t_Condidate { get; set; }
        public DbSet<t_condidatelist> t_condidatelist { get; set; }
        public DbSet<t_Elector> t_Elector { get; set; }
        public DbSet<t_Observer> t_Observer { get; set; }
        public DbSet<t_Party> t_Party { get; set; }
        public DbSet<t_Quiz> t_Quiz { get; set; }
        public DbSet<t_RestredUser> t_RestredUser { get; set; }
        public DbSet<t_Result> t_Result { get; set; }
        public DbSet<t_Session> t_Session { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new t_AgentMap());
            modelBuilder.Configurations.Add(new t_ApAdminMap());
            modelBuilder.Configurations.Add(new t_CastVoteMap());
            modelBuilder.Configurations.Add(new t_CitizenMap());
            modelBuilder.Configurations.Add(new t_CondidateMap());
            modelBuilder.Configurations.Add(new t_condidatelistMap());
            modelBuilder.Configurations.Add(new t_ElectorMap());
            modelBuilder.Configurations.Add(new t_ObserverMap());
            modelBuilder.Configurations.Add(new t_PartyMap());
            modelBuilder.Configurations.Add(new t_QuizMap());
            modelBuilder.Configurations.Add(new t_RestredUserMap());
            modelBuilder.Configurations.Add(new t_ResultMap());
            modelBuilder.Configurations.Add(new t_SessionMap());
        }
    }
}
