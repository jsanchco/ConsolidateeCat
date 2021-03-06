﻿namespace eCat.Repository.Mapped
{
    public class TFichasBaseAmbitosCesionRestriccionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFichasBaseAmbitosCesionRestriccion>
    {
        public TFichasBaseAmbitosCesionRestriccionConfiguration()
            : this("dbo")
        {
        }

        public TFichasBaseAmbitosCesionRestriccionConfiguration(string schema)
        {
            //ToTable("T_FichasBase_AmbitosCesion_Valores", schema);
            //HasKey(x => new { x.IdFichasBaseAmbitoCesion, x.IdAmbitoCesion });

            //Property(x => x.IdFichasBaseAmbitoCesion).HasColumnName(@"IdFichasBaseAmbitoCesion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            //Property(x => x.IdAmbitoCesion).HasColumnName(@"IdAmbitoCesion").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            //Property(x => x.Exclusivo).HasColumnName(@"Exclusivo").HasColumnType("bit").IsRequired();

            //// Foreign keys
            //HasRequired(a => a.TAmbitosCesion).WithMany(b => b.TFichasBaseAmbitosCesionValores).HasForeignKey(c => c.IdAmbitoCesion).WillCascadeOnDelete(false); // FK_T_FichasBase_AmbitosCesion_Valores_T_AmbitosCesion
            //HasRequired(a => a.TFichasBaseAmbitosCesion).WithMany(b => b.TFichasBaseAmbitosCesionValores).HasForeignKey(c => c.IdFichasBaseAmbitoCesion).WillCascadeOnDelete(false); // FK_T_FichasBase_AmbitosCesion_Valores_T_FichasBase_AmbitosCesion

            ToTable("T_FichasBase_AmbitosCesion_Restricciones", schema);
            HasKey(x => new { x.IdFichasBaseAmbitoCesion, x.IdAmbitoCesionRestriccion });

            Property(x => x.IdFichasBaseAmbitoCesion).HasColumnName(@"IdFichasBaseAmbitoCesion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAmbitoCesionRestriccion).HasColumnName(@"IdAmbitoCesionRestriccion").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);            

            //// Foreign keys
            HasRequired(a => a.TAmbitosCesion).WithMany(b => b.TFichasBaseAmbitosCesionRestricciones).HasForeignKey(c => c.IdAmbitoCesionRestriccion).WillCascadeOnDelete(false);
            HasRequired(a => a.TFichasBaseAmbitosCesion).WithMany(b => b.TFichasBaseAmbitosCesionRestricciones).HasForeignKey(c => c.IdFichasBaseAmbitoCesion).WillCascadeOnDelete(false);
        }
    }
}
