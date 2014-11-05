using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Observer
    {
        public t_Observer()
        {
            this.t_Agent = new List<t_Agent>();
            this.t_CastVote = new List<t_CastVote>();
        }

        public int idObserver { get; set; }
        public string name { get; set; }
        public int numCin { get; set; }
        public virtual ICollection<t_Agent> t_Agent { get; set; }
        public virtual ICollection<t_CastVote> t_CastVote { get; set; }
    }
}
