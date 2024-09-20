using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Formula")]
public class FormulaDW : EntityDW
{
	[Key]
	public int CodFormula { get; set; }

	public string Nombre { get; set; }

	public string NombreReal { get; set; }
}
