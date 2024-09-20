using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Volatilidad")]
public class VolatilidadDW : EntityDW
{
	[Key]
	public int CodVolatilidad { get; set; }

	public string Nombre { get; set; }

	public decimal IntervaloInferior { get; set; }

	public decimal IntervaloSuperior { get; set; }
}
