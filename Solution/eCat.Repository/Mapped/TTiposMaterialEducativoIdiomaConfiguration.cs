namespace eCat.Repository.Mapped
{
    public class TTiposMaterialEducativoIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMaterialEducativoIdioma>
    {
        public TTiposMaterialEducativoIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialEducativoIdiomaConfiguration(string schema)
        {
            ToTable("T_TiposMaterialEducativo_Idioma", schema);
            HasKey(x => new { x.IdTipoMaterialEducativo, x.IdIdiomaInterface });

            Property(x => x.IdTipoMaterialEducativo).HasColumnName(@"IdTipoMaterialEducativo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TTiposMaterialEducativoIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_TiposMaterialEducativo_Idioma_T_Idiomas_Plataforma
        }
    }
}