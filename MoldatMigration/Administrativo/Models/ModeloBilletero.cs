using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class ModeloBilletero : Etiqueta
{
	[Key]
	public int CodModeloBilletero { get; set; }

	public int CodMarcaBilletero { get; set; }

	public string Nombre { get; set; }

	public int CodRD { get; set; }
}
