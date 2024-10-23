namespace Jogo_Da_Velha_TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        int Xpontos = 0, Opontos = 0, Empates = 0, Rodadas = 0;
        bool turno = true, final = false;
        string[] texto = new string[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;

            if (button1.Text == "" && final == false)
            {
                int index = button1.TabIndex;
                if (turno)
                {
                    button1.Text = "X";
                    texto[index] = button1.Text;
                    Rodadas++;
                    turno = !turno;
                    checagem(1);
                }
                else
                {
                    button1.Text = "O";
                    texto[index] = button1.Text;
                    Rodadas++;
                    turno = !turno;
                    checagem(2);
                }// final do codigo
            }

            void Vencedor(int quemGanhou)
            {
                final = true;
                if (quemGanhou == 1)
                {
                    Xpontos++;
                    label4.Text = Convert.ToString(Xpontos);

                    MessageBox.Show("Jogador X venceu !!!");
                    turno = true;
                }
                else
                {
                    Opontos++;
                    label5.Text = Convert.ToString(Opontos);

                    MessageBox.Show("Jogador O venceu !!!");
                    turno = false;
                }

            }

            void checagem(int player)
            {
                string suporte = "";
                if (player == 1)
                {
                    suporte = "X";
                }
                else
                {
                    suporte = "O";
                }// final do codigo

                for (int horizontal = 0; horizontal < 8; horizontal += 3)
                {
                    if (suporte == texto[horizontal])
                    {
                        if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                        {
                           
                            Vencedor(player);
                            return;
                        }
                    }
                }// fim do loop horizontal

                for (int vertical = 0; vertical < 3; vertical++)
                {
                    if (suporte == texto[vertical])
                    {
                        if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                        {
                            Vencedor(player);
                            return;
                        }
                    }
                }// fim do loop vertical


                if (texto[0] == suporte)
                {

                    if (texto[0] == texto[4] && texto[0] == texto[8])
                    {
                       
                        Vencedor(player);
                        return;
                    }
                }// fim diagonal principal
                if (texto[2] == suporte)
                {

                    if (texto[2] == texto[4] && texto[2] == texto[6])
                    {
                        Vencedor(player);
                        return;
                    }
                }
                if (Rodadas == 9 && final == false)
                {

                    Empates++;
                    label6.Text = Convert.ToString(Empates);

                    MessageBox.Show("Empate !!!");
                    final = true;
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Rodadas = 0;
            final = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
    }
}
