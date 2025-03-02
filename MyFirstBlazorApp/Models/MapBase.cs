using Microsoft.AspNetCore.Components;

namespace MyFirstBlazorApp.Models
{
    public class MapBase : ComponentBase
    {
        public int X { get; set; } = 0; // X position
        public int Y { get; set; } = 0; // Y position

        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
    }
}
