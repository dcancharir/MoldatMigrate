using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Volatilidad : Entity
{
	[Key]
	public int CodVolatilidad { get; set; }

	public string Nombre { get; set; }

	public decimal IntervaloInferior { get; set; }

	public decimal IntervaloSuperior { get; set; }
}
