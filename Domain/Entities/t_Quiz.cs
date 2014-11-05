using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Quiz
    {
        public t_Quiz()
        {
            this.t_RestredUser = new List<t_RestredUser>();
        }

        public int idQuiz { get; set; }
        public string answer { get; set; }
        public string question { get; set; }
        public virtual ICollection<t_RestredUser> t_RestredUser { get; set; }
    }
}
