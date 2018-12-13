namespace eCat.Repository.Mapped
{
    public class TTiposMaterialesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMaterialesIdioma>
    {
        public TTiposMaterialesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialesIdiomaConfiguration(string schema)
        {
            ToTable("T_TiposMateriales_Idioma", schema);
            HasKey(x => new { x.IdTipoMaterial, x.IdIdiomaInterface });

            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TTiposMaterialesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_TiposMateriales_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TTiposMateriale).WithMany(b => b.TTiposMaterialesIdiomas).HasForeignKey(c => c.IdTipoMaterial).WillCascadeOnDelete(false); // FK_T_TiposMateriales_Idioma_T_TiposMateriales
        }
    }
}