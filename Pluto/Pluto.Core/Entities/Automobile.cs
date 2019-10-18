using Pluto.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Core.Entities
{
    //L’automobile è definita da  “Modello”, “Marca”, “NumeroCavalli”, “IsDiesel” e “DataImmatricolazione”.

    /// <summary>
    /// Entità libro venduto
    /// </summary>
    public class Automobile : MonitorableEntityBase
    {
        

        /// <summary>
        /// Numero dei cavalli
        /// </summary>
        public int NumeroCavalli { get; set; }

        /// <summary>
        /// Automobile Diesel
        /// </summary>
        public bool IsDiesel { get; set; }

        /// <summary>
        /// Data di immatricolazione dell'automobile
        /// </summary>
        public DateTime DataImmatricolazione { get; set; }


    }
}
