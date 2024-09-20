using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Linea : Etiqueta
{
	[Key]
	public int CodLinea { get; set; }

	public string Nombre { get; set; }
}
