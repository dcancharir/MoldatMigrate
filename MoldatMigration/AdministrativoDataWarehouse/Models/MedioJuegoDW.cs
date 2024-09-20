using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("MedioJuego")]
public class MedioJuegoDW : EtiquetaDW
{
	[Key]
	public int CodMedioJuego { get; set; }

	public string Nombre { get; set; }
}
