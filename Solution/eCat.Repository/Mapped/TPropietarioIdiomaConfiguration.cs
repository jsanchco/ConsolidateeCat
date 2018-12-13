namespace eCat.Repository.Mapped
{
    public class TPropietarioIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPropietarioIdioma>
    {
        public TPropietarioIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TPropietarioIdiomaConfiguration(string schema)
        {
            ToTable("T_Propietario_Idioma", schema);
            HasKey(x => new { x.Codigo, x.IdIdiomaInterface });

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TPropietarioIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Propietario_Idioma_T_Idiomas_Plataforma
        }
    }
}