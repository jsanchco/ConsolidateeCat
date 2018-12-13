namespace eCat.Repository.Mapped
{
    public class PePlanesEditorialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PePlanesEditoriale>
    {
        public PePlanesEditorialeConfiguration()
            : this("dbo")
        {
        }

        public PePlanesEditorialeConfiguration(string schema)
        {
            ToTable("PE_PlanesEditoriales", schema);
            HasKey(x => x.IdPlanEditorial);

            Property(x => x.IdPlanEditorial).HasColumnName(@"IdPlanEditorial").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired();
            Property(x => x.IdCampaña).HasColumnName(@"IdCampaña").HasColumnType("int").IsRequired();
            Property(x => x.IdPmp).HasColumnName(@"IdPMP").HasColumnType("int").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.Usuario_UsuarioBaja).WithMany(b => b.PePlanesEditoriales_UsuarioBaja).HasForeignKey(c => c.UsuarioBaja).WillCascadeOnDelete(false); // FK_PE_PlanesEditoriales_Usuarios2
            HasOptional(a => a.Usuario_UsuarioModificacion).WithMany(b => b.PePlanesEditoriales_UsuarioModificacion).HasForeignKey(c => c.UsuarioModificacion).WillCascadeOnDelete(false); // FK_PE_PlanesEditoriales_Usuarios1
            HasRequired(a => a.E2AclDominio).WithMany(b => b.PePlanesEditoriales).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_PE_PlanesEditoriales_E2_ACL_DOMINIOS
            HasRequired(a => a.Usuario_UsuarioCreacion).WithMany(b => b.PePlanesEditoriales_UsuarioCreacion).HasForeignKey(c => c.UsuarioCreacion).WillCascadeOnDelete(false); // FK_PE_PlanesEditoriales_Usuarios
        }
    }
}