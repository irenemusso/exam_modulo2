using Pluto.Core.Entities;
using Pluto.Storage.Automobili.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Storage
{
    public class JsonBicicletteManager : JsonManagerBase<Bicicletta>
    {
        protected override void RemapNuoviValoriSuEntityInLista(
            Bicicletta entitySorgente, Bicicletta entityDestinazione)
        {
            entityDestinazione.NumeroTelaio = entitySorgente.NumeroTelaio;
            entityDestinazione.IsElettrica = entitySorgente.IsElettrica;
            
        }
    }
}
