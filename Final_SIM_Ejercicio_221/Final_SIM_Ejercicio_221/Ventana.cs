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

            DataGridViewTextBoxColumn EstadoParada = new DataGridViewTextBoxColumn();
            EstadoParada.Name = "estadoParada";
            EstadoParada.HeaderText = "Estado Parada";
            EstadoParada.ReadOnly = true;
            EstadoParada.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(EstadoParada);

            DataGridViewTextBoxColumn ColaParada = new DataGridViewTextBoxColumn();
            ColaParada.Name = "colaParada";
            ColaParada.HeaderText = "Cola Parada";
            ColaParada.ReadOnly = true;
            ColaParada.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(ColaParada);

            DataGridViewTextBoxColumn MaxColaParada = new DataGridViewTextBoxColumn();
            MaxColaParada.Name = "maxColaParada";
            MaxColaParada.HeaderText = "Max Cola Parada";
            MaxColaParada.ReadOnly = true;
            MaxColaParada.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(MaxColaParada);

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

            DataGridViewTextBoxColumn TotalColectCola = new DataGridViewTextBoxColumn();
            TotalColectCola.Name = "totaColectCola";
            TotalColectCola.HeaderText = "Tot Colect Cola";
            TotalColectCola.ReadOnly = true;
            TotalColectCola.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(TotalColectCola);

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

            var watch = System.Diagnostics.Stopwatch.StartNew(); // que hace

            //Variables de pantalla
            int horasSim = int.Parse(txtHorasSim.Text);
            Double tiempoFinal = horasSim * 60;
            int ultimasHoras = int.Parse(txtUltHoras.Text);
            Double ultimosMinutos = ultimasHoras * 60;

            double promLlegColectivos = double.Parse(this.txtTpoLlegColectivos.Text);
            Int64 capacidadMaximaColectivo = Int64.Parse(this.txtCapacidadColectivos.Text);
            double promLlegPasajeros = Math.Round(double.Parse(this.txtTpoLLegPasajeros.Text)/60, 2);
            double tpoAscensoPasajeros = Math.Round(double.Parse(this.txtTpoSubirPasajero.Text)/60, 2);
            double tpoEsperaMaximaPasajeros = double.Parse(this.txtTpoEsperaMaximaPasajeros.Text);

            bool banderaSubiendoPasajero = false;            

            Random rnd = new Random();
            Simulacion sim = new Simulacion();
            VectorEstado ve = new VectorEstado();

            List<Pasajero> listaPasajeros = new List<Pasajero>();
            List<Colectivo> listaColectivos = new List<Colectivo>();

            int nroPasajero = 0;
            int nroColectivo = 0;
            int i = 0;

            while (ve.reloj <= tiempoFinal)
            {
                ve.fila = i;

                if(i == 0)
                {
                    ve.evento = "INICIO";
                    ve.reloj = 0;

                    ve.rndLlegColectivo = Math.Round(rnd.NextDouble(), 2);
                    ve.tpoLlegColectivo = sim.getTiempoLlegadaColectivo(ve.rndLlegColectivo, promLlegColectivos);
                    ve.proxLlegColectivo = ve.reloj + ve.tpoLlegColectivo;

                    ve.rndLlegPasajero = Math.Round(rnd.NextDouble(), 2);
                    ve.tpoLlegPasajero = sim.getTiempoLlegadaPasajero(ve.rndLlegPasajero, promLlegPasajeros);
                    ve.proxLlegPasajero = ve.reloj + ve.tpoLlegPasajero;

                    ve.estadoParada = "LIBRE";
                }
                else
                {
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
                    
                    ArrayList EventoTiempo = sim.devolverProximoEvento(ve.proxLlegColectivo, ve.proxLlegPasajero, ve.proxFinAscensoPasajero, tiempoMaxEspera);
                    ve.evento = EventoTiempo[0].ToString();

                    switch (EventoTiempo[0].ToString())
                    {
                        case "Llegada Colectivo":
                            ve.evento = "Llegada Colectivo";
                            ve.reloj = ve.proxLlegColectivo;

                            Colectivo colect = new Colectivo();

                            ve.rndLlegColectivo = Math.Round(rnd.NextDouble(), 2);
                            ve.tpoLlegColectivo = sim.getTiempoLlegadaColectivo(ve.rndLlegColectivo, promLlegColectivos);
                            ve.proxLlegColectivo = ve.reloj + ve.tpoLlegColectivo;

                            //datos colectivo
                            nroColectivo++;
                            colect.ID = nroColectivo;
                            colect.estado = "ESPERANDO EN COLA"; // Estado por defecto

                            //SI HAY PASAJEROS ESPERANDO EMPIEZA A CARGAR
                            if (ve.colaParada > 0)
                            {
                                ve.estadoParada = "CARGANDO";
                                ve.proxFinAscensoPasajero = ve.reloj + tpoAscensoPasajeros; //proximo fin ascenso pasajero 
                                banderaSubiendoPasajero = true;
                            }
                            else //SI NO HAY PASAJEROS ESERANDO SE VA SIN SUBIR PASAJEROS
                            {
                                ve.cantColectSinSubirPasaj++;
                            }
                            

                            break;
                        case "Llegada Pasajero":
                            ve.evento = "Llegada Pasajero";
                            ve.reloj = ve.proxLlegPasajero;

                            Pasajero pasaj = new Pasajero();                            

                            ve.rndLlegPasajero = Math.Round(rnd.NextDouble(), 2);
                            ve.tpoLlegPasajero = sim.getTiempoLlegadaPasajero(ve.rndLlegPasajero, promLlegPasajeros);
                            ve.proxLlegPasajero = ve.reloj + ve.tpoLlegPasajero;

                            // datos pasajero
                            nroPasajero++;
                            pasaj.ID = nroPasajero;
                            pasaj.estado = "Esperando en parada"; //por defecto el estado es "Esperando en parada"
                            pasaj.ingresoSistema = ve.reloj;
                            pasaj.salidaSistema = ve.reloj + tpoEsperaMaximaPasajeros;

                            listaPasajeros.Add(pasaj);

                            ve.colaParada++;

                            if (ve.colaParada == 0)
                            {
                                ve.estadoParada = "OCUPADA"; // la parada tiene pasajeros
                            }

                            if (ve.maxColaParada < ve.colaParada)
                            {
                                ve.maxColaParada = ve.colaParada; //maxima cantidad de personas en parada de colectivo
                            }

                           
                            break;

                        case "Fin Ascenso Pasajero":
                            ve.evento = "Fin Ascenso Pasajero";
                            ve.reloj = ve.proxFinAscensoPasajero;
                            ve.colaParada--;
                            capacidadMaximaColectivo--;
                            ve.cantPasajerosSubidos++;

                            
                            //TO DO: FALTA CONTROLAR CAPACIDAD MAXIMA DE COLECTIVOS.
                            if (capacidadMaximaColectivo == 0 && ve.colaParada == 0)
                            {
                                ve.estadoParada = "Libre"; //no hay pasajeros
                                ve.colaColectivos = 0; //cuando se llena el colectivo y no hay nadie mas en parada, se retiran todos los colectivos que hay en cola parada

                                foreach (var c in listaColectivos)
                                {
                                    if (c.estado == "ESPERANDO EN COLA")
                                    {
                                        c.estado = "RETIRADO";
                                    }
                                }

                            }
                            //SI SIGUEN PASAJEROS ESPERANDO; VUELVE A CALCULAR EL PROXIMO ASCENSO, SINO SE VA EL COLECTIVO
                            if (ve.colaParada > 0)
                            {
                                ve.proxFinAscensoPasajero = ve.reloj + tpoAscensoPasajeros;
                            }
                            else if(ve.colaParada == 0)
                            {
                                ve.estadoParada = "LIBRE";
                                ve.proxSalidaColectivo = ve.reloj;
                                ve.proxFinAscensoPasajero = 0;
                            }
                            break;
                        case "Salida Colectivo":

                            ve.evento = "Salida Colectivo";
                            ve.reloj = ve.proxSalidaColectivo;

                            break;
                        case "Interrupcion Espera Pasajero":
                            ve.evento = "Interrupcion Espera Pasajero";
                            
                            
                            break;
                        default:
                            break;

                    }



              }




                double auxUltMin = tiempoFinal - ultimosMinutos;
                //if (ve.reloj >= auxUltMin)
                //{
                    dgvDatos.Rows.Add(
                    ve.evento, ve.reloj, 
                    //Legada colectivos
                    ve.rndLlegColectivo, ve.tpoLlegColectivo, ve.proxLlegColectivo,
                    //Llegada pasajeros
                    ve.rndLlegPasajero, ve.tpoLlegPasajero, ve.proxLlegPasajero,
                    //Ascenso pasajeros y fin ascenso, donde fin ascenso inicia salida de colectivo
                    ve.tpoAscensoPasajero, ve.proxFinAscensoPasajero, 
                    //Estado de la parada, Cola de pasajeros, y max cola de pasajeros en la parada
                    ve.estadoParada, ve.colaParada, ve.maxColaParada,
                    //Cantidad pasajeros que se van 
                    ve.cantPasajerosRetirados, 
                    //Cola de colectivos en la parada
                    ve.colaColectivos, ve.totColectCola,
                    //Cantidad pasajeros que se van por interrupcion
                    ve.cantColectSinSubirPasaj, ve.porcColectSinSubirPasaj
                    
                    );

                //}

                //TO DO: PRUEBAS INICIALES
                if ( i == 15 )
                {
                    break;
                }

                i++;
            }// fin del while

        }// fin btnSimular



    }
}
