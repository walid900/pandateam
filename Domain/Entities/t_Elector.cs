using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Elector
    {
        public t_Elector()
        {
            this.t_CastVote = new List<t_CastVote>();
            this.t_CastVote1 = new List<t_CastVote>();
        }

        public int idElector { get; set; }
        public string identify { get; set; }
        public string mail { get; set; }
        public string name { get; set; }
        public int numCin { get; set; }
        public string password { get; set; }
        public string region { get; set; }
        public virtual ICollection<t_CastVote> t_CastVote { get; set; }
        public virtual ICollection<t_CastVote> t_CastVote1 { get; set; }
    }
}
