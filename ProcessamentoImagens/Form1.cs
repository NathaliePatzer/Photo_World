using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcessamentoImagens
{
    public partial class Form1 : Form
    {

        Bitmap img1; //image1
        Bitmap img2; //grey escale
        Bitmap img3; //image2
        Bitmap img4; //sum
        Bitmap img5; //subtract
        Bitmap img6; //contrast multiply
        Bitmap img7; //contrast divide
        Bitmap img8; //bright more
        Bitmap img9; //bright less
        Bitmap img10; //blend
        Bitmap img11; //difference1grey
        Bitmap img12; //difference2grey
        Bitmap img13; //difference1
        Bitmap img14; //difference2
        Bitmap img15; //differencefinal
        Bitmap img16; //average
        Bitmap img17; //flip x
        Bitmap img18; //flip y
        Bitmap img19; //differenceColor1
        Bitmap img20; //differenceColor2
        Bitmap img21; //differenceColo23r
        Bitmap img22; //limiar
        Bitmap img23; //not
        Bitmap img24; //and
        Bitmap img25; //or
        Bitmap img26; //xor
        Bitmap img27; //histogram
        Bitmap img28; //convolucao
        Bitmap img29; //gaussian
        Bitmap img30; //bordas
        Bitmap img31; //dilatacao 
        Bitmap img32; //erosao

        byte[,] vImg1Gray;
        byte[,] vImg2Gray;
        byte[,] vImg1Img2SumR;
        byte[,] vImg1Img2SumG;
        byte[,] vImg1Img2SumB;
        byte[,] vImg1Img2DifR;
        byte[,] vImg1Img2DifG;
        byte[,] vImg1Img2DifB;
        byte[,] vImg1ContMultR;
        byte[,] vImg1ContMultG;
        byte[,] vImg1ContMultB;
        byte[,] vImg1ContDivR;
        byte[,] vImg1ContDivG;
        byte[,] vImg1ContDivB;
        byte[,] vImg1BMoreR;
        byte[,] vImg1BMoreG;
        byte[,] vImg1BMoreB;
        byte[,] vImg1BLessR;
        byte[,] vImg1BLessG;
        byte[,] vImg1BLessB;
        byte[,] ImgBlendR;
        byte[,] ImgBlendG;
        byte[,] ImgBlendB;
        byte[,] ImgBlendA;
        byte[,] matC;
        byte[,] matD;
        byte[,] matE;
        byte[,] difR;
        byte[,] difG;
        byte[,] difB;
        byte[,] limiar;
        byte[,] not;
        byte[,] and;
        byte[,] or;
        byte[,] xor;
        byte[,] hvImg;
        byte[,] hvImgNew;
        byte[,] convBefore;
        byte[,] convAfter;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        byte[,] vImg2R;
        byte[,] vImg2G;
        byte[,] vImg2B;
        byte[,] vImg2A;

        public void LimparForm()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            txBright.Text = "";
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        //CARREGAR IMAGEM 1
        private void LoadImageOne_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;

                bool bLoadImgOK = false;

                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;

                }
            }
        }

        //CONVERSÃO PARA ESCALA DE CINZA - IMAGEM 1
        private void ConvertGray_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img2 = new Bitmap(img1.Width, img1.Height);
                vImg1Gray = new byte[img1.Width, img1.Height];
                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                        vImg1Gray[i, j] = pixelIntensity;

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        Color cor = Color.FromArgb(
                            255,
                            vImg1Gray[i, j],
                            vImg1Gray[i, j],
                            vImg1Gray[i, j]);

                        img2.SetPixel(i, j, cor);
                    }
                }

                pictureBox2.Image = img2;
            }
        }

        //AUMENTAR BRILHO - IMAGEM 1
        private void BrightMore_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    img8 = new Bitmap(img1.Width, img1.Height);
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1BMoreR = new byte[img1.Width, img1.Height];
                    vImg1BMoreG = new byte[img1.Width, img1.Height];
                    vImg1BMoreB = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;

                            float pixelIntensityR = vImg1R[i, j] + Convert.ToSingle(txBright.Text);
                            float pixelIntensityG = vImg1G[i, j] + Convert.ToSingle(txBright.Text);
                            float pixelIntensityB = vImg1B[i, j] + Convert.ToSingle(txBright.Text);

                            if (pixelIntensityR > 255)
                            {
                                pixelIntensityR = 255;
                            }

                            if (pixelIntensityG > 255)
                            {
                                pixelIntensityG = 255;
                            }

                            if (pixelIntensityB > 255)
                            {
                                pixelIntensityB = 255;
                            }

                            vImg1BMoreR[i, j] = Convert.ToByte(pixelIntensityR);
                            vImg1BMoreG[i, j] = Convert.ToByte(pixelIntensityG);
                            vImg1BMoreB[i, j] = Convert.ToByte(pixelIntensityB);

                            Color cor = Color.FromArgb(
                                255,
                                vImg1BMoreR[i, j],
                                vImg1BMoreG[i, j],
                                vImg1BMoreB[i, j]);

                            img8.SetPixel(i, j, cor);
                        }
                    }
                    pictureBox2.Image = img8;
                }
            }
        }

        //DIMINUIR BRILHO - IMAGEM 1
        private void BrightLess_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    img9 = new Bitmap(img1.Width, img1.Height);
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1BLessR = new byte[img1.Width, img1.Height];
                    vImg1BLessG = new byte[img1.Width, img1.Height];
                    vImg1BLessB = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;

                            float pixelIntensityR = vImg1R[i, j] - Convert.ToSingle(txBright.Text);
                            float pixelIntensityG = vImg1G[i, j] - Convert.ToSingle(txBright.Text);
                            float pixelIntensityB = vImg1B[i, j] - Convert.ToSingle(txBright.Text);

                            if (pixelIntensityR < 0)
                            {
                                pixelIntensityR = 0;
                            }

                            if (pixelIntensityG < 0)
                            {
                                pixelIntensityG = 0;
                            }

                            if (pixelIntensityB < 0)
                            {
                                pixelIntensityB = 0;
                            }

                            vImg1BLessR[i, j] = Convert.ToByte(pixelIntensityR);
                            vImg1BLessG[i, j] = Convert.ToByte(pixelIntensityG);
                            vImg1BLessB[i, j] = Convert.ToByte(pixelIntensityB);

                            Color cor = Color.FromArgb(
                                255,
                                vImg1BLessR[i, j],
                                vImg1BLessG[i, j],
                                vImg1BLessB[i, j]);

                            img9.SetPixel(i, j, cor);
                        }
                    }
                    pictureBox2.Image = img9;
                }
            }
        }

        //CARREGAR IMAGEM 2
        private void LoadImageTwo_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;

                bool bLoadImgOK = false;

                try
                {
                    img3 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox3.Image = img3;

                }
            }
        }

        //SOMAR IMAGENS 
        private void SumImages_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img4 = new Bitmap(img3.Width, img3.Height);
                vImg1Img2SumR = new byte[img3.Width, img3.Height];
                vImg1Img2SumG = new byte[img3.Width, img3.Height];
                vImg1Img2SumB = new byte[img3.Width, img3.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                vImg2R = new byte[img1.Width, img1.Height];
                vImg2G = new byte[img1.Width, img1.Height];
                vImg2B = new byte[img1.Width, img1.Height];
                vImg2A = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img3.Width; i++)
                {
                    for (int j = 0; j < img3.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        Color pixel2 = img3.GetPixel(i, j);

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        byte R2 = pixel2.R;
                        byte G2 = pixel2.G;
                        byte B2 = pixel2.B;
                        byte A2 = pixel2.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        vImg2R[i, j] = R2;
                        vImg2G[i, j] = G2;
                        vImg2B[i, j] = B2;
                        vImg2A[i, j] = A2;

                        int pixelColorR = vImg1R[i, j] + vImg2R[i, j];
                        int pixelColorG = vImg1G[i, j] + vImg2G[i, j];
                        int pixelColorB = vImg1B[i, j] + vImg2B[i, j];

                        if (pixelColorR > 255)
                        {
                            pixelColorR = 255;
                        }

                        if (pixelColorG > 255)
                        {
                            pixelColorG = 255;
                        }

                        if (pixelColorB > 255)
                        {
                            pixelColorB = 255;
                        }

                        vImg1Img2SumR[i, j] = Convert.ToByte(pixelColorR);
                        vImg1Img2SumG[i, j] = Convert.ToByte(pixelColorG);
                        vImg1Img2SumB[i, j] = Convert.ToByte(pixelColorB);


                        Color cor = Color.FromArgb(
                                    255,
                              vImg1Img2SumR[i, j],
                              vImg1Img2SumG[i, j],
                              vImg1Img2SumB[i, j]);

                        img4.SetPixel(i, j, cor);

                    }
                }

                pictureBox2.Image = img4;

            }
        }

        //SUBTRAIR IMAGENS
        private void SubtractImages_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img5 = new Bitmap(img3.Width, img3.Height);
                vImg1Img2DifR = new byte[img3.Width, img3.Height];
                vImg1Img2DifG = new byte[img3.Width, img3.Height];
                vImg1Img2DifB = new byte[img3.Width, img3.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                vImg2R = new byte[img1.Width, img1.Height];
                vImg2G = new byte[img1.Width, img1.Height];
                vImg2B = new byte[img1.Width, img1.Height];
                vImg2A = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img3.Width; i++)
                {
                    for (int j = 0; j < img3.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        Color pixel2 = img3.GetPixel(i, j);

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        byte R2 = pixel2.R;
                        byte G2 = pixel2.G;
                        byte B2 = pixel2.B;
                        byte A2 = pixel2.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        vImg2R[i, j] = R2;
                        vImg2G[i, j] = G2;
                        vImg2B[i, j] = B2;
                        vImg2A[i, j] = A2;

                        int pixelColorR = vImg1R[i, j] - vImg2R[i, j];
                        int pixelColorG = vImg1G[i, j] - vImg2G[i, j];
                        int pixelColorB = vImg1B[i, j] - vImg2B[i, j];

                        if (pixelColorR < 0)
                        {
                            pixelColorR = 0;
                        }

                        if (pixelColorG < 0)
                        {
                            pixelColorG = 0;
                        }

                        if (pixelColorB < 0)
                        {
                            pixelColorB = 0;
                        }

                        vImg1Img2DifR[i, j] = Convert.ToByte(pixelColorR);
                        vImg1Img2DifG[i, j] = Convert.ToByte(pixelColorG);
                        vImg1Img2DifB[i, j] = Convert.ToByte(pixelColorB);


                        Color cor = Color.FromArgb(
                                    255,
                              vImg1Img2DifR[i, j],
                              vImg1Img2DifG[i, j],
                              vImg1Img2DifB[i, j]);

                        img5.SetPixel(i, j, cor);

                    }
                }

                pictureBox2.Image = img5;

            }
        }

        //AUMENTAR CONTRASTE
        private void ContrastMultiply_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    img6 = new Bitmap(img1.Width, img1.Height);
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1ContMultR = new byte[img1.Width, img1.Height];
                    vImg1ContMultG = new byte[img1.Width, img1.Height];
                    vImg1ContMultB = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;

                            float pixelIntensityR = vImg1R[i, j] * Convert.ToSingle(txBright.Text);
                            float pixelIntensityG = vImg1G[i, j] * Convert.ToSingle(txBright.Text);
                            float pixelIntensityB = vImg1B[i, j] * Convert.ToSingle(txBright.Text);

                            if (pixelIntensityR > 255)
                            {
                                pixelIntensityR = 255;
                            }

                            if (pixelIntensityG > 255)
                            {
                                pixelIntensityG = 255;
                            }

                            if (pixelIntensityB > 255)
                            {
                                pixelIntensityB = 255;
                            }

                            if (pixelIntensityR < 0)
                            {
                                pixelIntensityR = 0;
                            }

                            if (pixelIntensityG < 0)
                            {
                                pixelIntensityG = 0;
                            }

                            if (pixelIntensityB < 0)
                            {
                                pixelIntensityB = 0;
                            }

                            vImg1ContMultR[i, j] = Convert.ToByte(pixelIntensityR);
                            vImg1ContMultG[i, j] = Convert.ToByte(pixelIntensityG);
                            vImg1ContMultB[i, j] = Convert.ToByte(pixelIntensityB);

                            Color cor = Color.FromArgb(
                                255,
                               vImg1ContMultR[i, j],
                               vImg1ContMultG[i, j],
                               vImg1ContMultB[i, j]);

                            img6.SetPixel(i, j, cor);
                        }
                    }
                    pictureBox2.Image = img6;
                }
            }
        }

        //DIMINUIR CONTRASTE
        private void ContrastDivide_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    img7 = new Bitmap(img1.Width, img1.Height);
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1ContDivR = new byte[img1.Width, img1.Height];
                    vImg1ContDivG = new byte[img1.Width, img1.Height];
                    vImg1ContDivB = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;

                            float pixelIntensityR = vImg1R[i, j] / Convert.ToSingle(txBright.Text);
                            float pixelIntensityG = vImg1G[i, j] / Convert.ToSingle(txBright.Text);
                            float pixelIntensityB = vImg1B[i, j] / Convert.ToSingle(txBright.Text);

                            if (pixelIntensityR > 255)
                            {
                                pixelIntensityR = 255;
                            }

                            if (pixelIntensityG > 255)
                            {
                                pixelIntensityG = 255;
                            }

                            if (pixelIntensityB > 255)
                            {
                                pixelIntensityB = 255;
                            }

                            if (pixelIntensityR < 0)
                            {
                                pixelIntensityR = 0;
                            }

                            if (pixelIntensityG < 0)
                            {
                                pixelIntensityG = 0;
                            }

                            if (pixelIntensityB < 0)
                            {
                                pixelIntensityB = 0;
                            }

                            vImg1ContDivR[i, j] = Convert.ToByte(pixelIntensityR);
                            vImg1ContDivG[i, j] = Convert.ToByte(pixelIntensityG);
                            vImg1ContDivB[i, j] = Convert.ToByte(pixelIntensityB);

                            Color cor = Color.FromArgb(
                                255,
                               vImg1ContDivR[i, j],
                               vImg1ContDivG[i, j],
                               vImg1ContDivB[i, j]);

                            img7.SetPixel(i, j, cor);
                        }
                    }
                    pictureBox2.Image = img7;
                }
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Nenhuma imagem disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Cria uma instância do SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Define o filtro de tipos de arquivo
                saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

                // Define o título da caixa de diálogo
                saveFileDialog.Title = "Save an Image File";

                // Define a extensão padrão do arquivo
                saveFileDialog.DefaultExt = "png";

                // Exibe o SaveFileDialog e verifica se o usuário clicou em "Salvar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o caminho do arquivo que o usuário escolheu
                    string filePath = saveFileDialog.FileName;

                    // Salva a imagem do PictureBox no local escolhido
                    pictureBox2.Image.Save(filePath);

                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void Blending_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor! (0.0 - 1.0) ;) ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    img10 = new Bitmap(img3.Width, img3.Height);

                    ImgBlendR = new byte[img3.Width, img3.Height];
                    ImgBlendG = new byte[img3.Width, img3.Height];
                    ImgBlendB = new byte[img3.Width, img3.Height];
                    ImgBlendA = new byte[img3.Width, img3.Height];

                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                    vImg2R = new byte[img1.Width, img1.Height];
                    vImg2G = new byte[img1.Width, img1.Height];
                    vImg2B = new byte[img1.Width, img1.Height];
                    vImg2A = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img3.Width; i++)
                    {
                        for (int j = 0; j < img3.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            Color pixel2 = img3.GetPixel(i, j);

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            byte R2 = pixel2.R;
                            byte G2 = pixel2.G;
                            byte B2 = pixel2.B;
                            byte A2 = pixel2.A;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;
                            vImg1A[i, j] = A;

                            vImg2R[i, j] = R2;
                            vImg2G[i, j] = G2;
                            vImg2B[i, j] = B2;
                            vImg2A[i, j] = A2;

                            float c = Convert.ToSingle(txBright.Text);

                            float pixelColorR = (c * vImg1R[i, j]) + (1 - c) * vImg2R[i, j];
                            float pixelColorG = (c * vImg1G[i, j]) + (1 - c) * vImg2G[i, j];
                            float pixelColorB = (c * vImg1B[i, j]) + (1 - c) * vImg2B[i, j];
                            float pixelColorA = (c * vImg1A[i, j]) + (1 - c) * vImg2A[i, j];

                            if (pixelColorR > 255)
                            {
                                pixelColorR = 255;
                            }

                            if (pixelColorG > 255)
                            {
                                pixelColorG = 255;
                            }

                            if (pixelColorB > 255)
                            {
                                pixelColorB = 255;
                            }

                            if (pixelColorA > 255)
                            {
                                pixelColorA = 255;
                            }

                            if (pixelColorR < 0)
                            {
                                pixelColorR = 0;
                            }

                            if (pixelColorG < 0)
                            {
                                pixelColorG = 0;
                            }

                            if (pixelColorB < 0)
                            {
                                pixelColorB = 0;
                            }

                            if (pixelColorA < 0)
                            {
                                pixelColorA = 0;
                            }


                            ImgBlendR[i, j] = Convert.ToByte(pixelColorR);
                            ImgBlendG[i, j] = Convert.ToByte(pixelColorG);
                            ImgBlendB[i, j] = Convert.ToByte(pixelColorB);
                            ImgBlendA[i, j] = Convert.ToByte(pixelColorA);

                            Color cor = Color.FromArgb(
                                  ImgBlendA[i, j],
                                  ImgBlendR[i, j],
                                  ImgBlendG[i, j],
                                  ImgBlendB[i, j]);

                            img10.SetPixel(i, j, cor);

                        }
                    }

                    pictureBox2.Image = img10;
                }
            }
        }

        private void Difference_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //VERIFICAÇÃO DE ESCALA DE CINZA
                img11 = new Bitmap(img1);
                img12 = new Bitmap(img3);

                bool isGray = true;
                int tolerance = 2;

                for (int i = 0; i < img11.Width; i++)
                {
                    for (int j = 0; j < img11.Height; j++)
                    {
                        if (!isGray)
                        {
                            break;
                        }

                        Color pixel = img11.GetPixel(i, j);
                        Color pixel2 = img12.GetPixel(i, j);

                        int R = pixel.R;
                        int G = pixel.G;
                        int B = pixel.B;

                        int R2 = pixel2.R;
                        int G2 = pixel2.G;
                        int B2 = pixel2.B;

                        if (Math.Abs(R - G) > tolerance || Math.Abs(G - B) > tolerance || Math.Abs(R - B) > tolerance ||
                            Math.Abs(R2 - G2) > tolerance || Math.Abs(G2 - B2) > tolerance || Math.Abs(R2 - B2) > tolerance)
                        {
                            isGray = false;
                        }

                        if (!isGray)
                        {
                            MessageBox.Show("Por favor, escolha imagens em Escala de Cinza!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (isGray)
                {
                    //CÁLCULOS
                    //Salva os valores dos pixels em duas matrizes e duas imagens
                    img13 = new Bitmap(img1.Width, img1.Height);
                    img14 = new Bitmap(img3.Width, img3.Height);
                    img15 = new Bitmap(img3.Width, img3.Height);

                    matC = new byte[img3.Width, img3.Height];
                    matD = new byte[img3.Width, img3.Height];
                    matE = new byte[img3.Width, img3.Height];

                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg2Gray = new byte[img3.Width, img3.Height];

                    //Percorre todos os pixels da imagem...
                    for (int i = 0; i < img3.Width; i++)
                    {
                        for (int j = 0; j < img3.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            Color pixel2 = img3.GetPixel(i, j);

                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg1Gray[i, j] = pixelIntensity;

                            byte pixelIntensity2 = Convert.ToByte((pixel2.R + pixel2.G + pixel2.B) / 3);
                            vImg2Gray[i, j] = pixelIntensity2;

                            Color cor = Color.FromArgb(
                                255,
                                vImg1Gray[i, j],
                                vImg1Gray[i, j],
                                vImg1Gray[i, j]);

                            img13.SetPixel(i, j, cor);

                            Color cor2 = Color.FromArgb(
                                255,
                                vImg2Gray[i, j],
                                vImg2Gray[i, j],
                                vImg2Gray[i, j]);

                            img14.SetPixel(i, j, cor2);
                        }
                    }
                    //Cálculo da matriz C
                    for (int i = 0; i < img3.Width; i++)
                    {
                        for (int j = 0; j < img3.Height; j++)
                        {
                            int pixelIntensity = vImg1Gray[i, j] - vImg2Gray[i, j];

                            if (pixelIntensity < 0)
                            {
                                pixelIntensity = 0;
                            }

                            matC[i, j] = Convert.ToByte(pixelIntensity);
                        }
                    }

                    //Cálculo da matriz D
                    for (int i = 0; i < img3.Width; i++)
                    {
                        for (int j = 0; j < img3.Height; j++)
                        {
                            int pixelIntensity = vImg2Gray[i, j] - vImg1Gray[i, j];

                            if (pixelIntensity < 0)
                            {
                                pixelIntensity = 0;
                            }

                            matD[i, j] = Convert.ToByte(pixelIntensity);
                        }
                    }

                    //Cálculo da matriz E
                    for (int i = 0; i < img3.Width; i++)
                    {
                        for (int j = 0; j < img3.Height; j++)
                        {
                            int pixelIntensity = matC[i, j] + matD[i, j];

                            if (pixelIntensity < 0)
                            {
                                pixelIntensity = 0;
                            }

                            if (pixelIntensity > 255)
                            {
                                pixelIntensity = 255;
                            }

                            matE[i, j] = Convert.ToByte(pixelIntensity);

                            Color cor = Color.FromArgb(
                                255,
                                matE[i, j],
                                matE[i, j],
                                matE[i, j]);

                            img15.SetPixel(i, j, cor);

                        }

                        pictureBox2.Image = img15;
                    }
                }
            }
        }

        private void Average_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img16 = new Bitmap(img3.Width, img3.Height);

                difR = new byte[img3.Width, img3.Height];
                difG = new byte[img3.Width, img3.Height];
                difB = new byte[img3.Width, img3.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                vImg2R = new byte[img1.Width, img1.Height];
                vImg2G = new byte[img1.Width, img1.Height];
                vImg2B = new byte[img1.Width, img1.Height];
                vImg2A = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img3.Width; i++)
                {
                    for (int j = 0; j < img3.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        Color pixel2 = img3.GetPixel(i, j);

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        byte R2 = pixel2.R;
                        byte G2 = pixel2.G;
                        byte B2 = pixel2.B;
                        byte A2 = pixel2.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        vImg2R[i, j] = R2;
                        vImg2G[i, j] = G2;
                        vImg2B[i, j] = B2;
                        vImg2A[i, j] = A2;

                        difR[i, j] = Convert.ToByte(Convert.ToInt32((R + R2) / 2));
                        difG[i, j] = Convert.ToByte(Convert.ToInt32((G + G2) / 2));
                        difB[i, j] = Convert.ToByte(Convert.ToInt32((B + B2) / 2));

                        Color cor = Color.FromArgb(
                                255,
                                difR[i, j],
                                difG[i, j],
                                difB[i, j]);

                        img16.SetPixel(i, j, cor);
                    }
                }

                pictureBox2.Image = img16;
            }
        }

        private void FlipX_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img17 = new Bitmap(img1.Width, img1.Height);

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                int size = img1.Width;

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        int c = size - 1 - i;

                        Color cor = Color.FromArgb(
                                255,
                                vImg1R[i, j],
                                vImg1G[i, j],
                                vImg1B[i, j]);

                        img17.SetPixel(c, j, cor);
                    }
                }
                pictureBox2.Image = img17;
            }
        }

        private void FlipY_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img18 = new Bitmap(img1.Width, img1.Height);

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                int size = img1.Width;

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        int l = size - 1 - j;

                        Color cor = Color.FromArgb(
                                255,
                                vImg1R[i, j],
                                vImg1G[i, j],
                                vImg1B[i, j]);

                        img18.SetPixel(i, l, cor);
                    }
                }

                pictureBox2.Image = img18;
            }
        }

        private void Limiar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor! (0 - 255) ;)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    img22 = new Bitmap(img1.Width, img1.Height);

                    limiar = new byte[img1.Width, img1.Height];

                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                    //VERIFICAÇÃO DE ESCALA DE CINZA
                    bool isGray = true;
                    int tolerance = 2;

                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            if (!isGray)
                            {
                                break;
                            }

                            Color pixel = img1.GetPixel(i, j);

                            int R = pixel.R;
                            int G = pixel.G;
                            int B = pixel.B;

                            if (Math.Abs(R - G) > tolerance || Math.Abs(G - B) > tolerance || Math.Abs(R - B) > tolerance)

                            {
                                isGray = false;
                            }
                        }
                    }

                    if (isGray)
                    {
                        //Percorre todos os pixels da imagem...
                        for (int i = 0; i < img1.Width; i++)
                        {
                            for (int j = 0; j < img1.Height; j++)
                            {
                                Color pixel = img1.GetPixel(i, j);

                                int pixelIntensity = Convert.ToInt32(pixel.R);

                                if (pixelIntensity >= Convert.ToInt32(txBright.Text))
                                {
                                    pixelIntensity = 255;
                                }
                                else
                                {
                                    pixelIntensity = 0;
                                }

                                limiar[i, j] = Convert.ToByte(pixelIntensity);

                                Color cor = Color.FromArgb(
                                    255,
                                    limiar[i, j],
                                    limiar[i, j],
                                    limiar[i, j]);

                                img22.SetPixel(i, j, cor);
                            }
                        }

                        pictureBox2.Image = img22;
                    }
                    else
                    {
                        // Percorre todos os pixels da imagem...
                        for (int i = 0; i < img1.Width; i++)
                        {
                            for (int j = 0; j < img1.Height; j++)
                            {
                                Color pixel = img1.GetPixel(i, j);

                                // Para imagens em escala de cinza, extrair o valor do pixel com...                             
                                int pixelIntensity = Convert.ToInt32((pixel.R + pixel.G + pixel.B) / 3);

                                if (pixelIntensity >= Convert.ToInt32(txBright.Text))
                                {
                                    pixelIntensity = 255;
                                }
                                else
                                {
                                    pixelIntensity = 0;
                                }

                                limiar[i, j] = Convert.ToByte(pixelIntensity);

                                Color cor = Color.FromArgb(
                                    255,
                                    limiar[i, j],
                                    limiar[i, j],
                                    limiar[i, j]);

                                img22.SetPixel(i, j, cor);
                            }
                        }
                    }

                    pictureBox2.Image = img22;
                }
            }
        }

        private void Not_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img23 = new Bitmap(img1.Width, img1.Height);

                not = new byte[img1.Width, img1.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                //VERIFICAÇÃO BINÁRIO
                bool isBinary = true;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (!isBinary)
                        {
                            break;
                        }

                        Color pixel = img1.GetPixel(i, j);

                        int color = Convert.ToInt32(pixel.R);

                        if (color != 0 && color != 255)
                        {
                            isBinary = false;
                        }
                    }
                }

                if (isBinary)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            int color = Convert.ToInt32(pixel.R);

                            if (color == 255)
                            {
                                color = 0;
                            }
                            else
                            {
                                color = 255;
                            }

                            not[i, j] = Convert.ToByte(color);

                            Color cor = Color.FromArgb(
                                    255,
                                    not[i, j],
                                    not[i, j],
                                    not[i, j]);

                            img23.SetPixel(i, j, cor);
                        }
                    }

                    pictureBox2.Image = img23;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione imagens binárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void And_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img24 = new Bitmap(img1.Width, img1.Height);

                and = new byte[img1.Width, img1.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                //VERIFICAÇÃO BINÁRIO
                bool isBinary = true;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (!isBinary)
                        {
                            break;
                        }

                        Color pixel = img1.GetPixel(i, j);
                        Color pixel2 = img3.GetPixel(i, j);

                        int color = Convert.ToInt32(pixel.R);
                        int color2 = Convert.ToInt32(pixel2.R);

                        if (color != 0 && color != 255 || color != 0 && color != 255)
                        {
                            isBinary = false;
                        }
                    }
                }

                if (isBinary)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            Color pixel2 = img3.GetPixel(i, j);

                            int color = Convert.ToInt32(pixel.R);
                            int color2 = Convert.ToInt32(pixel2.R);
                            int intensity;

                            if (color == 255 && color2 == 255)
                            {
                                intensity = 255;
                            }
                            else
                            {
                                intensity = 0;
                            }

                            and[i, j] = Convert.ToByte(intensity);

                            Color cor = Color.FromArgb(
                                    255,
                                    and[i, j],
                                    and[i, j],
                                    and[i, j]);

                            img24.SetPixel(i, j, cor);
                        }
                    }

                    pictureBox2.Image = img24;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione imagens binárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Or_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img25 = new Bitmap(img1.Width, img1.Height);

                or = new byte[img1.Width, img1.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                //VERIFICAÇÃO BINÁRIO
                bool isBinary = true;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (!isBinary)
                        {
                            break;
                        }

                        Color pixel = img1.GetPixel(i, j);
                        Color pixel2 = img3.GetPixel(i, j);

                        int color = Convert.ToInt32(pixel.R);
                        int color2 = Convert.ToInt32(pixel2.R);

                        if (color != 0 && color != 255 || color != 0 && color != 255)
                        {
                            isBinary = false;
                        }
                    }
                }

                if (isBinary)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            Color pixel2 = img3.GetPixel(i, j);

                            int color = Convert.ToInt32(pixel.R);
                            int color2 = Convert.ToInt32(pixel2.R);
                            int intensity;

                            if (color == 0 && color2 == 0)
                            {
                                intensity = 0;
                            }
                            else
                            {
                                intensity = 255;
                            }

                            or[i, j] = Convert.ToByte(intensity);

                            Color cor = Color.FromArgb(
                                    255,
                                    or[i, j],
                                    or[i, j],
                                    or[i, j]);

                            img25.SetPixel(i, j, cor);
                        }
                    }

                    pictureBox2.Image = img25;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione imagens binárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Xor_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox3.Image == null)
            {
                MessageBox.Show("Por favor, selecione duas imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img26 = new Bitmap(img1.Width, img1.Height);

                xor = new byte[img1.Width, img1.Height];

                vImg1R = new byte[img1.Width, img1.Height];
                vImg1G = new byte[img1.Width, img1.Height];
                vImg1B = new byte[img1.Width, img1.Height];
                vImg1A = new byte[img1.Width, img1.Height];

                //VERIFICAÇÃO BINÁRIO
                bool isBinary = true;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (!isBinary)
                        {
                            break;
                        }

                        Color pixel = img1.GetPixel(i, j);
                        Color pixel2 = img3.GetPixel(i, j);

                        int color = Convert.ToInt32(pixel.R);
                        int color2 = Convert.ToInt32(pixel2.R);

                        if (color != 0 && color != 255 || color != 0 && color != 255)
                        {
                            isBinary = false;
                        }
                    }
                }

                if (isBinary)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            Color pixel2 = img3.GetPixel(i, j);

                            int color = Convert.ToInt32(pixel.R);
                            int color2 = Convert.ToInt32(pixel2.R);
                            int intensity;

                            if (color != color2)
                            {
                                intensity = 255;
                            }
                            else
                            {
                                intensity = 0;
                            }

                            xor[i, j] = Convert.ToByte(intensity);

                            Color cor = Color.FromArgb(
                                    255,
                                    xor[i, j],
                                    xor[i, j],
                                    xor[i, j]);

                            img26.SetPixel(i, j, cor);
                        }
                    }

                    pictureBox2.Image = img26;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione imagens binárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img27 = new Bitmap(img1.Width, img1.Height);
                hvImg = new byte[img1.Width, img1.Height];
                hvImgNew = new byte[img1.Width, img1.Height];
                float[] histogramOrigin = new float[256];
                float[] histogramNew = new float[256];
                float[] cfd = new float[256];

                //POPULAR A MATRIZ COM AS CORES
                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        hvImg[i, j] = pixelIntensity;

                    }
                }

                //CALCULAR O HISTOGRAMA
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        histogramOrigin[hvImg[i, j]]++;
                    }
                }

                //PREENCHER O CHART 1
                for (int i = 0; i < 256; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(i, histogramOrigin[i]);
                }

                //CALCULAR O CFD
                for (int i = 0; i < cfd.Length; i++)
                {
                    if (i == 0)
                    {
                        cfd[i] = histogramOrigin[i];
                    }
                    else
                    {
                        cfd[i] = histogramOrigin[i] + cfd[i - 1];
                    }
                }

                //ENCONTRA O MENOR CFD MAIOR QUE ZERO
                float cfdMin = Convert.ToSingle(cfd.First(element => (element > 0)));

                //CALCULAR A NOVA COR DE CADA PIXEL
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        int pxNew = Convert.ToInt32(Math.Floor(
                            (((Convert.ToSingle(cfd[hvImg[i, j]] - cfdMin) /
                            (Convert.ToSingle(img1.Width * img1.Height) - cfdMin)) *
                            255.0))));

                        hvImgNew[i, j] = Convert.ToByte(pxNew);

                        Color cor = Color.FromArgb(
                                255,
                               hvImgNew[i, j],
                               hvImgNew[i, j],
                               hvImgNew[i, j]);

                        img27.SetPixel(i, j, cor);
                    }
                }

                pictureBox2.Image = img27;

                //CALCULAR O HISTOGRAMA NEW
                for (int i = 0; i < img27.Width; i++)
                {
                    for (int j = 0; j < img27.Height; j++)
                    {
                        histogramNew[hvImgNew[i, j]]++;
                    }
                }

                //PREENCHER O CHART 2
                for (int i = 0; i < 256; i++)
                {
                    chart2.Series["Series1"].Points.AddXY(i, histogramNew[i]);
                }
            }
        }

        private void ConvolucaoMaior_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img28 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];


                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        byte[] mask = new byte[9];
                        for (int i = 0; i < mask.Length; i++)
                        {
                            mask[i] = 1;
                        }

                        mask[0] = (byte)(mask[0] * convBefore[x - 1, y - 1]);
                        mask[1] = (byte)(mask[1] * convBefore[x - 1, y]);
                        mask[2] = (byte)(mask[2] * convBefore[x - 1, y + 1]);

                        mask[3] = (byte)(mask[3] * convBefore[x, y - 1]);
                        mask[4] = (byte)(mask[4] * convBefore[x, y]);
                        mask[5] = (byte)(mask[5] * convBefore[x, y + 1]);

                        mask[6] = (byte)(mask[6] * convBefore[x + 1, y - 1]);
                        mask[7] = (byte)(mask[7] * convBefore[x + 1, y]);
                        mask[8] = (byte)(mask[8] * convBefore[x + 1, y + 1]);

                        byte min = mask.Max();
                        convAfter[x, y] = Convert.ToByte(min);

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img28.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img28;
            }
        }

        private void ConvolucaoMenor_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img28 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];


                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        byte[] mask = new byte[9];
                        for (int i = 0; i < mask.Length; i++)
                        {
                            mask[i] = 1;
                        }

                        mask[0] = (byte)(mask[0] * convBefore[x - 1, y - 1]);
                        mask[1] = (byte)(mask[1] * convBefore[x - 1, y]);
                        mask[2] = (byte)(mask[2] * convBefore[x - 1, y + 1]);

                        mask[3] = (byte)(mask[3] * convBefore[x, y - 1]);
                        mask[4] = (byte)(mask[4] * convBefore[x, y]);
                        mask[5] = (byte)(mask[5] * convBefore[x, y + 1]);

                        mask[6] = (byte)(mask[6] * convBefore[x + 1, y - 1]);
                        mask[7] = (byte)(mask[7] * convBefore[x + 1, y]);
                        mask[8] = (byte)(mask[8] * convBefore[x + 1, y + 1]);

                        byte min = mask.Min();
                        convAfter[x, y] = Convert.ToByte(min);

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img28.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img28;
            }
        }

        private void ConvolucaoMedia_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img28 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];


                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        byte[] mask = new byte[9];
                        for (int i = 0; i < mask.Length; i++)
                        {
                            mask[i] = 1;
                        }

                        mask[0] = (byte)(mask[0] * convBefore[x - 1, y - 1]);
                        mask[1] = (byte)(mask[1] * convBefore[x - 1, y]);
                        mask[2] = (byte)(mask[2] * convBefore[x - 1, y + 1]);

                        mask[3] = (byte)(mask[3] * convBefore[x, y - 1]);
                        mask[4] = (byte)(mask[4] * convBefore[x, y]);
                        mask[5] = (byte)(mask[5] * convBefore[x, y + 1]);

                        mask[6] = (byte)(mask[6] * convBefore[x + 1, y - 1]);
                        mask[7] = (byte)(mask[7] * convBefore[x + 1, y]);
                        mask[8] = (byte)(mask[8] * convBefore[x + 1, y + 1]);

                        int sum = 0;
                        for (int j = 0; j < mask.Length; j++)
                        {
                            sum += (int)mask[j];
                        }
                        convAfter[x, y] = Convert.ToByte(sum / 9);

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img28.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img28;
            }
        }

        private void ConvolucaoMediana_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img28 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];


                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        byte[] mask = new byte[9];
                        for (int i = 0; i < mask.Length; i++)
                        {
                            mask[i] = 1;
                        }

                        mask[0] = (byte)(mask[0] * convBefore[x - 1, y - 1]);
                        mask[1] = (byte)(mask[1] * convBefore[x - 1, y]);
                        mask[2] = (byte)(mask[2] * convBefore[x - 1, y + 1]);

                        mask[3] = (byte)(mask[3] * convBefore[x, y - 1]);
                        mask[4] = (byte)(mask[4] * convBefore[x, y]);
                        mask[5] = (byte)(mask[5] * convBefore[x, y + 1]);

                        mask[6] = (byte)(mask[6] * convBefore[x + 1, y - 1]);
                        mask[7] = (byte)(mask[7] * convBefore[x + 1, y]);
                        mask[8] = (byte)(mask[8] * convBefore[x + 1, y + 1]);

                        Array.Sort(mask);

                        int value = mask[4];

                        convAfter[x, y] = Convert.ToByte(value);

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img28.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img28;
            }
        }

        private void ConvolucaoOrdem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == " " || txBright.Text != "0" && txBright.Text != "1" &&
                    txBright.Text != "2" && txBright.Text != "3" && txBright.Text != "4" &&
                     txBright.Text != "5" && txBright.Text != "6" && txBright.Text != "7" &&
                      txBright.Text != "8")
                {
                    MessageBox.Show("Por favor, informe um valor entre 0 e 8!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    img28 = new Bitmap(img1.Width, img1.Height);
                    convBefore = new byte[img1.Width, img1.Height];
                    convAfter = new byte[img1.Width, img1.Height];
                    int order = Convert.ToInt32(txBright.Text);

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                            convBefore[i, j] = pixelIntensity;

                        }
                    }

                    for (int x = 1; x < img1.Width - 1; x++)
                    {
                        for (int y = 1; y < img1.Height - 1; y++)
                        {
                            byte[] mask = new byte[9];
                            for (int i = 0; i < mask.Length; i++)
                            {
                                mask[i] = 1;
                            }

                            mask[0] = (byte)(mask[0] * convBefore[x - 1, y - 1]);
                            mask[1] = (byte)(mask[1] * convBefore[x - 1, y]);
                            mask[2] = (byte)(mask[2] * convBefore[x - 1, y + 1]);

                            mask[3] = (byte)(mask[3] * convBefore[x, y - 1]);
                            mask[4] = (byte)(mask[4] * convBefore[x, y]);
                            mask[5] = (byte)(mask[5] * convBefore[x, y + 1]);

                            mask[6] = (byte)(mask[6] * convBefore[x + 1, y - 1]);
                            mask[7] = (byte)(mask[7] * convBefore[x + 1, y]);
                            mask[8] = (byte)(mask[8] * convBefore[x + 1, y + 1]);

                            Array.Sort(mask);

                            int value = mask[order];

                            convAfter[x, y] = Convert.ToByte(value);

                            Color cor = Color.FromArgb(
                                    255,
                                    convAfter[x, y],
                                    convAfter[x, y],
                                    convAfter[x, y]);

                            img28.SetPixel(x, y, cor);

                        }
                    }
                    pictureBox2.Image = img28;
                }
            }
        }

        private void SuavizacaoConservativa_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img28 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];


                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        byte[] mask = new byte[8];
                        for (int i = 0; i < mask.Length; i++)
                        {
                            mask[i] = 1;
                        }

                        mask[0] = (byte)(mask[0] * convBefore[x - 1, y - 1]);
                        mask[1] = (byte)(mask[1] * convBefore[x - 1, y]);
                        mask[2] = (byte)(mask[2] * convBefore[x - 1, y + 1]);

                        mask[3] = (byte)(mask[3] * convBefore[x, y - 1]);
                        mask[4] = (byte)(mask[4] * convBefore[x, y + 1]);

                        mask[5] = (byte)(mask[5] * convBefore[x + 1, y - 1]);
                        mask[6] = (byte)(mask[6] * convBefore[x + 1, y]);
                        mask[7] = (byte)(mask[7] * convBefore[x + 1, y + 1]);

                        int pixel = (convBefore[x, y]);
                        int max = mask.Max();
                        int min = mask.Min();
                        int value = 0;

                        if (pixel > max)
                        {
                            value = max;
                        }
                        else if (pixel < min)
                        {
                            value = min;
                        }
                        else
                        {
                            value = pixel;
                        }

                        convAfter[x, y] = Convert.ToByte(value);

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img28.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img28;
            }
        }

        private void Gaussian_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txBright.Text == "")
                {
                    MessageBox.Show("Por favor, informe um valor entre 0 e 8!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    img29 = new Bitmap(img1.Width, img1.Height);
                    convBefore = new byte[img1.Width, img1.Height];
                    convAfter = new byte[img1.Width, img1.Height];

                    double sigma = Convert.ToDouble(txBright.Text);
                    double[,] GKernel;
                    GKernel = new double[5, 5];
                    double sum = 0;
                    double[,] mask = new double[5, 5];


                    //gerar o kernel 5x5
                    for (int x = -2; x <= 2; x++)
                    {
                        for (int y = -2; y <= 2; y++)
                        {
                            double coefficient = 1.0f / (2.0f * Math.PI * sigma * sigma);
                            double exponent = -(x * x + y * y) / (2.0f * sigma * sigma);
                            GKernel[x + 2, y + 2] = coefficient * Math.Exp(exponent);

                            sum += GKernel[x + 2, y + 2];

                        }
                    }

                    //Imprime o Kerner gaussiano
                    StreamWriter sw = new StreamWriter("GaussianKernel.txt");
                    sw.WriteLine("Sigma: {0:f2}", sigma);
                    sw.WriteLine("Sum: {0:f2}", sum);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            sw.Write(String.Format("{0:f2}", GKernel[i, j]) + "\t");
                        }

                        sw.WriteLine(); //próxima linha
                    }

                    sw.Close();

                    //normalizar o kernel
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            GKernel[i, j] /= sum;
                        }
                    }

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                            convBefore[i, j] = pixelIntensity;

                        }
                    }

                    //aplicar o filtro
                    for (int x = 2; x < img1.Width - 2; x++)
                    {
                        for (int y = 2; y < img1.Height - 2; y++)
                        {


                            mask[0, 0] = (byte)(GKernel[0, 0] * convBefore[x - 2, y - 2]);
                            mask[0, 1] = (byte)(GKernel[0, 1] * convBefore[x - 2, y - 1]);
                            mask[0, 2] = (byte)(GKernel[0, 2] * convBefore[x - 2, y]);
                            mask[0, 3] = (byte)(GKernel[0, 3] * convBefore[x - 2, y + 1]);
                            mask[0, 4] = (byte)(GKernel[0, 4] * convBefore[x - 2, y + 2]);

                            mask[1, 0] = (byte)(GKernel[1, 0] * convBefore[x - 1, y - 2]);
                            mask[1, 1] = (byte)(GKernel[1, 1] * convBefore[x - 1, y - 1]);
                            mask[1, 2] = (byte)(GKernel[1, 2] * convBefore[x - 1, y]);
                            mask[1, 3] = (byte)(GKernel[1, 3] * convBefore[x - 1, y + 1]);
                            mask[1, 4] = (byte)(GKernel[1, 4] * convBefore[x - 1, y + 2]);

                            mask[2, 0] = (byte)(GKernel[2, 0] * convBefore[x, y - 2]);
                            mask[2, 1] = (byte)(GKernel[2, 1] * convBefore[x, y - 1]);
                            mask[2, 2] = (byte)(GKernel[2, 2] * convBefore[x, y]);
                            mask[2, 3] = (byte)(GKernel[2, 3] * convBefore[x, y + 1]);
                            mask[2, 4] = (byte)(GKernel[2, 4] * convBefore[x, y + 2]);

                            mask[3, 0] = (byte)(GKernel[3, 0] * convBefore[x + 1, y - 2]);
                            mask[3, 1] = (byte)(GKernel[3, 1] * convBefore[x + 1, y - 1]);
                            mask[3, 2] = (byte)(GKernel[3, 2] * convBefore[x + 1, y]);
                            mask[3, 3] = (byte)(GKernel[3, 3] * convBefore[x + 1, y + 1]);
                            mask[3, 4] = (byte)(GKernel[3, 4] * convBefore[x + 1, y + 2]);

                            mask[4, 0] = (byte)(GKernel[4, 0] * convBefore[x + 2, y - 2]);
                            mask[4, 1] = (byte)(GKernel[4, 1] * convBefore[x + 2, y - 1]);
                            mask[4, 2] = (byte)(GKernel[4, 2] * convBefore[x + 2, y]);
                            mask[4, 3] = (byte)(GKernel[4, 3] * convBefore[x + 2, y + 1]);
                            mask[4, 4] = (byte)(GKernel[4, 4] * convBefore[x + 2, y + 2]);


                            //Soma todos os elementos da vizinhança 
                            //A soma será o valor final do pixel

                            int pixel = 0;

                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    pixel += (int)mask[i, j];
                                }
                            }

                            convAfter[x, y] = Convert.ToByte(pixel);

                            Color cor = Color.FromArgb(
                                    255,
                                    convAfter[x, y],
                                    convAfter[x, y],
                                    convAfter[x, y]);

                            img29.SetPixel(x, y, cor);

                        }
                    }
                    pictureBox2.Image = img29;
                }


            }
        }

        private void Prewitt_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img30 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {

                        int x0 = (-1 * convBefore[x - 1, y - 1]);
                        int x1 = (0 * convBefore[x - 1, y]);
                        int x2 = (1 * convBefore[x - 1, y + 1]);

                        int x3 = (-1 * convBefore[x, y - 1]);
                        int x4 = (0 * convBefore[x, y]);
                        int x5 = (1 * convBefore[x, y + 1]);

                        int x6 = (-1 * convBefore[x + 1, y - 1]);
                        int x7 = (0 * convBefore[x + 1, y]);
                        int x8 = (1 * convBefore[x + 1, y + 1]);

                        int Gx = x0 + x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8;

                        int y0 = (1 * convBefore[x - 1, y - 1]);
                        int y1 = (1 * convBefore[x - 1, y]);
                        int y2 = (1 * convBefore[x - 1, y + 1]);

                        int y3 = (0 * convBefore[x, y - 1]);
                        int y4 = (0 * convBefore[x, y]);
                        int y5 = (0 * convBefore[x, y + 1]);

                        int y6 = (-1 * convBefore[x + 1, y - 1]);
                        int y7 = (-1 * convBefore[x + 1, y]);
                        int y8 = (-1 * convBefore[x + 1, y + 1]);

                        int Gy = y0 + y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8;

                        convAfter[x, y] = (byte)Math.Sqrt((Gx * Gx) + (Gy * Gy));

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img30.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img30;
            }
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img30 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {

                        int x0 = (1 * convBefore[x - 1, y - 1]);
                        int x1 = (0 * convBefore[x - 1, y]);
                        int x2 = (-1 * convBefore[x - 1, y + 1]);

                        int x3 = (2 * convBefore[x, y - 1]);
                        int x4 = (0 * convBefore[x, y]);
                        int x5 = (-2 * convBefore[x, y + 1]);

                        int x6 = (1 * convBefore[x + 1, y - 1]);
                        int x7 = (0 * convBefore[x + 1, y]);
                        int x8 = (-1 * convBefore[x + 1, y + 1]);

                        int Gx = x0 + x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8;

                        int y0 = (1 * convBefore[x - 1, y - 1]);
                        int y1 = (2 * convBefore[x - 1, y]);
                        int y2 = (1 * convBefore[x - 1, y + 1]);

                        int y3 = (0 * convBefore[x, y - 1]);
                        int y4 = (0 * convBefore[x, y]);
                        int y5 = (0 * convBefore[x, y + 1]);

                        int y6 = (-1 * convBefore[x + 1, y - 1]);
                        int y7 = (-2 * convBefore[x + 1, y]);
                        int y8 = (-1 * convBefore[x + 1, y + 1]);

                        int Gy = y0 + y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8;

                        convAfter[x, y] = (byte)Math.Sqrt((Gx * Gx) + (Gy * Gy));

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img30.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img30;
            }
        }

        private void Laplaciano_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img30 = new Bitmap(img1.Width, img1.Height);
                convBefore = new byte[img1.Width, img1.Height];
                convAfter = new byte[img1.Width, img1.Height];

                // Percorre todos os pixels da imagem...
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                        convBefore[i, j] = pixelIntensity;

                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {

                        int x0 = (1 * convBefore[x - 1, y - 1]);
                        int x1 = (1 * convBefore[x - 1, y]);
                        int x2 = (1 * convBefore[x - 1, y + 1]);

                        int x3 = (1 * convBefore[x, y - 1]);
                        int x4 = (-8 * convBefore[x, y]);
                        int x5 = (1 * convBefore[x, y + 1]);

                        int x6 = (1 * convBefore[x + 1, y - 1]);
                        int x7 = (1 * convBefore[x + 1, y]);
                        int x8 = (1 * convBefore[x + 1, y + 1]);

                        int Gx = x0 + x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8;

                        int y0 = (-1 * convBefore[x - 1, y - 1]);
                        int y1 = (-1 * convBefore[x - 1, y]);
                        int y2 = (-1 * convBefore[x - 1, y + 1]);

                        int y3 = (-1 * convBefore[x, y - 1]);
                        int y4 = (8 * convBefore[x, y]);
                        int y5 = (-1 * convBefore[x, y + 1]);

                        int y6 = (-1 * convBefore[x + 1, y - 1]);
                        int y7 = (-1 * convBefore[x + 1, y]);
                        int y8 = (-1 * convBefore[x + 1, y + 1]);

                        int Gy = y0 + y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8;

                        convAfter[x, y] = (byte)Math.Sqrt((Gx * Gx) + (Gy * Gy));

                        Color cor = Color.FromArgb(
                                255,
                                convAfter[x, y],
                                convAfter[x, y],
                                convAfter[x, y]);

                        img30.SetPixel(x, y, cor);

                    }
                }
                pictureBox2.Image = img30;
            }
        }

        private void Dilatacao_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img31 = new Bitmap(img1.Width, img1.Height);

                byte[,] dilatacao = new byte[img1.Width, img1.Height];
                int[,] img = new int[img1.Width, img1.Height];
                byte[,] imgAfter = new byte[img1.Width, img1.Height];
                byte[,] imgAfterB = new byte[img1.Width, img1.Height];

                //VERIFICAÇÃO BINÁRIO
                bool isBinary = true;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (!isBinary)
                        {
                            break;
                        }

                        Color pixel = img1.GetPixel(i, j);

                        int color = Convert.ToInt32(pixel.R);

                        if (color != 0 && color != 255)
                        {
                            isBinary = false;
                        }
                    }
                }

                if (isBinary)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            int pixelIntensity = Convert.ToInt32(pixel.R);
                            img[i, j] = pixelIntensity;
                        }
                    }

                    for (int x = 1; x < img1.Width - 1; x++)
                    {
                        for (int y = 1; y < img1.Height - 1; y++)
                        {
                            if (img[x - 1, y] == 255 || img[x + 1, y] == 255 || img[x, y - 1] == 255 || img[x, y + 1] == 255 || img[x, y] == 255)
                            {
                                imgAfter[x, y] = 255;
                            }
                            else
                            {
                                imgAfter[x, y] = 0;
                            }

                            imgAfterB[x, y] = (byte)imgAfter[x, y];

                            Color cor = Color.FromArgb(
                                    255,
                                    imgAfterB[x, y],
                                    imgAfterB[x, y],
                                    imgAfterB[x, y]);

                            img31.SetPixel(x, y, cor);
                        }
                    }

                    pictureBox2.Image = img31;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione imagens binárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Erosao_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img32 = new Bitmap(img1.Width, img1.Height);

                byte[,] dilatacao = new byte[img1.Width, img1.Height];
                int[,] img = new int[img1.Width, img1.Height];
                byte[,] imgAfter = new byte[img1.Width, img1.Height];
                byte[,] imgAfterB = new byte[img1.Width, img1.Height];

                //VERIFICAÇÃO BINÁRIO
                bool isBinary = true;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (!isBinary)
                        {
                            break;
                        }

                        Color pixel = img1.GetPixel(i, j);

                        int color = Convert.ToInt32(pixel.R);

                        if (color != 0 && color != 255)
                        {
                            isBinary = false;
                        }
                    }
                }

                if (isBinary)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);
                            int pixelIntensity = Convert.ToInt32(pixel.R);
                            img[i, j] = pixelIntensity;
                        }
                    }

                    for (int x = 1; x < img1.Width - 1; x++)
                    {
                        for (int y = 1; y < img1.Height - 1; y++)
                        {
                            if (img[x - 1, y] == 255 && img[x + 1, y] == 255 && img[x, y - 1] == 255 && img[x, y + 1] == 255 && img[x, y] == 255)
                            {
                                imgAfter[x, y] = 255;
                            }
                            else
                            {
                                imgAfter[x, y] = 0;
                            }

                            imgAfterB[x, y] = (byte)imgAfter[x, y];

                            Color cor = Color.FromArgb(
                                    255,
                                    imgAfterB[x, y],
                                    imgAfterB[x, y],
                                    imgAfterB[x, y]);

                            img32.SetPixel(x, y, cor);
                        }
                    }

                    pictureBox2.Image = img32;
                }
                else
                {
                    MessageBox.Show("Por favor, selecione imagens binárias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Abertura_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img32 = new Bitmap(img1.Width, img1.Height);

                byte[,] dilatacao = new byte[img1.Width, img1.Height];
                int[,] img = new int[img1.Width, img1.Height];
                byte[,] imgAfter = new byte[img1.Width, img1.Height];
                byte[,] imgAfterB = new byte[img1.Width, img1.Height];
                byte[,] abertura = new byte[img1.Width, img1.Height];

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        int pixelIntensity = Convert.ToInt32(pixel.R);
                        img[i, j] = pixelIntensity;
                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        //erosao
                        if (img[x - 1, y] == 255 && img[x + 1, y] == 255 && img[x, y - 1] == 255 && img[x, y + 1] == 255 && img[x, y] == 255)
                        {
                            imgAfter[x, y] = 255;
                        }
                        else
                        {
                            imgAfter[x, y] = 0;
                        }

                        imgAfterB[x, y] = (byte)imgAfter[x, y];
                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        //dilatacao
                        if (imgAfterB[x - 1, y] == 255 || imgAfterB[x + 1, y] == 255 || imgAfterB[x, y - 1] == 255 || imgAfterB[x, y + 1] == 255 || imgAfterB[x, y] == 255)
                        {
                            abertura[x, y] = 255;
                        }
                        else
                        {
                            abertura[x, y] = 0;
                        }

                        Color cor = Color.FromArgb(
                                255,
                                abertura[x, y],
                                abertura[x, y],
                                abertura[x, y]);

                        img32.SetPixel(x, y, cor);
                    }
                }

                pictureBox2.Image = img32;

            }
        }

        private void Fechamento_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img32 = new Bitmap(img1.Width, img1.Height);

                byte[,] dilatacao = new byte[img1.Width, img1.Height];
                int[,] img = new int[img1.Width, img1.Height];
                byte[,] imgAfter = new byte[img1.Width, img1.Height];
                byte[,] imgAfterB = new byte[img1.Width, img1.Height];
                byte[,] fechamento = new byte[img1.Width, img1.Height];

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        int pixelIntensity = Convert.ToInt32(pixel.R);
                        img[i, j] = pixelIntensity;
                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        //dilatacao
                        if (img[x - 1, y] == 255 || img[x + 1, y] == 255 || img[x, y - 1] == 255 || img[x, y + 1] == 255 || img[x, y] == 255)
                        {
                            imgAfter[x, y] = 255;
                        }
                        else
                        {
                            imgAfter[x, y] = 0;
                        }

                        imgAfterB[x, y] = (byte)imgAfter[x, y];
                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {

                        //erosao
                        if (imgAfterB[x - 1, y] == 255 && imgAfterB[x + 1, y] == 255 && imgAfterB[x, y - 1] == 255 && imgAfterB[x, y + 1] == 255 && imgAfterB[x, y] == 255)
                        {
                            fechamento[x, y] = 255;
                        }
                        else
                        {
                            fechamento[x, y] = 0;
                        }

                        Color cor = Color.FromArgb(
                                255,
                                fechamento[x, y],
                                fechamento[x, y],
                                fechamento[x, y]);

                        img32.SetPixel(x, y, cor);
                    }
                }

                pictureBox2.Image = img32;
            }
        }

        private void Contorno_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, selecione uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img32 = new Bitmap(img1.Width, img1.Height);

                byte[,] dilatacao = new byte[img1.Width, img1.Height];
                int[,] img = new int[img1.Width, img1.Height];
                byte[,] imgAfter = new byte[img1.Width, img1.Height];
                byte[,] imgAfterB = new byte[img1.Width, img1.Height];
                byte[,] contorno = new byte[img1.Width, img1.Height];

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        int pixelIntensity = Convert.ToInt32(pixel.R);
                        img[i, j] = pixelIntensity;
                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        //erosao
                        if (img[x - 1, y] == 255 && img[x + 1, y] == 255 && img[x, y - 1] == 255 && img[x, y + 1] == 255 && img[x, y] == 255)
                        {
                            imgAfter[x, y] = 255;
                        }
                        else
                        {
                            imgAfter[x, y] = 0;
                        }

                        imgAfterB[x, y] = (byte)imgAfter[x, y];
                    }
                }

                for (int x = 1; x < img1.Width - 1; x++)
                {
                    for (int y = 1; y < img1.Height - 1; y++)
                    {
                        if (img[x,y] == imgAfterB[x,y])
                        {
                            contorno[x, y] = 0;
                        } else
                        {
                            contorno[x, y] = 255;
                        }

                        Color cor = Color.FromArgb(
                               255,
                               contorno[x, y],
                               contorno[x, y],
                               contorno[x, y]);

                        img32.SetPixel(x, y, cor);
                    }
                }

                pictureBox2.Image = img32;
            }
        }
    }
}
