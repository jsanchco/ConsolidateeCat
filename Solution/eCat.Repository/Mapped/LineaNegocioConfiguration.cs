namespace eCat.Repository.Mapped
{
    public class LineaNegocioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.LineaNegocio>
    {
        public LineaNegocioConfiguration()
            : this("dbo")
        {
        }

        public LineaNegocioConfiguration(string schema)
        {
            ToTable("LineaNegocio", schema);
            HasKey(x => x.IdLineaNegocio);

            Property(x => x.IdLineaNegocio).HasColumnName(@"IdLineaNegocio").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodigoLineaNegocio).HasColumnName(@"CodigoLineaNegocio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Url).HasColumnName(@"URL").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            HasMany(t => t.TProyectosGestions).WithMany(t => t.LineaNegocios).Map(m =>
            {
                m.ToTable("T_ProyectosGestion_LineaNegocio", "dbo");
                m.MapLeftKey("IdLineaNegocio");
                m.MapRightKey("IdProyectoGestion");
            });
            HasMany(t => t.PePlanesEditoriales).WithMany(t => t.LineaNegocios).Map(m =>
            {
                m.ToTable("PE_PlanesEditoriales_LineaNegocio", "dbo");
                m.MapLeftKey("IdLineaNegocio");
                m.MapRightKey("IdPlanEditorial");
            });
            HasMany(t => t.PeProyectoes).WithMany(t => t.LineaNegocios).Map(m =>
            {
                m.ToTable("PE_Proyectos_LineaNegocio", "dbo");
                m.MapLeftKey("IdLineanegocio");
                m.MapRightKey("IdProyecto");
            });
            HasMany(t => t.TProyectoes).WithMany(t => t.LineaNegocios).Map(m =>
            {
                m.ToTable("T_Proyectos_LineaNegocio", "dbo");
                m.MapLeftKey("IdLineaNegocio");
                m.MapRightKey("IdProyecto");
            });
            HasMany(t => t.TSeries).WithMany(t => t.LineaNegocios).Map(m =>
            {
                m.ToTable("T_Series_LineasNegocio", "dbo");
                m.MapLeftKey("IdLineaNegocio");
                m.MapRightKey("IdSerie");
            });
            HasMany(t => t.Usuarios).WithMany(t => t.LineaNegocios).Map(m =>
            {
                m.ToTable("T_Usuarios_LineaNegocio", "dbo");
                m.MapLeftKey("IdLineaNegocio");
                m.MapRightKey("IdUsuario");
            });
        }
    }
}