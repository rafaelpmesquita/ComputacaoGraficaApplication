using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Roteiro1
{
    public partial class Tela : Form
    {
        Bitmap areaDesenho;
        Color corPreenche;

        public Tela()
        {
            InitializeComponent();
            LimparTela();
        }

        private void btDesenhar_Click(object sender, EventArgs e)
        {
            int x = (int)Convert.ToInt64(txtX.Text);
            int y = (int)Convert.ToInt64(txtY.Text);

            areaDesenho.SetPixel(x, y, corPreenche);
            imagem.Image = areaDesenho;
        }

        private void BtCor_Click(object sender, EventArgs e)
        {
            DialogResult result = cdlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                corPreenche = cdlg.Color;
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            LimparTela();

        }

        private void LimparTela()
        {
            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            imagem.Image = areaDesenho;
        }

        private void imagem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;

                txtX.Text = Convert.ToString(x);
                txtY.Text = Convert.ToString(y);

                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
        }

        private void btnTransladar_Click(object sender, EventArgs e)
        {
            Bitmap novaImagem = new Bitmap(imagem.Width, imagem.Height);
            Graphics g = Graphics.FromImage(novaImagem);
            int novaPosicaoX = Decimal.ToInt32(numericX.Value);
            int novaPosicaoY = Decimal.ToInt32(numericY.Value);
            if (areaDesenho.Width - novaPosicaoX <= imagem.Width && areaDesenho.Height - novaPosicaoY <= imagem.Height)
            {
                g.DrawImage(areaDesenho, novaPosicaoX, novaPosicaoY);
                imagem.Image = novaImagem;
            }
            g.Dispose();
        }


        private void btnEscala_Click(object sender, EventArgs e)
        {
            Bitmap desenhoOriginal = new Bitmap(areaDesenho);
            int larguraEscalada = (int)Math.Round(desenhoOriginal.Width * NumericFatorEscala.Value);
            int alturaEscalada = (int)Math.Round(desenhoOriginal.Height * NumericFatorEscala.Value);
            Bitmap desenhoEscalado = new Bitmap(larguraEscalada, alturaEscalada);
            for (int x = 0; x < larguraEscalada; x++)
            {
                for (int y = 0; y < alturaEscalada; y++)
                {
                    int xOriginal = (int)Math.Round(x / NumericFatorEscala.Value);
                    int yOriginal = (int)Math.Round(y / NumericFatorEscala.Value);

                    if (xOriginal >= 0 && xOriginal < desenhoOriginal.Width && yOriginal >= 0 && yOriginal < desenhoOriginal.Height)
                    {
                        desenhoEscalado.SetPixel(x, y, desenhoOriginal.GetPixel(xOriginal, yOriginal));
                    }
                }
            }

            imagem.Image = desenhoEscalado;
        }

        private void rotacionarButton_Click(object sender, EventArgs e)
        {
            Bitmap rodarImagem = new Bitmap(areaDesenho);
            rodarImagem.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imagem.Image = rodarImagem;
        }

        private void reflexaoX_Click(object sender, EventArgs e)
        {
            Bitmap desenhoOriginal = new Bitmap(areaDesenho);
            Bitmap desenhoRefletido = new Bitmap(desenhoOriginal.Width, desenhoOriginal.Height);
            for (int x = 0; x < desenhoOriginal.Width; x++)
            {
                for (int y = 0; y < desenhoOriginal.Height; y++)
                {
                    int yRefletido = desenhoOriginal.Height - y - 1;
                    desenhoRefletido.SetPixel(x, yRefletido, desenhoOriginal.GetPixel(x, y));
                }
            }
            imagem.Image = desenhoRefletido;
        }

        private void reflexaoY_Click(object sender, EventArgs e)
        {
            Bitmap desenhoOriginal = new Bitmap(areaDesenho);
            Bitmap desenhoRefletido = new Bitmap(desenhoOriginal.Width, desenhoOriginal.Height);
            for (int x = 0; x < desenhoOriginal.Width; x++)
            {
                for (int y = 0; y < desenhoOriginal.Height; y++)
                {
                    int xRefletido = desenhoOriginal.Width - x - 1;
                    desenhoRefletido.SetPixel(xRefletido, y, desenhoOriginal.GetPixel(x, y));
                }
            }
            imagem.Image = desenhoRefletido;

        }

        private void reflexaoOrigem_Click(object sender, EventArgs e)
        {
            Bitmap desenhoOriginal = new Bitmap(areaDesenho);
            Bitmap desenhoRefletido = new Bitmap(desenhoOriginal.Width, desenhoOriginal.Height);
            for (int x = 0; x < desenhoOriginal.Width; x++)
            {
                for (int y = 0; y < desenhoOriginal.Height; y++)
                {
                    int xRefletido = desenhoOriginal.Width - x - 1;
                    int yRefletido = desenhoOriginal.Height - y - 1;
                    desenhoRefletido.SetPixel(xRefletido, yRefletido, desenhoOriginal.GetPixel(x, y));
                }
            }
            imagem.Image = desenhoRefletido;

        }

        private void cisalhamentoX_Click(object sender, EventArgs e)
        {
            Bitmap desenhoOriginal = new Bitmap(areaDesenho);
            Bitmap desenhoCisalhado = new Bitmap(desenhoOriginal.Width, desenhoOriginal.Height);
            double[,] matrizTransformacao = {{1, 0.5, 0},
                                                 {0, 1, 0},
                                                 {0, 0, 1}};

            for (int x = 0; x < desenhoOriginal.Width; x++)
            {
                for (int y = 0; y < desenhoOriginal.Height; y++)
                {
                    int xCisalhado = (int)Math.Round(matrizTransformacao[0, 0] * x + matrizTransformacao[0, 1] * y + matrizTransformacao[0, 2]);
                    int yCisalhado = (int)Math.Round(matrizTransformacao[1, 0] * x + matrizTransformacao[1, 1] * y + matrizTransformacao[1, 2]);

                    if (xCisalhado >= 0 && xCisalhado < desenhoCisalhado.Width && yCisalhado >= 0 && yCisalhado < desenhoCisalhado.Height)
                    {
                        desenhoCisalhado.SetPixel(xCisalhado, yCisalhado, desenhoOriginal.GetPixel(x, y));
                    }
                }
            }

            // Atribuir o novo desenho cisalhado ao PictureBox
            imagem.Image = desenhoCisalhado;
        }

        private void cisalhamentoY_Click(object sender, EventArgs e)
        {
            Bitmap desenhoOriginal = new Bitmap(areaDesenho);
            Bitmap desenhoCisalhado = new Bitmap(desenhoOriginal.Width, desenhoOriginal.Height);


            double[,] matrizTransformacao = {{1,0, 0},
                                                 {0, 0.3, 0},
                                                 {0, 0, 1}};

            for (int x = 0; x < desenhoOriginal.Width; x++)
            {
                for (int y = 0; y < desenhoOriginal.Height; y++)
                {
                    int xCisalhado = (int)Math.Round(matrizTransformacao[0, 0] * x + matrizTransformacao[0, 1] * y + matrizTransformacao[0, 2]);
                    int yCisalhado = (int)Math.Round(matrizTransformacao[1, 0] * x + matrizTransformacao[1, 1] * y + matrizTransformacao[1, 2]);

                    if (xCisalhado >= 0 && xCisalhado < desenhoCisalhado.Width && yCisalhado >= 0 && yCisalhado < desenhoCisalhado.Height)
                    {
                        desenhoCisalhado.SetPixel(xCisalhado, yCisalhado, desenhoOriginal.GetPixel(x, y));
                    }
                }
            }

            imagem.Image = desenhoCisalhado;
        }
    }
}
