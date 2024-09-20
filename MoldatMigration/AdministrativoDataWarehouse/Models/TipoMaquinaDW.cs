using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("TipoMaquina")]
public class TipoMaquinaDW : EtiquetaDW
{
	[Key]
	public int CodTipoMaquina { get; set; }

	public string Nombre { get; set; }

	public decimal ValorToD { get; set; }
}
