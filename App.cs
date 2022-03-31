namespace AcadAddinManager
{
    using Autodesk.AutoCAD.Runtime;

    class App : IExtensionApplication
    {
        public void Initialize()
        {
            "Loaded AddinManager. Command:\nAddinManager - Plugin selection and command launch,\nAddinManagerLast - Running last command.".Write();
            AddinManagerService.ClearAddins();
        }

        public void Terminate()
        {
            AddinManagerService.ClearAddins();
        }
    }
}