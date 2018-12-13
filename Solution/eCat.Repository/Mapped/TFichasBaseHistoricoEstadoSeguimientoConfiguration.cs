namespace eCat.Repository.Mapped
{
    public class TFichasBaseHistoricoEstadoSeguimientoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFichasBaseHistoricoEstadoSeguimiento>
    {
        public TFichasBaseHistoricoEstadoSeguimientoConfiguration()
            : this("dbo")
        {
        }

        public TFichasBaseHistoricoEstadoSeguimientoConfiguration(string schema)
        {
            ToTable("T_FichasBase_Historico_EstadoSeguimiento", schema);
            HasKey(x => x.IdHistorico);

            Property(x => x.IdHistorico).HasColumnName(@"IdHistorico").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.IdEstadoSeguimiento).HasColumnName(@"IdEstadoSeguimiento").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsuario).HasColumnName(@"IdUsuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Comentario).HasColumnName(@"Comentario").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.TFichasBaseHistoricoEstadoSeguimientoes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_T_FichasBase_Historico_EstadoSeguimiento_FichasBase
            HasRequired(a => a.TEstadosSeguimiento).WithMany(b => b.TFichasBaseHistoricoEstadoSeguimientoes).HasForeignKey(c => c.IdEstadoSeguimiento).WillCascadeOnDelete(false); // FK_T_FichasBase_Historico_EstadoSeguimiento_T_EstadosSeguimiento
            HasRequired(a => a.Usuario).WithMany(b => b.TFichasBaseHistoricoEstadoSeguimientoes).HasForeignKey(c => c.IdUsuario).WillCascadeOnDelete(false); // FK_T_FichasBase_Historico_EstadoSeguimiento_Usuarios
        }
    }
}