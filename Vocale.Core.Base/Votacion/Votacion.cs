using System;
using System.Collections.Generic;
using System.Linq;
namespace Vocale.Core.Base.Votacion
{

    public class Resumen {
        public IDictionary<Cargo, IList<Candidato>> Votacion {get; private set;}

        public Resumen(){
            Votacion = new Dictionary<Cargo, IList<Candidato>>();
            Enum.GetValues<Cargo>().ToList().ForEach(c => Votacion.Add(c, new List<Candidato>()));           
        }
    }

    public class Candidato {

        public Cargo Cargo{get;set;}
        public string Nombre{get;set;}
        public int OrdenEnVoto{get;set;}

        public IList<Voto> Votos => new List<Voto>();

        public IDictionary<EmisionVoto, int> Resumen => GetResumen();

        private IDictionary<EmisionVoto, int> GetResumen(){
            return this.Votos.GroupBy(v => v.Estado)
                     .ToDictionary(vt => vt.Key, vt => vt.Count());
        }
    }


    public class Voto {
        public Guid Id {get;set;}
        public EmisionVoto Estado{get;set;}
        public DateTime EscrutadoEn{get;set;}
    }

    public enum Cargo {
        Presidente,
        Senador,
        Diputado,
        Core
    }    

    public enum EmisionVoto{
        Valido,
        Nulo,
        Objetado
    }
}