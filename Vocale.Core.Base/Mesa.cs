using System;
using System.Collections;
using System.Collections.Generic;

namespace Vocale.Core.Base {
    public class Mesa {
        public int Numero {get;set;}
        public Constitucion Estado {get;set;}
        public IList<Vocal> Vocales => new List<Vocal>();
    }

    public class Constitucion{
        public Estado Estado{get;set;}
        public DateTime Actualizacion{get;set;}
    }


    public enum Estado {
        NoConstituida,
        Constituida,
        Abierta,
        Cerrada
    }
}