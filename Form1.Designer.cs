
namespace ProjectKR_Task3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AxesNumb = new System.Windows.Forms.CheckBox();
            this.NumbersChB = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorPickerFig = new System.Windows.Forms.Button();
            this.colorPickerLines = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRotationO = new System.Windows.Forms.GroupBox();
            this.FigCenter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPointChb = new System.Windows.Forms.CheckBox();
            this.Point = new System.Windows.Forms.RadioButton();
            this.Center = new System.Windows.Forms.RadioButton();
            this.AngleTxt = new System.Windows.Forms.TextBox();
            this.RotButton = new System.Windows.Forms.Button();
            this.CenterAuto = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PointTxt = new System.Windows.Forms.TextBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.figColor = new System.Windows.Forms.ColorDialog();
            this.linesColor = new System.Windows.Forms.ColorDialog();
            this.AnimTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbRotationO.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 757);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.Resize += new System.EventHandler(this.InvalidateEvent);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbRotationO);
            this.panel1.Controls.Add(this.gbSize);
            this.panel1.Location = new System.Drawing.Point(828, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 761);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AxesNumb);
            this.groupBox3.Controls.Add(this.NumbersChB);
            this.groupBox3.Controls.Add(this.ClearButton);
            this.groupBox3.Location = new System.Drawing.Point(11, 615);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 89);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // AxesNumb
            // 
            this.AxesNumb.AutoSize = true;
            this.AxesNumb.Location = new System.Drawing.Point(9, 21);
            this.AxesNumb.Name = "AxesNumb";
            this.AxesNumb.Size = new System.Drawing.Size(122, 21);
            this.AxesNumb.TabIndex = 24;
            this.AxesNumb.Text = "Подписи осей";
            this.AxesNumb.UseVisualStyleBackColor = true;
            this.AxesNumb.CheckedChanged += new System.EventHandler(this.InvalidateEvent);
            // 
            // NumbersChB
            // 
            this.NumbersChB.AutoSize = true;
            this.NumbersChB.Location = new System.Drawing.Point(9, 48);
            this.NumbersChB.Name = "NumbersChB";
            this.NumbersChB.Size = new System.Drawing.Size(141, 21);
            this.NumbersChB.TabIndex = 17;
            this.NumbersChB.Text = "Подписи вершин";
            this.NumbersChB.UseVisualStyleBackColor = true;
            this.NumbersChB.CheckedChanged += new System.EventHandler(this.InvalidateEvent);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(176, 32);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(113, 30);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Сбросить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorPickerFig);
            this.groupBox2.Controls.Add(this.colorPickerLines);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(11, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(307, 77);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвет";
            // 
            // colorPickerFig
            // 
            this.colorPickerFig.AutoSize = true;
            this.colorPickerFig.BackColor = System.Drawing.Color.AntiqueWhite;
            this.colorPickerFig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerFig.Location = new System.Drawing.Point(31, 28);
            this.colorPickerFig.Name = "colorPickerFig";
            this.colorPickerFig.Size = new System.Drawing.Size(77, 29);
            this.colorPickerFig.TabIndex = 21;
            this.colorPickerFig.Text = "Заливка";
            this.colorPickerFig.UseVisualStyleBackColor = false;
            this.colorPickerFig.Click += new System.EventHandler(this.colorPickerFig_Click);
            // 
            // colorPickerLines
            // 
            this.colorPickerLines.AutoSize = true;
            this.colorPickerLines.BackColor = System.Drawing.Color.MistyRose;
            this.colorPickerLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerLines.Location = new System.Drawing.Point(213, 28);
            this.colorPickerLines.Name = "colorPickerLines";
            this.colorPickerLines.Size = new System.Drawing.Size(76, 29);
            this.colorPickerLines.TabIndex = 22;
            this.colorPickerLines.Text = "Линии";
            this.colorPickerLines.UseVisualStyleBackColor = false;
            this.colorPickerLines.Click += new System.EventHandler(this.colorPickerLines_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(11, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 142);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица преобразований";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.Location = new System.Drawing.Point(31, 30);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(220, 91);
            this.dgv.TabIndex = 0;
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvalidateEvent);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbRotationO
            // 
            this.gbRotationO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRotationO.Controls.Add(this.FigCenter);
            this.gbRotationO.Controls.Add(this.label1);
            this.gbRotationO.Controls.Add(this.ShowPointChb);
            this.gbRotationO.Controls.Add(this.Point);
            this.gbRotationO.Controls.Add(this.Center);
            this.gbRotationO.Controls.Add(this.AngleTxt);
            this.gbRotationO.Controls.Add(this.RotButton);
            this.gbRotationO.Controls.Add(this.CenterAuto);
            this.gbRotationO.Controls.Add(this.panel2);
            this.gbRotationO.Location = new System.Drawing.Point(20, 105);
            this.gbRotationO.Name = "gbRotationO";
            this.gbRotationO.Size = new System.Drawing.Size(298, 207);
            this.gbRotationO.TabIndex = 15;
            this.gbRotationO.TabStop = false;
            this.gbRotationO.Text = "Вращение";
            // 
            // FigCenter
            // 
            this.FigCenter.AutoSize = true;
            this.FigCenter.Location = new System.Drawing.Point(9, 75);
            this.FigCenter.Name = "FigCenter";
            this.FigCenter.Size = new System.Drawing.Size(177, 21);
            this.FigCenter.TabIndex = 26;
            this.FigCenter.TabStop = true;
            this.FigCenter.Text = "Вокруг центра фигуры";
            this.FigCenter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Угол";
            // 
            // ShowPointChb
            // 
            this.ShowPointChb.AutoSize = true;
            this.ShowPointChb.Location = new System.Drawing.Point(11, 133);
            this.ShowPointChb.Name = "ShowPointChb";
            this.ShowPointChb.Size = new System.Drawing.Size(150, 21);
            this.ShowPointChb.TabIndex = 16;
            this.ShowPointChb.Text = "Отобразить точку";
            this.ShowPointChb.UseVisualStyleBackColor = true;
            this.ShowPointChb.CheckedChanged += new System.EventHandler(this.InvalidateEvent);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Location = new System.Drawing.Point(9, 48);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(161, 21);
            this.Point.TabIndex = 23;
            this.Point.TabStop = true;
            this.Point.Text = "Вокруг любой точки";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.CheckedChanged += new System.EventHandler(this.InvalidateEvent);
            // 
            // Center
            // 
            this.Center.AutoSize = true;
            this.Center.Location = new System.Drawing.Point(9, 21);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(198, 21);
            this.Center.TabIndex = 22;
            this.Center.TabStop = true;
            this.Center.Text = "Вокруг центра координат";
            this.Center.UseVisualStyleBackColor = true;
            this.Center.CheckedChanged += new System.EventHandler(this.InvalidateEvent);
            // 
            // AngleTxt
            // 
            this.AngleTxt.Location = new System.Drawing.Point(59, 105);
            this.AngleTxt.Name = "AngleTxt";
            this.AngleTxt.Size = new System.Drawing.Size(42, 22);
            this.AngleTxt.TabIndex = 21;
            // 
            // RotButton
            // 
            this.RotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.RotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotButton.Location = new System.Drawing.Point(116, 102);
            this.RotButton.Margin = new System.Windows.Forms.Padding(0);
            this.RotButton.Name = "RotButton";
            this.RotButton.Size = new System.Drawing.Size(90, 28);
            this.RotButton.TabIndex = 20;
            this.RotButton.Text = "Поворот";
            this.RotButton.UseVisualStyleBackColor = false;
            this.RotButton.Click += new System.EventHandler(this.RotButton_Click);
            // 
            // CenterAuto
            // 
            this.CenterAuto.AutoSize = true;
            this.CenterAuto.Location = new System.Drawing.Point(219, 105);
            this.CenterAuto.Name = "CenterAuto";
            this.CenterAuto.Size = new System.Drawing.Size(61, 21);
            this.CenterAuto.TabIndex = 18;
            this.CenterAuto.Text = "Авто";
            this.CenterAuto.UseVisualStyleBackColor = true;
            this.CenterAuto.CheckedChanged += new System.EventHandler(this.Auto_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.PointTxt);
            this.panel2.Location = new System.Drawing.Point(6, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 35);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Координаты точки";
            // 
            // PointTxt
            // 
            this.PointTxt.Location = new System.Drawing.Point(166, 8);
            this.PointTxt.Name = "PointTxt";
            this.PointTxt.Size = new System.Drawing.Size(54, 22);
            this.PointTxt.TabIndex = 13;
            this.PointTxt.Text = "1;1";
            this.PointTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PointTxt.TextChanged += new System.EventHandler(this.InvalidateEvent);
            // 
            // gbSize
            // 
            this.gbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSize.Controls.Add(this.txtSize);
            this.gbSize.Controls.Add(this.tbSize);
            this.gbSize.Location = new System.Drawing.Point(17, 17);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(301, 60);
            this.gbSize.TabIndex = 8;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Масштаб";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(196, 21);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(36, 22);
            this.txtSize.TabIndex = 11;
            this.txtSize.Text = "25";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // tbSize
            // 
            this.tbSize.AutoSize = false;
            this.tbSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbSize.Location = new System.Drawing.Point(3, 21);
            this.tbSize.Maximum = 60;
            this.tbSize.Minimum = 10;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(187, 30);
            this.tbSize.TabIndex = 4;
            this.tbSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSize.Value = 25;
            this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // AnimTimer
            // 
            this.AnimTimer.Tick += new System.EventHandler(this.AnimTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbRotationO.ResumeLayout(false);
            this.gbRotationO.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.GroupBox gbRotationO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox ShowPointChb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PointTxt;
        private System.Windows.Forms.CheckBox CenterAuto;
        private System.Windows.Forms.CheckBox NumbersChB;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button colorPickerLines;
        private System.Windows.Forms.Button colorPickerFig;
        private System.Windows.Forms.ColorDialog figColor;
        private System.Windows.Forms.ColorDialog linesColor;
        private System.Windows.Forms.CheckBox AxesNumb;
        private System.Windows.Forms.Timer AnimTimer;
        private System.Windows.Forms.RadioButton Point;
        private System.Windows.Forms.RadioButton Center;
        private System.Windows.Forms.TextBox AngleTxt;
        private System.Windows.Forms.Button RotButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FigCenter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

