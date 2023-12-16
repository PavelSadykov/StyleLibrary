using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StyleLibrary
{
    public class StyleProcessor
    {
        public static void ChangeButtonStyle(Button button, Color backColor, Color foreColor, Font font)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.Font = font;
        }
    }
}
