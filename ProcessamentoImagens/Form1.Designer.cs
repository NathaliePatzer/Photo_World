namespace ProcessamentoImagens
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ConvertGray = new System.Windows.Forms.Button();
            this.txBright = new System.Windows.Forms.TextBox();
            this.BrightMore = new System.Windows.Forms.Button();
            this.BrightLess = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SumImages = new System.Windows.Forms.Button();
            this.SubtractImages = new System.Windows.Forms.Button();
            this.LoadImageTwo = new System.Windows.Forms.Button();
            this.LoadImageOne = new System.Windows.Forms.Button();
            this.ContrastMultiply = new System.Windows.Forms.Button();
            this.ContrastDivide = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveImage = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Blending = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.FlipX = new System.Windows.Forms.Button();
            this.FlipY = new System.Windows.Forms.Button();
            this.Limiar = new System.Windows.Forms.Button();
            this.Not = new System.Windows.Forms.Button();
            this.And = new System.Windows.Forms.Button();
            this.Or = new System.Windows.Forms.Button();
            this.Xor = new System.Windows.Forms.Button();
            this.Histogram = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConvolucaoMaior = new System.Windows.Forms.Button();
            this.ConvolucaoMenor = new System.Windows.Forms.Button();
            this.ConvolucaoMedia = new System.Windows.Forms.Button();
            this.ConvolucaoMediana = new System.Windows.Forms.Button();
            this.ConvolucaoOrdem = new System.Windows.Forms.Button();
            this.SuavizacaoConservativa = new System.Windows.Forms.Button();
            this.Gaussian = new System.Windows.Forms.Button();
            this.Prewitt = new System.Windows.Forms.Button();
            this.Sobel = new System.Windows.Forms.Button();
            this.Laplaciano = new System.Windows.Forms.Button();
            this.Dilatacao = new System.Windows.Forms.Button();
            this.Erosao = new System.Windows.Forms.Button();
            this.Abertura = new System.Windows.Forms.Button();
            this.Fechamento = new System.Windows.Forms.Button();
            this.Contorno = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1040, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ConvertGray
            // 
            this.ConvertGray.BackColor = System.Drawing.Color.Thistle;
            this.ConvertGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertGray.Location = new System.Drawing.Point(341, 267);
            this.ConvertGray.Name = "ConvertGray";
            this.ConvertGray.Size = new System.Drawing.Size(157, 37);
            this.ConvertGray.TabIndex = 2;
            this.ConvertGray.Text = "Escala de Cinza";
            this.ConvertGray.UseVisualStyleBackColor = false;
            this.ConvertGray.Click += new System.EventHandler(this.ConvertGray_Click);
            // 
            // txBright
            // 
            this.txBright.BackColor = System.Drawing.Color.Pink;
            this.txBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBright.Location = new System.Drawing.Point(624, 23);
            this.txBright.Name = "txBright";
            this.txBright.Size = new System.Drawing.Size(157, 21);
            this.txBright.TabIndex = 3;
            // 
            // BrightMore
            // 
            this.BrightMore.BackColor = System.Drawing.Color.Thistle;
            this.BrightMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightMore.Location = new System.Drawing.Point(341, 67);
            this.BrightMore.Name = "BrightMore";
            this.BrightMore.Size = new System.Drawing.Size(157, 37);
            this.BrightMore.TabIndex = 4;
            this.BrightMore.Text = "Aumentar Brilho";
            this.BrightMore.UseVisualStyleBackColor = false;
            this.BrightMore.Click += new System.EventHandler(this.BrightMore_Click);
            // 
            // BrightLess
            // 
            this.BrightLess.BackColor = System.Drawing.Color.Thistle;
            this.BrightLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightLess.Location = new System.Drawing.Point(341, 117);
            this.BrightLess.Name = "BrightLess";
            this.BrightLess.Size = new System.Drawing.Size(157, 37);
            this.BrightLess.TabIndex = 5;
            this.BrightLess.Text = "Diminuir Brilho";
            this.BrightLess.UseVisualStyleBackColor = false;
            this.BrightLess.Click += new System.EventHandler(this.BrightLess_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(14, 372);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 254);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // SumImages
            // 
            this.SumImages.BackColor = System.Drawing.Color.Thistle;
            this.SumImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumImages.Location = new System.Drawing.Point(341, 376);
            this.SumImages.Name = "SumImages";
            this.SumImages.Size = new System.Drawing.Size(140, 37);
            this.SumImages.TabIndex = 7;
            this.SumImages.Text = "Somar Imagens";
            this.SumImages.UseVisualStyleBackColor = false;
            this.SumImages.Click += new System.EventHandler(this.SumImages_Click);
            // 
            // SubtractImages
            // 
            this.SubtractImages.BackColor = System.Drawing.Color.Thistle;
            this.SubtractImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractImages.Location = new System.Drawing.Point(341, 427);
            this.SubtractImages.Name = "SubtractImages";
            this.SubtractImages.Size = new System.Drawing.Size(140, 37);
            this.SubtractImages.TabIndex = 8;
            this.SubtractImages.Text = "Subtrair Imagens";
            this.SubtractImages.UseVisualStyleBackColor = false;
            this.SubtractImages.Click += new System.EventHandler(this.SubtractImages_Click);
            // 
            // LoadImageTwo
            // 
            this.LoadImageTwo.BackColor = System.Drawing.Color.Thistle;
            this.LoadImageTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImageTwo.Location = new System.Drawing.Point(87, 637);
            this.LoadImageTwo.Name = "LoadImageTwo";
            this.LoadImageTwo.Size = new System.Drawing.Size(157, 34);
            this.LoadImageTwo.TabIndex = 9;
            this.LoadImageTwo.Text = "Carregar Imagem";
            this.LoadImageTwo.UseVisualStyleBackColor = false;
            this.LoadImageTwo.Click += new System.EventHandler(this.LoadImageTwo_Click);
            // 
            // LoadImageOne
            // 
            this.LoadImageOne.BackColor = System.Drawing.Color.Thistle;
            this.LoadImageOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImageOne.Location = new System.Drawing.Point(87, 326);
            this.LoadImageOne.Name = "LoadImageOne";
            this.LoadImageOne.Size = new System.Drawing.Size(157, 34);
            this.LoadImageOne.TabIndex = 11;
            this.LoadImageOne.Text = "Carregar Imagem";
            this.LoadImageOne.UseVisualStyleBackColor = false;
            this.LoadImageOne.Click += new System.EventHandler(this.LoadImageOne_Click);
            // 
            // ContrastMultiply
            // 
            this.ContrastMultiply.BackColor = System.Drawing.Color.Thistle;
            this.ContrastMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastMultiply.Location = new System.Drawing.Point(341, 167);
            this.ContrastMultiply.Name = "ContrastMultiply";
            this.ContrastMultiply.Size = new System.Drawing.Size(157, 37);
            this.ContrastMultiply.TabIndex = 12;
            this.ContrastMultiply.Text = "Aumentar Contraste";
            this.ContrastMultiply.UseVisualStyleBackColor = false;
            this.ContrastMultiply.Click += new System.EventHandler(this.ContrastMultiply_Click);
            // 
            // ContrastDivide
            // 
            this.ContrastDivide.BackColor = System.Drawing.Color.Thistle;
            this.ContrastDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastDivide.Location = new System.Drawing.Point(341, 217);
            this.ContrastDivide.Name = "ContrastDivide";
            this.ContrastDivide.Size = new System.Drawing.Size(157, 37);
            this.ContrastDivide.TabIndex = 13;
            this.ContrastDivide.Text = "Diminuir Contraste";
            this.ContrastDivide.UseVisualStyleBackColor = false;
            this.ContrastDivide.Click += new System.EventHandler(this.ContrastDivide_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.BackColor = System.Drawing.Color.Thistle;
            this.SaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveImage.Location = new System.Drawing.Point(1040, 320);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(145, 50);
            this.SaveImage.TabIndex = 14;
            this.SaveImage.Text = "Salvar Imagem";
            this.SaveImage.UseVisualStyleBackColor = false;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Thistle;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1209, 320);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(145, 50);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Blending
            // 
            this.Blending.BackColor = System.Drawing.Color.Thistle;
            this.Blending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blending.Location = new System.Drawing.Point(341, 478);
            this.Blending.Name = "Blending";
            this.Blending.Size = new System.Drawing.Size(140, 37);
            this.Blending.TabIndex = 16;
            this.Blending.Text = "Blend";
            this.Blending.UseVisualStyleBackColor = false;
            this.Blending.Click += new System.EventHandler(this.Blending_Click);
            // 
            // Difference
            // 
            this.Difference.BackColor = System.Drawing.Color.Thistle;
            this.Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difference.Location = new System.Drawing.Point(341, 529);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(140, 37);
            this.Difference.TabIndex = 17;
            this.Difference.Text = "Diferença ";
            this.Difference.UseVisualStyleBackColor = false;
            this.Difference.Click += new System.EventHandler(this.Difference_Click);
            // 
            // Average
            // 
            this.Average.BackColor = System.Drawing.Color.Thistle;
            this.Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.Location = new System.Drawing.Point(341, 580);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(140, 37);
            this.Average.TabIndex = 18;
            this.Average.Text = "Média";
            this.Average.UseVisualStyleBackColor = false;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // FlipX
            // 
            this.FlipX.BackColor = System.Drawing.Color.Thistle;
            this.FlipX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipX.Location = new System.Drawing.Point(514, 67);
            this.FlipX.Name = "FlipX";
            this.FlipX.Size = new System.Drawing.Size(157, 37);
            this.FlipX.TabIndex = 19;
            this.FlipX.Text = "Flip X";
            this.FlipX.UseVisualStyleBackColor = false;
            this.FlipX.Click += new System.EventHandler(this.FlipX_Click);
            // 
            // FlipY
            // 
            this.FlipY.BackColor = System.Drawing.Color.Thistle;
            this.FlipY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipY.Location = new System.Drawing.Point(514, 117);
            this.FlipY.Name = "FlipY";
            this.FlipY.Size = new System.Drawing.Size(157, 37);
            this.FlipY.TabIndex = 20;
            this.FlipY.Text = "Flip Y";
            this.FlipY.UseVisualStyleBackColor = false;
            this.FlipY.Click += new System.EventHandler(this.FlipY_Click);
            // 
            // Limiar
            // 
            this.Limiar.BackColor = System.Drawing.Color.Thistle;
            this.Limiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limiar.Location = new System.Drawing.Point(514, 167);
            this.Limiar.Name = "Limiar";
            this.Limiar.Size = new System.Drawing.Size(157, 37);
            this.Limiar.TabIndex = 21;
            this.Limiar.Text = "Limiar";
            this.Limiar.UseVisualStyleBackColor = false;
            this.Limiar.Click += new System.EventHandler(this.Limiar_Click);
            // 
            // Not
            // 
            this.Not.BackColor = System.Drawing.Color.Thistle;
            this.Not.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Not.Location = new System.Drawing.Point(341, 320);
            this.Not.Name = "Not";
            this.Not.Size = new System.Drawing.Size(70, 40);
            this.Not.TabIndex = 22;
            this.Not.Text = "NOT";
            this.Not.UseVisualStyleBackColor = false;
            this.Not.Click += new System.EventHandler(this.Not_Click);
            // 
            // And
            // 
            this.And.BackColor = System.Drawing.Color.Thistle;
            this.And.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.And.Location = new System.Drawing.Point(427, 320);
            this.And.Name = "And";
            this.And.Size = new System.Drawing.Size(70, 40);
            this.And.TabIndex = 23;
            this.And.Text = "AND";
            this.And.UseVisualStyleBackColor = false;
            this.And.Click += new System.EventHandler(this.And_Click);
            // 
            // Or
            // 
            this.Or.BackColor = System.Drawing.Color.Thistle;
            this.Or.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Or.Location = new System.Drawing.Point(513, 320);
            this.Or.Name = "Or";
            this.Or.Size = new System.Drawing.Size(70, 40);
            this.Or.TabIndex = 24;
            this.Or.Text = "OR";
            this.Or.UseVisualStyleBackColor = false;
            this.Or.Click += new System.EventHandler(this.Or_Click);
            // 
            // Xor
            // 
            this.Xor.BackColor = System.Drawing.Color.Thistle;
            this.Xor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xor.Location = new System.Drawing.Point(599, 320);
            this.Xor.Name = "Xor";
            this.Xor.Size = new System.Drawing.Size(70, 40);
            this.Xor.TabIndex = 25;
            this.Xor.Text = "XOR";
            this.Xor.UseVisualStyleBackColor = false;
            this.Xor.Click += new System.EventHandler(this.Xor_Click);
            // 
            // Histogram
            // 
            this.Histogram.BackColor = System.Drawing.Color.Thistle;
            this.Histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Histogram.Location = new System.Drawing.Point(514, 217);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(157, 37);
            this.Histogram.TabIndex = 26;
            this.Histogram.Text = "Histograma";
            this.Histogram.UseVisualStyleBackColor = false;
            this.Histogram.Click += new System.EventHandler(this.Histogram_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(690, 387);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(314, 218);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1040, 386);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(302, 218);
            this.chart2.TabIndex = 28;
            this.chart2.Text = "chart2";
            // 
            // ConvolucaoMaior
            // 
            this.ConvolucaoMaior.BackColor = System.Drawing.Color.Thistle;
            this.ConvolucaoMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvolucaoMaior.Location = new System.Drawing.Point(692, 67);
            this.ConvolucaoMaior.Name = "ConvolucaoMaior";
            this.ConvolucaoMaior.Size = new System.Drawing.Size(157, 37);
            this.ConvolucaoMaior.TabIndex = 29;
            this.ConvolucaoMaior.Text = "Maior";
            this.ConvolucaoMaior.UseVisualStyleBackColor = false;
            this.ConvolucaoMaior.Click += new System.EventHandler(this.ConvolucaoMaior_Click);
            // 
            // ConvolucaoMenor
            // 
            this.ConvolucaoMenor.BackColor = System.Drawing.Color.Thistle;
            this.ConvolucaoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvolucaoMenor.Location = new System.Drawing.Point(692, 117);
            this.ConvolucaoMenor.Name = "ConvolucaoMenor";
            this.ConvolucaoMenor.Size = new System.Drawing.Size(157, 37);
            this.ConvolucaoMenor.TabIndex = 30;
            this.ConvolucaoMenor.Text = "Menor";
            this.ConvolucaoMenor.UseVisualStyleBackColor = false;
            this.ConvolucaoMenor.Click += new System.EventHandler(this.ConvolucaoMenor_Click);
            // 
            // ConvolucaoMedia
            // 
            this.ConvolucaoMedia.BackColor = System.Drawing.Color.Thistle;
            this.ConvolucaoMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvolucaoMedia.Location = new System.Drawing.Point(692, 167);
            this.ConvolucaoMedia.Name = "ConvolucaoMedia";
            this.ConvolucaoMedia.Size = new System.Drawing.Size(157, 37);
            this.ConvolucaoMedia.TabIndex = 31;
            this.ConvolucaoMedia.Text = "Média";
            this.ConvolucaoMedia.UseVisualStyleBackColor = false;
            this.ConvolucaoMedia.Click += new System.EventHandler(this.ConvolucaoMedia_Click);
            // 
            // ConvolucaoMediana
            // 
            this.ConvolucaoMediana.BackColor = System.Drawing.Color.Thistle;
            this.ConvolucaoMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvolucaoMediana.Location = new System.Drawing.Point(692, 217);
            this.ConvolucaoMediana.Name = "ConvolucaoMediana";
            this.ConvolucaoMediana.Size = new System.Drawing.Size(157, 37);
            this.ConvolucaoMediana.TabIndex = 32;
            this.ConvolucaoMediana.Text = "Mediana";
            this.ConvolucaoMediana.UseVisualStyleBackColor = false;
            this.ConvolucaoMediana.Click += new System.EventHandler(this.ConvolucaoMediana_Click);
            // 
            // ConvolucaoOrdem
            // 
            this.ConvolucaoOrdem.BackColor = System.Drawing.Color.Thistle;
            this.ConvolucaoOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvolucaoOrdem.Location = new System.Drawing.Point(692, 267);
            this.ConvolucaoOrdem.Name = "ConvolucaoOrdem";
            this.ConvolucaoOrdem.Size = new System.Drawing.Size(157, 37);
            this.ConvolucaoOrdem.TabIndex = 33;
            this.ConvolucaoOrdem.Text = "Ordem";
            this.ConvolucaoOrdem.UseVisualStyleBackColor = false;
            this.ConvolucaoOrdem.Click += new System.EventHandler(this.ConvolucaoOrdem_Click);
            // 
            // SuavizacaoConservativa
            // 
            this.SuavizacaoConservativa.BackColor = System.Drawing.Color.Thistle;
            this.SuavizacaoConservativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuavizacaoConservativa.Location = new System.Drawing.Point(867, 67);
            this.SuavizacaoConservativa.Name = "SuavizacaoConservativa";
            this.SuavizacaoConservativa.Size = new System.Drawing.Size(157, 37);
            this.SuavizacaoConservativa.TabIndex = 34;
            this.SuavizacaoConservativa.Text = "Suavização";
            this.SuavizacaoConservativa.UseVisualStyleBackColor = false;
            this.SuavizacaoConservativa.Click += new System.EventHandler(this.SuavizacaoConservativa_Click);
            // 
            // Gaussian
            // 
            this.Gaussian.BackColor = System.Drawing.Color.Thistle;
            this.Gaussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gaussian.Location = new System.Drawing.Point(868, 117);
            this.Gaussian.Name = "Gaussian";
            this.Gaussian.Size = new System.Drawing.Size(157, 37);
            this.Gaussian.TabIndex = 35;
            this.Gaussian.Text = "Gaussiano";
            this.Gaussian.UseVisualStyleBackColor = false;
            this.Gaussian.Click += new System.EventHandler(this.Gaussian_Click);
            // 
            // Prewitt
            // 
            this.Prewitt.BackColor = System.Drawing.Color.Thistle;
            this.Prewitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prewitt.Location = new System.Drawing.Point(868, 167);
            this.Prewitt.Name = "Prewitt";
            this.Prewitt.Size = new System.Drawing.Size(157, 37);
            this.Prewitt.TabIndex = 36;
            this.Prewitt.Text = "Prewitt";
            this.Prewitt.UseVisualStyleBackColor = false;
            this.Prewitt.Click += new System.EventHandler(this.Prewitt_Click);
            // 
            // Sobel
            // 
            this.Sobel.BackColor = System.Drawing.Color.Thistle;
            this.Sobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobel.Location = new System.Drawing.Point(868, 217);
            this.Sobel.Name = "Sobel";
            this.Sobel.Size = new System.Drawing.Size(157, 37);
            this.Sobel.TabIndex = 37;
            this.Sobel.Text = "Sobel";
            this.Sobel.UseVisualStyleBackColor = false;
            this.Sobel.Click += new System.EventHandler(this.Sobel_Click);
            // 
            // Laplaciano
            // 
            this.Laplaciano.BackColor = System.Drawing.Color.Thistle;
            this.Laplaciano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laplaciano.Location = new System.Drawing.Point(868, 267);
            this.Laplaciano.Name = "Laplaciano";
            this.Laplaciano.Size = new System.Drawing.Size(157, 37);
            this.Laplaciano.TabIndex = 38;
            this.Laplaciano.Text = "Laplaciano";
            this.Laplaciano.UseVisualStyleBackColor = false;
            this.Laplaciano.Click += new System.EventHandler(this.Laplaciano_Click);
            // 
            // Dilatacao
            // 
            this.Dilatacao.BackColor = System.Drawing.Color.Thistle;
            this.Dilatacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dilatacao.Location = new System.Drawing.Point(514, 528);
            this.Dilatacao.Name = "Dilatacao";
            this.Dilatacao.Size = new System.Drawing.Size(157, 37);
            this.Dilatacao.TabIndex = 39;
            this.Dilatacao.Text = "Dilatação";
            this.Dilatacao.UseVisualStyleBackColor = false;
            this.Dilatacao.Click += new System.EventHandler(this.Dilatacao_Click);
            // 
            // Erosao
            // 
            this.Erosao.BackColor = System.Drawing.Color.Thistle;
            this.Erosao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erosao.Location = new System.Drawing.Point(513, 579);
            this.Erosao.Name = "Erosao";
            this.Erosao.Size = new System.Drawing.Size(157, 37);
            this.Erosao.TabIndex = 40;
            this.Erosao.Text = "Erosão";
            this.Erosao.UseVisualStyleBackColor = false;
            this.Erosao.Click += new System.EventHandler(this.Erosao_Click);
            // 
            // Abertura
            // 
            this.Abertura.BackColor = System.Drawing.Color.Thistle;
            this.Abertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abertura.Location = new System.Drawing.Point(513, 375);
            this.Abertura.Name = "Abertura";
            this.Abertura.Size = new System.Drawing.Size(157, 37);
            this.Abertura.TabIndex = 41;
            this.Abertura.Text = "Abertura";
            this.Abertura.UseVisualStyleBackColor = false;
            this.Abertura.Click += new System.EventHandler(this.Abertura_Click);
            // 
            // Fechamento
            // 
            this.Fechamento.BackColor = System.Drawing.Color.Thistle;
            this.Fechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechamento.Location = new System.Drawing.Point(513, 426);
            this.Fechamento.Name = "Fechamento";
            this.Fechamento.Size = new System.Drawing.Size(157, 37);
            this.Fechamento.TabIndex = 42;
            this.Fechamento.Text = "Fechamento";
            this.Fechamento.UseVisualStyleBackColor = false;
            this.Fechamento.Click += new System.EventHandler(this.Fechamento_Click);
            // 
            // Contorno
            // 
            this.Contorno.BackColor = System.Drawing.Color.Thistle;
            this.Contorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contorno.Location = new System.Drawing.Point(514, 477);
            this.Contorno.Name = "Contorno";
            this.Contorno.Size = new System.Drawing.Size(157, 37);
            this.Contorno.TabIndex = 43;
            this.Contorno.Text = "Contorno";
            this.Contorno.UseVisualStyleBackColor = false;
            this.Contorno.Click += new System.EventHandler(this.Contorno_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(546, -10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 698);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Contorno);
            this.Controls.Add(this.Fechamento);
            this.Controls.Add(this.Abertura);
            this.Controls.Add(this.Erosao);
            this.Controls.Add(this.Dilatacao);
            this.Controls.Add(this.Laplaciano);
            this.Controls.Add(this.Sobel);
            this.Controls.Add(this.Prewitt);
            this.Controls.Add(this.Gaussian);
            this.Controls.Add(this.SuavizacaoConservativa);
            this.Controls.Add(this.ConvolucaoOrdem);
            this.Controls.Add(this.ConvolucaoMediana);
            this.Controls.Add(this.ConvolucaoMedia);
            this.Controls.Add(this.ConvolucaoMenor);
            this.Controls.Add(this.ConvolucaoMaior);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.Xor);
            this.Controls.Add(this.Or);
            this.Controls.Add(this.And);
            this.Controls.Add(this.Not);
            this.Controls.Add(this.Limiar);
            this.Controls.Add(this.FlipY);
            this.Controls.Add(this.FlipX);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Blending);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.ContrastDivide);
            this.Controls.Add(this.ContrastMultiply);
            this.Controls.Add(this.LoadImageOne);
            this.Controls.Add(this.LoadImageTwo);
            this.Controls.Add(this.SubtractImages);
            this.Controls.Add(this.SumImages);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BrightLess);
            this.Controls.Add(this.BrightMore);
            this.Controls.Add(this.txBright);
            this.Controls.Add(this.ConvertGray);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Photo World";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ConvertGray;
        private System.Windows.Forms.TextBox txBright;
        private System.Windows.Forms.Button BrightMore;
        private System.Windows.Forms.Button BrightLess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SumImages;
        private System.Windows.Forms.Button SubtractImages;
        private System.Windows.Forms.Button LoadImageTwo;
        private System.Windows.Forms.Button LoadImageOne;
        private System.Windows.Forms.Button ContrastMultiply;
        private System.Windows.Forms.Button ContrastDivide;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Blending;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button FlipX;
        private System.Windows.Forms.Button FlipY;
        private System.Windows.Forms.Button Limiar;
        private System.Windows.Forms.Button Not;
        private System.Windows.Forms.Button And;
        private System.Windows.Forms.Button Or;
        private System.Windows.Forms.Button Xor;
        private System.Windows.Forms.Button Histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button ConvolucaoMaior;
        private System.Windows.Forms.Button ConvolucaoMenor;
        private System.Windows.Forms.Button ConvolucaoMedia;
        private System.Windows.Forms.Button ConvolucaoMediana;
        private System.Windows.Forms.Button ConvolucaoOrdem;
        private System.Windows.Forms.Button SuavizacaoConservativa;
        private System.Windows.Forms.Button Gaussian;
        private System.Windows.Forms.Button Prewitt;
        private System.Windows.Forms.Button Sobel;
        private System.Windows.Forms.Button Laplaciano;
        private System.Windows.Forms.Button Dilatacao;
        private System.Windows.Forms.Button Erosao;
        private System.Windows.Forms.Button Abertura;
        private System.Windows.Forms.Button Fechamento;
        private System.Windows.Forms.Button Contorno;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

