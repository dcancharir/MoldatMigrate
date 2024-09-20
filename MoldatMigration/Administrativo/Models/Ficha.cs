using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Ficha : Entity
{
	[Key]
	public int CodFicha { get; set; }

	public string Nombre { get; set; }
	public int CodRD { get; set; }
	public virtual decimal valor { get { return decimal.Parse(Nombre); } }
}
