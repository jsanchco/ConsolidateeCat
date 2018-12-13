namespace eCat.Repository.Mapped
{
    public class E2LineasproductoIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2LineasproductoIdioma>
    {
        public E2LineasproductoIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2LineasproductoIdiomaConfiguration(string schema)
        {
            ToTable("E2_LINEASPRODUCTO_Idioma", schema);
            HasKey(x => new { x.CodLineaP, x.IdIdiomaInterface });

            Property(x => x.CodLineaP).HasColumnName(@"COD_lineaP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.E2LineasproductoIdioma).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_E2_LINEASPRODUCTO_Idioma_T_Idiomas_Plataforma
        }
    }
}