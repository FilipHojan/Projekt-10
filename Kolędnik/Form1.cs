using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolędnik
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void dodawanie_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int x = 0; x < files.Length; x++)
                {
                    listapiosenek.Items.Add(files[x]);
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void listapiosenek_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[listapiosenek.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Losowosc_CheckedChanged(object sender, EventArgs e)
        {
            int randomIndex = _random.Next(listapiosenek.Items.Count);
            var randomItem = listapiosenek.Items[randomIndex];
            MessageBox.Show($"Random item at index {randomIndex} is {randomItem}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }
    }
}
