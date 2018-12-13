namespace eCat.Repository.Mapped
{
    public class TiposEncuadernacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposEncuadernacion>
    {
        public TiposEncuadernacionConfiguration()
            : this("dbo")
        {
        }

        public TiposEncuadernacionConfiguration(string schema)
        {
            ToTable("TiposEncuadernacion", schema);
            HasKey(x => x.IdTipoEncuadernacion);

            Property(x => x.IdTipoEncuadernacion).HasColumnName(@"IDTipoEncuadernacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Encuadernacion).HasColumnName(@"Encuadernacion").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
        }
    }
}