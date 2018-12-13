namespace eCat.Repository.Mapped
{
    public class TReferenciasWebTiposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TReferenciasWebTipos>
    {
        public TReferenciasWebTiposConfiguration()
            : this("dbo")
        {
        }

        public TReferenciasWebTiposConfiguration(string schema)
        {
            ToTable("T_ReferenciasWeb_Tipos", schema);
            HasKey(x => x.IdTipoReferenciaWeb);

            Property(x => x.IdTipoReferenciaWeb).HasColumnName(@"IdTipoReferenciaWeb").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
        }
    }
}