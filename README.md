Project content:
ConsoleApp1: Contains the AppHost and a simple Service
WpfApp1: Contains a small app that reproduce the issue

WpfApp1 use some external DevExpress references that I add into the ".Assemblies" folder. The solution build successfully.

To reproduce the issue: start the ConsoleApp1 and than start WpfApp1 from another PC. Method "Loaded" of HeaderViewModel will execute till the end, while method "Loaded" of MainMenuViewModel will not reach the end.  It hangs until the Timeout exceptions.

Thanks
Enrico
