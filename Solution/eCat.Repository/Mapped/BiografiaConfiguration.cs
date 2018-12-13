namespace eCat.Repository.Mapped
{
    public class BiografiaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Biografia>
    {
        public BiografiaConfiguration()
            : this("dbo")
        {
        }

        public BiografiaConfiguration(string schema)
        {
            ToTable("Biografias", schema);
            HasKey(x => x.IdPersona);

            Property(x => x.IdPersona).HasColumnName(@"IDPersona").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Foto).HasColumnName(@"Foto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Sinopsis).HasColumnName(@"Sinopsis").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.Persona).WithOptional(b => b.Biografia).WillCascadeOnDelete(false); // FK_Biografias_Personas
        }
    }
}