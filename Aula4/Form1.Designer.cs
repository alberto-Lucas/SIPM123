namespace Aula4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnValidar2 = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.cbbOpcoes = new System.Windows.Forms.ComboBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.lsbFibonacci = new System.Windows.Forms.ListBox();
            this.btnWhile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(12, 12);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(291, 22);
            this.txtConteudo.TabIndex = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(309, 12);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnValidar2
            // 
            this.btnValidar2.Location = new System.Drawing.Point(309, 41);
            this.btnValidar2.Name = "btnValidar2";
            this.btnValidar2.Size = new System.Drawing.Size(75, 23);
            this.btnValidar2.TabIndex = 2;
            this.btnValidar2.Text = "Validar2";
            this.btnValidar2.UseVisualStyleBackColor = true;
            this.btnValidar2.Click += new System.EventHandler(this.btnValidar2_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 102);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(291, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // cbxMostrarSenha
            // 
            this.cbxMostrarSenha.AutoSize = true;
            this.cbxMostrarSenha.Location = new System.Drawing.Point(12, 130);
            this.cbxMostrarSenha.Name = "cbxMostrarSenha";
            this.cbxMostrarSenha.Size = new System.Drawing.Size(116, 20);
            this.cbxMostrarSenha.TabIndex = 4;
            this.cbxMostrarSenha.Text = "Mostrar Senha";
            this.cbxMostrarSenha.UseVisualStyleBackColor = true;
            this.cbxMostrarSenha.CheckedChanged += new System.EventHandler(this.cbxMostrarSenha_CheckedChanged);
            // 
            // cbbOpcoes
            // 
            this.cbbOpcoes.FormattingEnabled = true;
            this.cbbOpcoes.Items.AddRange(new object[] {
            "BANANA",
            "MAÇA",
            "MELÃO",
            "LIMÃO"});
            this.cbbOpcoes.Location = new System.Drawing.Point(12, 170);
            this.cbbOpcoes.Name = "cbbOpcoes";
            this.cbbOpcoes.Size = new System.Drawing.Size(291, 24);
            this.cbbOpcoes.TabIndex = 5;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(309, 171);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 6;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(12, 225);
            this.nudValor.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 22);
            this.nudValor.TabIndex = 7;
            this.nudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(138, 224);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 8;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(138, 262);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnFibonacci.TabIndex = 9;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // lsbFibonacci
            // 
            this.lsbFibonacci.FormattingEnabled = true;
            this.lsbFibonacci.ItemHeight = 16;
            this.lsbFibonacci.Location = new System.Drawing.Point(12, 294);
            this.lsbFibonacci.Name = "lsbFibonacci";
            this.lsbFibonacci.Size = new System.Drawing.Size(368, 148);
            this.lsbFibonacci.TabIndex = 10;
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 458);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 11;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 572);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lsbFibonacci);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.cbbOpcoes);
            this.Controls.Add(this.cbxMostrarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnValidar2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnValidar2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox cbxMostrarSenha;
        private System.Windows.Forms.ComboBox cbbOpcoes;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.ListBox lsbFibonacci;
        private System.Windows.Forms.Button btnWhile;
    }
}

