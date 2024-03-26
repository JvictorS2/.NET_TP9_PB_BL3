using System.ComponentModel.DataAnnotations;

namespace SCA_MVC_TP9_PB.Models;
public class Professor
{
    [Key]
    public int matricula { get; set; }
    [Required]
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Titulacao { get; set; }
    public string FormaContratada { get; set; }
    public string Curriculo { get; set; }
    public string Horario { get; set; }
}

