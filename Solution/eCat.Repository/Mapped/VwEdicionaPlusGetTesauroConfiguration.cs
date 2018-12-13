namespace eCat.Repository.Mapped
{
    public class VwEdicionaPlusGetTesauroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.VwEdicionaPlusGetTesauro>
    {
        public VwEdicionaPlusGetTesauroConfiguration()
            : this("dbo")
        {
        }

        public VwEdicionaPlusGetTesauroConfiguration(string schema)
        {
            ToTable("vw_EdicionaPlus_GetTesauro", schema);
            HasKey(x => new { x.IdArbol, x.Nombre, x.Nivelador, x.Orden });

            Property(x => x.IdArbol).HasColumnName(@"IdArbol").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sinonimos).HasColumnName(@"Sinonimos").HasColumnType("text").IsOptional().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.Nivelador).HasColumnName(@"Nivelador").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPadre).HasColumnName(@"IdPadre").HasColumnType("int").IsOptional();
        }
    }
}