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

        //Fin Ascenso Pasajeros
        public double tpoAscensoPasajero { get; set; }
        public double proxFinAscensoPasajero { get; set; }

        //Servidor Parada 
        public Int64 colaParada { get; set; }
        public string estadoParada { get; set; }
        public Int64 capacidadCargaColect { get; set; }
        public Int64 maxColaParada { get; set; }

        public Int64 cantPasajerosTransportados { get; set; }
        public Int64 cantPasajerosRetirados { get; set;}
        public Int64 colaColectivos { get; set; }

        public Int64 totColectQuePasan { get; set; }
        public Int64 totColectQuePasanSinSubirPasaj { get; set; } 

        public double porcColectSinSubirPasaj { get; set; }

        public double tpoAcuEsperaPasajerosCola { get; set; }
        public double tpoPromEsperaPasajerosCola { get; set; }

        //PROX INTERRUPCION
        public double proxInterrupcionPasajero { get; set; }

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
            this.proxFinAscensoPasajero = proxFinAscensoPasajero;

            this.estadoParada = estadoParada;
            this.capacidadCargaColect = capacidadCargaColect;
            this.colaParada = colaParada;
            this.maxColaParada = maxColaParada;

            this.cantPasajerosRetirados = cantPasajerosRetirados;

            this.colaColectivos = colaColectivos;

            this.totColectQuePasan = totColectQuePasan;
            this.totColectQuePasanSinSubirPasaj = totColectQuePasanSinSubirPasaj;

            this.porcColectSinSubirPasaj = porcColectSinSubirPasaj;

            this.proxInterrupcionPasajero = proxInterrupcionPasajero;

            this.tpoAcuEsperaPasajerosCola = tpoAcuEsperaPasajerosCola;
            this.tpoPromEsperaPasajerosCola = tpoPromEsperaPasajerosCola;
        }


    }
    
}
