namespace eCat.Repository.Mapped
{
    public class PersonaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Persona>
    {
        public PersonaConfiguration()
            : this("dbo")
        {
        }

        public PersonaConfiguration(string schema)
        {
            ToTable("Personas", schema);
            HasKey(x => x.IdPersona);

            Property(x => x.IdPersona).HasColumnName(@"IDPersona").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Apellidos).HasColumnName(@"Apellidos").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Nacionalidad).HasColumnName(@"Nacionalidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.FechaNacimiento).HasColumnName(@"FechaNacimiento").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaFallecimiento).HasColumnName(@"FechaFallecimiento").HasColumnType("datetime").IsOptional();
            Property(x => x.Sexo).HasColumnName(@"Sexo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Url).HasColumnName(@"URL").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}