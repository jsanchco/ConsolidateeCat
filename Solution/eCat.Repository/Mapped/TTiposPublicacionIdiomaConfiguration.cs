namespace eCat.Repository.Mapped
{
    public class TTiposPublicacionIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposPublicacionIdioma>
    {
        public TTiposPublicacionIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TTiposPublicacionIdiomaConfiguration(string schema)
        {
            ToTable("T_TiposPublicacion_Idioma", schema);
            HasKey(x => new { x.IdTipoPublicacion, x.IdIdiomaInterface });

            Property(x => x.IdTipoPublicacion).HasColumnName(@"IdTipoPublicacion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TTiposPublicacionIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_TiposPublicacion_Idioma_T_Idiomas_Plataforma
        }
    }
}