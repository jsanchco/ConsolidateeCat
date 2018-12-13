namespace eCat.Repository.Mapped
{
    public class E2AclDominiosJerarquiasLineaNegocioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclDominiosJerarquiasLineaNegocio>
    {
        public E2AclDominiosJerarquiasLineaNegocioConfiguration()
            : this("dbo")
        {
        }

        public E2AclDominiosJerarquiasLineaNegocioConfiguration(string schema)
        {
            ToTable("E2_ACL_DOMINIOS_JERARQUIAS_LineaNegocio", schema);
            HasKey(x => new { x.IdDominioJerarquia, x.IdLineaNegocio });

            Property(x => x.IdDominioJerarquia).HasColumnName(@"IdDominioJerarquia").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdLineaNegocio).HasColumnName(@"IdLineaNegocio").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}