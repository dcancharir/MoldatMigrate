using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Clasificacion")]
public class ClasificacionDW : EntityDW
{
	[Key]
	public int CodClasificacion { get; set; }

	public string Nombre { get; set; }
}
