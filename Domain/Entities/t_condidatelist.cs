using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_condidatelist
    {
        public t_condidatelist()
        {
            this.t_CastVote = new List<t_CastVote>();
            this.t_Condidate = new List<t_Condidate>();
        }

        public int idList { get; set; }
        public string name { get; set; }
        public int num { get; set; }
        public string region { get; set; }
        public Nullable<int> fkpar { get; set; }
        public Nullable<int> fksess { get; set; }
        public virtual ICollection<t_CastVote> t_CastVote { get; set; }
        public virtual ICollection<t_Condidate> t_Condidate { get; set; }
        public virtual t_Party t_Party { get; set; }
        public virtual t_Session t_Session { get; set; }
    }
}
