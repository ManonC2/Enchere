using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enchere2.Models
{
    public class TypeEnchere
    {
        #region Attributs

        public static List<TypeEnchere> CollClasse = new List<TypeEnchere>();

        private int _id;
        private string _nom;

        #endregion

        #region Constructeurs

        public TypeEnchere(int id, string nom)
        {
            TypeEnchere.CollClasse.Add(this);
            _id = id;
            _nom = nom;
        }


        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nom")]
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
