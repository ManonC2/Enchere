using Enchere2.Modeles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enchere2.Models
{
    public class Magasin
    {
        #region Attributs
        public static List<Magasin> CollClasse = new List<Magasin>();
        private int _id;
        private string _nom;
        private string _adresse;
        private string _ville;
        private string _codepostal;
        private string _portable;
        private float _latitude;
        private float _longitude;
        #endregion

        #region Constructeur 
        public Magasin(int id, string portable, string nom, string adresse, string ville, string codepostal, float latitude, float longitude)
        {
            _id = id;
            _nom = nom;
            _adresse = adresse;
            _ville = ville;
            _codepostal = codepostal;
            _latitude = latitude;
            _longitude = longitude;
            _portable = portable;
            Magasin.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nom")]
        public string Nom { get => _nom; set => _nom = value; }

        [JsonProperty("adresse")]
        public string Adresse{ get => _adresse; set => _adresse = value; }

        [JsonProperty("ville")]
        public string Ville{ get => _ville; set => _ville = value; }

        [JsonProperty("codepostal")]
        public string CodePostal { get => _codepostal; set => _codepostal= value; }

        [JsonProperty("portable")]
        public string Portable { get => _portable; set => _portable = value; }

        [JsonProperty("latitude")]
        internal float Latitude{ get => _latitude; set => _latitude= value; }
        
        [JsonProperty("longitude")]
        internal float Longitude{ get => _longitude; set => _longitude= value; }

        #endregion

        #region Méthodes
        #endregion

    }
}
