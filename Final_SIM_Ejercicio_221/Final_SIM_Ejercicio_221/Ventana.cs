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

            DataGridViewTextBoxColumn FinAscensoPasajero = new DataGridViewTextBoxColumn();
            FinAscensoPasajero.Name = "finAscensoPasajero";
            FinAscensoPasajero.HeaderText = "Fin Ascen Pasajero";
            FinAscensoPasajero.ReadOnly = true;
            TpoAscensoPasajero.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDatos.Columns.Add(FinAscensoPasajero);

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
            double promLlegPasajeros = Math.Round(double.Parse(this.txtTpoLLegPasajeros.Text)/60, 2);
            double tpoAscensoPasajeros = Math.Round(double.Parse(this.txtTpoSubirPasajero.Text)/60, 2);
            double tpoEsperaMaximaPasajeros = double.Parse(this.txtTpoEsperaMaximaPasajeros.Text);

            int i = 0;

            Random rnd = new Random();
            Simulacion sim = new Simulacion();
            VectorEstado ve = new VectorEstado();

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

                }
                else
                {
                    ArrayList EventoTiempo = sim.devolverProximoEvento(ve.proxLlegColectivo, ve.proxLlegPasajero);
                    ve.evento = EventoTiempo[0].ToString();

                    switch (EventoTiempo[0].ToString())
                    {
                        case "Llegada Colectivo":
                            ve.evento = "Llegada Colectivo";
                            ve.reloj = ve.proxLlegColectivo;

                            ve.rndLlegColectivo = Math.Round(rnd.NextDouble(), 2);
                            ve.tpoLlegColectivo = sim.getTiempoLlegadaColectivo(ve.rndLlegColectivo, promLlegColectivos);
                            ve.proxLlegColectivo = ve.reloj + ve.tpoLlegColectivo;

                            break;
                        case "Llegada Pasajero":
                            ve.evento = "Llegada Pasajero";
                            ve.reloj = ve.proxLlegPasajero;

                            ve.rndLlegPasajero = Math.Round(rnd.NextDouble(), 2);
                            ve.tpoLlegPasajero = sim.getTiempoLlegadaPasajero(ve.rndLlegPasajero, promLlegPasajeros);
                            ve.proxLlegPasajero = ve.reloj + ve.tpoLlegPasajero;

                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        default:
                            break;

                    }



                    }




                double auxUltMin = tiempoFinal - ultimosMinutos;
                //if (ve.reloj >= auxUltMin)
                //{
                    dgvDatos.Rows.Add(
                    ve.evento, ve.reloj, ve.rndLlegColectivo, ve.tpoLlegColectivo, ve.proxLlegColectivo,
                    ve.rndLlegPasajero, ve.tpoLlegPasajero, ve.proxLlegPasajero
                    
                    );


                //}

                //TO DO: PRUEBAS INICIALES
                if ( i == 5 )
                {
                    break;
                }

                i++;
            }// fin del while

        }// fin btnSimular



    }
}
