namespace WinFormsApp1
{
    partial class Form1
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
            this.label1_nome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxListaPessoas = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_Processados = new System.Windows.Forms.ListBox();
            this.button3_Alunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_nome
            // 
            this.label1_nome.AutoSize = true;
            this.label1_nome.Location = new System.Drawing.Point(12, 9);
            this.label1_nome.Name = "label1_nome";
            this.label1_nome.Size = new System.Drawing.Size(241, 20);
            this.label1_nome.TabIndex = 0;
            this.label1_nome.Text = "Bem vindo ao organizador de Lista";
            this.label1_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxListaPessoas
            // 
            this.listBoxListaPessoas.FormattingEnabled = true;
            this.listBoxListaPessoas.ItemHeight = 20;
            this.listBoxListaPessoas.Location = new System.Drawing.Point(34, 104);
            this.listBoxListaPessoas.Name = "listBoxListaPessoas";
            this.listBoxListaPessoas.Size = new System.Drawing.Size(413, 344);
            this.listBoxListaPessoas.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Pessoas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_Processados
            // 
            this.listBox_Processados.FormattingEnabled = true;
            this.listBox_Processados.ItemHeight = 20;
            this.listBox_Processados.Location = new System.Drawing.Point(680, 104);
            this.listBox_Processados.Name = "listBox_Processados";
            this.listBox_Processados.Size = new System.Drawing.Size(409, 344);
            this.listBox_Processados.TabIndex = 5;
            this.listBox_Processados.SelectedIndexChanged += new System.EventHandler(this.listBox_Processados_SelectedIndexChanged);
            // 
            // button3_Alunos
            // 
            this.button3_Alunos.Location = new System.Drawing.Point(900, 49);
            this.button3_Alunos.Name = "button3_Alunos";
            this.button3_Alunos.Size = new System.Drawing.Size(189, 29);
            this.button3_Alunos.TabIndex = 6;
            this.button3_Alunos.Text = "Ver Alunos";
            this.button3_Alunos.UseVisualStyleBackColor = true;
            this.button3_Alunos.Click += new System.EventHandler(this.button3_Alunos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 520);
            this.Controls.Add(this.button3_Alunos);
            this.Controls.Add(this.listBox_Processados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxListaPessoas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1_nome);
            this.Name = "Form1";
            this.Text = "Win Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_nome;
        private Button button1;
        private ListBox listBoxListaPessoas;
        private Button button2;
        private ListBox listBox_Processados;
        private Button button3_Alunos;
    }
}