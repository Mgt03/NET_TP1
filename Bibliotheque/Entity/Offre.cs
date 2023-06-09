﻿using System;
using System.Collections.Generic;

namespace Bibliotheque.Entity
{
    public class Offre
    {
        public Offre()
        {
            Postulations = new HashSet<Postulation>();
        }
        
        public int Id { get; set; }
        public string Intitule { get; set; }
        public DateTime Date { get; set; }
        public int Salaire { get; set; }
        public string Description { get; set; }
        public string Responsable { get; set; }
        public Statut Statut { get; set; }
        public int StatutId { get; set; }
        public HashSet<Postulation> Postulations { get; set; }
    }
}
