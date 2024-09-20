using Microsoft.EntityFrameworkCore;
namespace MoldatMigration.Administrativo.Models;

public abstract class Entity
{
	protected Entity()
	{
		Activo = true;
		Estado = 1;
	}

	public DateTime FechaRegistro { get; set; }

	public DateTime FechaModificacion { get; set; }

	public string? CodUsuario { get; set; }

	public int Estado { get; set; }

	public bool Activo { get; set; }

	public EntityState EntityState { get; set; }

	public int Order { get; set; }

}
