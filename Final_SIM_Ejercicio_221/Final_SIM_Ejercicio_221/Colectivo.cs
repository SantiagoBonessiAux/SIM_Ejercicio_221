using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SIM_Ejercicio_221
{
    public class Colectivo
    {
        public Int64 ID { get; set; }

        public string estado { get; set; }

        public double ingresoSistema { get; set; }

        public double salidaSistema { get; set; }

        public Colectivo()
        {
            this.ID = ID;
            this.estado = estado;
            this.ingresoSistema = ingresoSistema;
            this.salidaSistema = salidaSistema;
        }
    }
}
