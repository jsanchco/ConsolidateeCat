namespace eCat.Repository.Mapped
{
    public class TTiposMaterialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMateriale>
    {
        public TTiposMaterialeConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialeConfiguration(string schema)
        {
            ToTable("T_TiposMateriales", schema);
            HasKey(x => x.IdTipoMaterial);

            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodigoTipoMaterial).HasColumnName(@"CodigoTipoMaterial").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.TipoMaterial).HasColumnName(@"TipoMaterial").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prefijo).HasColumnName(@"Prefijo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.IdTipoMaterialBusqueda).HasColumnName(@"IdTipoMaterialBusqueda").HasColumnType("tinyint").IsRequired();
            Property(x => x.RevisarStock).HasColumnName(@"RevisarStock").HasColumnType("bit").IsRequired();
            Property(x => x.Digital).HasColumnName(@"Digital").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.TBusquedaGeneralTiposMateriale).WithMany(b => b.TTiposMateriales).HasForeignKey(c => c.IdTipoMaterialBusqueda).WillCascadeOnDelete(false); // FK_T_TiposMateriales_T_BusquedaGeneral_TiposMateriales
        }
    }
}