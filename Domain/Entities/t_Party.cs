using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Party
    {
        public t_Party()
        {
            this.t_condidatelist = new List<t_condidatelist>();
            this.t_RestredUser = new List<t_RestredUser>();
        }

        public int idParty { get; set; }
        public string creatorMail { get; set; }
        public string description { get; set; }
        public string foundingMember { get; set; }
        public string name { get; set; }
        public string nbrAdhe { get; set; }
        public string news { get; set; }
        public string password { get; set; }
        public string politicalAffiliation { get; set; }
        public string valuess { get; set; }
        public virtual ICollection<t_condidatelist> t_condidatelist { get; set; }
        public virtual ICollection<t_RestredUser> t_RestredUser { get; set; }
    }
}
