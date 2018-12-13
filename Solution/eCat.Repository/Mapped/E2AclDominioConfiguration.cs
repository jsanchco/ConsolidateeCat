namespace eCat.Repository.Mapped
{
    public class E2AclDominioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclDominio>
    {
        public E2AclDominioConfiguration()
            : this("dbo")
        {
        }

        public E2AclDominioConfiguration(string schema)
        {
            ToTable("E2_ACL_DOMINIOS", schema);
            HasKey(x => x.IdDominio);

            Property(x => x.IdDominio).HasColumnName(@"IdDominio").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dominio).HasColumnName(@"DOMINIO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Visible).HasColumnName(@"Visible").HasColumnType("bit").IsRequired();
            Property(x => x.IncluidoSap).HasColumnName(@"IncluidoSAP").HasColumnType("bit").IsRequired();
            Property(x => x.Prefijo).HasColumnName(@"Prefijo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Icono).HasColumnName(@"Icono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Dominio2000).HasColumnName(@"Dominio2000").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IncluidoPs).HasColumnName(@"IncluidoPS").HasColumnType("bit").IsRequired();
            Property(x => x.IdArbol).HasColumnName(@"IdArbol").HasColumnType("int").IsOptional();
            HasMany(t => t.LineaNegocios).WithMany(t => t.E2AclDominio).Map(m =>
            {
                m.ToTable("T_Dominios_LineasNegocio", "dbo");
                m.MapLeftKey("IdDominio");
                m.MapRightKey("IdLineaNegocio");
            });
        }
    }
}