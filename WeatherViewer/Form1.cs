using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updateWeather();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateWeather();
        }

        void updateWeather() 
        {
            //TODO: Написать логику обновления погоды
        }
    }
}
