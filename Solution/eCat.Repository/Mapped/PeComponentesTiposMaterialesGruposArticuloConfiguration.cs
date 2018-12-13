namespace eCat.Repository.Mapped
{
    public class PeComponentesTiposMaterialesGruposArticuloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesTiposMaterialesGruposArticulo>
    {
        public PeComponentesTiposMaterialesGruposArticuloConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesTiposMaterialesGruposArticuloConfiguration(string schema)
        {
            ToTable("PE_Componentes_TiposMateriales_GruposArticulos", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdFormato).HasColumnName(@"IdFormato").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdDestino).HasColumnName(@"IdDestino").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsoComercial).HasColumnName(@"IdUsoComercial").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdTipo).HasColumnName(@"IdTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsRequired();
            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9);
            Property(x => x.IdTipoMaterialEducativo).HasColumnName(@"IdTipoMaterialEducativo").HasColumnType("tinyint").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.TUsosComerciale).WithMany(b => b.PeComponentesTiposMaterialesGruposArticuloes).HasForeignKey(c => c.IdUsoComercial).WillCascadeOnDelete(false); // FK_PE_Componentes_TiposMateriales_GruposArticulos_T_UsosComerciales
            HasRequired(a => a.PeComponentesDestino).WithMany(b => b.PeComponentesTiposMaterialesGruposArticuloes).HasForeignKey(c => c.IdDestino).WillCascadeOnDelete(false); // FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Destinos
            HasRequired(a => a.PeComponentesFormato).WithMany(b => b.PeComponentesTiposMaterialesGruposArticuloes).HasForeignKey(c => c.IdFormato).WillCascadeOnDelete(false); // FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Formatos
            HasRequired(a => a.PeComponentesTipos).WithMany(b => b.PeComponentesTiposMaterialesGruposArticuloes).HasForeignKey(c => c.IdTipo).WillCascadeOnDelete(false); // FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Tipos
            HasRequired(a => a.TTiposMaterialesGruposArticulosPrefijo).WithMany(b => b.PeComponentesTiposMaterialesGruposArticuloes).HasForeignKey(c => new { c.IdTipoMaterial, c.CodigoGrupo }).WillCascadeOnDelete(false); // FK_PE_Componentes_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo
        }
    }
}