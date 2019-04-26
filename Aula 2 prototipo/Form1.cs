using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aula_2_prototipo
{
    public partial class frmMove : Form
    {
        private bool paraEsquerda;
        private bool paraDireita;
        private bool paraCima;
        private bool paraBaixo;
        private int velocidade = 10;

        public frmMove()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (paraEsquerda)
            {
                pbPersonagem.Left -= velocidade;
            } else if (paraDireita)
            {
                pbPersonagem.Left += velocidade;
            } else if (paraCima)
            {
                pbPersonagem.Top -= velocidade;
            } else if (paraBaixo)
            {
                pbPersonagem.Top += velocidade;
            }

            //colisão teste

            //if (
               //pbPersonagem.Location.X >= pbMuro.Location.X - pbMuro.Size.Width + 5
              // &&
               //pbPersonagem.Location.X <= pbMuro.Location.X + pbMuro.Size.Width - 5
              // &&
              // pbPersonagem.Location.Y >= pbMuro.Location.Y - pbMuro.Size.Height + 5
              // &&
              // pbPersonagem.Location.Y <= pbMuro.Location.Y + pbMuro.Size.Height - 5
               //)
            //{                
                //pbMuro.Visible = false;
            //}

            //Professor Iterar Comandos

            foreach(Control item in this.Controls)
            {
                //Verificar se o Control é uma picture box e se sua Tag é a muro
                if(item is PictureBox && (string)item.Tag == "muro")
                {
                    //MessageBox.Show(item.ToString());

                    //Detectar se a PictureBox interage com o personagem (Colisão)
                    //Bounds retorna a posição do objeto

                    if (((PictureBox)item).Bounds.IntersectsWith(pbPersonagem.Bounds))
                    {
                        timer1.Stop();
                        pbPersonagem.Visible = false;
                        GameOver();
                        
                    }

                }
            }



        } 
        private void GameOver()
        {
            lblGameOver.Visible = true;
            imgGameOver.Visible = true;           
            pbMuro.Visible = false;
            pbPersonagem.Visible = false;
        }

        private void frmMove_KeyDown(object sender, KeyEventArgs e)
        {
            //Se o usuário pressionar a tecla para a esquerda etc
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = true;
            } else if (e.KeyCode == Keys.Right)
            {
                paraDireita = true;
            } else if (e.KeyCode == Keys.Up)
            {
                paraCima = true;
            } else if (e.KeyCode == Keys.Down)
            {
                paraBaixo = true;
            }
        }

        private void frmMove_KeyUp(object sender, KeyEventArgs e)
        {  //Quando o usuário não estiver apertando ele para
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                paraDireita = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                paraCima = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                paraBaixo = false;
            }
        }

        private void frmMove_Load(object sender, EventArgs e)
        {

        }
    }
}
