using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Comparador : Etiqueta
{
	[Key]
	public int CodComparador { get; set; }

	public int CodMarcaComparador { get; set; }

	public string Nombre { get; set; }

	public int TipoComparador { get; set; } //1: Comparador, 2: Monedero
	public int CodRD { get; set; }
}
