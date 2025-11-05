

//* Permite usar componenter de Banco de dados para o Backend
using System.ComponentModel.DataAnnotations;

namespace Sistema_Funcionario.Models
{
    public abstract class Funcionario
    {
        //* Defini o atributo como chave primaria
        [Key]
        public int Id {get;set;}

        //*[Required] Obriga o Usuario a por um valor ao atributo
        [Required] 
        public string Nome{get;set;}

        //* [Range] Defini um parametro para o valor
        [Range(0,10000)]
        public double SalarioBase;

        public Funcionario(string NomeConstrutor, double SalarioBaseConstrutor)
        {
            Nome = NomeConstrutor;
            SalarioBase = SalarioBaseConstrutor;
        }

        public abstract double CalcularSalario();
    }
}