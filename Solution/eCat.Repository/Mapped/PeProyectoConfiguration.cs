namespace eCat.Repository.Mapped
{
    public class PeProyectoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyecto>
    {
        public PeProyectoConfiguration()
            : this("dbo")
        {
        }

        public PeProyectoConfiguration(string schema)
        {
            ToTable("PE_Proyectos", schema);
            HasKey(x => x.IdProyecto);

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdPlanEditorial).HasColumnName(@"IdPlanEditorial").HasColumnType("int").IsRequired();
            Property(x => x.IdProyectoMarco).HasColumnName(@"IdProyectoMarco").HasColumnType("int").IsOptional();
            Property(x => x.IdEstructuraNnee).HasColumnName(@"IdEstructuraNNEE").HasColumnType("int").IsOptional();
            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.PeEstructuraEdade).WithMany(b => b.PeProyectoes).HasForeignKey(c => c.IdEstructuraNnee).WillCascadeOnDelete(false); // FK_PE_Proyectos_PE_EstructuraEdades
            HasOptional(a => a.PeProyectosEstado).WithMany(b => b.PeProyectoes).HasForeignKey(c => c.IdEstado).WillCascadeOnDelete(false); // FK_PE_Proyectos_PE_Proyectos_Estados
            HasOptional(a => a.PeProyectosMarco).WithMany(b => b.PeProyectoes).HasForeignKey(c => c.IdProyectoMarco).WillCascadeOnDelete(false); // FK_PE_Proyectos_PE_ProyectosMarco
            HasOptional(a => a.Usuario_UsuarioBaja).WithMany(b => b.PeProyectoes_UsuarioBaja).HasForeignKey(c => c.UsuarioBaja).WillCascadeOnDelete(false); // FK_PE_Proyectos_Usuarios2
            HasOptional(a => a.Usuario_UsuarioModificacion).WithMany(b => b.PeProyectoes_UsuarioModificacion).HasForeignKey(c => c.UsuarioModificacion).WillCascadeOnDelete(false); // FK_PE_Proyectos_Usuarios1
            HasRequired(a => a.PePlanesEditoriale).WithMany(b => b.PeProyectoes).HasForeignKey(c => c.IdPlanEditorial).WillCascadeOnDelete(false); // FK_PE_Proyectos_PE_PlanesEditoriales
            HasRequired(a => a.Usuario_UsuarioCreacion).WithMany(b => b.PeProyectoes_UsuarioCreacion).HasForeignKey(c => c.UsuarioCreacion).WillCascadeOnDelete(false); // FK_PE_Proyectos_Usuarios
        }
    }
}