using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Core.Entities.Interfaces
{
    /// <summary>
    /// Interfaccia per entità che hanno la 
    /// data di creazione e l'utente creatore
    /// </summary>
    public interface IMonitorableEntity
    {
        /// <summary>
        /// Modello 
        /// </summary>
        string Modello { get; set; }

        /// <summary>
        /// Marca 
        /// </summary>
        string Marca { get; set; }

        /// <summary>
        /// Data di creazione dell'entità
        /// </summary>
        DateTime Timestamp { get; set; }

        /// <summary>
        /// Utente che ha creato l'entità
        /// </summary>
        string UtenteCreatore { get; set; }
    }
}
