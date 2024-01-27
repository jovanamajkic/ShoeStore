using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Util
{
    public class Theme
    {
        public Image image { get; set; }
        public FontStyle fontStyle { get; set; }
        public Color light { get; set; }
        public Color medium { get; set; }
        public Color dark { get; set; }

        public static Theme pickedTheme = null;

        public static void SetTheme(int t)
        {

            pickedTheme = new Theme();
            if (t == 1)
            {
                pickedTheme.image = Properties.Resources.shoe_shop0;
                pickedTheme.fontStyle = FontStyle.Regular;
                pickedTheme.light = Color.FromArgb(177, 189, 234);
                pickedTheme.medium = Color.FromArgb(146, 163, 226);
                pickedTheme.dark = Color.FromArgb(90, 107, 171);
            }
            else if (t == 2)
            {
                pickedTheme.image = Properties.Resources.shoe_shop1;
                pickedTheme.fontStyle = FontStyle.Italic;
                pickedTheme.light = Color.FromArgb(200, 177, 234);
                pickedTheme.medium = Color.FromArgb(169, 151, 226);
                pickedTheme.dark = Color.FromArgb(113, 95, 171);
            }
            else
            {
                pickedTheme.image = Properties.Resources.shoe_shop2;
                pickedTheme.fontStyle = FontStyle.Bold;
                pickedTheme.light = Color.FromArgb(181, 234, 177);
                pickedTheme.medium = Color.FromArgb(150, 208, 171);
                pickedTheme.dark = Color.FromArgb(94, 152, 116);
            }
        }
    }
}
