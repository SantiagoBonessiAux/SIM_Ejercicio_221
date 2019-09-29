using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_SIM_Ejercicio_221
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
            IncializarColumnas();
        }

        public void IncializarColumnas()
        {
            DataGridViewTextBoxColumn Evento = new DataGridViewTextBoxColumn();
            Evento.Name = "evento";
            Evento.HeaderText = "Evento";
            Evento.ReadOnly = true;
            Evento.Width = 120;
            Evento.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(Evento);

            DataGridViewTextBoxColumn Reloj = new DataGridViewTextBoxColumn();
            Reloj.Name = "reloj";
            Reloj.HeaderText = "Reloj";
            Reloj.ReadOnly = true;
            Reloj.Width = 105;
            Reloj.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(Reloj);

            //LLEGADA COLECTIVO
            DataGridViewTextBoxColumn RndLlegColectivo = new DataGridViewTextBoxColumn();
            RndLlegColectivo.Name = "rndLlegColectivo";
            RndLlegColectivo.HeaderText = "RND";
            RndLlegColectivo.ReadOnly = true;
            RndLlegColectivo.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(RndLlegColectivo);

            DataGridViewTextBoxColumn TpoLlegColectivo = new DataGridViewTextBoxColumn();
            TpoLlegColectivo.Name = "tpoLlegColectivo";
            TpoLlegColectivo.HeaderText = "Tpo LLeg Colectivo";
            TpoLlegColectivo.ReadOnly = true;
            TpoLlegColectivo.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(TpoLlegColectivo);

            DataGridViewTextBoxColumn ProxLlegColectivo = new DataGridViewTextBoxColumn();
            ProxLlegColectivo.Name = "proxLlegColectivo";
            ProxLlegColectivo.HeaderText = "Prox LLeg Colectivo";
            ProxLlegColectivo.ReadOnly = true;
            ProxLlegColectivo.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(ProxLlegColectivo);
            
            //LLEGADA PASAJEROS
            DataGridViewTextBoxColumn RndLlegPasajero = new DataGridViewTextBoxColumn();
            RndLlegPasajero.Name = "rndLlegPasajero";
            RndLlegPasajero.HeaderText = "RND";
            RndLlegPasajero.ReadOnly = true;
            RndLlegPasajero.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(RndLlegPasajero);

            DataGridViewTextBoxColumn TpoLlegPasajero = new DataGridViewTextBoxColumn();
            TpoLlegPasajero.Name = "tpoLlegPasajero";
            TpoLlegPasajero.HeaderText = "Tpo LLeg Pasajero";
            TpoLlegPasajero.ReadOnly = true;
            TpoLlegPasajero.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(TpoLlegPasajero);

            DataGridViewTextBoxColumn ProxLlegPasajero = new DataGridViewTextBoxColumn();
            ProxLlegPasajero.Name = "proxLlegPasajero";
            ProxLlegPasajero.HeaderText = "Prox LLeg Pasajero";
            ProxLlegPasajero.ReadOnly = true;
            ProxLlegPasajero.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(ProxLlegPasajero);

            DataGridViewTextBoxColumn TpoAscensoPasajero = new DataGridViewTextBoxColumn();
            TpoAscensoPasajero.Name = "tpoAscensoPasajero";
            TpoAscensoPasajero.HeaderText = "Tpo Ascen Pasajero";
            TpoAscensoPasajero.ReadOnly = true;
            TpoAscensoPasajero.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(TpoAscensoPasajero);

            DataGridViewTextBoxColumn ProxFinAscensoPasajero = new DataGridViewTextBoxColumn();
            ProxFinAscensoPasajero.Name = "proxFinAscensoPasajero";
            ProxFinAscensoPasajero.HeaderText = "Prox Fin Ascen Pasajero";
            ProxFinAscensoPasajero.ReadOnly = true;
            TpoAscensoPasajero.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(ProxFinAscensoPasajero);

            DataGridViewTextBoxColumn ColaParada = new DataGridViewTextBoxColumn();
            ColaParada.Name = "colaParada";
            ColaParada.HeaderText = "Cola Parada";
            ColaParada.ReadOnly = true;
            ColaParada.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(ColaParada);

            DataGridViewTextBoxColumn EstadoParada = new DataGridViewTextBoxColumn();
            EstadoParada.Name = "estadoParada";
            EstadoParada.HeaderText = "Estado Parada";
            EstadoParada.ReadOnly = true;
            EstadoParada.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(EstadoParada);

            DataGridViewTextBoxColumn CapacidadCargaColect = new DataGridViewTextBoxColumn();
            CapacidadCargaColect.Name = "capacidadColectivo";
            CapacidadCargaColect.HeaderText = "Capacida Colectivo";
            CapacidadCargaColect.ReadOnly = true;
            CapacidadCargaColect.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(CapacidadCargaColect);

            DataGridViewTextBoxColumn MaxColaParada = new DataGridViewTextBoxColumn();
            MaxColaParada.Name = "maxColaParada";
            MaxColaParada.HeaderText = "Max Cola Parada";
            MaxColaParada.ReadOnly = true;
            MaxColaParada.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(MaxColaParada);

            DataGridViewTextBoxColumn CantPasajerosTransportados = new DataGridViewTextBoxColumn();
            CantPasajerosTransportados.Name = "cantPasajerosTransportados";
            CantPasajerosTransportados.HeaderText = "Cant Pasajeros Transportados";
            CantPasajerosTransportados.ReadOnly = true;
            CantPasajerosTransportados.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(CantPasajerosTransportados);

            DataGridViewTextBoxColumn CantPasajerosRetirados = new DataGridViewTextBoxColumn();
            CantPasajerosRetirados.Name = "cantPasajerosRetirados";
            CantPasajerosRetirados.HeaderText = "Cant Pasajeros Retirados";
            CantPasajerosRetirados.ReadOnly = true;
            CantPasajerosRetirados.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(CantPasajerosRetirados);

            DataGridViewTextBoxColumn ColaColectivos = new DataGridViewTextBoxColumn();
            ColaColectivos.Name = "colaColectivos";
            ColaColectivos.HeaderText = "Cola Colect";
            ColaColectivos.ReadOnly = true;
            ColaColectivos.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(ColaColectivos);

            DataGridViewTextBoxColumn TotalColectQuePasan = new DataGridViewTextBoxColumn();
            TotalColectQuePasan.Name = "totaColectQuePasan";
            TotalColectQuePasan.HeaderText = "Tot Colect Que Pasan";
            TotalColectQuePasan.ReadOnly = true;
            TotalColectQuePasan.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(TotalColectQuePasan);

            DataGridViewTextBoxColumn CantColectSinSubirPasaj = new DataGridViewTextBoxColumn();
            CantColectSinSubirPasaj.Name = "cantColectSinSubirPasaje";
            CantColectSinSubirPasaj.HeaderText = "Tot Colect Sin Subir Pasaj";
            CantColectSinSubirPasaj.ReadOnly = true;
            CantColectSinSubirPasaj.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(CantColectSinSubirPasaj);

            DataGridViewTextBoxColumn PorcColectSinSubirPasaj = new DataGridViewTextBoxColumn();
            PorcColectSinSubirPasaj.Name = "porcColectSinSubirPasaje";
            PorcColectSinSubirPasaj.HeaderText = "Porc Colect Sin Subir Pasaj";
            PorcColectSinSubirPasaj.ReadOnly = true;
            PorcColectSinSubirPasaj.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(PorcColectSinSubirPasaj);

            dgvDatos.Columns["reloj"].DefaultCellStyle.BackColor = Color.LightBlue;

            dgvDatos.Columns["proxLlegColectivo"].DefaultCellStyle.BackColor = Color.LightBlue;

            dgvDatos.Columns["proxLlegPasajero"].DefaultCellStyle.BackColor = Color.LightBlue;
            
            dgvDatos.Columns["proxFinAscensoPasajero"].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();
            dgvDatos.Refresh();
            IncializarColumnas();

            var watch = System.Diagnostics.Stopwatch.StartNew();

            //Variables de pantalla
            int horasSim = int.Parse(txtHorasSim.Text);
            Double tiempoFinal = horasSim * 60;
            int ultimasHoras = int.Parse(txtUltHoras.Text);
            Double ultimosMinutos = ultimasHoras * 60;

            double promLlegColectivos = double.Parse(this.txtTpoLlegColectivos.Text);
            Int64 capacidadMaximaColectivo = Int64.Parse(this.txtCapacidadColectivos.Text);
            double promLlegPasajeros = Math.Round(double.Parse(this.txtTpoLLegPasajeros.Text)/60, 2); // tiempo llegada pasajeros a minutos
            double tpoAscensoPasajeros = Math.Round(double.Parse(this.txtTpoSubirPasajero.Text)/60, 2); //tiempo ascenso pasajeros a minutos
            double tpoEsperaMaximaPasajeros = double.Parse(this.txtTpoEsperaMaximaPasajeros.Text);
            bool mostarPasajColect = this.chPasajColect.Checked;


            Random rnd = new Random();
            Simulacion sim = new Simulacion();
            VectorEstado ve = new VectorEstado();

            List<Pasajero> listaPasajeros = new List<Pasajero>();
            List<Colectivo> listaColectivos = new List<Colectivo>();

            int nroPasajero = 0;
            int nroColectivo = 0;
            int i = 0;

            /**
            ESTADOS PARADA: LIBRE, OCUPADA, CARGANDO
            ESTADOS PASAJERO: ESPERANDO, SUBIENDO, 
            ESTADOS COLECTIVO: CARGANDO
            */

            while (ve.reloj <= tiempoFinal)
            {
                ve.fila = i;

                if(i == 0)
                {
                    //EVENTO INICIAL DE LA SIMULACION
                    ve.evento = "INICIO";
                    ve.reloj = 0;

                    ve.rndLlegColectivo = Math.Round(rnd.NextDouble(), 2);
                    ve.tpoLlegColectivo = sim.getTiempoLlegadaColectivo(ve.rndLlegColectivo, promLlegColectivos);
                    ve.proxLlegColectivo = Math.Round(ve.reloj + ve.tpoLlegColectivo, 2);

                    ve.rndLlegPasajero = Math.Round(rnd.NextDouble(), 2);
                    ve.tpoLlegPasajero = sim.getTiempoLlegadaPasajero(ve.rndLlegPasajero, promLlegPasajeros);
                    ve.proxLlegPasajero = Math.Round(ve.reloj + ve.tpoLlegPasajero, 2);

                    ve.estadoParada = "LIBRE";
                }
                else
                {
                    //SIGUIENTES EVENTOS DE LA SIMULACION

                    double tiempoMaxEspera = 0;

                    foreach (var p in listaPasajeros)
                    {
                        if (p.estado == "Esperando en Parada" && p.salidaSistema > tiempoMaxEspera)
                        {
                            tiempoMaxEspera = p.salidaSistema;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    ArrayList EventoTiempo = sim.devolverProximoEvento(ve.proxLlegColectivo, ve.proxLlegPasajero, ve.proxFinAscensoPasajero);
                    ve.evento = EventoTiempo[0].ToString();

                    switch (EventoTiempo[0].ToString())
                    {
                        case "Llegada Colectivo":
                            ve.evento = "Llegada Colectivo";
                            ve.reloj = ve.proxLlegColectivo;

                            ve.rndLlegColectivo = Math.Round((Convert.ToDouble(rnd.Next(0, 99)) / 100), 2);
                            ve.tpoLlegColectivo = sim.getTiempoLlegadaColectivo(ve.rndLlegColectivo, promLlegColectivos);
                            ve.proxLlegColectivo = Math.Round(ve.reloj + ve.tpoLlegColectivo, 2);

                            //DATOS COLECTIVO
                            Colectivo colect = new Colectivo();
                            nroColectivo++;
                            colect.ID = nroColectivo;
                            colect.estado = "ESPERANDO EN COLA"; // Estado por defecto

                            listaColectivos.Add(colect);

                            //SI HAY PASAJEROS ESPERANDO Y NO HAY COLECTIVOS EMPIEZA A CARGAR 
                            if (ve.colaParada > 0 && ve.estadoParada != "CARGANDO")
                            {

                                colect.estado = "CARGANDO PASAJEROS";

                                ve.capacidadCargaColect = capacidadMaximaColectivo;
                                ve.estadoParada = "CARGANDO";
                                ve.tpoAscensoPasajero = tpoAscensoPasajeros;
                                ve.proxFinAscensoPasajero = Math.Round(ve.reloj + ve.tpoAscensoPasajero, 2); //proximo fin ascenso pasajero 
                            }
                            else if(ve.estadoParada == "CARGANDO")
                            {
                                ve.colaColectivos++;
                            }
                            else if(ve.colaParada == 0 && ve.estadoParada == "LIBRE") //SI NO HAY PASAJEROS ESERANDO SE VA SIN SUBIR PASAJEROS
                            {
                                ve.totColectQuePasan++;
                                ve.totColectQuePasanSinSubirPasaj++;
                            }

                            break;
                        case "Llegada Pasajero":
                            ve.evento = "Llegada Pasajero";
                            ve.reloj = ve.proxLlegPasajero;

                            ve.rndLlegPasajero = Math.Round((Convert.ToDouble(rnd.Next(0, 99)) / 100), 2);
                            ve.tpoLlegPasajero = sim.getTiempoLlegadaPasajero(ve.rndLlegPasajero, promLlegPasajeros);
                            ve.proxLlegPasajero = Math.Round(ve.reloj + ve.tpoLlegPasajero, 2);

                            ve.colaParada++;

                            if (ve.estadoParada == "CARGANDO")
                            {
                                //SI LA PARADA ESTA CARGANDO; VA A SEGUIR CARGANDO PASAJEROS AL COLECTIVO
                            }
                            else
                            {
                                //SI LA PARADA ESTA LIBRE U OCUPADA, PASA O SIGUE OCUPADA
                                ve.estadoParada = "OCUPADA"; // la parada tiene pasajeros
                            }

                            //CALCULO DE LA COLA MAX EN LA PARADA
                            if (ve.maxColaParada < ve.colaParada)
                            {
                                ve.maxColaParada = ve.colaParada; //maxima cantidad de personas en parada de colectivo
                            }

                            //DATOS PASAJERO
                            Pasajero pasaj = new Pasajero();
                            // datos pasajero
                            nroPasajero++;
                            pasaj.ID = nroPasajero;
                            pasaj.estado = "Esperando en parada"; //por defecto el estado es "Esperando en parada"
                            pasaj.ingresoSistema = ve.reloj;
                            // pasaj.salidaSistema = ve.reloj + tpoEsperaMaximaPasajeros; // no sabemos la salida hasta que se vaya

                            //TODO: AGREGAR DATOS PASAJERO A LA GRID VIEW
                            if (mostarPasajColect)
                            {

                            }

                            listaPasajeros.Add(pasaj);
                            
                            break;

                        case "Fin Ascenso Pasajero":

                            ve.evento = "Fin Ascenso Pasajero";
                            ve.reloj = ve.proxFinAscensoPasajero;

                            ve.colaParada--;
                            ve.capacidadCargaColect--;

                            //if (ve.capacidadCargaColect == 0 && ve.colaParada == 0)
                            //{
                            //    ve.totColectQuePasan = ve.totColectQuePasan + ve.colaColectivos; // ya sean los colectivos que se retiran porque no hay mas personas en parada para cargar, como los colectivos que no suben a nadie
                            //    ve.estadoParada = "Libre"; //no hay pasajeros
                            //    ve.colaColectivos = 0; //cuando se llena el colectivo y no hay nadie mas en parada, se retiran todos los colectivos que hay en cola parada

                            //    // TODO calcular la cantidad de colectivos que se retiran sin subir pasajeros

                            //    foreach (var c in listaColectivos)
                            //    {
                            //        if (c.estado == "ESPERANDO EN COLA")
                            //        {
                            //            c.estado = "RETIRADO";
                            //        }
                            //    }
                            //}

                            //SI SIGUEN PASAJEROS ESPERANDO; VUELVE A CALCULAR EL PROXIMO ASCENSO, SINO SE VA EL COLECTIVO
                            if (ve.colaParada > 0 && ve.capacidadCargaColect > 0)
                            {
                                ve.tpoAscensoPasajero = tpoAscensoPasajeros;
                                ve.proxFinAscensoPasajero = Math.Round(ve.reloj + ve.tpoAscensoPasajero, 2);

                            }
                            else if (ve.colaParada > 0 && ve.capacidadCargaColect == 0 && ve.colaColectivos > 0)
                            {
                                ve.tpoAscensoPasajero = tpoAscensoPasajeros;
                                ve.proxFinAscensoPasajero = Math.Round(ve.reloj + ve.tpoAscensoPasajero, 2);

                                ve.colaColectivos--;
                                ve.totColectQuePasan++;

                                ve.capacidadCargaColect = capacidadMaximaColectivo;
                            }
                            else if (ve.colaParada > 0 && ve.capacidadCargaColect == 0 && ve.colaColectivos == 0)
                            {
                                ve.estadoParada = "OCUPADA";
                                ve.tpoAscensoPasajero = 0;
                                ve.proxFinAscensoPasajero = 0;

                                ve.cantPasajerosTransportados += capacidadMaximaColectivo;

                            }
                            else if(ve.colaParada == 0 && ve.capacidadCargaColect > 0)
                            {
                                //SUBIO A TODOS LOS PASAJEROS; Y EL COLECTIVO SE VA CARGADO
                                ve.estadoParada = "LIBRE";
                                ve.tpoAscensoPasajero = 0;
                                ve.proxFinAscensoPasajero = 0;
                                
                                ve.cantPasajerosTransportados += (capacidadMaximaColectivo - ve.capacidadCargaColect);
                                
                                //SE VUELVE A CERO LA CAPACIDAD DE CARGA HASTA NUEVO COLECTIVO
                                ve.capacidadCargaColect = 0;

                                ve.totColectQuePasan++; //SE AGREGA UN COLECTIVO A LOS QUE PASAN

                                if (ve.colaColectivos > 0)
                                {
                                    ve.totColectQuePasanSinSubirPasaj += ve.colaColectivos;
                                    ve.totColectQuePasan += ve.colaColectivos;

                                    ve.colaColectivos = 0;
                                }
                            }
                            break;
                        case "Interrupcion Espera Pasajero":
                            ve.evento = "Interrupcion Espera Pasajero";
                            
                            
                            break;
                        default:
                            break;

                    }

              }




                double auxUltMin = tiempoFinal - ultimosMinutos;
                if (ve.reloj >= auxUltMin)
                {
                    dgvDatos.Rows.Add(
                    ve.evento, ve.reloj, 
                    //Legada colectivos
                    ve.rndLlegColectivo, ve.tpoLlegColectivo, ve.proxLlegColectivo,
                    //Llegada pasajeros
                    ve.rndLlegPasajero, ve.tpoLlegPasajero, ve.proxLlegPasajero,
                    //Ascenso pasajeros y fin ascenso, donde fin ascenso inicia salida de colectivo
                    ve.tpoAscensoPasajero, ve.proxFinAscensoPasajero, 
                    //Estado de la parada, Cola de pasajeros, y max cola de pasajeros en la parada
                    ve.colaParada, ve.estadoParada, ve.capacidadCargaColect, ve.maxColaParada,
                    //Cantidad pasajeros que se van 
                    ve.cantPasajerosTransportados, ve.cantPasajerosRetirados, 
                    //Cola de colectivos en la parada
                    ve.colaColectivos, ve.totColectQuePasan,
                    //Cantidad pasajeros que se van por interrupcion
                    ve.totColectQuePasanSinSubirPasaj, ve.porcColectSinSubirPasaj
                    
                    );

                }

                i++;
            }// fin del while


            //CALULO DE RESULTADOS
            this.txtRdoCantPasajEnSistema.Text = nroPasajero.ToString();
            this.txtRdoCantPasajTransp.Text = ve.cantPasajerosTransportados.ToString();
            this.txtRdoCantPasajRetirados.Text = ve.cantPasajerosRetirados.ToString();
            this.txtRdoColaMaxPasaj.Text = ve.maxColaParada.ToString();
            this.txtRdoPromEsperaPasaj.Text = "";

            this.txtRdoCantColectSistema.Text = "";
            this.txtRdoCantColectSinSubirPasaj.Text = "";
            this.txtRdoPorcColectSinSubirPasaj.Text = "";


            watch.Stop();
            this.txtTimeElapsed.Text = watch.Elapsed.ToString();

        }// fin btnSimular



    }
}
