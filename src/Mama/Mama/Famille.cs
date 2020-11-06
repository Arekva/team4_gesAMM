﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mama
{
    /// <summary>
    /// Famille / type de médicament.
    /// </summary>
    public class Famille
    {
        /// <summary>
        /// Identifiant unique de la famille.
        /// </summary>
        public string Code { get; }
        /// <summary>
        /// Nom du médicament.
        /// </summary>
        public string Libelle { get; }
        /// <summary>
        /// Nombre de médicament qui ont reçu une validation AMM.
        /// </summary>
        public int NombreAMM { get; set; }
        /// <summary>
        /// Nouvelle famille où tous les paramètres sont fournis.
        /// </summary>
        /// <param name="code">Le code identifiant de la famille.</param>
        /// <param name="libelle">Le libelle de la famille.</param>
        /// <param name="nbMediAmm">Le nombre de médicaments qui ont eu une validation</param>
        public Famille(string code, string libelle, int nbMediAmm)
        {
            Code = code;
            Libelle = libelle;
            NombreAMM = nbMediAmm;
        }
    }
}
