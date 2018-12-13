namespace eCat.Repository.Mapped
{
    public class TNegocioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TNegocio>
    {
        public TNegocioConfiguration()
            : this("dbo")
        {
        }

        public TNegocioConfiguration(string schema)
        {
            ToTable("T_Negocio", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdNegocio).HasColumnName(@"IdNegocio").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
        }
    }
}