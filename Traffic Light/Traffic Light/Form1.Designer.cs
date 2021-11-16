
namespace Traffic_Light
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.On = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = global::Traffic_Light.Properties.Resources._908d3_rojo;
            this.pb1.Location = new System.Drawing.Point(356, 190);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(75, 76);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(282, 117);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 13;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(282, 68);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(75, 23);
            this.Off.TabIndex = 12;
            this.Off.Text = "OFF";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // On
            // 
            this.On.Location = new System.Drawing.Point(282, 22);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(75, 23);
            this.On.TabIndex = 11;
            this.On.Text = "ON";
            this.On.UseVisualStyleBackColor = true;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Image = global::Traffic_Light.Properties.Resources.De23f47_amarillo;
            this.pb2.Location = new System.Drawing.Point(356, 346);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(75, 76);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 14;
            this.pb2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Image = global::Traffic_Light.Properties.Resources.AbOff;
            this.pb3.Location = new System.Drawing.Point(202, 356);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(75, 76);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 16;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.Image = global::Traffic_Light.Properties.Resources.IzOff;
            this.pb4.Location = new System.Drawing.Point(190, 190);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(75, 76);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 17;
            this.pb4.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 532);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.On);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Button On;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Timer timer2;
    }
}

