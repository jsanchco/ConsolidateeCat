namespace eCat.Repository.Mapped
{
    public class CoEditorialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.CoEditoriale>
    {
        public CoEditorialeConfiguration()
            : this("dbo")
        {
        }

        public CoEditorialeConfiguration(string schema)
        {
            ToTable("CoEditoriales", schema);
            HasKey(x => x.IdCoEditorial);

            Property(x => x.IdCoEditorial).HasColumnName(@"IDCoEditorial").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CoEditorial).HasColumnName(@"CoEditorial").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Url).HasColumnName(@"URL").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.EsEditorialGrupo).HasColumnName(@"EsEditorialGrupo").HasColumnType("bit").IsRequired();
            Property(x => x.PorcentajeCoedicion).HasColumnName(@"PorcentajeCoedicion").HasColumnType("tinyint").IsOptional();
        }
    }
}