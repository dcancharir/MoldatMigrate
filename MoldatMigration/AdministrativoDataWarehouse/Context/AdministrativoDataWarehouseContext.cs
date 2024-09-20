using Microsoft.EntityFrameworkCore;
using MoldatMigration.Administrativo.Context;
using MoldatMigration.AdministrativoDataWarehouse.Models;

namespace MoldatMigration.AdministrativoDataWarehouse.Context;

public class AdministrativoDataWarehouseContext : DbContext
{
	public AdministrativoDataWarehouseContext() { }
	public AdministrativoDataWarehouseContext(DbContextOptions<AdministrativoDatawareHouseContext> options) : base(options) { }
	public virtual DbSet<AlmacenDW> Almacens { get; set; }
	public virtual DbSet<ClasificacionDW> Clasificacions { get; set; }
	public virtual DbSet<ComparadorDW> Comparadors { get; set; }
	public virtual DbSet<ContratoDW> Contratos { get; set; }
	public virtual DbSet<EmpresaDW> Empresas { get; set; }
	public virtual DbSet<EstadoMaquinaDW> EstadoMaquinas { get; set; }
	public virtual DbSet<FichaDW> Fichas { get; set; }
	public virtual DbSet<FormulaDW> Formulas { get; set; }
	public virtual DbSet<FormulaBonusInDW> FormulaBonusIns { get; set; }
	public virtual DbSet<IslaDW> Islas { get; set; }
	public virtual DbSet<JuegoDW> Juegos { get; set; }
	public virtual DbSet<LineaDW> Lineas { get; set; }
	public virtual DbSet<MaquinaDW> Maquinas { get; set; }
	public virtual DbSet<MedioJuegoDW> MedioJuegos { get; set; }
	public virtual DbSet<ModeloBilleteroDW> ModeloBilleteros { get; set; }
	public virtual DbSet<ModeloHopperDW> ModeloHoppers { get; set; }
	public virtual DbSet<ModeloMaquinaDW> ModeloMaquinas { get; set; }
	public virtual DbSet<MonedaDW> Monedas { get; set; }
	public virtual DbSet<MuebleDW> Muebles { get; set; }
	public virtual DbSet<PantallaDW> Pantallas { get; set; }
	public virtual DbSet<SalaDW> Salas { get; set; }
	public virtual DbSet<TipoFichaDW> TipoFichas { get; set; }
	public virtual DbSet<VolatilidadDW> Volatilidads { get; set; }
	public virtual DbSet<ZonaDW> Zonas { get; set; }
}
