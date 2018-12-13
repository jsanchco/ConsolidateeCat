namespace eCat.Repository.Mapped
{
    public class DilveMaterialEducativoAneleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveMaterialEducativoAnele>
    {
        public DilveMaterialEducativoAneleConfiguration()
            : this("dbo")
        {
        }

        public DilveMaterialEducativoAneleConfiguration(string schema)
        {
            ToTable("DILVE_MaterialEducativoANELE", schema);
            HasKey(x => x.IdTipoMaterialEducativoAnele);

            Property(x => x.IdTipoMaterialEducativoAnele).HasColumnName(@"IdTipoMaterialEducativoANELE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoMaterialEducaticoAnele).HasColumnName(@"CodigoMaterialEducaticoANELE").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}