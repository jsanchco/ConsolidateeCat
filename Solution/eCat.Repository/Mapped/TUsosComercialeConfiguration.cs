namespace eCat.Repository.Mapped
{
    public class TUsosComercialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TUsosComerciale>
    {
        public TUsosComercialeConfiguration()
            : this("dbo")
        {
        }

        public TUsosComercialeConfiguration(string schema)
        {
            ToTable("T_UsosComerciales", schema);
            HasKey(x => x.IdUsoComercial);

            Property(x => x.IdUsoComercial).HasColumnName(@"IdUsoComercial").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodigoUsoComercial).HasColumnName(@"CodigoUsoComercial").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.UsoComercial).HasColumnName(@"UsoComercial").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
        }
    }
}