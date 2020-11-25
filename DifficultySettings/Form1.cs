using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        //Global variables
        string name;
        string difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "easy";
            easyButton.BackColor = Color.DarkRed;
            mediumButton.BackColor = Color.DimGray;
            hardButton.BackColor = Color.DimGray;
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "medium";
            mediumButton.BackColor = Color.DarkRed;
            hardButton.BackColor = Color.DimGray;
            easyButton.BackColor = Color.DimGray;
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "hard";
            easyButton.BackColor = Color.DimGray;
            mediumButton.BackColor = Color.DimGray;
            hardButton.BackColor = Color.DarkRed;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            descriptionLabel.Text = "Welcome, " + name + "\nGo forth and conquer the " + difficultyLevel + " difficulty!";
            descriptionLabel.Visible = true;
        }
    }
}
