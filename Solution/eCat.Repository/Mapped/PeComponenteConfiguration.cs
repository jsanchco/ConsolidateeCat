namespace eCat.Repository.Mapped
{
    public class PeComponenteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponente>
    {
        public PeComponenteConfiguration()
            : this("dbo")
        {
        }

        public PeComponenteConfiguration(string schema)
        {
            ToTable("PE_Componentes", schema);
            HasKey(x => x.IdComponente);

            Property(x => x.IdComponente).HasColumnName(@"IdComponente").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdTituloPrincipal).HasColumnName(@"IdTituloPrincipal").HasColumnType("bigint").IsRequired();
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdFormato).HasColumnName(@"IdFormato").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdDestino).HasColumnName(@"IdDestino").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsoComercial).HasColumnName(@"IdUsoComercial").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdTipo).HasColumnName(@"IdTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.TUsosComerciale).WithMany(b => b.PeComponentes).HasForeignKey(c => c.IdUsoComercial).WillCascadeOnDelete(false); // FK_PE_Componentes_T_UsosComerciales
            HasRequired(a => a.PeComponentesDestino).WithMany(b => b.PeComponentes).HasForeignKey(c => c.IdDestino).WillCascadeOnDelete(false); // FK_PE_Componentes_PE_Componentes_Destinos
            HasRequired(a => a.PeComponentesEstado).WithMany(b => b.PeComponentes).HasForeignKey(c => c.IdEstado).WillCascadeOnDelete(false); // FK_PE_Componentes_PE_Componentes_Estados
            HasRequired(a => a.PeComponentesFormato).WithMany(b => b.PeComponentes).HasForeignKey(c => c.IdFormato).WillCascadeOnDelete(false); // FK_PE_Componentes_PE_Componentes_Formatos
            HasRequired(a => a.PeComponentesTipos).WithMany(b => b.PeComponentes).HasForeignKey(c => c.IdTipo).WillCascadeOnDelete(false); // FK_PE_Componentes_PE_Componentes_Tipos
            HasRequired(a => a.PeTitulosPrincipale).WithMany(b => b.PeComponentes).HasForeignKey(c => c.IdTituloPrincipal).WillCascadeOnDelete(false); // FK_PE_Componentes_PE_TitulosPrincipales
        }
    }
}