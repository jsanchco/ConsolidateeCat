namespace eCat.Repository.Mapped
{
    public class EditorialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Editoriale>
    {
        public EditorialeConfiguration()
            : this("dbo")
        {
        }

        public EditorialeConfiguration(string schema)
        {
            ToTable("Editoriales", schema);
            HasKey(x => x.IdEditorial);

            Property(x => x.IdEditorial).HasColumnName(@"IdEditorial").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}