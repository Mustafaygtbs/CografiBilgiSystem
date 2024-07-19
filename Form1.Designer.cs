namespace CografiBilgiSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEnlem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBoylam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addTo = new System.Windows.Forms.TextBox();
            this.addFrom = new System.Windows.Forms.TextBox();
            this.addType = new System.Windows.Forms.TextBox();
            this.addPlaka = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addEnlem = new System.Windows.Forms.TextBox();
            this.addBoylam = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(13, 11);
            this.map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(867, 812);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(891, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mark on the map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEnlem
            // 
            this.textBoxEnlem.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxEnlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEnlem.Location = new System.Drawing.Point(893, 52);
            this.textBoxEnlem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnlem.Multiline = true;
            this.textBoxEnlem.Name = "textBoxEnlem";
            this.textBoxEnlem.Size = new System.Drawing.Size(153, 38);
            this.textBoxEnlem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(888, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enlem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1099, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boylam:";
            // 
            // textBoxBoylam
            // 
            this.textBoxBoylam.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxBoylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBoylam.Location = new System.Drawing.Point(1104, 52);
            this.textBoxBoylam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBoylam.Multiline = true;
            this.textBoxBoylam.Name = "textBoxBoylam";
            this.textBoxBoylam.Size = new System.Drawing.Size(151, 38);
            this.textBoxBoylam.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(800, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(888, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Use Commas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1099, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Use Commas:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(891, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Place the vehicles in the list on the map.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(888, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Information of the selected vehicle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(932, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Plaka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(932, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(932, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(932, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "To:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(1001, 316);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 29);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(1001, 350);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 29);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGreen;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(1001, 380);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 29);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGreen;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(1001, 415);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 29);
            this.textBox4.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(885, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Add new car:";
            // 
            // addTo
            // 
            this.addTo.BackColor = System.Drawing.Color.LightGreen;
            this.addTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addTo.Location = new System.Drawing.Point(1003, 592);
            this.addTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTo.Multiline = true;
            this.addTo.Name = "addTo";
            this.addTo.Size = new System.Drawing.Size(160, 29);
            this.addTo.TabIndex = 28;
            // 
            // addFrom
            // 
            this.addFrom.BackColor = System.Drawing.Color.LightGreen;
            this.addFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addFrom.Location = new System.Drawing.Point(1003, 558);
            this.addFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFrom.Multiline = true;
            this.addFrom.Name = "addFrom";
            this.addFrom.Size = new System.Drawing.Size(160, 29);
            this.addFrom.TabIndex = 27;
            // 
            // addType
            // 
            this.addType.BackColor = System.Drawing.Color.LightGreen;
            this.addType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addType.Location = new System.Drawing.Point(1003, 527);
            this.addType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addType.Multiline = true;
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(160, 29);
            this.addType.TabIndex = 26;
            // 
            // addPlaka
            // 
            this.addPlaka.BackColor = System.Drawing.Color.LightGreen;
            this.addPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPlaka.Location = new System.Drawing.Point(1003, 494);
            this.addPlaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPlaka.Multiline = true;
            this.addPlaka.Name = "addPlaka";
            this.addPlaka.Size = new System.Drawing.Size(160, 29);
            this.addPlaka.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(912, 596);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "To:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(912, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "From:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(912, 532);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(912, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Plaka:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1187, 571);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 37);
            this.button4.TabIndex = 29;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(912, 631);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Enlem:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(912, 666);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 25);
            this.label17.TabIndex = 31;
            this.label17.Text = "Boylam:";
            // 
            // addEnlem
            // 
            this.addEnlem.BackColor = System.Drawing.Color.LightGreen;
            this.addEnlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEnlem.Location = new System.Drawing.Point(1003, 626);
            this.addEnlem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEnlem.Multiline = true;
            this.addEnlem.Name = "addEnlem";
            this.addEnlem.Size = new System.Drawing.Size(160, 29);
            this.addEnlem.TabIndex = 32;
            // 
            // addBoylam
            // 
            this.addBoylam.BackColor = System.Drawing.Color.LightGreen;
            this.addBoylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBoylam.Location = new System.Drawing.Point(1001, 661);
            this.addBoylam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBoylam.Multiline = true;
            this.addBoylam.Name = "addBoylam";
            this.addBoylam.Size = new System.Drawing.Size(160, 29);
            this.addBoylam.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(893, 721);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(427, 43);
            this.button3.TabIndex = 34;
            this.button3.Text = "List all tools";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1324, 825);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addBoylam);
            this.Controls.Add(this.addEnlem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addTo);
            this.Controls.Add(this.addFrom);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.addPlaka);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBoylam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnlem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEnlem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBoylam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addTo;
        private System.Windows.Forms.TextBox addFrom;
        private System.Windows.Forms.TextBox addType;
        private System.Windows.Forms.TextBox addPlaka;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox addEnlem;
        private System.Windows.Forms.TextBox addBoylam;
        private System.Windows.Forms.Button button3;
    }
}

