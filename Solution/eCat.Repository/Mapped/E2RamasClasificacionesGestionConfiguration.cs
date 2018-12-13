namespace eCat.Repository.Mapped
{
    public class E2RamasClasificacionesGestionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2RamasClasificacionesGestion>
    {
        public E2RamasClasificacionesGestionConfiguration()
            : this("dbo")
        {
        }

        public E2RamasClasificacionesGestionConfiguration(string schema)
        {
            ToTable("E2_RAMAS_CLASIFICACIONES_GESTION", schema);
            HasKey(x => new { x.IdCatalogo, x.IdClasificacion });

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPadre).HasColumnName(@"ID_PADRE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaAlta).HasColumnName(@"FechaAlta").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaUltModif).HasColumnName(@"FechaUltModif").HasColumnType("datetime").IsOptional();
            Property(x => x.Nivel).HasColumnName(@"Nivel").HasColumnType("tinyint").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.Personalizado).HasColumnName(@"Personalizado").HasColumnType("bit").IsRequired();
            Property(x => x.CodPropietario).HasColumnName(@"CodPropietario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodMercado).HasColumnName(@"CodMercado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodNegocio).HasColumnName(@"CodNegocio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodEtapaEdad).HasColumnName(@"CodEtapaEdad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodCategoriaCiclo).HasColumnName(@"CodCategoriaCiclo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodSubcategoriaMateria).HasColumnName(@"CodSubcategoriaMateria").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodEdadCurso).HasColumnName(@"CodEdadCurso").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Pendiente).HasColumnName(@"Pendiente").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.TCategoriasCiclo).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodCategoriaCiclo).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_CategoriasCiclos
            HasOptional(a => a.TEdadCurso).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodEdadCurso).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EdadCurso
            HasOptional(a => a.TEtapasRangoEdad).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodEtapaEdad).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EtapasRangoEdad
            HasOptional(a => a.TMercado).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodMercado).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Mercado
            HasOptional(a => a.TNegocio).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodNegocio).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Negocio
            HasOptional(a => a.TPropietario).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodPropietario).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Propietario
            HasOptional(a => a.TSubcategoriasMateria).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.CodSubcategoriaMateria).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_SubcategoriasMaterias
            HasRequired(a => a.E2ClasificacionesGestion).WithMany(b => b.E2RamasClasificacionesGestion).HasForeignKey(c => c.IdCatalogo).WillCascadeOnDelete(false); // FK_E2_RAMAS_CLASIFICACIONES_GESTION_E2_CLASIFICACIONES_GESTION
        }
    }
}