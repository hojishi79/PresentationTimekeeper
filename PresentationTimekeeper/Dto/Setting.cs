using System.Collections.Generic;
using System.Drawing;

namespace PresentationTimekeeper.Dto
{
    public class Setting
    {
        public int TargetTime { get; set; }
        public bool DoCountUp { get; set; }
        public Color TextColor { get; set; }
        public Color BackgroundColor { get; set; }
        public bool OmitHourDisplay { get; set; }
        public Dictionary<int, int> RingingTiming { get; set; }

        public Setting()
        {
            TargetTime = 180;
            DoCountUp = true;
            TextColor = Color.White;
            BackgroundColor = Color.Black;
            OmitHourDisplay = true;
            RingingTiming = new Dictionary<int, int>();
        }
    }
}
