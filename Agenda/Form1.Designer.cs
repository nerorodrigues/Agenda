namespace Agenda
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dtpDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.txtCompromisso = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbCompromissos = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 89);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // dtpDataCompromisso
            // 
            this.dtpDataCompromisso.Location = new System.Drawing.Point(12, 57);
            this.dtpDataCompromisso.Name = "dtpDataCompromisso";
            this.dtpDataCompromisso.Size = new System.Drawing.Size(200, 20);
            this.dtpDataCompromisso.TabIndex = 1;
            // 
            // txtCompromisso
            // 
            this.txtCompromisso.Location = new System.Drawing.Point(15, 105);
            this.txtCompromisso.Name = "txtCompromisso";
            this.txtCompromisso.Size = new System.Drawing.Size(197, 20);
            this.txtCompromisso.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(137, 145);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataCompromisso
            // 
            this.lblDataCompromisso.AutoSize = true;
            this.lblDataCompromisso.Location = new System.Drawing.Point(12, 41);
            this.lblDataCompromisso.Name = "lblDataCompromisso";
            this.lblDataCompromisso.Size = new System.Drawing.Size(95, 13);
            this.lblDataCompromisso.TabIndex = 4;
            this.lblDataCompromisso.Text = "Data Compromisso";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(613, 180);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbCompromissos
            // 
            this.cmbCompromissos.FormattingEnabled = true;
            this.cmbCompromissos.Location = new System.Drawing.Point(12, 17);
            this.cmbCompromissos.Name = "cmbCompromissos";
            this.cmbCompromissos.Size = new System.Drawing.Size(200, 21);
            this.cmbCompromissos.TabIndex = 6;
            this.cmbCompromissos.DropDown += new System.EventHandler(this.cmbCompromissos_DropDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 230);
            this.Controls.Add(this.cmbCompromissos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblDataCompromisso);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCompromisso);
            this.Controls.Add(this.dtpDataCompromisso);
            this.Controls.Add(this.lblDescricao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DateTimePicker dtpDataCompromisso;
        private System.Windows.Forms.TextBox txtCompromisso;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDataCompromisso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbCompromissos;
    }
}

