using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("ModelHopper")]
public class ModeloHopperDW : EntityDW
{
	[Key]
	public int CodModeloHopper { get; set; }

	public int CodMarcaHopper { get; set; }

	public string Nombre { get; set; }

	public int CodRD { get; set; }
}
