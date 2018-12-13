namespace eCat.Repository.Mapped
{
    public class PePmpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PePmp>
    {
        public PePmpConfiguration()
            : this("dbo")
        {
        }

        public PePmpConfiguration(string schema)
        {
            ToTable("PE_PMPs", schema);
            HasKey(x => x.IdPmp);

            Property(x => x.IdPmp).HasColumnName(@"IdPMP").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2559);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired();
            Property(x => x.IdCampañaInicial).HasColumnName(@"IdCampañaInicial").HasColumnType("smallint").IsRequired();
            Property(x => x.IdCampañaFinal).HasColumnName(@"IdCampañaFinal").HasColumnType("smallint").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasOptional(a => a.Usuario_UsuarioBaja).WithMany(b => b.PePmps_UsuarioBaja).HasForeignKey(c => c.UsuarioBaja).WillCascadeOnDelete(false); // FK_PE_PMPs_Usuarios2
            HasOptional(a => a.Usuario_UsuarioModificacion).WithMany(b => b.PePmps_UsuarioModificacion).HasForeignKey(c => c.UsuarioModificacion).WillCascadeOnDelete(false); // FK_PE_PMPs_Usuarios1
            HasRequired(a => a.E2AclDominio).WithMany(b => b.PePmps).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_PE_PMPs_E2_ACL_DOMINIOS
            HasRequired(a => a.TCampañas_IdCampañaFinal).WithMany(b => b.PePmps_IdCampañaFinal).HasForeignKey(c => c.IdCampañaFinal).WillCascadeOnDelete(false); // FK_PE_PMPs_T_Campañas1
            HasRequired(a => a.TCampañas_IdCampañaInicial).WithMany(b => b.PePmps_IdCampañaInicial).HasForeignKey(c => c.IdCampañaInicial).WillCascadeOnDelete(false); // FK_PE_PMPs_T_Campañas
            HasRequired(a => a.Usuario_UsuarioCreacion).WithMany(b => b.PePmps_UsuarioCreacion).HasForeignKey(c => c.UsuarioCreacion).WillCascadeOnDelete(false); // FK_PE_PMPs_Usuarios
        }
    }
}