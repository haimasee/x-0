using System.Drawing.Text;

namespace Krestiki_Noliki
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;
        private Button[,] buttons = new Button[3, 3];
        private int player;
        public Form1()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            player = 1;
            label1.Text = "Текущий ход: ";
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                }
            }
            setButtons();
        }

        private void setButtons()
        {
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j].Location = new Point(0 + 189 * j, 0 + 189 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Segoe UI"), 72);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    label1.Text = "Текущий ход: Крестики";
                    break;

                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    label1.Text = "Текущий ход: Нолики";
                    break;
            }

            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkwin(sender as Button);
        }
        private void checkwin(Button pressedButton)
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }

            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Выиграли: " + pressedButton.Text);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Текущий ход: ";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }

        private void выборИгрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void крестикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ноликиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

//public void Bot
//Random random = new Random();
//while (true)
//{
//    int num1 = Random.Next(1, 4);
//    int num2 = Random.Next(1, 4);
//    var myBut = (Bytton)this.FindName($"pole{num1}_{num2}");
//    if (myBut.IsEnabled)
//    {
//        myBut.Content = ValidationConstraints == 1 ? "o" : "x";
//        myBut.IsEnabled = false;
//        tictac.Click(NewsStyleUriParser int[] {num1 1, num2 1}, val);
//    return;
//    }