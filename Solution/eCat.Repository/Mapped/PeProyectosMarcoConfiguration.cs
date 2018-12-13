namespace eCat.Repository.Mapped
{
    public class PeProyectosMarcoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosMarco>
    {
        public PeProyectosMarcoConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosMarcoConfiguration(string schema)
        {
            ToTable("PE_ProyectosMarco", schema);
            HasKey(x => x.IdProyectoMarco);

            Property(x => x.IdProyectoMarco).HasColumnName(@"IdProyectoMarco").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired();
            Property(x => x.IdCampañaInicial).HasColumnName(@"IdCampañaInicial").HasColumnType("smallint").IsRequired();
            Property(x => x.IdProyectoMarcoOrigen).HasColumnName(@"IdProyectoMarcoOrigen").HasColumnType("int").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.PeProyectosMarco_IdProyectoMarcoOrigen).WithMany(b => b.PeProyectosMarcoes).HasForeignKey(c => c.IdProyectoMarcoOrigen).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_PE_ProyectosMarco
            HasOptional(a => a.Usuario_UsuarioBaja).WithMany(b => b.PeProyectosMarcoes_UsuarioBaja).HasForeignKey(c => c.UsuarioBaja).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_Usuarios2
            HasOptional(a => a.Usuario_UsuarioModificacion).WithMany(b => b.PeProyectosMarcoes_UsuarioModificacion).HasForeignKey(c => c.UsuarioModificacion).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_Usuarios1
            HasRequired(a => a.E2AclDominio).WithMany(b => b.PeProyectosMarcoes).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_E2_ACL_DOMINIOS
            HasRequired(a => a.TCampañas).WithMany(b => b.PeProyectosMarcoes).HasForeignKey(c => c.IdCampañaInicial).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_T_Campañas
            HasRequired(a => a.Usuario_UsuarioCreacion).WithMany(b => b.PeProyectosMarcoes_UsuarioCreacion).HasForeignKey(c => c.UsuarioCreacion).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_Usuarios
        }
    }
}