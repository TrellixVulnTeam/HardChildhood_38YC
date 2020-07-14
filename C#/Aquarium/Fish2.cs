﻿using System.Drawing;

namespace Aquarium
{
    class Fish2 : AFish, IFish
    {
        private Bitmap bitmap = Properties.Resources._2fish;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}