using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Veiculos.Models;

public partial class TabelaVeiculo
{
    [Key]
    public int Id { get; set; }

    public string ModeloVeiculo { get; set; } = null!;

    public double AnoVeiculo { get; set; }

    [StringLength(8)]
    public string Tipo { get; set; } = null!;
}
