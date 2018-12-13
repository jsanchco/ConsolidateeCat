namespace eCat.Repository.Mapped
{
    public class E2VwLibrosListosParaWebConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2VwLibrosListosParaWeb>
    {
        public E2VwLibrosListosParaWebConfiguration()
            : this("dbo")
        {
        }

        public E2VwLibrosListosParaWebConfiguration(string schema)
        {
            ToTable("E2_vw_LibrosListosParaWeb", schema);
            HasKey(x => new { x.IdInterno, x.EstadoSap, x.IdClasificacion });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Isbn).HasColumnName(@"ISBN").HasColumnType("nvarchar").IsOptional().HasMaxLength(13);
            Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.EstadoSap).HasColumnName(@"EstadoSAP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}