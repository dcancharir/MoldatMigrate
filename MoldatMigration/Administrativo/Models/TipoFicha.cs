using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class TipoFicha : Entity
{
	[Key]
	public int CodTipoFicha { get; set; }

	public string Nombre { get; set; }
}
