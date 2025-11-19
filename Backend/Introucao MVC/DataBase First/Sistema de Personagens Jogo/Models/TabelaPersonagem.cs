using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Personagens_Jogo.Models;

[Table("TabelaPersonagem")]
public partial class TabelaPersonagem
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int Nivel { get; set; }

    [StringLength(13)]
    public string Classe { get; set; } = null!;
}
