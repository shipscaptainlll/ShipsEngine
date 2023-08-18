using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ShipsEngine.Panels
{
    internal class Panel
    {
        public string Title { get; private set; }
        public Vector2f Position { get; set; }
        public Vector2f Size { get; set; }
        public Color Color { get; set; } = new Color(100, 100, 100);

        public Panel(string title, Vector2f position, Vector2f size)
        {
            Title = title;
            Position = position;
            Size = size;
        }

        public Panel(string title, Vector2f position, Vector2f size, Color color)
            : this (title, position, size)
        {
            Color = color;
        }

        public void Render(RenderWindow target)
        {
            RectangleShape shape = new RectangleShape(Size)
            {
                Position = this.Position,
                Size = this.Size
            };

            target.Draw(shape);
        }
    }
}
