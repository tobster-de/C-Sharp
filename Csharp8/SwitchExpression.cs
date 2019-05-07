﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    class RGBColor
    {
        public RGBColor(int r, int g, int b) => (this.R, this.B, this.G) = (r, g, b);

        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

    class SwitchExpression
    {
        public static RGBColor FromRainbow(Rainbow colorBand) => colorBand switch
        {
            Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
            Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
            Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
            Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
            Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
            Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
            Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
            _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
        };
    }
}
