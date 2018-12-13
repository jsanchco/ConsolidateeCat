namespace eCat.Repository.Mapped
{
    public class TiposArticulosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposArticulosIdioma>
    {
        public TiposArticulosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TiposArticulosIdiomaConfiguration(string schema)
        {
            ToTable("TiposArticulos_Idioma", schema);
            HasKey(x => new { x.IdTipoArticulo, x.IdIdiomaInterface });

            Property(x => x.IdTipoArticulo).HasColumnName(@"IDTipoArticulo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TiposArticulosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_TiposArticulos_Idioma_T_Idiomas_Plataforma
        }
    }
}