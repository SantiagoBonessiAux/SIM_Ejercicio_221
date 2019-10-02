using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SIM_Ejercicio_221
{
    public class Simulacion
    {

        /// <summary>
        /// Retorna el proximo evento en base al reloj.        
        /// /// </summary>
        /// <param name="proxLlegColectivo"></param>
        /// <param name="proxLlegPasajero"></param>
        /// <returns></returns>
        public ArrayList devolverProximoEvento(double proxLlegColectivo, double proxLlegPasajero, double proxFinAscensoPasajero, double proxInterrupcion)
        {
            ArrayList listaEventoTiempo = new ArrayList(2);

            List<Double> listaTiempos = new List<Double>();
            List<String> listaEventos = new List<String>();

            if (proxLlegColectivo > 0)
            {
                listaTiempos.Add(proxLlegColectivo);
                listaEventos.Add("Llegada Colectivo");
            }

            if (proxLlegPasajero > 0)
            {
                listaTiempos.Add(proxLlegPasajero);
                listaEventos.Add("Llegada Pasajero");
            }

            if(proxFinAscensoPasajero > 0)
            {
                listaTiempos.Add(proxFinAscensoPasajero);
                listaEventos.Add("Fin Ascenso Pasajero");
            }

            if (proxInterrupcion > 0)
            {
                listaTiempos.Add(proxInterrupcion);
                listaEventos.Add("Interrupcion Espera Pasajero");
            }

            //Tomamos el menor de los tiempos asi obtenemos el tiempo del próximo evento
            Double menorTiempo = listaTiempos.Min();
            //Tomamos el index del evento próximo
            int indiceMayor = listaTiempos.IndexOf(menorTiempo);

            // Para tomar el evento próximo tomamos el indice del próximo evento y lo asignamos a la variable evento
            string evento = listaEventos[indiceMayor].ToString();
            // Agregamos al ArrayList el evento próximo y cuando se producirá
            listaEventoTiempo.Add(evento);
            listaEventoTiempo.Add(menorTiempo);

            return listaEventoTiempo;
        }

        /// <summary>
        /// Tiempo llegada colectivos, distribucion exponencial.
        /// Donde promedio = 1/lambda
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="tpoPromedio"></param>
        /// <returns></returns>
        public double getTiempoLlegadaColectivo(double rnd, double tpoPromedio)
        {
            return Math.Round((-(tpoPromedio) * Math.Log(1-rnd)), 2);
        }

        /// <summary>
        /// Tiempo llegada pasajeros, distribucion exponencial.
        /// Donde promedio = 1/lambda
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="tpoPromedio"></param>
        /// <returns></returns>
        public double getTiempoLlegadaPasajero(double rnd, double tpoPromedio)
        {
            return Math.Round((-(tpoPromedio) * Math.Log(1-rnd)), 2); 
        }

    }
}
