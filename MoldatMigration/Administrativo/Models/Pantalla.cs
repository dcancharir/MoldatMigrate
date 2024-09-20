using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Pantalla : Etiqueta
{
	[Key]
	public int CodPantalla { get; set; }

	public int CodMarcaPantalla { get; set; }

	public string Nombre { get; set; }

	public int CodRD { get; set; }

	public string Tamanio { get; set; }

	public string Tipo { get; set; }
}
