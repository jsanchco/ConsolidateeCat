namespace eCat.Repository.Mapped
{
    public class PeTitulosPrincipaleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeTitulosPrincipale>
    {
        public PeTitulosPrincipaleConfiguration()
            : this("dbo")
        {
        }

        public PeTitulosPrincipaleConfiguration(string schema)
        {
            ToTable("PE_TitulosPrincipales", schema);
            HasKey(x => x.IdTituloPrincipal);

            Property(x => x.IdTituloPrincipal).HasColumnName(@"IdTituloPrincipal").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("bigint").IsRequired();
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired();
            Property(x => x.CodEdad).HasColumnName(@"CodEdad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodEtapa).HasColumnName(@"CodEtapa").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodCiclo).HasColumnName(@"CodCiclo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodCurso).HasColumnName(@"CodCurso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.IdAreaGlobal).HasColumnName(@"IdAreaGlobal").HasColumnType("smallint").IsRequired();
            Property(x => x.CodMateria).HasColumnName(@"CodMateria").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.PeProyecto).WithMany(b => b.PeTitulosPrincipales).HasForeignKey(c => c.IdProyecto).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_PE_Proyectos
            HasRequired(a => a.PeTitulosPrincipalesEstado).WithMany(b => b.PeTitulosPrincipales).HasForeignKey(c => c.IdEstado).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_PE_TitulosPrincipales_Estados
        }
    }
}