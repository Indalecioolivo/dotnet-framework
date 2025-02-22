namespace WindowsFormsApp1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelEditora = new System.Windows.Forms.Label();
            this.labelAnoEdicao = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.inputTitulo = new System.Windows.Forms.TextBox();
            this.inputAutor = new System.Windows.Forms.TextBox();
            this.inputEditora = new System.Windows.Forms.TextBox();
            this.inputAnoEdicao = new System.Windows.Forms.TextBox();
            this.inputLocal = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(33, 37);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(32, 96);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 1;
            this.labelAutor.Text = "Autor:";
            this.labelAutor.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(33, 160);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(43, 13);
            this.labelEditora.TabIndex = 2;
            this.labelEditora.Text = "Editora:";
            this.labelEditora.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelAnoEdicao
            // 
            this.labelAnoEdicao.AutoSize = true;
            this.labelAnoEdicao.Location = new System.Drawing.Point(33, 220);
            this.labelAnoEdicao.Name = "labelAnoEdicao";
            this.labelAnoEdicao.Size = new System.Drawing.Size(62, 13);
            this.labelAnoEdicao.TabIndex = 3;
            this.labelAnoEdicao.Text = "AnoEdicao:";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(33, 273);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(36, 13);
            this.labelLocal.TabIndex = 4;
            this.labelLocal.Text = "Local:";
            // 
            // inputTitulo
            // 
            this.inputTitulo.Location = new System.Drawing.Point(117, 37);
            this.inputTitulo.Name = "inputTitulo";
            this.inputTitulo.Size = new System.Drawing.Size(100, 20);
            this.inputTitulo.TabIndex = 5;
            // 
            // inputAutor
            // 
            this.inputAutor.Location = new System.Drawing.Point(117, 96);
            this.inputAutor.Name = "inputAutor";
            this.inputAutor.Size = new System.Drawing.Size(100, 20);
            this.inputAutor.TabIndex = 6;
            // 
            // inputEditora
            // 
            this.inputEditora.Location = new System.Drawing.Point(117, 157);
            this.inputEditora.Name = "inputEditora";
            this.inputEditora.Size = new System.Drawing.Size(100, 20);
            this.inputEditora.TabIndex = 7;
            // 
            // inputAnoEdicao
            // 
            this.inputAnoEdicao.Location = new System.Drawing.Point(117, 220);
            this.inputAnoEdicao.Name = "inputAnoEdicao";
            this.inputAnoEdicao.Size = new System.Drawing.Size(100, 20);
            this.inputAnoEdicao.TabIndex = 8;
            // 
            // inputLocal
            // 
            this.inputLocal.Location = new System.Drawing.Point(117, 273);
            this.inputLocal.Name = "inputLocal";
            this.inputLocal.Size = new System.Drawing.Size(100, 20);
            this.inputLocal.TabIndex = 9;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(163, 350);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(486, 350);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.inputLocal);
            this.Controls.Add(this.inputAnoEdicao);
            this.Controls.Add(this.inputEditora);
            this.Controls.Add(this.inputAutor);
            this.Controls.Add(this.inputTitulo);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelAnoEdicao);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelEditora;
        private System.Windows.Forms.Label labelAnoEdicao;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox inputTitulo;
        private System.Windows.Forms.TextBox inputAutor;
        private System.Windows.Forms.TextBox inputEditora;
        private System.Windows.Forms.TextBox inputAnoEdicao;
        private System.Windows.Forms.TextBox inputLocal;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
    }
}

