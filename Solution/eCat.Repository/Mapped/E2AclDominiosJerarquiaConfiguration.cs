namespace eCat.Repository.Mapped
{
    public class E2AclDominiosJerarquiaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclDominiosJerarquia>
    {
        public E2AclDominiosJerarquiaConfiguration()
            : this("dbo")
        {
        }

        public E2AclDominiosJerarquiaConfiguration(string schema)
        {
            ToTable("E2_ACL_DOMINIOS_JERARQUIAS", schema);
            HasKey(x => x.IdDominioJerarquia);

            Property(x => x.IdDominioJerarquia).HasColumnName(@"IdDominioJerarquia").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dominio).HasColumnName(@"DOMINIO").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired();
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.PermiteAlta).HasColumnName(@"PermiteAlta").HasColumnType("bit").IsRequired();
            Property(x => x.PermiteComercializacion).HasColumnName(@"PermiteComercializacion").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2ClasificacionesGestion).WithMany(b => b.E2AclDominiosJerarquia).HasForeignKey(c => c.IdCatalogo).WillCascadeOnDelete(false); // FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_CLASIFICACIONES_GESTION
            HasRequired(a => a.E2RamasClasificacionesGestion).WithMany(b => b.E2AclDominiosJerarquia).HasForeignKey(c => new { c.IdCatalogo, c.IdClasificacion }).WillCascadeOnDelete(false); // FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_RAMAS_CLASIFICACIONES_GESTION
        }
    }
}