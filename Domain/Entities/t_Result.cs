using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Result
    {
        public int idResult { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string result { get; set; }
    }
}
