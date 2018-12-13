namespace eCat.Repository.Mapped
{
    public class DilveEditorialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveEditoriale>
    {
        public DilveEditorialeConfiguration()
            : this("dbo")
        {
        }

        public DilveEditorialeConfiguration(string schema)
        {
            ToTable("DILVE_Editoriales", schema);
            HasKey(x => x.IdEditorialDilve);

            Property(x => x.IdEditorialDilve).HasColumnName(@"IdEditorialDILVE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoEditorialDilve).HasColumnName(@"CodigoEditorialDILVE").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.TPropietarios).WithMany(t => t.DilveEditoriales).Map(m =>
            {
                m.ToTable("DILVE_Editoriales_Equivalencias", "dbo");
                m.MapLeftKey("IdEditorialDILVE");
                m.MapRightKey("IdPropietario");
            });
        }
    }
}