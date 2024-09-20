using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class MedioJuego : Etiqueta
{
	[Key]
	public int CodMedioJuego { get; set; }

	public string Nombre { get; set; }
}
