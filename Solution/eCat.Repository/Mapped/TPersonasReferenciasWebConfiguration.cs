namespace eCat.Repository.Mapped
{
    public class TPersonasReferenciasWebConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPersonasReferenciasWeb>
    {
        public TPersonasReferenciasWebConfiguration()
            : this("dbo")
        {
        }

        public TPersonasReferenciasWebConfiguration(string schema)
        {
            ToTable("T_Personas_ReferenciasWeb", schema);
            HasKey(x => x.IdReferenciaWeb);

            Property(x => x.IdReferenciaWeb).HasColumnName(@"IdReferenciaWeb").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPersona).HasColumnName(@"IdPersona").HasColumnType("bigint").IsRequired();
            Property(x => x.IdTipoReferenciaWeb).HasColumnName(@"IdTipoReferenciaWeb").HasColumnType("smallint").IsRequired();
            Property(x => x.Url).HasColumnName(@"URL").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("bigint").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.Persona).WithMany(b => b.TPersonasReferenciasWebs).HasForeignKey(c => c.IdPersona).WillCascadeOnDelete(false); // FK_T_Personas_ReferenciasWeb_Personas
            HasRequired(a => a.TReferenciasWebTipos).WithMany(b => b.TPersonasReferenciasWebs).HasForeignKey(c => c.IdTipoReferenciaWeb).WillCascadeOnDelete(false); // FK_T_Personas_ReferenciasWeb_T_ReferenciasWeb_Tipos
        }
    }
}