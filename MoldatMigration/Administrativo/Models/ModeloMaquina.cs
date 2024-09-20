using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class ModeloMaquina : Etiqueta
{
	[Key]
	public int CodModeloMaquina { get; set; }

	public int CodMarcaMaquina { get; set; }

	public string Nombre { get; set; }

	public string Ncmod { get; set; }

	public string Cimod { get; set; }

	public int CodRD { get; set; }
}
