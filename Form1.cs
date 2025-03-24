using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace cubo
{
    public partial class cubo : Form
    {
        public int[] gambi = { 1, 1, 1, 1 };
        public int[] frente = { 1, 1, 1, 1 };
        public int[] ladoes = { 2, 2, 2, 2 };
        public int[] ladodi = { 4, 4, 4, 4 };
        public int[] back = { 3, 3, 3, 3 };
        public int[] up = { 5, 5, 5, 5 };
        public int[] down = { 6, 6, 6, 6 };

        void AlterarCorLabel(Label lbl)
        {
            switch (lbl.Text)
            {
                case "1":
                    lbl.ForeColor = Color.Red; // Verde
                    break;
                case "2":
                    lbl.ForeColor = Color.Green; // Azul
                    break;
                case "3":
                    lbl.ForeColor = Color.Orange; // Vermelho
                    break;
                case "4":
                    lbl.ForeColor = Color.Purple; // Cor padrão
                    break;
                case "5":
                    lbl.ForeColor = Color.Blue; // Cor padrão
                    break;
                case "6":
                    lbl.ForeColor = Color.Brown; // Cor padrão
                    break;
            }
        }


        public cubo()
        {
            InitializeComponent();
            InicializarVariaveis();

        }
        public void InicializarVariaveis()
        {

        }
        private void lbl_cima1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

          

        }

        private void btn_baixo1_Click(object sender, EventArgs e)
        {
            gambi[0] = frente[0];
            gambi[2] = frente[2];

            frente[0] = down[0];
            frente[2] = down[2];

            down[0] = back[0];
            down[2] = back[2];

            back[0] = up[0];
            back[2] = up[2];

            up[0] = gambi[0];
            up[2] = gambi[2];

            (lbl_cima1.Text, lbl_baixo1.Text) = (frente[0].ToString(), frente[2].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_esquerda_cima_Click_1(object sender, EventArgs e)
        {
            gambi[0] = frente[0];
            gambi[1] = frente[1];


            frente[0] = ladoes[0];
            frente[1] = ladoes[1];

            ladoes[0] = back[0];
            ladoes[1] = back[1];

            back[0] = ladodi[0];
            back[1] = ladodi[1];

            ladodi[0] = gambi[0];
            ladodi[1] = gambi[1];





            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_esquerda_baixo_Click_1(object sender, EventArgs e)
        {
            gambi[2] = frente[2];
            gambi[3] = frente[3];

            frente[2] = ladoes[2];
            frente[3] = ladoes[3];

            ladoes[2] = back[2];
            ladoes[3] = back[3];

            back[2] = ladodi[2];
            back[3] = ladodi[3];

            ladodi[2] = gambi[2];
            ladodi[3] = gambi[3];

            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_baixo2_Click_1(object sender, EventArgs e)
        {
            gambi[1] = frente[1];
            gambi[3] = frente[3];

            frente[1] = down[1];
            frente[3] = down[3];

            down[1] = back[1];
            down[3] = back[3];

            back[1] = up[1];
            back[3] = up[3];

            up[1] = gambi[1];
            up[3] = gambi[3];

            (lbl_cima2.Text, lbl_baixo2.Text) = (frente[1].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());
            
            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_cima2_Click(object sender, EventArgs e)
        {
            gambi[1] = frente[1];
            gambi[3] = frente[3];

            frente[1] = up[1];
            frente[3] = up[3];

            up[1] = back[1];
            up[3] = back[3];

            back[1] = down[1];
            back[3] = down[3];

            down[1] = gambi[1];
            down[3] = gambi[3];

            (lbl_cima2.Text, lbl_baixo2.Text) = (frente[1].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_cima1_Click(object sender, EventArgs e)
        {
            gambi[0] = frente[0];
            gambi[2] = frente[2];

            frente[0] = up[0];
            frente[2] = up[2];

            up[0] = back[0];
            up[2] = back[2];

            back[0] = down[0];
            back[2] = down[2];

            down[0] = gambi[0];
            down[2] = gambi[2];

            (lbl_cima1.Text, lbl_baixo1.Text) = (frente[0].ToString(), frente[2].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_direita_baixo_Click(object sender, EventArgs e)
        {
            gambi[2] = frente[2];
            gambi[3] = frente[3];


            frente[2] = ladodi[2];
            frente[3] = ladodi[3];

            ladodi[2] = back[2];
            ladodi[3] = back[3];

            back[2] = ladoes[2];
            back[3] = ladoes[3];

            ladoes[2] = gambi[2];
            ladoes[3] = gambi[3];





            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_direita_cima_Click(object sender, EventArgs e)
        {

            gambi[0] = frente[0];
            gambi[1] = frente[1];


            frente[0] = ladodi[0];
            frente[1] = ladodi[1];

            ladodi[0] = back[0];
            ladodi[1] = back[1];

            back[0] = ladoes[0];
            back[1] = ladoes[1];

            ladoes[0] = gambi[0];
            ladoes[1] = gambi[1];





            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);

        }

        private void btn_ram_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            List<int> randm = new List<int>
                        {
                                 1,1,1,1, 2,2,2,2, 3,3,3,3, 4,4,4,4, 5,5,5,5, 6,6,6,6
                            };
            void PreencherArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (randm.Count > 0)
                    {
                        int index = rand.Next(0, randm.Count);
                        array[i] = randm[index];
                        randm.RemoveAt(index);
                    }
                }
            }
            PreencherArray(frente);
            PreencherArray(up);
            PreencherArray(down);
            PreencherArray(ladodi);
            PreencherArray(ladoes);
            PreencherArray(back);

            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());
            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());


            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());


            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void btn_rcm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frente.Length; i++)
            {
                frente[i] = 1;
            }
            for (int i = 0; i < up.Length; i++)
            {
                up[i] = 5;
            }
            for (int i = 0; i < down.Length; i++)
            {
                down[i] = 6;
            }
            for (int i = 0; i < ladodi.Length; i++)
            {
                ladodi[i] = 4;
            }
            for (int i = 0; i < ladoes.Length; i++)
            {
                ladoes[i] = 2;
            }
            for (int i = 0; i < back.Length; i++)
            {
                back[i] = 3;
            }

            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());
            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gambi[0] = up[0];
            gambi[1] = up[1];

            up[0] = ladoes[0];
            up[1] = ladoes[1];

            ladoes[0] = down[0];
            ladoes[1] = down[1];

            down[0] = ladodi[0];
            down[1] = ladodi[1];

            ladodi[0] = gambi[0];
            ladodi[1] = gambi[1];

            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());
            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gambi[0] = up[0];
            gambi[1] = up[1];

            up[0] = ladodi[0];
            up[1] = ladodi[1];

            ladodi[0] = down[0];
            ladodi[1] = down[1];

            down[0] = ladoes[0];
            down[1] = ladoes[1];

            ladoes[0] = gambi[0];
            ladoes[1] = gambi[1];

            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());
            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gambi[2] = up[2];
            gambi[3] = up[3];

            up[2] = ladodi[2];
            up[3] = ladodi[3];

            ladodi[2] = down[2];
            ladodi[3] = down[3];

            down[2] = ladoes[2];
            down[3] = ladoes[3];

            ladoes[2] = gambi[2];
            ladoes[3] = gambi[3];

            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());
            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gambi[2] = up[2];
            gambi[3] = up[3];

            up[2] = ladoes[2];
            up[3] = ladoes[3];

            ladoes[2] = down[2];
            ladoes[3] = down[3];

            down[2] = ladodi[2];
            down[3] = ladodi[3];

            ladodi[2] = gambi[2];
            ladodi[3] = gambi[3];

            (lbl_cima1.Text, lbl_cima2.Text) = (frente[0].ToString(), frente[1].ToString());
            (lbl_baixo1.Text, lbl_baixo2.Text) = (frente[2].ToString(), frente[3].ToString());

            (lbl1.Text, lbl2.Text) = (back[0].ToString(), back[1].ToString());
            (lbl3.Text, lbl4.Text) = (back[2].ToString(), back[3].ToString());

            (lbl5.Text, lbl6.Text) = (ladodi[0].ToString(), ladodi[1].ToString());
            (lbl7.Text, lbl8.Text) = (ladodi[2].ToString(), ladodi[3].ToString());

            (lbl9.Text, lbl10.Text) = (up[0].ToString(), up[1].ToString());
            (lbl11.Text, lbl12.Text) = (up[2].ToString(), up[3].ToString());

            (lbl13.Text, lbl14.Text) = (ladoes[0].ToString(), ladoes[1].ToString());
            (lbl15.Text, lbl16.Text) = (ladoes[2].ToString(), ladoes[3].ToString());

            (lbl17.Text, lbl18.Text) = (down[0].ToString(), down[1].ToString());
            (lbl19.Text, lbl20.Text) = (down[2].ToString(), down[3].ToString());

            AlterarCorLabel(lbl_baixo1);
            AlterarCorLabel(lbl_baixo2);
            AlterarCorLabel(lbl_cima1);
            AlterarCorLabel(lbl_cima2);
            AlterarCorLabel(lbl1);
            AlterarCorLabel(lbl2);
            AlterarCorLabel(lbl3);
            AlterarCorLabel(lbl4);
            AlterarCorLabel(lbl5);
            AlterarCorLabel(lbl6);
            AlterarCorLabel(lbl7);
            AlterarCorLabel(lbl8);
            AlterarCorLabel(lbl9);
            AlterarCorLabel(lbl10);
            AlterarCorLabel(lbl11);
            AlterarCorLabel(lbl12);
            AlterarCorLabel(lbl13);
            AlterarCorLabel(lbl14);
            AlterarCorLabel(lbl15);
            AlterarCorLabel(lbl16);
            AlterarCorLabel(lbl17);
            AlterarCorLabel(lbl18);
            AlterarCorLabel(lbl19);
            AlterarCorLabel(lbl20);

        }
    }
}


