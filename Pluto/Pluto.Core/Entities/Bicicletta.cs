using Pluto.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Core.Entities
{
    //La bicicletta è definita dal campo “Modello”, “Marca”, “NumeroTelaio” e “IsElettrica”; 
    public class Bicicletta : MonitorableEntityBase
    {
        

        /// <summary>
        /// Numero del telaio
        /// </summary>
        public int NumeroTelaio { get; set; }

        /// <summary>
        /// Bicicletta Elettrica
        /// </summary>
        public bool IsElettrica { get; set; }

    }
}
