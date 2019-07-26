
using ClassLibrary1;
using ServiceStack;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainMenuViewModel : NotifyPropertyChanged
    {
        RelayCommand _OnLoad;
        public ICommand OnLoad
        {
            get
            {
                return _OnLoad ?? (_OnLoad = new RelayCommand(m => this.Loaded()));
            }
        }

        private void Loaded()
        {
            var url = "http://192.168.34.76:10256";
            var proxy = new JsonServiceClient(url);

            var sse = new ServerEventsClient(url);
            sse.Start();
            sse.Update(new[] { "ABC" }, null);
            sse.Handlers["test1"] = (client, msg) =>
            {

            };

            var res = proxy.Get(new MachineNotesGet()
            {
                MachineCode = "",
                GetDeletedNotes = false
            });

            //it never stop here!!!
            int i = 0;
        }

    }
}
