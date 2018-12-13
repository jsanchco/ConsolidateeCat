namespace eCat.Repository.Mapped
{
    public class E2MensajeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2Mensaje>
    {
        public E2MensajeConfiguration()
            : this("dbo")
        {
        }

        public E2MensajeConfiguration(string schema)
        {
            ToTable("E2_MENSAJES", schema);
            HasKey(x => x.IdMensaje);

            Property(x => x.IdMensaje).HasColumnName(@"IDMensaje").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdUsuarioDe).HasColumnName(@"IDUsuarioDe").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdUsuarioPara).HasColumnName(@"IDUsuarioPara").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Asunto).HasColumnName(@"Asunto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Mensaje).HasColumnName(@"Mensaje").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Importancia).HasColumnName(@"Importancia").HasColumnType("tinyint").IsRequired();
            Property(x => x.Repetir).HasColumnName(@"Repetir").HasColumnType("bit").IsRequired();
            Property(x => x.FechaEnvio).HasColumnName(@"FechaEnvio").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaDesactivado).HasColumnName(@"FechaDesactivado").HasColumnType("datetime").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();
        }
    }
}