using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Comparacao
{
    //* Para ter mais que uma heranca, voce usa virgula
    public class Programador : Funcionario, ITrabalhador
    {
        public override void Trabalhar() => Console.WriteLine($"{Nome} esta programando...");

        public void ExercutarTarefa() => Console.WriteLine($"{Nome} concluiu uma tarefa.");
    }
}