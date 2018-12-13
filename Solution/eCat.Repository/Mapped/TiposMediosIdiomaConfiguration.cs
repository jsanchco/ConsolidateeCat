namespace eCat.Repository.Mapped
{
    public class TiposMediosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposMediosIdioma>
    {
        public TiposMediosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TiposMediosIdiomaConfiguration(string schema)
        {
            ToTable("TiposMedios_Idioma", schema);
            HasKey(x => new { x.IdTipoMedio, x.IdIdiomaInterface });

            Property(x => x.IdTipoMedio).HasColumnName(@"IDTipoMedio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TiposMediosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_TiposMedios_Idioma_T_Idiomas_Plataforma
        }
    }
}