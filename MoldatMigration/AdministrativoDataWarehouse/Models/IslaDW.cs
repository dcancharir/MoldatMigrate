using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Isla")]
public class IslaDW : EntityDW
{
	[Key]
	public int CodIsla { get; set; }

	public string Nombre { get; set; }
}
