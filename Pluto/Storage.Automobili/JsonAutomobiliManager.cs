using Pluto.Core.Entities;
using Pluto.Storage.Automobili.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Storage.Automobili
{
    public class JsonBicicletteManager : JsonManagerBase<Automobile>
    {
        protected override void RemapNuoviValoriSuEntityInLista(
            Automobile entitySorgente, Automobile entityDestinazione)
        {
            entityDestinazione.NumeroCavalli = entitySorgente.NumeroCavalli;
            entityDestinazione.IsDiesel = entitySorgente.IsDiesel;
            entityDestinazione.DataImmatricolazione = entitySorgente.DataImmatricolazione;

        }
    }
}
