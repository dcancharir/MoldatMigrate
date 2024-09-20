using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class FormulaBonusIn : Entity
{
	[Key]
	public int CodFormulaBonusIn { get; set; }

	public string Nombre { get; set; }

	public string Descripcion { get; set; }
}
