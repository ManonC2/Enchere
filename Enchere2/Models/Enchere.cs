using Enchere2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enchere2.Modeles
{
    public class Enchere
    {
        #region Attributs

        public static List<Enchere> CollClasse = new List<Enchere>();
        private int _id;
        private DateTime _date_debut;
        private DateTime _date_fin;
        private float _prixreserve;
        private int _type_enchere_id;
        private Produit _leProduit;
        private TypeEnchere _leTypeEnchere;
        private Magasin _leMagasin;

        #endregion

        #region Constructeurs

        public Enchere(int id, DateTime date_debut, DateTime date_fin, float prixreserve, int type_enchere_id, Produit leProduit, TypeEnchere letypeenchere, Magasin lemagasin)
        {
            _id = id;
            _date_debut = date_debut;
            _date_fin = date_fin;
            _prixreserve = prixreserve;
            _type_enchere_id = type_enchere_id;
            _leProduit = leProduit;
            _leMagasin = lemagasin;

            Enchere.CollClasse.Add(this);
            _leTypeEnchere = letypeenchere;
        }



        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("datedebut")]
        public DateTime Date_debut { get => _date_debut; set => _date_debut = value; }

        [JsonProperty("datefin")]
        public DateTime Date_fin { get => _date_fin; set => _date_fin = value; }
        
        public float Prixreserve { get => _prixreserve; set => _prixreserve = value; }

        [JsonProperty("leproduit")]
        public Produit LeProduit { get => _leProduit; set => _leProduit = value; }

        [JsonProperty("lemagasin")]
        public Magasin LeMagasin { get => _leMagasin; set => _leMagasin = value; }


        [JsonProperty("letypeenchere")]
        public TypeEnchere LeTypeEnchere { get => _leTypeEnchere; set => _leTypeEnchere = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
