//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Items
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Niveau { get; set; }
        public int ValeurArgent { get; set; }
        public int Poid { get; set; }
        public int RegNiveau { get; set; }
        public int RegForce { get; set; }
        public int RegDex { get; set; }
        public int RegInt { get; set; }
        public int RegEnduance { get; set; }
        public int Quantitê { get; set; }
        public int MondeId { get; set; }
    
        public virtual Monde Monde { get; set; }
        public virtual InventaireHero InventaireHero { get; set; }
    }
}