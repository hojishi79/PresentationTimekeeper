using System;
using System.Drawing;

namespace PresentationTimekeeper.Dto
{
    [Serializable]
    public class TextBgColor
    {
        public Color Text { get; set; } 
        public Color BackGround { get; set; }
    }
}
