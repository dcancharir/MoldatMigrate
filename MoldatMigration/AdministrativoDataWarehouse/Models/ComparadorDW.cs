using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Comparador")]
public class ComparadorDW : EtiquetaDW
{
	[Key]
	public int CodComparador { get; set; }

	public int CodMarcaComparador { get; set; }

	public string Nombre { get; set; }

	public int TipoComparador { get; set; } //1: Comparador, 2: Monedero
	public int CodRD { get; set; }
}
