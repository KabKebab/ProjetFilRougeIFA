namespace BDDAtosFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<AGENCE> AGENCE { get; set; }
        public virtual DbSet<BESOIN> BESOIN { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<COLLABORATEUR> COLLABORATEUR { get; set; }
        public virtual DbSet<COMMENTAIRE_DEMARCHE> COMMENTAIRE_DEMARCHE { get; set; }
        public virtual DbSet<COMMENTAIRE_PROPOSITION> COMMENTAIRE_PROPOSITION { get; set; }
        public virtual DbSet<COMPETENCE> COMPETENCE { get; set; }
        public virtual DbSet<concerner> concerner { get; set; }
        public virtual DbSet<CONTACT_CLIENT> CONTACT_CLIENT { get; set; }
        public virtual DbSet<CONTACT_STT> CONTACT_STT { get; set; }
        public virtual DbSet<DEMARCHE> DEMARCHE { get; set; }
        public virtual DbSet<disposer> disposer { get; set; }
        public virtual DbSet<EXPERIENCE> EXPERIENCE { get; set; }
        public virtual DbSet<INTERNE> INTERNE { get; set; }
        public virtual DbSet<necessiter> necessiter { get; set; }
        public virtual DbSet<PROPOSITION> PROPOSITION { get; set; }
        public virtual DbSet<ROLE> ROLE { get; set; }
        public virtual DbSet<SOUS_TRAITANT> SOUS_TRAITANT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TYPE_COMPETENCE> TYPE_COMPETENCE { get; set; }
        public virtual DbSet<UTILISATEUR> UTILISATEUR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AGENCE>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCE>()
                .HasMany(e => e.INTERNE)
                .WithRequired(e => e.AGENCE)
                .HasForeignKey(e => e.id_AGENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BESOIN>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<BESOIN>()
                .HasMany(e => e.concerner)
                .WithRequired(e => e.BESOIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BESOIN>()
                .HasMany(e => e.necessiter)
                .WithRequired(e => e.BESOIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.adresseSiege)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .HasMany(e => e.BESOIN)
                .WithRequired(e => e.CLIENT)
                .HasForeignKey(e => e.id_CLIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENT>()
                .HasMany(e => e.CONTACT_CLIENT)
                .WithRequired(e => e.CLIENT)
                .HasForeignKey(e => e.id_CLIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENT>()
                .HasMany(e => e.DEMARCHE)
                .WithRequired(e => e.CLIENT)
                .HasForeignKey(e => e.id_CLIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLLABORATEUR>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<COLLABORATEUR>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<COLLABORATEUR>()
                .HasMany(e => e.disposer)
                .WithRequired(e => e.COLLABORATEUR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLLABORATEUR>()
                .HasOptional(e => e.INTERNE)
                .WithRequired(e => e.COLLABORATEUR);

            modelBuilder.Entity<COLLABORATEUR>()
                .HasMany(e => e.PROPOSITION)
                .WithRequired(e => e.COLLABORATEUR)
                .HasForeignKey(e => e.id_COLLABORATEUR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLLABORATEUR>()
                .HasOptional(e => e.SOUS_TRAITANT)
                .WithRequired(e => e.COLLABORATEUR);

            modelBuilder.Entity<COMMENTAIRE_DEMARCHE>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<COMMENTAIRE_PROPOSITION>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<COMPETENCE>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<COMPETENCE>()
                .HasMany(e => e.disposer)
                .WithRequired(e => e.COMPETENCE)
                .HasForeignKey(e => e.id_COMPETENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPETENCE>()
                .HasMany(e => e.necessiter)
                .WithRequired(e => e.COMPETENCE)
                .HasForeignKey(e => e.id_COMPETENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.poste)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.courriel)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.tel_fixe)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.tel_perso)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_CLIENT>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.cv)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.societe)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.poste)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.courriel)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.tel_fixe)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.tel_perso)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACT_STT>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<DEMARCHE>()
                .Property(e => e.nomDemarcheur)
                .IsUnicode(false);

            modelBuilder.Entity<DEMARCHE>()
                .Property(e => e.action)
                .IsUnicode(false);

            modelBuilder.Entity<DEMARCHE>()
                .HasMany(e => e.COMMENTAIRE_DEMARCHE)
                .WithRequired(e => e.DEMARCHE)
                .HasForeignKey(e => e.id_DEMARCHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXPERIENCE>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<EXPERIENCE>()
                .HasMany(e => e.COMPETENCE)
                .WithRequired(e => e.EXPERIENCE)
                .HasForeignKey(e => e.id_EXPERIENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXPERIENCE>()
                .HasMany(e => e.disposer)
                .WithRequired(e => e.EXPERIENCE)
                .HasForeignKey(e => e.id_EXPERIENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXPERIENCE>()
                .HasMany(e => e.necessiter)
                .WithRequired(e => e.EXPERIENCE)
                .HasForeignKey(e => e.id_EXPERIENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INTERNE>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<INTERNE>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<PROPOSITION>()
                .Property(e => e.tarif)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PROPOSITION>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<PROPOSITION>()
                .HasMany(e => e.COMMENTAIRE_PROPOSITION)
                .WithRequired(e => e.PROPOSITION)
                .HasForeignKey(e => e.id_PROPOSITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROPOSITION>()
                .HasMany(e => e.concerner)
                .WithRequired(e => e.PROPOSITION)
                .HasForeignKey(e => e.id_PROPOSITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.UTILISATEUR)
                .WithRequired(e => e.ROLE)
                .HasForeignKey(e => e.id_ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOUS_TRAITANT>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<SOUS_TRAITANT>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<SOUS_TRAITANT>()
                .HasMany(e => e.CONTACT_STT)
                .WithRequired(e => e.SOUS_TRAITANT)
                .HasForeignKey(e => e.id_SOUS_TRAITANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYPE_COMPETENCE>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_COMPETENCE>()
                .HasMany(e => e.COMPETENCE)
                .WithRequired(e => e.TYPE_COMPETENCE)
                .HasForeignKey(e => e.id_TYPE_COMPETENCE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UTILISATEUR>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<UTILISATEUR>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<UTILISATEUR>()
                .Property(e => e.nomDeCompte)
                .IsUnicode(false);

            modelBuilder.Entity<UTILISATEUR>()
                .Property(e => e.motDePasse)
                .IsUnicode(false);

            modelBuilder.Entity<UTILISATEUR>()
                .HasMany(e => e.concerner)
                .WithRequired(e => e.UTILISATEUR)
                .HasForeignKey(e => e.id_UTILISATEUR)
                .WillCascadeOnDelete(false);
        }
    }
}
