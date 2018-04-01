using System;
using System.Collections.Generic;
using System.Drawing;

namespace PresentationTimekeeper.Dto
{
    [Serializable]
    public class Setting
    {
        public int TargetTime { get; set; }
        public bool DoCountUp { get; set; }
        public TextBgColor DefaultColor { get; set; }
        public bool OmitHourDisplay { get; set; }
        public Dictionary<int, int> RingTiming { get; set; }
        public Dictionary<int, TextBgColor> ChangeColorTiming { get; set; }

        public Setting()
        {
            TargetTime = 180;
            DoCountUp = true;
            DefaultColor = new TextBgColor
            {
                Text = Color.White,
                BackGround = Color.Black
            };
            OmitHourDisplay = true;
            RingTiming = new Dictionary<int, int>();
            ChangeColorTiming = new Dictionary<int, TextBgColor>();
        }
    }
}
