﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduitChimiques.Models.Entities
{
    public class MouvementStock
    {
        public int Id { get; set; }
        public DateTime? DateMouvement { get; set; }
        public int IdRespMvt { get; set; }
        public string TypeMvt { get; set; }
        public string Raison { get; set; }
        public int IdProduit { get; set; }
        public int Quantite { get; set; }
        public string Observation { get; set; }
        public Produit produit { get; set; }
        public Lot lot { get; set; }
    }
}