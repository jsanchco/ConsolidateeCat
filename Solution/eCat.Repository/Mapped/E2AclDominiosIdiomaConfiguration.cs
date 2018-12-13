namespace eCat.Repository.Mapped
{
    public class E2AclDominiosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2AclDominiosIdioma>
    {
        public E2AclDominiosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2AclDominiosIdiomaConfiguration(string schema)
        {
            ToTable("E2_ACL_DOMINIOS_Idioma", schema);
            HasKey(x => new { x.IdDominio, x.IdIdiomaInterface });

            Property(x => x.IdDominio).HasColumnName(@"IdDominio").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.E2AclDominio).WithMany(b => b.E2AclDominiosIdioma).HasForeignKey(c => c.IdDominio).WillCascadeOnDelete(false); // FK_E2_ACL_DOMINIOS_Idioma_E2_ACL_DOMINIOS
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.E2AclDominiosIdioma).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_E2_ACL_DOMINIOS_Idioma_T_Idiomas_Plataforma
        }
    }
}