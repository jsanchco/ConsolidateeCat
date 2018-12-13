namespace eCat.Repository.Mapped
{
    public class TbImagenesTiposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbImagenesTipos>
    {
        public TbImagenesTiposConfiguration()
            : this("dbo")
        {
        }

        public TbImagenesTiposConfiguration(string schema)
        {
            ToTable("TB_Imagenes_Tipos", schema);
            HasKey(x => x.IdTipoImagen);

            Property(x => x.IdTipoImagen).HasColumnName(@"IdTipoImagen").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoImagen).HasColumnName(@"TipoImagen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.Redimensionar3).HasColumnName(@"Redimensionar3").HasColumnType("bit").IsRequired();
        }
    }
}