namespace Simulador_Consulta_Amortizacion
{
    partial class Consulta_Amortizacion_Prestamo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tb_Plazo = new TextBox();
            tb_TasaInteres = new TextBox();
            tb_Prestamo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_ConsultaAmortizacionPrestamo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            b_Restablecer = new Button();
            b_Consultar = new Button();
            groupBox4 = new GroupBox();
            l_ZonaMensajes = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultaAmortizacionPrestamo).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tb_Plazo);
            groupBox1.Controls.Add(tb_TasaInteres);
            groupBox1.Controls.Add(tb_Prestamo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 62);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(708, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tb_Plazo
            // 
            tb_Plazo.Location = new Point(313, 155);
            tb_Plazo.Margin = new Padding(4, 5, 4, 5);
            tb_Plazo.Name = "tb_Plazo";
            tb_Plazo.Size = new Size(235, 31);
            tb_Plazo.TabIndex = 5;
            tb_Plazo.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_TasaInteres
            // 
            tb_TasaInteres.Location = new Point(313, 90);
            tb_TasaInteres.Margin = new Padding(4, 5, 4, 5);
            tb_TasaInteres.Name = "tb_TasaInteres";
            tb_TasaInteres.Size = new Size(235, 31);
            tb_TasaInteres.TabIndex = 4;
            tb_TasaInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_Prestamo
            // 
            tb_Prestamo.Location = new Point(313, 32);
            tb_Prestamo.Margin = new Padding(4, 5, 4, 5);
            tb_Prestamo.Name = "tb_Prestamo";
            tb_Prestamo.Size = new Size(235, 31);
            tb_Prestamo.TabIndex = 3;
            tb_Prestamo.TextAlign = HorizontalAlignment.Right;
            tb_Prestamo.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 40);
            label4.TabIndex = 2;
            label4.Text = "Plazo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 40);
            label3.TabIndex = 1;
            label3.Text = "Tasa de Intéres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 40);
            label2.TabIndex = 0;
            label2.Text = "Préstamo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(113, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(511, 40);
            label1.TabIndex = 1;
            label1.Text = "Consulta Amortización de Préstamo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgv_ConsultaAmortizacionPrestamo);
            groupBox2.Location = new Point(17, 300);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(708, 548);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // dgv_ConsultaAmortizacionPrestamo
            // 
            dgv_ConsultaAmortizacionPrestamo.BackgroundColor = Color.White;
            dgv_ConsultaAmortizacionPrestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultaAmortizacionPrestamo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgv_ConsultaAmortizacionPrestamo.Location = new Point(0, 0);
            dgv_ConsultaAmortizacionPrestamo.Margin = new Padding(4, 5, 4, 5);
            dgv_ConsultaAmortizacionPrestamo.Name = "dgv_ConsultaAmortizacionPrestamo";
            dgv_ConsultaAmortizacionPrestamo.ReadOnly = true;
            dgv_ConsultaAmortizacionPrestamo.RowHeadersWidth = 62;
            dgv_ConsultaAmortizacionPrestamo.RowTemplate.Height = 25;
            dgv_ConsultaAmortizacionPrestamo.ShowRowErrors = false;
            dgv_ConsultaAmortizacionPrestamo.Size = new Size(707, 547);
            dgv_ConsultaAmortizacionPrestamo.TabIndex = 6;
            dgv_ConsultaAmortizacionPrestamo.CellContentClick += dgv_ConsultaAmortizacionPrestamo_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.FillWeight = 25F;
            Column1.HeaderText = "Periodo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 25F;
            Column2.HeaderText = "Cuota";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.FillWeight = 25F;
            Column3.HeaderText = "Monto Interés";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.FillWeight = 25F;
            Column4.HeaderText = "Amortización";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.FillWeight = 25F;
            Column5.HeaderText = "Préstamo";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(b_Restablecer);
            groupBox3.Controls.Add(b_Consultar);
            groupBox3.Location = new Point(17, 885);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(708, 167);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // b_Restablecer
            // 
            b_Restablecer.BackColor = Color.Gainsboro;
            b_Restablecer.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b_Restablecer.Location = new Point(430, 37);
            b_Restablecer.Margin = new Padding(4, 5, 4, 5);
            b_Restablecer.Name = "b_Restablecer";
            b_Restablecer.Size = new Size(186, 88);
            b_Restablecer.TabIndex = 1;
            b_Restablecer.Text = "Restablecer";
            b_Restablecer.UseVisualStyleBackColor = false;
            b_Restablecer.Click += b_Restablecer_Click;
            // 
            // b_Consultar
            // 
            b_Consultar.BackColor = Color.Gainsboro;
            b_Consultar.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b_Consultar.Location = new Point(84, 37);
            b_Consultar.Margin = new Padding(4, 5, 4, 5);
            b_Consultar.Name = "b_Consultar";
            b_Consultar.Size = new Size(186, 88);
            b_Consultar.TabIndex = 0;
            b_Consultar.Text = "Consultar";
            b_Consultar.UseVisualStyleBackColor = false;
            b_Consultar.Click += b_Consultar_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(l_ZonaMensajes);
            groupBox4.Location = new Point(17, 1062);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(708, 102);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // l_ZonaMensajes
            // 
            l_ZonaMensajes.AutoSize = true;
            l_ZonaMensajes.BackColor = Color.Transparent;
            l_ZonaMensajes.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l_ZonaMensajes.ForeColor = Color.Red;
            l_ZonaMensajes.Location = new Point(49, 32);
            l_ZonaMensajes.Margin = new Padding(4, 0, 4, 0);
            l_ZonaMensajes.Name = "l_ZonaMensajes";
            l_ZonaMensajes.Size = new Size(220, 32);
            l_ZonaMensajes.TabIndex = 0;
            l_ZonaMensajes.Text = "Zona de Mensajes";
            // 
            // Consulta_Amortizacion_Prestamo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(752, 1183);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Consulta_Amortizacion_Prestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Amortizacion Prestamo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultaAmortizacionPrestamo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox tb_Plazo;
        private TextBox tb_TasaInteres;
        private TextBox tb_Prestamo;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dgv_ConsultaAmortizacionPrestamo;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label l_ZonaMensajes;
        private Button b_Restablecer;
        private Button b_Consultar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}