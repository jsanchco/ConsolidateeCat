namespace eCat.Repository.Mapped
{
    public class FichasBaseCamposLibreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseCamposLibre>
    {
        public FichasBaseCamposLibreConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseCamposLibreConfiguration(string schema)
        {
            ToTable("FichasBase_CamposLibres", schema);
            HasKey(x => new { x.IdInterno, x.IdCampoLn });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCampoLn).HasColumnName(@"IdCampoLN").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdValor).HasColumnName(@"IdValor").HasColumnType("int").IsOptional();
            Property(x => x.Texto).HasColumnName(@"Texto").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);

            // Foreign keys
            HasOptional(a => a.TLineasNegocioCamposLibresValore).WithMany(b => b.FichasBaseCamposLibres).HasForeignKey(c => c.IdValor).WillCascadeOnDelete(false); // FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres_Valores
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseCamposLibres).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_CamposLibres_FichasBase
            HasRequired(a => a.TLineasNegocioCamposLibre).WithMany(b => b.FichasBaseCamposLibres).HasForeignKey(c => c.IdCampoLn).WillCascadeOnDelete(false); // FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres
        }
    }
}