using Microsoft.EntityFrameworkCore;
using MoldatMigration.Administrativo.Models;

namespace MoldatMigration.Administrativo.Context;

public class AdministrativoContext : DbContext
{
    public AdministrativoContext(){}
    public AdministrativoContext(DbContextOptions<AdministrativoContext> options) : base(options) { }
    public virtual DbSet<Almacen> Almacens { get; set; }
    public virtual DbSet<Clasificacion> Clasificacions { get; set; }
    public virtual DbSet<Comparador> Comparadors { get; set; }
    public virtual DbSet<Contrato> Contratos { get; set; }
    public virtual DbSet<Empresa> Empresas { get; set; }
    public virtual DbSet<EstadoMaquina> EstadoMaquinas { get; set; }
    public virtual DbSet<Ficha> Fichas { get; set; }
    public virtual DbSet<Formula> Formulas { get; set; }
    public virtual DbSet<FormulaBonusIn> FormulaBonusIns { get; set; }
    public virtual DbSet<Isla> Islas { get; set; }
    public virtual DbSet<Juego> Juegos { get; set; }
    public virtual DbSet<Linea> Lineas { get; set; }
    public virtual DbSet<Maquina> Maquinas { get; set; }
    public virtual DbSet<MedioJuego> MedioJuegos { get; set; }
    public virtual DbSet<ModeloBilletero> ModeloBilleteros { get; set; }
    public virtual DbSet<ModeloHopper> ModeloHoppers { get; set; }
    public virtual DbSet<ModeloMaquina> ModeloMaquinas { get; set; }
    public virtual DbSet<Moneda> Monedas { get; set; }
    public virtual DbSet<Mueble> Muebles { get; set; }
    public virtual DbSet<Pantalla> Pantallas { get; set; }
    public virtual DbSet<Sala> Salas { get; set; }
    public virtual DbSet<TipoFicha> TipoFichas { get; set; }
    public virtual DbSet<Volatilidad> Volatilidads { get; set; }
    public virtual DbSet<Zona> Zonas { get; set; }
}
