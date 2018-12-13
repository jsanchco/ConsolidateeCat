namespace eCat.Repository.Mapped
{
    public class TFichasBaseMaterialesReferenciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFichasBaseMaterialesReferencia>
    {
        public TFichasBaseMaterialesReferenciaConfiguration()
            : this("dbo")
        {
        }

        public TFichasBaseMaterialesReferenciaConfiguration(string schema)
        {
            ToTable("T_FichasBase_MaterialesReferencia", schema);
            HasKey(x => new { x.IdInterno, x.IdTipoMaterialReferencia, x.IdInternoReferencia });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipoMaterialReferencia).HasColumnName(@"IdTipoMaterialReferencia").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInternoReferencia).HasColumnName(@"IdInternoReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.FichasBase_IdInterno).WithMany(b => b.TFichasBaseMaterialesReferencias_IdInterno).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_T_FichasBase_MaterialesReferencia_FichasBase
            HasRequired(a => a.FichasBase_IdInternoReferencia).WithMany(b => b.TFichasBaseMaterialesReferencias_IdInternoReferencia).HasForeignKey(c => c.IdInternoReferencia).WillCascadeOnDelete(false); // FK_T_FichasBase_MaterialesReferencia_FichasBase1
            HasRequired(a => a.TMaterialesReferenciaTipos).WithMany(b => b.TFichasBaseMaterialesReferencias).HasForeignKey(c => c.IdTipoMaterialReferencia).WillCascadeOnDelete(false); // FK_T_FichasBase_MaterialesReferencia_T_MaterialesReferencia_Tipos
        }
    }
}