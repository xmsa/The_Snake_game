﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class CFood
    {
        //Object Food
        PictureBox _food;

        //Location Food
        public Point _location { set; get; }

        //Height and Width form
        int _height { set; get; }
        int _width { set; get; }

        //Constructor
        public CFood(ref Frm_Main _frm)
        {
            _food = new PictureBox();
            _food.Size = new System.Drawing.Size(20, 20);
            _food.BackColor = System.Drawing.Color.Red;
            _height = _frm.Size.Height - 60;
            _width = _frm.Size.Width - 60;
            _location = Point.Empty;
            _food.Location = ranlocation();
            _location = _food.Location;
            _frm.Controls.Add(_food);
        }
        //Return Location Randome
        private Point ranlocation()
        {
            Random rm = new Random();
            Point loc = new Point(rm.Next(20, _width - 20), rm.Next(20, _height - 20));
            return loc;
        }

        //Shift Food
        public void shift()
        {
            _location = ranlocation();
            _food.Location = _location;
        }
    }
}