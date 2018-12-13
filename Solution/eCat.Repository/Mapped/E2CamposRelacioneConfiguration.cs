namespace eCat.Repository.Mapped
{
    public class E2CamposRelacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2CamposRelacione>
    {
        public E2CamposRelacioneConfiguration()
            : this("dbo")
        {
        }

        public E2CamposRelacioneConfiguration(string schema)
        {
            ToTable("E2_CAMPOS_RELACIONES", schema);
            HasKey(x => x.IdCampoRelacion);

            Property(x => x.IdCampoRelacion).HasColumnName(@"IdCampoRelacion").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodConsulta).HasColumnName(@"COD_CONSULTA").HasColumnType("tinyint").IsRequired();
            Property(x => x.CodCampo).HasColumnName(@"COD_CAMPO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Tabla).HasColumnName(@"TABLA").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CampoTabla).HasColumnName(@"CAMPO_TABLA").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.TablaRelacion).HasColumnName(@"TABLA_RELACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CampoRelacion).HasColumnName(@"CAMPO_RELACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nivel).HasColumnName(@"NIVEL").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comparacion).HasColumnName(@"COMPARACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.E2CamposConsulta).WithMany(b => b.E2CamposRelacione).HasForeignKey(c => c.CodCampo).WillCascadeOnDelete(false); // FK_E2_CAMPOS_RELACIONES_E2_CAMPOS_CONSULTA
        }
    }
}