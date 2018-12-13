namespace eCat.Repository.Mapped
{
    public class TiposMedioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposMedio>
    {
        public TiposMedioConfiguration()
            : this("dbo")
        {
        }

        public TiposMedioConfiguration(string schema)
        {
            ToTable("TiposMedios", schema);
            HasKey(x => x.IdTipoMedio);

            Property(x => x.IdTipoMedio).HasColumnName(@"IDTipoMedio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoMedio).HasColumnName(@"TipoMedio").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}