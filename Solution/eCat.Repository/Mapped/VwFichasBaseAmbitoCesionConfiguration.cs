namespace eCat.Repository.Mapped
{
    public class VwFichasBaseAmbitoCesionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.VwFichasBaseAmbitoCesion>
    {
        public VwFichasBaseAmbitoCesionConfiguration()
            : this("dbo")
        {
        }

        public VwFichasBaseAmbitoCesionConfiguration(string schema)
        {
            ToTable("vw_FichasBase_AmbitoCesion", schema);
            HasKey(x => new { x.IdInterno, x.Fecha, x.Estado });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Observaciones).HasColumnName(@"Observaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.AmbitoCesion).HasColumnName(@"AmbitoCesion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}