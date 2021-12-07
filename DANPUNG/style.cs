using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DANPUNG
{
    class style : ProfessionalColorTable
    {
        public void MenuColorTable()
        {
            base.UseSystemColors = false;
        }
        public override Color MenuBorder
        {
            get { return Color.Black; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Black; }
        }
        public override Color MenuItemSelected
        {
            get { return Color.PaleGreen; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.GreenYellow; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Lime; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.White; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Lime; }
        }
    }
}
