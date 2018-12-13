namespace eCat.Repository.Mapped
{
    public class TUsosComercialesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TUsosComercialesIdioma>
    {
        public TUsosComercialesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TUsosComercialesIdiomaConfiguration(string schema)
        {
            ToTable("T_UsosComerciales_Idioma", schema);
            HasKey(x => new { x.IdUsoComercial, x.IdIdiomaInterface });

            Property(x => x.IdUsoComercial).HasColumnName(@"IdUsoComercial").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TUsosComercialesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_UsosComerciales_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TUsosComerciale).WithMany(b => b.TUsosComercialesIdiomas).HasForeignKey(c => c.IdUsoComercial).WillCascadeOnDelete(false); // FK_T_UsosComerciales_Idioma_T_UsosComerciales
        }
    }
}