using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("TipoFicha")]
public class TipoFichaDW : EntityDW
{
	[Key]
	public int CodTipoFicha { get; set; }

	public string Nombre { get; set; }
}
