using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Core.Managers.Enum
{
    /*Quando l’applicazione viene avviata permette di selezione se si vuole lavorare 
       sul catalogo delle biciclette(selezione da menu “A”) o 
       quello delle automobili(selezione da menu “B”).*/

    /// <summary>
    /// Enumerazione di tutti i possibili 
    /// cataloghi supportati dalla piattaforma
    /// </summary>
    public enum StorageCatalogo
    {
        /// <summary>
        /// Catalogo Biciclette
        /// </summary>
        CatalogoBiciclette = 0,

        /// <summary>
        /// Catalogo Automobili
        /// </summary>
        CatalogoAutomobili = 1


    }
}
