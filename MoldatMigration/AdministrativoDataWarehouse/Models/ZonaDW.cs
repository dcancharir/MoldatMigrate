using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Zona")]
public class ZonaDW : EntityDW
{
	[Key]
	public int CodZona { get; set; }

	public string Nombre { get; set; }

}
