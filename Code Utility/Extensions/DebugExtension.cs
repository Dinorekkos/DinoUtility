using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dino.UtilityTools.Extensions 
{
    /// <summary>
    /// Last Update 29/08/2025 Dino
    /// A class that allows you to set a color to a debug.
    /// </summary>
    public static class DebugExtension
    {
        public static string SetColor(this string inputText, string color)
        {
            return "<color=" + color + ">" + inputText + "</color>";
        } 
    
        public static string SetColor(this string inputText, ColorDebug color)
        {
            return "<color=" + GetColorDebug(color) + ">" + inputText + "</color>";
        }
    
        public static Color GetColor(ColorDebug color)
        {
            Color colorValue = Color.white;
            switch (color)
            {
                case ColorDebug.Red:
                    colorValue = new Color(1f, 0.32f, 0.45f);
                    break;
                case ColorDebug.Green:
                    colorValue = new Color(0.6f, 0.87f, 0.4f);
                    break;
                case ColorDebug.Blue:
                    colorValue = new Color(0.43f, 0.78f, 0.98f);
                    break;
                case ColorDebug.Yellow:
                    colorValue = new Color(0.95f, 0.94f, 0.38f);
                    break;
                case ColorDebug.Orange:
                    colorValue = new Color(0.98f, 0.62f, 0.21f);
                    break;
                case ColorDebug.Purple:
                    colorValue = new Color(0.49f, 0.43f, 1f);
                    break;
                
            }
            return colorValue;
        }
        private static string GetColorDebug(ColorDebug color)
        {
            string colorString = "";
            switch (color)
            {
                case ColorDebug.Red:
                    colorString = "#ff5274";
                    break;
                case ColorDebug.Green:
                    colorString = "#98dd67";
                    break;
                case ColorDebug.Blue:
                    colorString = "#6ec8f8";
                    break;
                case ColorDebug.Yellow:
                    colorString = "#f1ef60";
                    break;
                case ColorDebug.Orange:
                    colorString = "#fb9f36";
                    break;
                case ColorDebug.Purple:
                    colorString = "#7d6efe";
                    break;
                
            }


            return colorString;
        }

    }
}

public enum ColorDebug
{
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Purple,
}