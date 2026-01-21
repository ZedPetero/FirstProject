using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance; 
        public Form3()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(materialSwitch1.Text == "DARK  ")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSwitch1.Text = "LIGHT  ";
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSwitch1.Text = "DARK  ";
            }
        }
    }
}
