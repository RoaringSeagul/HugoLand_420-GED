﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HugoLandEditeur
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GameContext : DbContext
    {
        public GameContext()
            : base("name=GameContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<CompteJoueur> CompteJoueurs { get; set; }
        public virtual DbSet<EffetItem> EffetItems { get; set; }
        public virtual DbSet<Hero> Heros { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Monde> Mondes { get; set; }
        public virtual DbSet<Monstre> Monstres { get; set; }
        public virtual DbSet<ObjetMonde> ObjetMondes { get; set; }
    }
}
