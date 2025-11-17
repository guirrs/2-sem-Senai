using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Veiculos.Models
{
    public abstract class Veiculo
    {
        [Key]
        public int Id {get;set;}
        public string ModeloVeiculo { get; set; } = string.Empty;
        public double AnoVeiculo { get; set; }

        public Veiculo(){}
        public Veiculo(string ModeloConstrutor, double AnoConstrutor)
        {
            ModeloVeiculo = ModeloConstrutor;
            AnoVeiculo = AnoConstrutor;
        }

        public abstract double CalcularRevisao();

    }
}