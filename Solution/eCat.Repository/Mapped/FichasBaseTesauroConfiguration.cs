namespace eCat.Repository.Mapped
{
    public class FichasBaseTesauroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseTesauro>
    {
        public FichasBaseTesauroConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseTesauroConfiguration(string schema)
        {
            ToTable("FichasBase_Tesauro", schema);
            HasKey(x => x.IdTesauroLibro);

            Property(x => x.IdTesauroLibro).HasColumnName(@"IDTesauroLibro").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.IdArbol).HasColumnName(@"IDArbol").HasColumnType("int").IsRequired();
            Property(x => x.Clasificacion).HasColumnName(@"Clasificacion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.IdTipo).HasColumnName(@"IdTipo").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseTesauroes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_Tesauro_FichasBase
        }
    }
}