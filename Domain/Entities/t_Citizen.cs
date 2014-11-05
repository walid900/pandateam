using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class t_Citizen
    {
        public int idCitizen { get; set; }
        public int isnotBankrupt { get; set; }
        public int isnotCriminal { get; set; }
        public int isnotDead { get; set; }
        public int isnotMentalRetarded { get; set; }
        public int isnotMilitary { get; set; }
        public int numCin { get; set; }
    }
}
