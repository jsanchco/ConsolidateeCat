namespace eCat.Repository.Mapped
{
    public class TActualizacionesCabeceraConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesCabecera>
    {
        public TActualizacionesCabeceraConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesCabeceraConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Cabecera", schema);
            HasKey(x => x.IdActualizacion);

            Property(x => x.IdActualizacion).HasColumnName(@"IdActualizacion").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdUsuario).HasColumnName(@"IdUsuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdConsulta).HasColumnName(@"IdConsulta").HasColumnType("numeric").IsRequired().HasPrecision(18,0);
            Property(x => x.CodigoCampoActualizacion).HasColumnName(@"CodigoCampoActualizacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdTipoActualizacion).HasColumnName(@"IdTipoActualizacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.NuevoValor).HasColumnName(@"NuevoValor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NuevoValorDescripcion).HasColumnName(@"NuevoValorDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.IdEstadoActualizacion).HasColumnName(@"IdEstadoActualizacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaEjecucionInicio).HasColumnName(@"FechaEjecucionInicio").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaEjecucionFin).HasColumnName(@"FechaEjecucionFin").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.E2ConsultasAsistente).WithMany(b => b.TActualizacionesCabeceras).HasForeignKey(c => c.IdConsulta).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Cabecera_E2_CONSULTAS_ASISTENTE
            HasRequired(a => a.TActualizacionesCampos).WithMany(b => b.TActualizacionesCabeceras).HasForeignKey(c => c.CodigoCampoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Campos
            HasRequired(a => a.TActualizacionesEstado).WithMany(b => b.TActualizacionesCabeceras).HasForeignKey(c => c.IdEstadoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Estados
            HasRequired(a => a.TActualizacionesTiposActualizacion).WithMany(b => b.TActualizacionesCabeceras).HasForeignKey(c => c.IdTipoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Tipos
            HasRequired(a => a.Usuario).WithMany(b => b.TActualizacionesCabeceras).HasForeignKey(c => c.IdUsuario).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Cabecera_Usuarios
        }
    }
}