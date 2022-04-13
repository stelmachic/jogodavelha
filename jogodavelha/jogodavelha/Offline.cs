using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace jogodavelha
{
    public partial class Offline : Form
    {
        SoundPlayer soundPlayer= new SoundPlayer();
        int i = 0;
        string elemento;
        public Offline()
        {
            InitializeComponent();
        }

        private bool Linha1 => but11.Text == elemento && but12.Text == elemento && but13.Text == elemento;
        private bool Linha2 => but21.Text == elemento && but22.Text == elemento && but23.Text == elemento;
        private bool Linha3 => but31.Text == elemento && but32.Text == elemento && but33.Text == elemento;
        private bool Diagonal1  => but11.Text == elemento && but22.Text == elemento && but33.Text == elemento;
        private bool Diagonal2 => but13.Text == elemento && but22.Text == elemento && but31.Text == elemento;
        private bool Coluna1 => but11.Text == elemento && but21.Text == elemento && but31.Text == elemento;
        private bool Coluna2 => but12.Text == elemento && but22.Text == elemento && but32.Text == elemento;
        private bool Coluna3 => but13.Text == elemento && but23.Text == elemento && but33.Text == elemento;

        private void btn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (i == 0)
            {
                elemento = "X";
                i++;
                button.Text = elemento;
                button.Enabled = false;
            }
            else if (i == 1)
            {
                elemento = "O";
                i--;
                button.Text = elemento;
                button.Enabled = false;
            }

            if (Linha1 || Linha2 || Linha3 || Diagonal1 || Diagonal2 || Coluna1 || Coluna2 || Coluna3)
            {
                MessageBox.Show($"O {elemento} ganhou");
            }
        }
    }
}
