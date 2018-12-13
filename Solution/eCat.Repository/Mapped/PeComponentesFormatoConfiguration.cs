namespace eCat.Repository.Mapped
{
    public class PeComponentesFormatoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesFormato>
    {
        public PeComponentesFormatoConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesFormatoConfiguration(string schema)
        {
            ToTable("PE_Componentes_Formatos", schema);
            HasKey(x => x.IdFormato);

            Property(x => x.IdFormato).HasColumnName(@"IdFormato").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}