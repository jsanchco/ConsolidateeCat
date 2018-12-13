namespace eCat.Repository.Mapped
{
    public class E2RamasclasifFichaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2RamasclasifFicha>
    {
        public E2RamasclasifFichaConfiguration()
            : this("dbo")
        {
        }

        public E2RamasclasifFichaConfiguration(string schema)
        {
            ToTable("E2_RAMASCLASIF_FICHAS", schema);
            HasKey(x => new { x.IdCatalogo, x.IdClasificacion, x.IdInterno });

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.E2RamasClasificacionesGestion).WithMany(b => b.E2RamasclasifFicha).HasForeignKey(c => new { c.IdCatalogo, c.IdClasificacion }).WillCascadeOnDelete(false); // FK_E2_RAMASCLASIF_FICHAS_E2_RAMAS_CLASIFICACIONES_GESTION
            HasRequired(a => a.FichasBase).WithMany(b => b.E2RamasclasifFicha).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_E2_RAMASCLASIF_FICHAS_FichasBase
        }
    }
}