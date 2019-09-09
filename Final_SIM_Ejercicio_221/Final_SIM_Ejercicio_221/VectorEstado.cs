using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SIM_Ejercicio_221
{
    public class VectorEstado
    {
        public Int64 fila { get; set; }
        public string evento { get; set; }
        public double reloj { get; set; }

        //Llegada Colectivos
        public double rndLlegColectivo { get; set; }
        public double tpoLlegColectivo { get; set; }
        public double proxLlegColectivo { get; set; }

        //Llegada Pasajeros
        public double rndLlegPasajero { get; set; }
        public double tpoLlegPasajero { get; set; }
        public double proxLlegPasajero { get; set; }

        public double tpoAscensoPasajero { get; set; }
        public double finAscensoPasajero { get; set; }

        public Int64 colaParada { get; set; }
        public Int64 maxColaParada { get; set; }
        public Int64 cantPasajerosRetirados { get; set;}
        public Int64 colaColectivos { get; set; }
        public Int64 totColectCola { get; set; }
        public Int64 cantColectSinSubirPasaj { get; set; } 
        public double porcColectSinSubirPasaj { get; set; }

        public VectorEstado()
        {
            this.evento = evento;
            this.reloj = reloj;

            this.rndLlegColectivo = rndLlegColectivo;
            this.tpoLlegColectivo = tpoLlegColectivo;
            this.proxLlegColectivo = proxLlegColectivo;

            this.rndLlegPasajero = rndLlegPasajero;
            this.tpoLlegPasajero = tpoLlegPasajero;
            this.proxLlegPasajero = proxLlegPasajero;

            this.tpoAscensoPasajero = tpoAscensoPasajero;
            this.finAscensoPasajero = finAscensoPasajero;

            this.colaParada = colaParada;
            this.maxColaParada = maxColaParada;

            this.cantPasajerosRetirados = cantPasajerosRetirados;

            this.colaColectivos = colaColectivos;
            this.totColectCola = totColectCola;
            this.cantColectSinSubirPasaj = cantColectSinSubirPasaj;
            this.porcColectSinSubirPasaj = porcColectSinSubirPasaj;
        }


    }
    
}
