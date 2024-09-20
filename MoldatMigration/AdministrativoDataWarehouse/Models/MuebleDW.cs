using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Mueble")]
public class MuebleDW : EtiquetaDW
{
	[Key]
	public int CodMueble { get; set; }

	public string Nombre { get; set; }
	public int CodRD { get; set; }
}
