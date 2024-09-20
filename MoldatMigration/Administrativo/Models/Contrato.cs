using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Contrato : Entity
{
	[Key]
	public int CodContrato { get; set; }

	public int CodTipoContrato { get; set; }

	public int CodSala { get; set; }

	public int CodMoneda { get; set; }

	public string Descripcion { get; set; }

	public DateTime? FechaInicio { get; set; }

	public DateTime? FechaFin { get; set; }

	public string RutaArchivo { get; set; }

	public int TotalMaquinas { get; set; }

	public int ExonerarProduccionNegativa { get; set; }

	public string ArchivoBase64 { get; set; }

	public string NombreArchivo { get; set; }

}
