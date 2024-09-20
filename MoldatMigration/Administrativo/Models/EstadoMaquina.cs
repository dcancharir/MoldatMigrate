using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class EstadoMaquina : Entity
{
	[Key]
	public int CodEstadoMaquina { get; set; }

	public string Nombre { get; set; }
}
