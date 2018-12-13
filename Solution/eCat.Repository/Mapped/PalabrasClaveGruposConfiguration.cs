namespace eCat.Repository.Mapped
{
    public class PalabrasClaveGruposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PalabrasClaveGrupos>
    {
        public PalabrasClaveGruposConfiguration()
            : this("dbo")
        {
        }

        public PalabrasClaveGruposConfiguration(string schema)
        {
            ToTable("PalabrasClaveGrupos", schema);
            HasKey(x => x.IdGrupoPalabraClave);

            Property(x => x.IdGrupoPalabraClave).HasColumnName(@"IdGrupoPalabraClave").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}