namespace eCat.Repository.Mapped
{
    public class TTiposMaterialesGruposArticuloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMaterialesGruposArticulo>
    {
        public TTiposMaterialesGruposArticuloConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialesGruposArticuloConfiguration(string schema)
        {
            ToTable("T_TiposMateriales_GruposArticulos", schema);
            HasKey(x => new { x.IdTipoMaterial, x.CodigoGrupo, x.IdUsoComercial });

            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsoComercial).HasColumnName(@"IdUsoComercial").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.TTiposMaterialesGruposArticulosPrefijo).WithMany(b => b.TTiposMaterialesGruposArticuloes).HasForeignKey(c => new { c.IdTipoMaterial, c.CodigoGrupo }).WillCascadeOnDelete(false); // FK_T_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo
            HasRequired(a => a.TUsosComerciale).WithMany(b => b.TTiposMaterialesGruposArticuloes).HasForeignKey(c => c.IdUsoComercial).WillCascadeOnDelete(false); // FK_T_TiposMateriales_GruposArticulos_T_UsosComerciales
        }
    }
}