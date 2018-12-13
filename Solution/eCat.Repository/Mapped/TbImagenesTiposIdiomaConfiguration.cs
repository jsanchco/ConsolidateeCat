namespace eCat.Repository.Mapped
{
    public class TbImagenesTiposIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbImagenesTiposIdioma>
    {
        public TbImagenesTiposIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TbImagenesTiposIdiomaConfiguration(string schema)
        {
            ToTable("TB_Imagenes_Tipos_Idioma", schema);
            HasKey(x => new { x.IdTipoImagen, x.IdIdiomaInterface });

            Property(x => x.IdTipoImagen).HasColumnName(@"IdTipoImagen").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TbImagenesTiposIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_TB_Imagenes_Tipos_Idioma_T_Idiomas_Plataforma
        }
    }
}