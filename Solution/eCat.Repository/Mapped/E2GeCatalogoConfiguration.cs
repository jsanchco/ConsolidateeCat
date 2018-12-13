namespace eCat.Repository.Mapped
{
    public class E2GeCatalogoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GeCatalogo>
    {
        public E2GeCatalogoConfiguration()
            : this("dbo")
        {
        }

        public E2GeCatalogoConfiguration(string schema)
        {
            ToTable("E2_GE_CATALOGOS", schema);
            HasKey(x => x.IdCatalogo);

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NombreCatalogo).HasColumnName(@"Nombre_Catalogo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.EstiloLibre).HasColumnName(@"EstiloLibre").HasColumnType("bit").IsRequired();
            Property(x => x.Campos).HasColumnName(@"Campos").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Publicado).HasColumnName(@"Publicado").HasColumnType("bit").IsRequired();
            Property(x => x.PendientePublicar).HasColumnName(@"PendientePublicar").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaPublicacion).HasColumnName(@"FechaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioPublicacion).HasColumnName(@"UsuarioPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaUltimaPublicacion).HasColumnName(@"FechaUltimaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioUltimaPublicacion).HasColumnName(@"UsuarioUltimaPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaActualizacion).HasColumnName(@"FechaActualizacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioActualizacion).HasColumnName(@"UsuarioActualizacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaRetirada).HasColumnName(@"FechaRetirada").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioRetirada).HasColumnName(@"UsuarioRetirada").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Equivalencias).HasColumnName(@"Equivalencias").HasColumnType("bit").IsRequired();
            Property(x => x.Bloqueado).HasColumnName(@"Bloqueado").HasColumnType("bit").IsRequired();
            Property(x => x.Notificacion).HasColumnName(@"Notificacion").HasColumnType("bit").IsRequired();
            Property(x => x.XmlFicha).HasColumnName(@"XMLFicha").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8000);
            Property(x => x.CodigoOrden1).HasColumnName(@"CodigoOrden1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.CodigoOrden2).HasColumnName(@"CodigoOrden2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.TipoOrden1).HasColumnName(@"TipoOrden1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.TipoOrden2).HasColumnName(@"TipoOrden2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.NBrowser).HasColumnName(@"NBrowser").HasColumnType("int").IsRequired();
            Property(x => x.NombreParteIzquierda).HasColumnName(@"NombreParteIzquierda").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NombreParteDerecha).HasColumnName(@"NombreParteDerecha").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NImpresion).HasColumnName(@"NImpresion").HasColumnType("int").IsRequired();
            Property(x => x.EstadoPublicacion).HasColumnName(@"EstadoPublicacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.PorcentajePublicacion).HasColumnName(@"PorcentajePublicacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.IndexacionSavia).HasColumnName(@"IndexacionSAVIA").HasColumnType("bit").IsRequired();
            Property(x => x.GenerarXml).HasColumnName(@"GenerarXML").HasColumnType("bit").IsRequired();
            Property(x => x.FechaUltimaGeneracionXml).HasColumnName(@"FechaUltimaGeneracionXML").HasColumnType("datetime").IsOptional();
            Property(x => x.PrecioEspecialCatalogo).HasColumnName(@"PrecioEspecialCatalogo").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.Usuario).WithMany(b => b.E2GeCatalogo).HasForeignKey(c => c.UsuarioCreacion).WillCascadeOnDelete(false); // FK_E2_GE_CATALOGOS_Usuarios
            HasMany(t => t.PalabrasClaves).WithMany(t => t.E2GeCatalogo).Map(m =>
            {
                m.ToTable("E2_GE_CATALOGOS_PALABRASCLAVE", "dbo");
                m.MapLeftKey("ID_CATALOGO");
                m.MapRightKey("IDPalabra");
            });
        }
    }
}