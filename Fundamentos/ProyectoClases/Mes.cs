using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public Mes() { }

        public Mes(int maxima, int minima)
        {
            this.TemperaturaMaxima = maxima;
            this.TemperaturaMinima = minima;
        }
        public string NombreMes { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }

        public float GetTemperaturaMedia()
        {
            return (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
        }
    }
}
