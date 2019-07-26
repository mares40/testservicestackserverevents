using ClassLibrary1;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ApiService : Service
    {
        public IServerEvents ServerEvents { get; set; }

        public List<MachineNote> Get(MachineNotesGet request)
        {
            return new List<MachineNote>()
            {
                new MachineNote(){ Id = 1, Description  = "aaa" },
                new MachineNote(){ Id = 2, Description  = "bbb" }
            };
        }

    }
}
