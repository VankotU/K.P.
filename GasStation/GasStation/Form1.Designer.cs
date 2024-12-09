
namespace GasStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblWay = new System.Windows.Forms.Label();
            this.lblLitres = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rbBenzin = new System.Windows.Forms.RadioButton();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbGas = new System.Windows.Forms.RadioButton();
            this.txtBoxDistance = new System.Windows.Forms.TextBox();
            this.txtBoxConsumption = new System.Windows.Forms.TextBox();
            this.chBoxWays = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFuel.Location = new System.Drawing.Point(7, 12);
            this.lblFuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(157, 17);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Цена на горивото (лв)";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(7, 80);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(132, 17);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Разстояние (км) - ";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(7, 136);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(145, 17);
            this.lblAverage.TabIndex = 2;
            this.lblAverage.Text = "Среден разход (л) - ";
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Location = new System.Drawing.Point(7, 184);
            this.lblWay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(110, 17);
            this.lblWay.TabIndex = 3;
            this.lblWay.Text = "В двете посоки";
            // 
            // lblLitres
            // 
            this.lblLitres.AutoSize = true;
            this.lblLitres.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLitres.Location = new System.Drawing.Point(353, 76);
            this.lblLitres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLitres.Name = "lblLitres";
            this.lblLitres.Size = new System.Drawing.Size(61, 15);
            this.lblLitres.TabIndex = 4;
            this.lblLitres.Text = "0 ЛИТРА";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(353, 132);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "0 ЛЕВА";
            // 
            // rbBenzin
            // 
            this.rbBenzin.AutoSize = true;
            this.rbBenzin.Location = new System.Drawing.Point(11, 39);
            this.rbBenzin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBenzin.Name = "rbBenzin";
            this.rbBenzin.Size = new System.Drawing.Size(77, 21);
            this.rbBenzin.TabIndex = 6;
            this.rbBenzin.TabStop = true;
            this.rbBenzin.Text = "Бензин";
            this.rbBenzin.UseVisualStyleBackColor = true;
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Location = new System.Drawing.Point(101, 39);
            this.rbDiesel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(69, 21);
            this.rbDiesel.TabIndex = 7;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Дизел";
            this.rbDiesel.UseVisualStyleBackColor = true;
            // 
            // rbGas
            // 
            this.rbGas.AutoSize = true;
            this.rbGas.Location = new System.Drawing.Point(187, 39);
            this.rbGas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGas.Name = "rbGas";
            this.rbGas.Size = new System.Drawing.Size(50, 21);
            this.rbGas.TabIndex = 8;
            this.rbGas.TabStop = true;
            this.rbGas.Text = "Газ";
            this.rbGas.UseVisualStyleBackColor = true;
            // 
            // txtBoxDistance
            // 
            this.txtBoxDistance.Location = new System.Drawing.Point(156, 76);
            this.txtBoxDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDistance.Name = "txtBoxDistance";
            this.txtBoxDistance.Size = new System.Drawing.Size(132, 24);
            this.txtBoxDistance.TabIndex = 9;
            // 
            // txtBoxConsumption
            // 
            this.txtBoxConsumption.Location = new System.Drawing.Point(156, 132);
            this.txtBoxConsumption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxConsumption.Name = "txtBoxConsumption";
            this.txtBoxConsumption.Size = new System.Drawing.Size(132, 24);
            this.txtBoxConsumption.TabIndex = 10;
            // 
            // chBoxWays
            // 
            this.chBoxWays.AutoSize = true;
            this.chBoxWays.Location = new System.Drawing.Point(128, 184);
            this.chBoxWays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxWays.Name = "chBoxWays";
            this.chBoxWays.Size = new System.Drawing.Size(15, 14);
            this.chBoxWays.TabIndex = 11;
            this.chBoxWays.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(357, 12);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Изчисли";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(465, 12);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 237);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chBoxWays);
            this.Controls.Add(this.txtBoxConsumption);
            this.Controls.Add(this.txtBoxDistance);
            this.Controls.Add(this.rbGas);
            this.Controls.Add(this.rbDiesel);
            this.Controls.Add(this.rbBenzin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLitres);
            this.Controls.Add(this.lblWay);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblFuel);
            this.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Калкулатор на гориво";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblWay;
        private System.Windows.Forms.Label lblLitres;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton rbBenzin;
        private System.Windows.Forms.RadioButton rbDiesel;
        private System.Windows.Forms.RadioButton rbGas;
        private System.Windows.Forms.TextBox txtBoxDistance;
        private System.Windows.Forms.TextBox txtBoxConsumption;
        private System.Windows.Forms.CheckBox chBoxWays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

