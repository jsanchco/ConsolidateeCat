namespace eCat.Repository.Mapped
{
    public class TTiposMaterialesGruposArticulosPaisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMaterialesGruposArticulosPais>
    {
        public TTiposMaterialesGruposArticulosPaisConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialesGruposArticulosPaisConfiguration(string schema)
        {
            ToTable("T_TiposMateriales_GruposArticulos_Paises", schema);
            HasKey(x => new { x.IdTipoMaterial, x.CodigoGrupo, x.IdPais });

            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.ProyectoGestion).HasColumnName(@"ProyectoGestion").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2AclDominio).WithMany(b => b.TTiposMaterialesGruposArticulosPais).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_T_TiposMateriales_GruposArticulos_Paises_E2_ACL_DOMINIOS
            HasRequired(a => a.TTiposMaterialesGruposArticulosPrefijo).WithMany(b => b.TTiposMaterialesGruposArticulosPais).HasForeignKey(c => new { c.IdTipoMaterial, c.CodigoGrupo }).WillCascadeOnDelete(false); // FK_T_TiposMateriales_GruposArticulos_Paises_T_TiposMateriales_GruposArticulos_Prefijo
        }
    }
}