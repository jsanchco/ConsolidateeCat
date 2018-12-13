namespace eCat.Repository.Mapped
{
    public class PeTitulosPrincipalesComponenteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeTitulosPrincipalesComponente>
    {
        public PeTitulosPrincipalesComponenteConfiguration()
            : this("dbo")
        {
        }

        public PeTitulosPrincipalesComponenteConfiguration(string schema)
        {
            ToTable("PE_TitulosPrincipales_Componentes", schema);
            HasKey(x => new { x.IdTituloPrincipal, x.IdComponente });

            Property(x => x.IdTituloPrincipal).HasColumnName(@"IdTituloPrincipal").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdComponente).HasColumnName(@"IdComponente").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeComponente).WithMany(b => b.PeTitulosPrincipalesComponentes).HasForeignKey(c => c.IdComponente).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_Componentes_PE_Componentes
            HasRequired(a => a.PeTitulosPrincipale).WithMany(b => b.PeTitulosPrincipalesComponentes).HasForeignKey(c => c.IdTituloPrincipal).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_Componentes_PE_TitulosPrincipales
        }
    }
}