namespace eCat.Repository.Mapped
{
    public class AuditoriaBusquedaGeneralConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.AuditoriaBusquedaGeneral>
    {
        public AuditoriaBusquedaGeneralConfiguration()
            : this("dbo")
        {
        }

        public AuditoriaBusquedaGeneralConfiguration(string schema)
        {
            ToTable("Auditoria_BusquedaGeneral", schema);
            HasKey(x => x.IdAuditoria);

            Property(x => x.IdAuditoria).HasColumnName(@"IdAuditoria").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FechaAuditoria).HasColumnName(@"FechaAuditoria").HasColumnType("datetime").IsRequired();
            Property(x => x.Dominio).HasColumnName(@"Dominio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CodigoAutorTitulo).HasColumnName(@"CodigoAutorTitulo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.PalabrasClave).HasColumnName(@"PalabrasClave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.TipoMaterial).HasColumnName(@"TipoMaterial").HasColumnType("int").IsOptional();
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("int").IsOptional();
            Property(x => x.Sello).HasColumnName(@"Sello").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Etapa).HasColumnName(@"Etapa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Materia).HasColumnName(@"Materia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Edad).HasColumnName(@"Edad").HasColumnType("int").IsOptional();
            Property(x => x.Proyecto).HasColumnName(@"Proyecto").HasColumnType("int").IsOptional();
            Property(x => x.Coleccion).HasColumnName(@"Coleccion").HasColumnType("int").IsOptional();
            Property(x => x.TextoLibre).HasColumnName(@"TextoLibre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Contenido).HasColumnName(@"Contenido").HasColumnType("bit").IsOptional();
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }
}