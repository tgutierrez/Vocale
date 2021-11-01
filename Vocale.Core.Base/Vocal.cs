using System;

namespace Vocale.Core.Base{
    public class Vocal {
        public string Rut{ get;set;}
        public string Nombre{get;set;}
        public Rol Rol {get;set;}
    }

    public enum Rol{
        Presidente,
        Comisario,
        Vocal
    }
}