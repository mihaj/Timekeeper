
namespace Timekeeper
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.time = new System.Windows.Forms.Label();
            this.controller = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.green = new System.Windows.Forms.NumericUpDown();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.yellow = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(0, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(1480, 930);
            this.time.TabIndex = 0;
            this.time.Text = "00:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controller
            // 
            this.controller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controller.Location = new System.Drawing.Point(12, 12);
            this.controller.Name = "controller";
            this.controller.Size = new System.Drawing.Size(121, 33);
            this.controller.TabIndex = 1;
            this.controller.Text = "Start";
            this.controller.UseVisualStyleBackColor = true;
            this.controller.Click += new System.EventHandler(this.controller_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(60, 61);
            this.green.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(73, 20);
            this.green.TabIndex = 2;
            this.green.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(15, 63);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(39, 13);
            this.greenLabel.TabIndex = 3;
            this.greenLabel.Text = "Green:";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.Location = new System.Drawing.Point(15, 89);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(41, 13);
            this.yellowLabel.TabIndex = 5;
            this.yellowLabel.Text = "Yellow:";
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(60, 87);
            this.yellow.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(73, 20);
            this.yellow.TabIndex = 4;
            this.yellow.Value = new decimal(new int[] {
            420,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1480, 930);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.green);
            this.Controls.Add(this.controller);
            this.Controls.Add(this.time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timekeeper";
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button controller;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown green;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.NumericUpDown yellow;
    }
}

