using ShipsEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;


namespace ShipsEngine
{
    public class Program
    {
        static RenderWindow _window;

        public static void Main(string[] args)
        {

            _window = new RenderWindow(new VideoMode(1080, 800), "GameEngine");
            _window.Closed += OnClosed;

            Panels.Panel panel = new Panels.Panel("HUD Panel", new SFML.System.Vector2f(500, 500), new SFML.System.Vector2f(100, 100));

            while (_window.IsOpen)
            {
                _window.DispatchEvents();

                _window.Clear();
                panel.Render(_window);
                _window.Display();
            }
        }

        private static void OnClosed(object sender, System.EventArgs s)
        {
            _window.Close();
            
        }
    }
}
