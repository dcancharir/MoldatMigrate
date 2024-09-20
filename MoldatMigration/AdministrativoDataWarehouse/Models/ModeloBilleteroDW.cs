using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("ModeloBilletero")]
public class ModeloBilleteroDW : EtiquetaDW
{
	[Key]
	public int CodModeloBilletero { get; set; }

	public int CodMarcaBilletero { get; set; }

	public string Nombre { get; set; }

	public int CodRD { get; set; }
}
