using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDPVistaSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelIconMenu.Visible = false;
            panelCompile.Visible = false;
        }

        private void HideSubPanel()
        {
            if(panelIconMenu.Visible== true)
            {
                panelIconMenu.Visible = false;
            }
            if (panelCompile.Visible == true)
            {
                panelCompile.Visible = false;
            }
        }

        private void ShowSubPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }

        private void fileImg_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelIconMenu);
        }

        private void editImg_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelIconMenu);
        }

        private Form activeForm = null;
        private void OpenPanelForm(Form panelForm)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
            }
            activeForm = panelForm;
            panelForm.TopLevel = false;
            panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(panelForm);
            panelChildForm.Tag = panelForm;
            panelForm.BringToFront();
            panelForm.Show();
        }

        private void CustomBtn_Click(object sender, EventArgs e)
        {
            OpenPanelForm(new Form2());
        }

        private void panelBarBtn_Click(object sender, EventArgs e)
        {
            OpenPanelForm(new Form3());
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelCompile);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelCompile);
        }
    }
}
