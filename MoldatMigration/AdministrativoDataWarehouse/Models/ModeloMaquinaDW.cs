using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("ModeloMaquina")]
public class ModeloMaquinaDW : EtiquetaDW
{
	[Key]
	public int CodModeloMaquina { get; set; }

	public int CodMarcaMaquina { get; set; }

	public string Nombre { get; set; }

	public string Ncmod { get; set; }

	public string Cimod { get; set; }

	public int CodRD { get; set; }
}
