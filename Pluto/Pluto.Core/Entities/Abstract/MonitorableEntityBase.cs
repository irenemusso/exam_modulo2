using Pluto.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Core.Entities.Abstract
{
    /// <summary>
    /// Classe astratta per tutte le entità monitorabili
    /// </summary>
    public abstract class MonitorableEntityBase : IEntity, IMonitorableEntity
    {

        /// <summary>
        /// Id primario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Modello 
        /// </summary>
        public string Modello { get; set; }

        /// <summary>
        /// Marca 
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// Data di creazione dell'entità
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Utente che ha fisicamente creato dell'entità nel catalogo
        /// </summary>
        public string UtenteCreatore { get; set; }
    }
}
