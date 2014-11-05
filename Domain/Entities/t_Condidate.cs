using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Condidate
    {
        public int idCandidate { get; set; }
        public string adresse { get; set; }
        public int dateOfBirth { get; set; }
        public string email { get; set; }
        public string fatherName { get; set; }
        public int fatherNumCin { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string motherName { get; set; }
        public int motherNumCin { get; set; }
        public int numCin { get; set; }
        public string occupation { get; set; }
        public int tel { get; set; }
        public Nullable<int> candidates_idList { get; set; }
        public virtual t_condidatelist t_condidatelist { get; set; }
    }
}
