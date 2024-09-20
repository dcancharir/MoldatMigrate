using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("FormulaBonusIn")]
public class FormulaBonusInDW : EntityDW
{
	[Key]
	public int CodFormulaBonusIn { get; set; }

	public string Nombre { get; set; }

	public string Descripcion { get; set; }
}
