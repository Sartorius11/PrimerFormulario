using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class ClaseAnual
    {
        public ClaseAnual()
        {
            this.GenerarMeses();
        }

        public ClaseAnual(int anyo)
        {
            this.Anyo = anyo;
            this.GenerarMeses();
        }

        private void GenerarMeses()
        {
            //CREAMOS LOS MESES
            DateTime fecha = DateTime.Parse("01/01/2023");
            Random random = new Random();
            this.Meses = new List<Mes>();
            for (int i = 1; i <= 12; i++)
            {
                string nombreMes = fecha.ToString("MMMM");
                Mes mes = new Mes();
                mes.NombreMes = nombreMes;
                mes.TemperaturaMaxima = random.Next(10, 50);
                mes.TemperaturaMinima = random.Next(-19, 9);
                this.Meses.Add(mes);
                fecha = fecha.AddMonths(1);
            }
        }

        public int Anyo { get; set; }
        public List<Mes> Meses { get; set; }

        public int GetMaximaAnual()
        {
            int maxima = this.Meses[0].TemperaturaMinima;
            foreach (Mes mes in this.Meses)
            {
                maxima = Math.Max(maxima, mes.TemperaturaMaxima);
            }
            return maxima;
        }

        public int GetMinimaAnual()
        {
            int minima = this.Meses[0].TemperaturaMinima;
            foreach (Mes mes in this.Meses)
            {
                minima = Math.Min(minima, mes.TemperaturaMinima);
            }
            return minima;
        }

        public float GetMediaAnual()
        {
            float suma = 0;
            foreach (Mes mes in this.Meses)
            {
                suma = mes.GetTemperaturaMedia();
            }
            return suma / this.Meses.Count;
        }
    }
}
