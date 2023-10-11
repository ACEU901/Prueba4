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
            l_ZonaMensaje = new Label();
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
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tb_Plazo
            // 
            tb_Plazo.Location = new Point(219, 93);
            tb_Plazo.Name = "tb_Plazo";
            tb_Plazo.Size = new Size(114, 23);
            tb_Plazo.TabIndex = 5;
            tb_Plazo.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_TasaInteres
            // 
            tb_TasaInteres.Location = new Point(219, 54);
            tb_TasaInteres.Name = "tb_TasaInteres";
            tb_TasaInteres.Size = new Size(114, 23);
            tb_TasaInteres.TabIndex = 4;
            tb_TasaInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_Prestamo
            // 
            tb_Prestamo.Location = new Point(219, 19);
            tb_Prestamo.Name = "tb_Prestamo";
            tb_Prestamo.Size = new Size(166, 23);
            tb_Prestamo.TabIndex = 3;
            tb_Prestamo.TextAlign = HorizontalAlignment.Right;
            tb_Prestamo.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 93);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 2;
            label4.Text = "Plazo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 54);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 1;
            label3.Text = "Tasa de Intéres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 19);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 0;
            label2.Text = "Préstamo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 25);
            label1.TabIndex = 1;
            label1.Text = "Consulta Amortización de Préstamo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgv_ConsultaAmortizacionPrestamo);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 345);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // dgv_ConsultaAmortizacionPrestamo
            // 
            dgv_ConsultaAmortizacionPrestamo.BackgroundColor = Color.White;
            dgv_ConsultaAmortizacionPrestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultaAmortizacionPrestamo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgv_ConsultaAmortizacionPrestamo.Location = new Point(6, 10);
            dgv_ConsultaAmortizacionPrestamo.Name = "dgv_ConsultaAmortizacionPrestamo";
            dgv_ConsultaAmortizacionPrestamo.RowTemplate.Height = 25;
            dgv_ConsultaAmortizacionPrestamo.Size = new Size(504, 324);
            dgv_ConsultaAmortizacionPrestamo.TabIndex = 6;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.FillWeight = 25F;
            Column1.HeaderText = "Periodo";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 90;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 25F;
            Column2.HeaderText = "Cuota";
            Column2.Name = "Column2";
            Column2.Width = 90;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.FillWeight = 25F;
            Column3.HeaderText = "Monto Interés";
            Column3.Name = "Column3";
            Column3.Width = 90;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.FillWeight = 25F;
            Column4.HeaderText = "Amortización";
            Column4.Name = "Column4";
            Column4.Width = 90;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.FillWeight = 25F;
            Column5.HeaderText = "Préstamo";
            Column5.Name = "Column5";
            Column5.Width = 90;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(b_Restablecer);
            groupBox3.Controls.Add(b_Consultar);
            groupBox3.Location = new Point(12, 531);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(516, 100);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // b_Restablecer
            // 
            b_Restablecer.BackColor = Color.Gainsboro;
            b_Restablecer.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b_Restablecer.Location = new Point(303, 22);
            b_Restablecer.Name = "b_Restablecer";
            b_Restablecer.Size = new Size(130, 53);
            b_Restablecer.TabIndex = 1;
            b_Restablecer.Text = "Restablecer";
            b_Restablecer.UseVisualStyleBackColor = false;
            b_Restablecer.Click += b_Restablecer_Click;
            // 
            // b_Consultar
            // 
            b_Consultar.BackColor = Color.Gainsboro;
            b_Consultar.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b_Consultar.Location = new Point(75, 22);
            b_Consultar.Name = "b_Consultar";
            b_Consultar.Size = new Size(130, 53);
            b_Consultar.TabIndex = 0;
            b_Consultar.Text = "Consultar";
            b_Consultar.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(l_ZonaMensaje);
            groupBox4.Location = new Point(12, 637);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(516, 61);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // l_ZonaMensaje
            // 
            l_ZonaMensaje.AutoSize = true;
            l_ZonaMensaje.BackColor = Color.Transparent;
            l_ZonaMensaje.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            l_ZonaMensaje.ForeColor = Color.Red;
            l_ZonaMensaje.Location = new Point(34, 19);
            l_ZonaMensaje.Name = "l_ZonaMensaje";
            l_ZonaMensaje.Size = new Size(171, 25);
            l_ZonaMensaje.TabIndex = 0;
            l_ZonaMensaje.Text = "Zona de Mensajes";
            // 
            // Consulta_Amortizacion_Prestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(540, 710);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label l_ZonaMensaje;
        private Button b_Restablecer;
        private Button b_Consultar;
    }
}