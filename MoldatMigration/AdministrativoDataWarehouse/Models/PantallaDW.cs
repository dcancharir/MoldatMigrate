using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Pantalla")]
public class PantallaDW : EtiquetaDW
{
	[Key]
	public int CodPantalla { get; set; }

	public int CodMarcaPantalla { get; set; }

	public string Nombre { get; set; }

	public int CodRD { get; set; }

	public string Tamanio { get; set; }

	public string Tipo { get; set; }
}
