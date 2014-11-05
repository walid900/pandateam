using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Session
    {
        public t_Session()
        {
            this.t_CastVote = new List<t_CastVote>();
            this.t_condidatelist = new List<t_condidatelist>();
        }

        public int idSession { get; set; }
        public Nullable<System.DateTime> closingDate { get; set; }
        public Nullable<System.DateTime> openingDate { get; set; }
        public string typeOfElection { get; set; }
        public virtual ICollection<t_CastVote> t_CastVote { get; set; }
        public virtual ICollection<t_condidatelist> t_condidatelist { get; set; }
    }
}
