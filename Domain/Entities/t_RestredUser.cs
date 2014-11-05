using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_RestredUser
    {
        public t_RestredUser()
        {
            this.t_Quiz = new List<t_Quiz>();
        }

        public int idUser { get; set; }
        public string mail { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public Nullable<int> party_idParty { get; set; }
        public virtual t_Party t_Party { get; set; }
        public virtual ICollection<t_Quiz> t_Quiz { get; set; }
    }
}
