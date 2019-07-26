using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MachineNotesGet : IReturn<List<MachineNote>>
    {
        /// <summary>
        /// Codice della macchina della quale si intende recuperare le note.  Se il valore è string.empty verranno cercate tutte le note SENZA destinatario, 
        /// ovvero quelle riservate al server
        /// </summary>
        public string MachineCode { get; set; }
        /// <summary>
        /// Indica se caricare o meno le note eliminate
        /// </summary>
        public bool GetDeletedNotes { get; set; }
    }
}
