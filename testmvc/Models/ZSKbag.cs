using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testmvc.Models {
    public class ZSKbag {
        public int Ziegen { get; set; }
        public int Schafe { get; set; }
        public int Kuehe { get; set; }
        public int EUR { get; set; }
        public static string Ausgabe { get; set; } = "Sie erhalten EUR: ";


    }
}