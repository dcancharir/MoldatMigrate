using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class TipoMaquina : Etiqueta
{
	[Key]
	public int CodTipoMaquina { get; set; }

	public string Nombre { get; set; }

	public decimal ValorToD { get; set; }
}
