namespace eCat.Repository.Mapped
{
    public class TAyudaCmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TAyudaCm>
    {
        public TAyudaCmConfiguration()
            : this("dbo")
        {
        }

        public TAyudaCmConfiguration(string schema)
        {
            ToTable("T_ayuda_CMS", schema);
            HasKey(x => x.IdAyuda);

            Property(x => x.IdAyuda).HasColumnName(@"idAyuda").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoAyuda).HasColumnName(@"CodigoAyuda").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdCmsContenido).HasColumnName(@"IdCMSContenido").HasColumnType("bigint").IsRequired();
            Property(x => x.Discriminador).HasColumnName(@"Discriminador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }
}