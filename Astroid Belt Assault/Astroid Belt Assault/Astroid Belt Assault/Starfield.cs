using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Astroid_Belt_Assault
{
    class Starfield
    {
        private List<Sprite> stars = new List<Sprite>();
        private int screenWidth = 800;
        private int screenHeight = 600;
        private Random rand = new Random();
        private Color[] colors = { Color.White, Color.Yellow,
                                    Color.Wheat, Color.WhiteSmoke,
                                    Color.SlateGray };
    }
}
