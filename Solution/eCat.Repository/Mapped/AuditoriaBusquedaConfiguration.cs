namespace eCat.Repository.Mapped
{
    public class AuditoriaBusquedaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.AuditoriaBusqueda>
    {
        public AuditoriaBusquedaConfiguration()
            : this("dbo")
        {
        }

        public AuditoriaBusquedaConfiguration(string schema)
        {
            ToTable("Auditoria_Busquedas", schema);
            HasKey(x => x.IdAuditoriaBusquedas);

            Property(x => x.IdAuditoriaBusquedas).HasColumnName(@"IdAuditoriaBusquedas").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FechaAuditoria).HasColumnName(@"FechaAuditoria").HasColumnType("datetime").IsRequired();
            Property(x => x.Dominio).HasColumnName(@"Dominio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Autor).HasColumnName(@"Autor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Isbn).HasColumnName(@"ISBN").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Editorial).HasColumnName(@"Editorial").HasColumnType("int").IsOptional();
            Property(x => x.AnnoEdicion).HasColumnName(@"AnnoEdicion").HasColumnType("int").IsOptional();
            Property(x => x.Etapa).HasColumnName(@"Etapa").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Materia).HasColumnName(@"Materia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Coleccion).HasColumnName(@"Coleccion").HasColumnType("int").IsOptional();
            Property(x => x.Serie).HasColumnName(@"Serie").HasColumnType("int").IsOptional();
            Property(x => x.Edad).HasColumnName(@"Edad").HasColumnType("int").IsOptional();
            Property(x => x.Proyecto).HasColumnName(@"Proyecto").HasColumnType("int").IsOptional();
            Property(x => x.Pagina).HasColumnName(@"Pagina").HasColumnType("int").IsOptional();
            Property(x => x.MaterialesPagina).HasColumnName(@"MaterialesPagina").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Sentido).HasColumnName(@"Sentido").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TextoLibre).HasColumnName(@"TextoLibre").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Contenido).HasColumnName(@"Contenido").HasColumnType("bit").IsOptional();
            Property(x => x.DominioUsuario).HasColumnName(@"DominioUsuario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DominioExcluyente).HasColumnName(@"DominioExcluyente").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TipoBusqueda).HasColumnName(@"TipoBusqueda").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("int").IsOptional();
            Property(x => x.TipoMaterial).HasColumnName(@"TipoMaterial").HasColumnType("int").IsOptional();
            Property(x => x.PalabrasClave).HasColumnName(@"PalabrasClave").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Propietario).HasColumnName(@"Propietario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
        }
    }
}