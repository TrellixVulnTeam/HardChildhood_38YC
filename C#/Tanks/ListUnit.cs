﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListUnit
    {
        public byte count = 10;
        private Random random = new Random();
        private List<object> listUnits = new List<object>();
        
        //создаём список танков и Машинок
        public List<object> CreateListUnits(Color color)
        {
            for (byte  i = 1; i <= count; i++)
            {
                listUnits.Add(new Tank
                {
                    color = color,
                    position = StartPosition(),
                    speed = 1
                });

                listUnits.Add(new Car
                {
                    color = color,
                    position = StartPosition(),
                    speed = 2
                });
            }
            return listUnits;
        }       

        // отрисовка списка танков и машинок
        public void DrawListUnit(Graphics g, Point cursor)
        {
            foreach (dynamic unit in listUnits)
            {
                unit.DrawUnit(g, cursor);
            }
        }

        //Стартовая позиция танка и мошинок
        private Point StartPosition()
        {
            Point position = new Point();
            position.X = random.Next(1280);
            position.Y = random.Next(720);
            return position;
        }
    }
}