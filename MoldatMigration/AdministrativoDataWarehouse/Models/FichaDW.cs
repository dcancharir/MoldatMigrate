using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Ficha")]
public class FichaDW : EntityDW
{
	[Key]
	public int CodFicha { get; set; }

	public string Nombre { get; set; }
	public int CodRD { get; set; }
	public virtual decimal valor { get { return decimal.Parse(Nombre); } }
}
