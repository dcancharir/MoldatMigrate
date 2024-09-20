using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Almacen")]
public class AlmacenDW : EntityDW
{
	[Key]
	public int CodAlmacen { get; set; }

	[Description("Nombre del Almacen")]
	public string Nombre { get; set; }

	public string Direccion { get; set; }

	public int CodRD { get; set; }

	[Description("FK: Codigo de Ubigeo de la Direccion del Almacen Distrito")]
	public int CodUbigeo { get; set; }
}
