namespace eCat.Repository.Mapped
{
    public class TMercadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TMercado>
    {
        public TMercadoConfiguration()
            : this("dbo")
        {
        }

        public TMercadoConfiguration(string schema)
        {
            ToTable("T_Mercado", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdMercado).HasColumnName(@"IdMercado").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
        }
    }
}