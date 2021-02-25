
namespace OptimizeDelete.Frm
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marcado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldtiniciobanco = new System.Windows.Forms.Label();
            this.lbbanco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.dtgvFilial = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Optimeze = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFilial)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marcado});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(144, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1CellFormatting);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1KeyDown);
            // 
            // Marcado
            // 
            this.Marcado.HeaderText = "Marcado";
            this.Marcado.MinimumWidth = 2;
            this.Marcado.Name = "Marcado";
            this.Marcado.ReadOnly = true;
            this.Marcado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Marcado.Width = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbldtiniciobanco);
            this.panel1.Controls.Add(this.lbbanco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblFilial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpfinal);
            this.panel1.Controls.Add(this.dtpinicio);
            this.panel1.Controls.Add(this.dtgvFilial);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 305);
            this.panel1.TabIndex = 1;
            // 
            // lbldtiniciobanco
            // 
            this.lbldtiniciobanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtiniciobanco.ForeColor = System.Drawing.Color.Indigo;
            this.lbldtiniciobanco.Location = new System.Drawing.Point(154, 188);
            this.lbldtiniciobanco.Name = "lbldtiniciobanco";
            this.lbldtiniciobanco.Size = new System.Drawing.Size(211, 19);
            this.lbldtiniciobanco.TabIndex = 27;
            // 
            // lbbanco
            // 
            this.lbbanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbanco.ForeColor = System.Drawing.Color.Indigo;
            this.lbbanco.Location = new System.Drawing.Point(368, 238);
            this.lbbanco.Name = "lbbanco";
            this.lbbanco.Size = new System.Drawing.Size(144, 18);
            this.lbbanco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(206, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecionar filial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilial
            // 
            this.lblFilial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilial.ForeColor = System.Drawing.Color.Indigo;
            this.lblFilial.Location = new System.Drawing.Point(368, 207);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(144, 18);
            this.lblFilial.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(149, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data final:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(149, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data inicial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpfinal
            // 
            this.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfinal.Location = new System.Drawing.Point(218, 234);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(97, 20);
            this.dtpfinal.TabIndex = 2;
            this.dtpfinal.ValueChanged += new System.EventHandler(this.DtpfinalValueChanged);
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(218, 209);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpinicio.Size = new System.Drawing.Size(97, 20);
            this.dtpinicio.TabIndex = 1;
            this.dtpinicio.ValueChanged += new System.EventHandler(this.DtpinicioValueChanged);
            // 
            // dtgvFilial
            // 
            this.dtgvFilial.AllowUserToAddRows = false;
            this.dtgvFilial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvFilial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFilial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvFilial.Location = new System.Drawing.Point(152, 28);
            this.dtgvFilial.Name = "dtgvFilial";
            this.dtgvFilial.ReadOnly = true;
            this.dtgvFilial.RowHeadersVisible = false;
            this.dtgvFilial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvFilial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFilial.Size = new System.Drawing.Size(386, 157);
            this.dtgvFilial.TabIndex = 9;
            this.dtgvFilial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgvFilialCellFormatting);
            this.dtgvFilial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtgvFilialKeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Filtrar tabela";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "F5 Marca/Desmarca  F6 Marca todos  F7 Desmarca todos";
            this.label6.Click += new System.EventHandler(this.Label6Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Optimeze);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 43);
            this.panel2.TabIndex = 2;
            // 
            // Optimeze
            // 
            this.Optimeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Optimeze.Location = new System.Drawing.Point(462, 3);
            this.Optimeze.Name = "Optimeze";
            this.Optimeze.Size = new System.Drawing.Size(72, 33);
            this.Optimeze.TabIndex = 2;
            this.Optimeze.Text = "Optimize";
            this.Optimeze.UseVisualStyleBackColor = true;
            this.Optimeze.Click += new System.EventHandler(this.OptimezeClick);
            this.Optimeze.MouseLeave += new System.EventHandler(this.Optimeze_MouseLeave);
            this.Optimeze.MouseHover += new System.EventHandler(this.Optimeze_MouseHover);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Location = new System.Drawing.Point(370, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(78, 33);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.DeleteClick);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            this.Delete.MouseHover += new System.EventHandler(this.Delete_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 57);
            this.panel3.TabIndex = 3;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel3MouseMove);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = " Delete por periodo e optimize de tabelas";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label4MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(70)))), ((int)(((byte)(45)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnFechar);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(542, 32);
            this.panel4.TabIndex = 24;
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel4MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(503, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 32);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "OptimezeDelete versao 0.1.3";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipalLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFilial)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lbldtiniciobanco;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblFilial;
		private System.Windows.Forms.DataGridView dtgvFilial;
		private System.Windows.Forms.Label lbbanco;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Marcado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpinicio;
		private System.Windows.Forms.DateTimePicker dtpfinal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button Optimeze;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnFechar;
	}
}
