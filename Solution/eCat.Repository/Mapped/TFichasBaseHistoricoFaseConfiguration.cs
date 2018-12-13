namespace eCat.Repository.Mapped
{
    public class TFichasBaseHistoricoFaseConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFichasBaseHistoricoFase>
    {
        public TFichasBaseHistoricoFaseConfiguration()
            : this("dbo")
        {
        }

        public TFichasBaseHistoricoFaseConfiguration(string schema)
        {
            ToTable("T_FichasBase_Historico_Fase", schema);
            HasKey(x => new { x.IdInterno, x.IdFase });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdFase).HasColumnName(@"IdFase").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsuario).HasColumnName(@"IdUsuario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.Usuario).WithMany(b => b.TFichasBaseHistoricoFases).HasForeignKey(c => c.IdUsuario).WillCascadeOnDelete(false); // FK_T_FichasBase_Historico_Fase_Usuarios
            HasRequired(a => a.FichasBase).WithMany(b => b.TFichasBaseHistoricoFases).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_T_FichasBase_Historico_Fase_FichasBase
            HasRequired(a => a.TFasesMaterial).WithMany(b => b.TFichasBaseHistoricoFases).HasForeignKey(c => c.IdFase).WillCascadeOnDelete(false); // FK_T_FichasBase_Historico_Fase_T_FasesMaterial
        }
    }
}