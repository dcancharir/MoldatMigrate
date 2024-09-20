using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Mueble : Etiqueta
{
	[Key]
	public int CodMueble { get; set; }

	public string Nombre { get; set; }
	public int CodRD { get; set; }
}
