using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Agent
    {
        public int idAgent { get; set; }
        public string name { get; set; }
        public int numCin { get; set; }
        public Nullable<int> observer_idObserver { get; set; }
        public virtual t_Observer t_Observer { get; set; }
    }
}
