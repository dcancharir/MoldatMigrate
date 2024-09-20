using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Clasificacion : Entity
{
	[Key]
	public int CodClasificacion { get; set; }

	public string Nombre { get; set; }
}
