namespace HerYPol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComBox1 = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvLista = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActorPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActrizPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrevia = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ComBox2 = new System.Windows.Forms.ComboBox();
            this.txtAPH = new System.Windows.Forms.TextBox();
            this.txtAPM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.lbxPrevia = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wavToolStripMenuItem,
            this.mp3ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(102, 48);
            // 
            // wavToolStripMenuItem
            // 
            this.wavToolStripMenuItem.Name = "wavToolStripMenuItem";
            this.wavToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.wavToolStripMenuItem.Text = ".wav";
            // 
            // mp3ToolStripMenuItem
            // 
            this.mp3ToolStripMenuItem.Name = "mp3ToolStripMenuItem";
            this.mp3ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.mp3ToolStripMenuItem.Text = ".mp3";
            // 
            // ComBox1
            // 
            this.ComBox1.FormattingEnabled = true;
            this.ComBox1.Location = new System.Drawing.Point(348, 36);
            this.ComBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComBox1.Name = "ComBox1";
            this.ComBox1.Size = new System.Drawing.Size(170, 22);
            this.ComBox1.TabIndex = 3;
            this.ComBox1.SelectedIndexChanged += new System.EventHandler(this.ComBox1_SelectedIndexChanged);
            this.ComBox1.Click += new System.EventHandler(this.ComBox1_Click);
            this.ComBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBox1_KeyPress);
            this.ComBox1.MouseCaptureChanged += new System.EventHandler(this.ComBox1_MouseCaptureChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(22, 38);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(276, 21);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.Click += new System.EventHandler(this.TxtTitulo_Click);
            this.txtTitulo.MouseCaptureChanged += new System.EventHandler(this.TxtTitulo_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // dtgvLista
            // 
            this.dtgvLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.ActorPrincipal,
            this.ActrizPrincipal,
            this.Categoria,
            this.Formato,
            this.Duracio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLista.Location = new System.Drawing.Point(16, 190);
            this.dtgvLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgvLista.Name = "dtgvLista";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvLista.Size = new System.Drawing.Size(1144, 387);
            this.dtgvLista.TabIndex = 6;
            // 
            // Titulo
            // 
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 250;
            // 
            // Autor
            // 
            this.Autor.Frozen = true;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 200;
            // 
            // ActorPrincipal
            // 
            this.ActorPrincipal.Frozen = true;
            this.ActorPrincipal.HeaderText = "Actor Principal";
            this.ActorPrincipal.Name = "ActorPrincipal";
            this.ActorPrincipal.Width = 200;
            // 
            // ActrizPrincipal
            // 
            this.ActrizPrincipal.Frozen = true;
            this.ActrizPrincipal.HeaderText = "Actriz Principal";
            this.ActrizPrincipal.Name = "ActrizPrincipal";
            this.ActrizPrincipal.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.Frozen = true;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 85;
            // 
            // Formato
            // 
            this.Formato.Frozen = true;
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.Width = 85;
            // 
            // Duracio
            // 
            this.Duracio.Frozen = true;
            this.Duracio.HeaderText = "Duracion";
            this.Duracio.Name = "Duracio";
            this.Duracio.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autor(es)";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(22, 88);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(276, 21);
            this.txtAutor.TabIndex = 8;
            this.txtAutor.Click += new System.EventHandler(this.TxtAutor_Click);
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAutor_KeyPress);
            this.txtAutor.MouseCaptureChanged += new System.EventHandler(this.TxtAutor_MouseCaptureChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(346, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Formato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duracion";
            this.label4.UseMnemonic = false;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(348, 88);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(29, 21);
            this.txtHoras.TabIndex = 11;
            this.txtHoras.Click += new System.EventHandler(this.TxtHoras_Click);
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoras_KeyPress);
            this.txtHoras.MouseCaptureChanged += new System.EventHandler(this.TxtHoras_MouseCaptureChanged);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(404, 88);
            this.txtMinutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(29, 21);
            this.txtMinutos.TabIndex = 12;
            this.txtMinutos.Click += new System.EventHandler(this.TxtMinutos_Click);
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMinutos_KeyPress);
            this.txtMinutos.MouseCaptureChanged += new System.EventHandler(this.TxtMinutos_MouseCaptureChanged);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(464, 88);
            this.txtSegundos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(29, 21);
            this.txtSegundos.TabIndex = 13;
            this.txtSegundos.Click += new System.EventHandler(this.TxtSegundos_Click);
            this.txtSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSegundos_KeyPress);
            this.txtSegundos.MouseCaptureChanged += new System.EventHandler(this.TxtSegundos_MouseCaptureChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hs.";
            this.label5.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(435, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "min.";
            this.label6.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "seg,";
            this.label7.UseMnemonic = false;
            // 
            // btnPrevia
            // 
            this.btnPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevia.BackgroundImage")));
            this.btnPrevia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevia.Location = new System.Drawing.Point(1106, 82);
            this.btnPrevia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevia.Name = "btnPrevia";
            this.btnPrevia.Size = new System.Drawing.Size(60, 40);
            this.btnPrevia.TabIndex = 17;
            this.btnPrevia.UseVisualStyleBackColor = false;
            this.btnPrevia.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-34, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1333, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // ComBox2
            // 
            this.ComBox2.FormattingEnabled = true;
            this.ComBox2.Location = new System.Drawing.Point(869, 61);
            this.ComBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComBox2.Name = "ComBox2";
            this.ComBox2.Size = new System.Drawing.Size(170, 22);
            this.ComBox2.TabIndex = 19;
            this.ComBox2.Click += new System.EventHandler(this.ComBox2_Click);
            this.ComBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBox2_KeyPress);
            this.ComBox2.MouseCaptureChanged += new System.EventHandler(this.ComBox2_MouseCaptureChanged);
            // 
            // txtAPH
            // 
            this.txtAPH.Location = new System.Drawing.Point(565, 36);
            this.txtAPH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAPH.Name = "txtAPH";
            this.txtAPH.Size = new System.Drawing.Size(276, 21);
            this.txtAPH.TabIndex = 20;
            this.txtAPH.Click += new System.EventHandler(this.TxtAPH_Click);
            this.txtAPH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAPH_KeyPress);
            this.txtAPH.MouseCaptureChanged += new System.EventHandler(this.TxtAPH_MouseCaptureChanged);
            // 
            // txtAPM
            // 
            this.txtAPM.Location = new System.Drawing.Point(565, 90);
            this.txtAPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAPM.Name = "txtAPM";
            this.txtAPM.Size = new System.Drawing.Size(276, 21);
            this.txtAPM.TabIndex = 21;
            this.txtAPM.Click += new System.EventHandler(this.TxtAPM_Click);
            this.txtAPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAPM_KeyPress);
            this.txtAPM.MouseCaptureChanged += new System.EventHandler(this.TxtAPM_MouseCaptureChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(562, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Actor Principal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Actriz Principal";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBox.Location = new System.Drawing.Point(869, 38);
            this.chkBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(88, 18);
            this.chkBox.TabIndex = 24;
            this.chkBox.Text = "Documental";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.CheckedChanged += new System.EventHandler(this.ChkBox_CheckedChanged);
            this.chkBox.Click += new System.EventHandler(this.ChkBox_Click);
            // 
            // lbxPrevia
            // 
            this.lbxPrevia.BackColor = System.Drawing.Color.Snow;
            this.lbxPrevia.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPrevia.ForeColor = System.Drawing.Color.Brown;
            this.lbxPrevia.FormattingEnabled = true;
            this.lbxPrevia.ItemHeight = 19;
            this.lbxPrevia.Location = new System.Drawing.Point(16, 138);
            this.lbxPrevia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxPrevia.Name = "lbxPrevia";
            this.lbxPrevia.Size = new System.Drawing.Size(1081, 42);
            this.lbxPrevia.TabIndex = 25;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(1100, 136);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(66, 44);
            this.btnAñadir.TabIndex = 26;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.chkBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAPM);
            this.groupBox1.Controls.Add(this.txtAPH);
            this.groupBox1.Controls.Add(this.ComBox2);
            this.groupBox1.Controls.Add(this.btnPrevia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSegundos);
            this.groupBox1.Controls.Add(this.txtMinutos);
            this.groupBox1.Controls.Add(this.txtHoras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.ComBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(-7, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1204, 130);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lbxPrevia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvLista);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Medio Multimedia";
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem wavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mp3ToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComBox1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrevia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComBox2;
        private System.Windows.Forms.TextBox txtAPH;
        private System.Windows.Forms.TextBox txtAPM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.ListBox lbxPrevia;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActorPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActrizPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracio;
    }
}

