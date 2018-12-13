namespace eCat.Repository.Mapped
{
    public class PeAreasGlobaleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeAreasGlobale>
    {
        public PeAreasGlobaleConfiguration()
            : this("dbo")
        {
        }

        public PeAreasGlobaleConfiguration(string schema)
        {
            ToTable("PE_AreasGlobales", schema);
            HasKey(x => x.IdAreaGlobal);

            Property(x => x.IdAreaGlobal).HasColumnName(@"IdAreaGlobal").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("smallint").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
        }
    }
}