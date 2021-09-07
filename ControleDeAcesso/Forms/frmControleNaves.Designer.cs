
namespace ConroleAcesso.Forms
{
    partial class frmControleNaves
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
            this.txtNomeNave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePiloto = new System.Windows.Forms.TextBox();
            this.dgvNaves = new System.Windows.Forms.DataGridView();
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSaindo = new System.Windows.Forms.RadioButton();
            this.rdbChegando = new System.Windows.Forms.RadioButton();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.btnBuscarPiloto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeNave
            // 
            this.txtNomeNave.Location = new System.Drawing.Point(95, 21);
            this.txtNomeNave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeNave.Name = "txtNomeNave";
            this.txtNomeNave.Size = new System.Drawing.Size(884, 31);
            this.txtNomeNave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piloto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomePiloto
            // 
            this.txtNomePiloto.Location = new System.Drawing.Point(95, 363);
            this.txtNomePiloto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomePiloto.Name = "txtNomePiloto";
            this.txtNomePiloto.Size = new System.Drawing.Size(884, 31);
            this.txtNomePiloto.TabIndex = 2;
            // 
            // dgvNaves
            // 
            this.dgvNaves.AllowUserToAddRows = false;
            this.dgvNaves.AllowUserToDeleteRows = false;
            this.dgvNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaves.Location = new System.Drawing.Point(80, 68);
            this.dgvNaves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNaves.Name = "dgvNaves";
            this.dgvNaves.RowHeadersWidth = 62;
            this.dgvNaves.RowTemplate.Height = 25;
            this.dgvNaves.Size = new System.Drawing.Size(990, 285);
            this.dgvNaves.TabIndex = 4;
            // 
            // dgvPilotos
            // 
            this.dgvPilotos.AllowUserToAddRows = false;
            this.dgvPilotos.AllowUserToDeleteRows = false;
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilotos.Location = new System.Drawing.Point(80, 412);
            this.dgvPilotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPilotos.Name = "dgvPilotos";
            this.dgvPilotos.RowHeadersWidth = 62;
            this.dgvPilotos.RowTemplate.Height = 25;
            this.dgvPilotos.Size = new System.Drawing.Size(990, 285);
            this.dgvPilotos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSaindo);
            this.groupBox1.Controls.Add(this.rdbChegando);
            this.groupBox1.Location = new System.Drawing.Point(80, 708);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(367, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdbSaindo
            // 
            this.rdbSaindo.AutoSize = true;
            this.rdbSaindo.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbSaindo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSaindo.Location = new System.Drawing.Point(244, 20);
            this.rdbSaindo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbSaindo.Name = "rdbSaindo";
            this.rdbSaindo.Size = new System.Drawing.Size(97, 25);
            this.rdbSaindo.TabIndex = 1;
            this.rdbSaindo.TabStop = true;
            this.rdbSaindo.Text = "Saindo";
            this.rdbSaindo.UseVisualStyleBackColor = true;
            // 
            // rdbChegando
            // 
            this.rdbChegando.AutoSize = true;
            this.rdbChegando.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbChegando.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbChegando.Location = new System.Drawing.Point(30, 20);
            this.rdbChegando.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbChegando.Name = "rdbChegando";
            this.rdbChegando.Size = new System.Drawing.Size(124, 25);
            this.rdbChegando.TabIndex = 0;
            this.rdbChegando.TabStop = true;
            this.rdbChegando.Text = "Chegando";
            this.rdbChegando.UseVisualStyleBackColor = true;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvancar.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAvancar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAvancar.Location = new System.Drawing.Point(930, 725);
            this.btnAvancar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(107, 38);
            this.btnAvancar.TabIndex = 7;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuscarNave.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarNave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarNave.Location = new System.Drawing.Point(974, 18);
            this.btnBuscarNave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(96, 38);
            this.btnBuscarNave.TabIndex = 8;
            this.btnBuscarNave.Text = "Buscar";
            this.btnBuscarNave.UseVisualStyleBackColor = false;
            this.btnBuscarNave.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // btnBuscarPiloto
            // 
            this.btnBuscarPiloto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuscarPiloto.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarPiloto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPiloto.Location = new System.Drawing.Point(974, 362);
            this.btnBuscarPiloto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarPiloto.Name = "btnBuscarPiloto";
            this.btnBuscarPiloto.Size = new System.Drawing.Size(96, 38);
            this.btnBuscarPiloto.TabIndex = 9;
            this.btnBuscarPiloto.Text = "Buscar";
            this.btnBuscarPiloto.UseVisualStyleBackColor = false;
            this.btnBuscarPiloto.Click += new System.EventHandler(this.btnBuscarPiloto_Click);
            // 
            // frmControleNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1090, 790);
            this.Controls.Add(this.btnBuscarPiloto);
            this.Controls.Add(this.btnBuscarNave);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.dgvNaves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePiloto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeNave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmControleNaves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControleNaves_FormClosing);
            this.Load += new System.EventHandler(this.frmControleNaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeNave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePiloto;
        private System.Windows.Forms.DataGridView dgvNaves;
        private System.Windows.Forms.DataGridView dgvPilotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSaindo;
        private System.Windows.Forms.RadioButton rdbChegando;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnBuscarNave;
        private System.Windows.Forms.Button btnBuscarPiloto;
    }
}