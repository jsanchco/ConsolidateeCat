namespace eCat.Repository.Mapped
{
    public class TTiposMaterialesGruposArticulosPrefijoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMaterialesGruposArticulosPrefijo>
    {
        public TTiposMaterialesGruposArticulosPrefijoConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialesGruposArticulosPrefijoConfiguration(string schema)
        {
            ToTable("T_TiposMateriales_GruposArticulos_Prefijo", schema);
            HasKey(x => new { x.IdTipoMaterial, x.CodigoGrupo });

            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prefijo).HasColumnName(@"Prefijo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.BDependenciaImagenes).HasColumnName(@"bDependenciaImagenes").HasColumnType("bit").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2GruposArticulo).WithMany(b => b.TTiposMaterialesGruposArticulosPrefijoes).HasForeignKey(c => c.CodigoGrupo).WillCascadeOnDelete(false); // FK_T_TiposMateriales_GruposArticulos_Prefijo_E2_GRUPOS_ARTICULOS
            HasRequired(a => a.TTiposMateriale).WithMany(b => b.TTiposMaterialesGruposArticulosPrefijoes).HasForeignKey(c => c.IdTipoMaterial).WillCascadeOnDelete(false); // FK_T_TiposMateriales_GruposArticulos_Prefijo_T_TiposMateriales
        }
    }
}