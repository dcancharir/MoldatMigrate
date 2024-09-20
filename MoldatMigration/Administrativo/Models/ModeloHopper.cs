using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class ModeloHopper : Entity
{
	[Key]
	public int CodModeloHopper { get; set; }

	public int CodMarcaHopper { get; set; }

	public string Nombre { get; set; }

	public int CodRD { get; set; }
}
