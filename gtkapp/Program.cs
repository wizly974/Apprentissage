#nullable enable
using Gtk;
using System;

namespace gtkapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.gtkapp.gtkapp", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
