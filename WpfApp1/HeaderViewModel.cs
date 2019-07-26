using ClassLibrary1;
using ServiceStack;
using System.Windows.Input;

namespace WpfApp1
{
    public class HeaderViewModel : NotifyPropertyChanged
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
            sse.Update(new[] { "*" }, null);
            sse.Update(new[] { "SERVER" }, null);
            sse.Handlers["test"] = (client, msg) =>
            {

            };

            var req = new MachineNotesGet()
            {
                MachineCode = "",
                GetDeletedNotes = false
            };
            var res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
            res = proxy.Get(req);
        }

    }
}
