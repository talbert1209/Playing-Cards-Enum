using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playing_Cards_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawACard_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var randomSuit = random.Next(4);
            var randomValue = random.Next(1, 14);

            var card = new Card((Suit) randomSuit, (Value) randomValue);

            MessageBox.Show(card.Name);
        }
    }
}
