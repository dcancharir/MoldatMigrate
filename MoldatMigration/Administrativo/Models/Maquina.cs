using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace MoldatMigration.Administrativo.Models;

public class Maquina : Entity
{
	[Key]
	public int CodMaquina { get; set; }

	public int CodJuego { get; set; }

	public int CodComparador { get; set; }

	public int CodModeloBilletero { get; set; }

	public int CodVolatilidad { get; set; }

	public int CodLinea { get; set; }

	public int CodTipoMaquina { get; set; }

	public int CodModeloHopper { get; set; }

	public int? CodContrato { get; set; }

	public int CodClasificacion { get; set; }

	public int CodMueble { get; set; }

	public int CodSala { get; set; }

	public int CodEmpresa { get; set; }

	public int CodZona { get; set; }

	public int CodIsla { get; set; }

	public int CodPantalla { get; set; }

	public int CodMoneda { get; set; }

	public int CodFicha { get; set; }

	public int CodTipoFicha { get; set; }

	public int CodMedioJuego { get; set; }

	public int CodModeloMaquina { get; set; }

	public int CodAlmacen { get; set; }

	public int CodFormula { get; set; }

	public int CodEstadoMaquina { get; set; }

	public string? CodMaquinaLey { get; set; }

	public string? CodAlterno { get; set; }

	public string? NroFabricacion { get; set; }

	public DateTime? FechaFabricacion { get; set; }

	public DateTime? FechaReconstruccion { get; set; }

	public string? NroSerie { get; set; }

	public decimal ValorComercial { get; set; }

	public int CordX { get; set; }

	public int CordY { get; set; }

	public int Segmento { get; set; }

	public int Posicion { get; set; }

	public decimal ApuestaMaxima { get; set; }

	public decimal ApuestaMinima { get; set; }

	public int Hopper { get; set; }

	public decimal CreditoFicha { get; set; }

	public decimal Token { get; set; }

	public decimal PorcentajeDevolucion { get; set; }

	public int CodRD { get; set; }
	public int? CodFormulaBonusIn { get; set; }
	//2=sin retiro, 1=con retiro
	public int RetiroTemporal { get; set; }

}
