
namespace Roteiro1
{
    partial class Tela
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel = new System.Windows.Forms.Panel();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.lbX = new System.Windows.Forms.Label();
            this.IbY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btDesenhar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.BtCor = new System.Windows.Forms.Button();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            this.btnTransladar = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.NumericFatorEscala = new System.Windows.Forms.NumericUpDown();
            this.fatorEscala = new System.Windows.Forms.Label();
            this.btnEscala = new System.Windows.Forms.Button();
            this.rotacionarButton = new System.Windows.Forms.Button();
            this.reflexaoX = new System.Windows.Forms.Button();
            this.reflexaoY = new System.Windows.Forms.Button();
            this.reflexaoOrigem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cisalhamentoY = new System.Windows.Forms.Button();
            this.cisalhamentoX = new System.Windows.Forms.Button();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFatorEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Controls.Add(this.imagem);
            this.painel.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel.Location = new System.Drawing.Point(300, 0);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(500, 450);
            this.painel.TabIndex = 0;
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(500, 450);
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            this.imagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagem_MouseMove);
            // 
            // lbX
            // 
            this.lbX.AccessibleDescription = "";
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbX.Location = new System.Drawing.Point(32, 20);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(35, 37);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "X";
            // 
            // IbY
            // 
            this.IbY.AccessibleDescription = "";
            this.IbY.AutoSize = true;
            this.IbY.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IbY.Location = new System.Drawing.Point(32, 62);
            this.IbY.Name = "IbY";
            this.IbY.Size = new System.Drawing.Size(33, 37);
            this.IbY.TabIndex = 2;
            this.IbY.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(73, 34);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(160, 23);
            this.txtX.TabIndex = 3;
            this.txtX.Text = "0";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(73, 76);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(160, 23);
            this.txtY.TabIndex = 4;
            this.txtY.Text = "0";
            // 
            // btDesenhar
            // 
            this.btDesenhar.Location = new System.Drawing.Point(12, 130);
            this.btDesenhar.Name = "btDesenhar";
            this.btDesenhar.Size = new System.Drawing.Size(68, 34);
            this.btDesenhar.TabIndex = 5;
            this.btDesenhar.Text = "Desenhar";
            this.btDesenhar.UseVisualStyleBackColor = true;
            this.btDesenhar.Click += new System.EventHandler(this.btDesenhar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(101, 130);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(68, 34);
            this.btApagar.TabIndex = 6;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // BtCor
            // 
            this.BtCor.Location = new System.Drawing.Point(194, 130);
            this.BtCor.Name = "BtCor";
            this.BtCor.Size = new System.Drawing.Size(68, 34);
            this.BtCor.TabIndex = 7;
            this.BtCor.Text = "Cor";
            this.BtCor.UseVisualStyleBackColor = true;
            this.BtCor.Click += new System.EventHandler(this.BtCor_Click);
            // 
            // btnTransladar
            // 
            this.btnTransladar.Location = new System.Drawing.Point(12, 192);
            this.btnTransladar.Name = "btnTransladar";
            this.btnTransladar.Size = new System.Drawing.Size(68, 34);
            this.btnTransladar.TabIndex = 8;
            this.btnTransladar.Text = "Transladar";
            this.btnTransladar.UseVisualStyleBackColor = true;
            this.btnTransladar.Click += new System.EventHandler(this.btnTransladar_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(180, 202);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 15);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "X:";
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(108, 200);
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(66, 23);
            this.numericX.TabIndex = 13;
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(203, 200);
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(66, 23);
            this.numericY.TabIndex = 14;
            // 
            // NumericFatorEscala
            // 
            this.NumericFatorEscala.Location = new System.Drawing.Point(156, 249);
            this.NumericFatorEscala.Name = "NumericFatorEscala";
            this.NumericFatorEscala.Size = new System.Drawing.Size(113, 23);
            this.NumericFatorEscala.TabIndex = 18;
            // 
            // fatorEscala
            // 
            this.fatorEscala.AutoSize = true;
            this.fatorEscala.Location = new System.Drawing.Point(87, 251);
            this.fatorEscala.Name = "fatorEscala";
            this.fatorEscala.Size = new System.Drawing.Size(63, 15);
            this.fatorEscala.TabIndex = 17;
            this.fatorEscala.Text = "Aumentar:";
            // 
            // btnEscala
            // 
            this.btnEscala.Location = new System.Drawing.Point(12, 241);
            this.btnEscala.Name = "btnEscala";
            this.btnEscala.Size = new System.Drawing.Size(68, 34);
            this.btnEscala.TabIndex = 15;
            this.btnEscala.Text = "Escala";
            this.btnEscala.UseVisualStyleBackColor = true;
            this.btnEscala.Click += new System.EventHandler(this.btnEscala_Click);
            // 
            // rotacionarButton
            // 
            this.rotacionarButton.Location = new System.Drawing.Point(12, 295);
            this.rotacionarButton.Name = "rotacionarButton";
            this.rotacionarButton.Size = new System.Drawing.Size(92, 34);
            this.rotacionarButton.TabIndex = 19;
            this.rotacionarButton.Text = "Rotacionar 90°";
            this.rotacionarButton.UseVisualStyleBackColor = true;
            this.rotacionarButton.Click += new System.EventHandler(this.rotacionarButton_Click);
            // 
            // reflexaoX
            // 
            this.reflexaoX.Location = new System.Drawing.Point(177, 295);
            this.reflexaoX.Name = "reflexaoX";
            this.reflexaoX.Size = new System.Drawing.Size(25, 34);
            this.reflexaoX.TabIndex = 20;
            this.reflexaoX.Text = "X";
            this.reflexaoX.UseVisualStyleBackColor = true;
            this.reflexaoX.Click += new System.EventHandler(this.reflexaoX_Click);
            // 
            // reflexaoY
            // 
            this.reflexaoY.Location = new System.Drawing.Point(208, 295);
            this.reflexaoY.Name = "reflexaoY";
            this.reflexaoY.Size = new System.Drawing.Size(25, 34);
            this.reflexaoY.TabIndex = 21;
            this.reflexaoY.Text = "Y";
            this.reflexaoY.UseVisualStyleBackColor = true;
            this.reflexaoY.Click += new System.EventHandler(this.reflexaoY_Click);
            // 
            // reflexaoOrigem
            // 
            this.reflexaoOrigem.Location = new System.Drawing.Point(239, 295);
            this.reflexaoOrigem.Name = "reflexaoOrigem";
            this.reflexaoOrigem.Size = new System.Drawing.Size(25, 34);
            this.reflexaoOrigem.TabIndex = 22;
            this.reflexaoOrigem.Text = "O";
            this.reflexaoOrigem.UseVisualStyleBackColor = true;
            this.reflexaoOrigem.Click += new System.EventHandler(this.reflexaoOrigem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reflexão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cisalhamento:";
            // 
            // cisalhamentoY
            // 
            this.cisalhamentoY.Location = new System.Drawing.Point(125, 342);
            this.cisalhamentoY.Name = "cisalhamentoY";
            this.cisalhamentoY.Size = new System.Drawing.Size(25, 34);
            this.cisalhamentoY.TabIndex = 25;
            this.cisalhamentoY.Text = "Y";
            this.cisalhamentoY.UseVisualStyleBackColor = true;
            this.cisalhamentoY.Click += new System.EventHandler(this.cisalhamentoY_Click);
            // 
            // cisalhamentoX
            // 
            this.cisalhamentoX.Location = new System.Drawing.Point(94, 342);
            this.cisalhamentoX.Name = "cisalhamentoX";
            this.cisalhamentoX.Size = new System.Drawing.Size(25, 34);
            this.cisalhamentoX.TabIndex = 24;
            this.cisalhamentoX.Text = "X";
            this.cisalhamentoX.UseVisualStyleBackColor = true;
            this.cisalhamentoX.Click += new System.EventHandler(this.cisalhamentoX_Click);
            // 
            // Tela
            // 
            this.AccessibleDescription = "lbX";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cisalhamentoY);
            this.Controls.Add(this.cisalhamentoX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reflexaoOrigem);
            this.Controls.Add(this.reflexaoY);
            this.Controls.Add(this.reflexaoX);
            this.Controls.Add(this.rotacionarButton);
            this.Controls.Add(this.NumericFatorEscala);
            this.Controls.Add(this.fatorEscala);
            this.Controls.Add(this.btnEscala);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.btnTransladar);
            this.Controls.Add(this.BtCor);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btDesenhar);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.IbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.painel);
            this.Name = "Tela";
            this.Text = "Roteiro 1 – Ambientação e Transformações ";
            this.painel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFatorEscala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label IbY;
        private System.Windows.Forms.TextBox txtX;  
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btDesenhar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button BtCor;
        private System.Windows.Forms.ColorDialog cdlg;
        private System.Windows.Forms.Button btnTransladar;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown NumericFatorEscala;
        private System.Windows.Forms.Label fatorEscala;
        private System.Windows.Forms.Button btnEscala;
        private System.Windows.Forms.Button rotacionarButton;
        private System.Windows.Forms.Button reflexaoX;
        private System.Windows.Forms.Button reflexaoY;
        private System.Windows.Forms.Button reflexaoOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cisalhamentoY;
        private System.Windows.Forms.Button cisalhamentoX;
    }
}

