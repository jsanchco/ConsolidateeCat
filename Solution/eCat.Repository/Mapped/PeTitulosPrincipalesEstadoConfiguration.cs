namespace eCat.Repository.Mapped
{
    public class PeTitulosPrincipalesEstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeTitulosPrincipalesEstado>
    {
        public PeTitulosPrincipalesEstadoConfiguration()
            : this("dbo")
        {
        }

        public PeTitulosPrincipalesEstadoConfiguration(string schema)
        {
            ToTable("PE_TitulosPrincipales_Estados", schema);
            HasKey(x => x.IdEstado);

            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Icono).HasColumnName(@"Icono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}