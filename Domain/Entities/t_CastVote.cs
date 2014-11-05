using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_CastVote
    {
        public t_CastVote()
        {
            this.t_Elector1 = new List<t_Elector>();
        }

        public int idVote { get; set; }
        public Nullable<int> candidateList_idList { get; set; }
        public Nullable<int> fkelec { get; set; }
        public Nullable<int> observerc_idObserver { get; set; }
        public Nullable<int> session_idSession { get; set; }
        public virtual t_Elector t_Elector { get; set; }
        public virtual t_Observer t_Observer { get; set; }
        public virtual t_condidatelist t_condidatelist { get; set; }
        public virtual t_Session t_Session { get; set; }
        public virtual ICollection<t_Elector> t_Elector1 { get; set; }
    }
}
