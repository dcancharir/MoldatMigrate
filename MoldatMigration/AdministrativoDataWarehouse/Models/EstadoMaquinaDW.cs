using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("EstadoMaquina")]
public class EstadoMaquinaDW : EntityDW
{
	[Key]
	public int CodEstadoMaquina { get; set; }

	public string Nombre { get; set; }
}
