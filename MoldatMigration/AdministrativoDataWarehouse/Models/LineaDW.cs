using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Linea")]
public class LineaDW : EtiquetaDW
{
	[Key]
	public int CodLinea { get; set; }

	public string Nombre { get; set; }
}
