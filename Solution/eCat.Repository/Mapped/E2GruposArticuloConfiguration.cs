namespace eCat.Repository.Mapped
{
    public class E2GruposArticuloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GruposArticulo>
    {
        public E2GruposArticuloConfiguration()
            : this("dbo")
        {
        }

        public E2GruposArticuloConfiguration(string schema)
        {
            ToTable("E2_GRUPOS_ARTICULOS", schema);
            HasKey(x => x.CodigoGrupo);

            Property(x => x.IdGrupo).HasColumnName(@"IdGrupo").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DescripcionGrupo).HasColumnName(@"DescripcionGrupo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
        }
    }
}