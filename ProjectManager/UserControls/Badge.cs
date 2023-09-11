using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.UserControls
{
    public partial class Badge : UserControl
    {
        public Badge(string badgeName)
        {
            InitializeComponent();
            lblText.Text = badgeName;
            int minWidth = 50;
            this.Width = (lblText.Text.Length * 10) > 50 ? (lblText.Text.Length * 10) : minWidth;
            switch (badgeName.ToLower().Trim())
            {
                case "design":
                    lblText.BackColor = ColorTranslator.FromHtml("#e9ff90");
                    break;
                case "app":
                case "mobile app": // Aynı renk için iki durum
                    lblText.BackColor = ColorTranslator.FromHtml("#fecfb4");
                    break;
                case "website":
                    lblText.BackColor = ColorTranslator.FromHtml("#b3d4fe");
                    break;
                case "planning":
                    lblText.BackColor = ColorTranslator.FromHtml("#dbe3eb");
                    break;
                case "research":
                    lblText.BackColor = ColorTranslator.FromHtml("#3498db");
                    break;
                case "frontend":
                    lblText.BackColor = ColorTranslator.FromHtml("#3498db");
                    break;
                case "backend":
                    lblText.BackColor = ColorTranslator.FromHtml("#FF8C00");
                    break;
                case "high":
                    lblText.BackColor = ColorTranslator.FromHtml("#FF5733");
                    break;
                case "medium":
                    lblText.BackColor = ColorTranslator.FromHtml("#FFA500");
                    Width += 15;
                    break;
                case "low":
                    lblText.BackColor = ColorTranslator.FromHtml("#5eb95e");
                    break;
                default:
                    break;
            }
        }
    }
}
