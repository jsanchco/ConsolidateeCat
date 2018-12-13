namespace eCat.Repository.Mapped
{
    public class PeTitulosPrincipalesEstadosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeTitulosPrincipalesEstadosIdioma>
    {
        public PeTitulosPrincipalesEstadosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeTitulosPrincipalesEstadosIdiomaConfiguration(string schema)
        {
            ToTable("PE_TitulosPrincipales_Estados_Idioma", schema);
            HasKey(x => new { x.IdEstado, x.IdIdiomaInterface });

            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.PeTitulosPrincipalesEstado).WithMany(b => b.PeTitulosPrincipalesEstadosIdiomas).HasForeignKey(c => c.IdEstado).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_Estados_Idioma_PE_TitulosPrincipales_Estados
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeTitulosPrincipalesEstadosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_Estados_Idioma_T_Idiomas_Plataforma
        }
    }
}