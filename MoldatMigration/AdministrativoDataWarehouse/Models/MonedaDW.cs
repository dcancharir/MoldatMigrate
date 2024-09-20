using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Moneda")]
public class MonedaDW
{
	[Key]
	public int CodMoneda { get; set; }

	public string Nombre { get; set; }

	public string CodIso { get; set; }

	public string Simbolo { get; set; }

	public int Predeterminado { get; set; }

	public int Boveda { get; set; }
}
