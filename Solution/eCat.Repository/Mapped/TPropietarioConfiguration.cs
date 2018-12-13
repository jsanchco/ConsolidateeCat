namespace eCat.Repository.Mapped
{
    public class TPropietarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPropietario>
    {
        public TPropietarioConfiguration()
            : this("dbo")
        {
        }

        public TPropietarioConfiguration(string schema)
        {
            ToTable("T_Propietario", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdPropietario).HasColumnName(@"IdPropietario").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdioma).HasColumnName(@"IDIdioma").HasColumnType("tinyint").IsOptional();
        }
    }
}