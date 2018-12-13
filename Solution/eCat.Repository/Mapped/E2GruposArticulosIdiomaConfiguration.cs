namespace eCat.Repository.Mapped
{
    public class E2GruposArticulosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GruposArticulosIdioma>
    {
        public E2GruposArticulosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2GruposArticulosIdiomaConfiguration(string schema)
        {
            ToTable("E2_GRUPOS_ARTICULOS_Idioma", schema);
            HasKey(x => new { x.CodigoGrupo, x.IdIdiomaInterface });

            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.E2GruposArticulo).WithMany(b => b.E2GruposArticulosIdioma).HasForeignKey(c => c.CodigoGrupo).WillCascadeOnDelete(false); // FK_E2_GRUPOS_ARTICULOS_Idioma_E2_GRUPOS_ARTICULOS
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.E2GruposArticulosIdioma).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_E2_GRUPOS_ARTICULOS_Idioma_T_Idiomas_Plataforma
        }
    }
}