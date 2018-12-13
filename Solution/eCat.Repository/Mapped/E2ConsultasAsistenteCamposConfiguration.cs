namespace eCat.Repository.Mapped
{
    public class E2ConsultasAsistenteCamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2ConsultasAsistenteCampos>
    {
        public E2ConsultasAsistenteCamposConfiguration()
            : this("dbo")
        {
        }

        public E2ConsultasAsistenteCamposConfiguration(string schema)
        {
            ToTable("E2_CONSULTAS_ASISTENTE_CAMPOS", schema);
            HasKey(x => new { x.IdConsulta, x.CodCampo });

            Property(x => x.IdConsulta).HasColumnName(@"IdConsulta").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodCampo).HasColumnName(@"CodCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2ConsultasAsistente).WithMany(b => b.E2ConsultasAsistenteCampos).HasForeignKey(c => c.IdConsulta).WillCascadeOnDelete(false); // FK_E2_CONSULTAS_ASISTENTE_CAMPOS_E2_CONSULTAS_ASISTENTE
        }
    }
}