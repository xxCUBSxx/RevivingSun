﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class PlusUser : AbstractMessage
    {
        public override string _Name { get => "+usr"; }

        public string I { get; set; }
        public string N { get; set; }
        public string M { get; set; }
        public string F { get; set; } = "H";
        public string A { get; set; }
        public string P { get; set; }
        public string S { get; set; } = "";
        public string X { get; set; }
        public string G { get; set; }
        public string T { get; set; } = "2";
    }
}
