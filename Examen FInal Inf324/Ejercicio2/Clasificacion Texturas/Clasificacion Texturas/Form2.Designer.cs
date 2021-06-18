
namespace Clasificacion_Texturas
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Rcol = new System.Windows.Forms.TextBox();
            this.Gcol = new System.Windows.Forms.TextBox();
            this.Bcol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RTextura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTextura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTextura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nomText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtr = new System.Windows.Forms.TextBox();
            this.gtxrt = new System.Windows.Forms.TextBox();
            this.btxtr = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar tectura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rcol
            // 
            this.Rcol.Location = new System.Drawing.Point(54, 70);
            this.Rcol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rcol.Name = "Rcol";
            this.Rcol.Size = new System.Drawing.Size(77, 31);
            this.Rcol.TabIndex = 2;
            // 
            // Gcol
            // 
            this.Gcol.Location = new System.Drawing.Point(54, 125);
            this.Gcol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gcol.Name = "Gcol";
            this.Gcol.Size = new System.Drawing.Size(77, 31);
            this.Gcol.TabIndex = 3;
            // 
            // Bcol
            // 
            this.Bcol.Location = new System.Drawing.Point(57, 183);
            this.Bcol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bcol.Name = "Bcol";
            this.Bcol.Size = new System.Drawing.Size(77, 31);
            this.Bcol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "R ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "G ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "B ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.RTextura,
            this.GTextura,
            this.BTextura,
            this.Rcolor,
            this.Gcolor,
            this.BColor});
            this.dataGridView1.Location = new System.Drawing.Point(359, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(769, 303);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // RTextura
            // 
            this.RTextura.HeaderText = "RTextura";
            this.RTextura.MinimumWidth = 6;
            this.RTextura.Name = "RTextura";
            this.RTextura.Width = 125;
            // 
            // GTextura
            // 
            this.GTextura.HeaderText = "GTextura";
            this.GTextura.MinimumWidth = 6;
            this.GTextura.Name = "GTextura";
            this.GTextura.Width = 125;
            // 
            // BTextura
            // 
            this.BTextura.HeaderText = "BTextura";
            this.BTextura.MinimumWidth = 6;
            this.BTextura.Name = "BTextura";
            this.BTextura.Width = 125;
            // 
            // Rcolor
            // 
            this.Rcolor.HeaderText = "Rcolor";
            this.Rcolor.MinimumWidth = 6;
            this.Rcolor.Name = "Rcolor";
            this.Rcolor.Width = 125;
            // 
            // Gcolor
            // 
            this.Gcolor.HeaderText = "GColor";
            this.Gcolor.MinimumWidth = 6;
            this.Gcolor.Name = "Gcolor";
            this.Gcolor.Width = 125;
            // 
            // BColor
            // 
            this.BColor.HeaderText = "BColor";
            this.BColor.MinimumWidth = 6;
            this.BColor.Name = "BColor";
            this.BColor.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1141, 55);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1141, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(29, 255);
            this.nomText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(155, 31);
            this.nomText.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rtxtr
            // 
            this.rtxtr.Location = new System.Drawing.Point(260, 70);
            this.rtxtr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtxtr.Name = "rtxtr";
            this.rtxtr.ReadOnly = true;
            this.rtxtr.Size = new System.Drawing.Size(77, 31);
            this.rtxtr.TabIndex = 15;
            // 
            // gtxrt
            // 
            this.gtxrt.Location = new System.Drawing.Point(260, 125);
            this.gtxrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gtxrt.Name = "gtxrt";
            this.gtxrt.ReadOnly = true;
            this.gtxrt.Size = new System.Drawing.Size(77, 31);
            this.gtxrt.TabIndex = 16;
            // 
            // btxtr
            // 
            this.btxtr.Location = new System.Drawing.Point(260, 179);
            this.btxtr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btxtr.Name = "btxtr";
            this.btxtr.ReadOnly = true;
            this.btxtr.Size = new System.Drawing.Size(77, 31);
            this.btxtr.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(159, 70);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 25);
            this.label.TabIndex = 18;
            this.label.Text = "R Textura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "G Textura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "B Textura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(27, 318);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 533);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 3);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 37);
            this.button5.TabIndex = 22;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1136, 318);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(117, 533);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1136, 269);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 37);
            this.button6.TabIndex = 24;
            this.button6.Text = " Clasificar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 867);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btxtr);
            this.Controls.Add(this.gtxrt);
            this.Controls.Add(this.rtxtr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bcol);
            this.Controls.Add(this.Gcol);
            this.Controls.Add(this.Rcol);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Rcol;
        private System.Windows.Forms.TextBox Gcol;
        private System.Windows.Forms.TextBox Bcol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTextura;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTextura;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTextura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BColor;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rtxtr;
        private System.Windows.Forms.TextBox gtxrt;
        private System.Windows.Forms.TextBox btxtr;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button6;
    }
}