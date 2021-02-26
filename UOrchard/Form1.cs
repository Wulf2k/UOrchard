using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UOrchard
{
    public partial class UOrchard : Form
    {
        public UOrchard()
        {
            InitializeComponent();
        }

        private void UOrchard_Load(object sender, EventArgs e)
        {
            foreach (object ctrl in Controls)
            {
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    var cmb = ctrl as ComboBox;

                    void nu(string val)
                    {
                        cmb.Items.Add(val);
                    }

                    nu("Compassion");
                    nu("Despise");

                    nu("Honor");
                    nu("Shame");

                    nu("Honesty");
                    nu("Deceit");

                    nu("Humility");
                    nu("Pride");

                    nu("Justice");
                    nu("Wrong");

                    nu("Sacrifice");
                    nu("Covetous");

                    nu("Spirituality");
                    nu("Hythloth");

                    nu("Valor");
                    nu("Destard");

                    cmb.SelectedIndexChanged += new EventHandler(cmd_SelectedIndexChanged);
                }
                
            }
        }

        private void cmd_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var cmb = sender as ComboBox;
            switch (cmb.Text)
            {
                case "Compassion":
                case "Despise":
                    cmb.BackColor = Color.Yellow;
                    break;

                case "Honor":
                case "Shame":
                    cmb.BackColor = Color.Green;
                    break;

                case "Honesty":
                case "Deceit":
                    cmb.BackColor = Color.Red;
                    break;

                case "Humility":
                case "Pride":
                    cmb.BackColor = Color.Brown;
                    break;

                case "Justice":
                case "Wrong":
                    cmb.BackColor = Color.BlueViolet;
                    break;

                case "Sacrifice":
                case "Covetous":
                    cmb.BackColor = Color.DeepPink;
                    break;

                case "Spirituality":
                case "Hythloth":
                    cmb.BackColor = Color.DarkGoldenrod;
                    break;

                case "Valor":
                case "Destard":
                    cmb.BackColor = Color.Lavender;
                    break;

                default:
                    cmb.BackColor = Color.White;
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (object ctrl in Controls)
            {
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    var cmb = ctrl as ComboBox;

                    cmb.Text = "";
                    cmb.BackColor = Color.White;
                }
            }
        }
    }
}
