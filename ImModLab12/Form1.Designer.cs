
namespace ImModLab12
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
            this.startStopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edAmount = new System.Windows.Forms.NumericUpDown();
            this.edTime = new System.Windows.Forms.NumericUpDown();
            this.clearDays = new System.Windows.Forms.Label();
            this.stDistClear = new System.Windows.Forms.Label();
            this.cloudyDays = new System.Windows.Forms.Label();
            this.stDistOverc = new System.Windows.Forms.Label();
            this.stDistCloudy = new System.Windows.Forms.Label();
            this.overcastDays = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTime)).BeginInit();
            this.SuspendLayout();
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(283, 536);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(192, 78);
            this.startStopBtn.TabIndex = 0;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(574, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cloudy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(875, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Overcast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "stationary distribution";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time";
            // 
            // edAmount
            // 
            this.edAmount.Location = new System.Drawing.Point(104, 518);
            this.edAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edAmount.Name = "edAmount";
            this.edAmount.Size = new System.Drawing.Size(146, 22);
            this.edAmount.TabIndex = 8;
            this.edAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edTime
            // 
            this.edTime.Location = new System.Drawing.Point(104, 589);
            this.edTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edTime.Name = "edTime";
            this.edTime.Size = new System.Drawing.Size(146, 22);
            this.edTime.TabIndex = 9;
            this.edTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // clearDays
            // 
            this.clearDays.AutoSize = true;
            this.clearDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearDays.Location = new System.Drawing.Point(278, 151);
            this.clearDays.Name = "clearDays";
            this.clearDays.Size = new System.Drawing.Size(23, 25);
            this.clearDays.TabIndex = 10;
            this.clearDays.Text = "0";
            // 
            // stDistClear
            // 
            this.stDistClear.AutoSize = true;
            this.stDistClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stDistClear.Location = new System.Drawing.Point(278, 285);
            this.stDistClear.Name = "stDistClear";
            this.stDistClear.Size = new System.Drawing.Size(23, 25);
            this.stDistClear.TabIndex = 11;
            this.stDistClear.Text = "0";
            // 
            // cloudyDays
            // 
            this.cloudyDays.AutoSize = true;
            this.cloudyDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloudyDays.Location = new System.Drawing.Point(574, 151);
            this.cloudyDays.Name = "cloudyDays";
            this.cloudyDays.Size = new System.Drawing.Size(23, 25);
            this.cloudyDays.TabIndex = 12;
            this.cloudyDays.Text = "0";
            // 
            // stDistOverc
            // 
            this.stDistOverc.AutoSize = true;
            this.stDistOverc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stDistOverc.Location = new System.Drawing.Point(875, 285);
            this.stDistOverc.Name = "stDistOverc";
            this.stDistOverc.Size = new System.Drawing.Size(23, 25);
            this.stDistOverc.TabIndex = 13;
            this.stDistOverc.Text = "0";
            // 
            // stDistCloudy
            // 
            this.stDistCloudy.AutoSize = true;
            this.stDistCloudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stDistCloudy.Location = new System.Drawing.Point(574, 285);
            this.stDistCloudy.Name = "stDistCloudy";
            this.stDistCloudy.Size = new System.Drawing.Size(23, 25);
            this.stDistCloudy.TabIndex = 13;
            this.stDistCloudy.Text = "0";
            // 
            // overcastDays
            // 
            this.overcastDays.AutoSize = true;
            this.overcastDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overcastDays.Location = new System.Drawing.Point(875, 151);
            this.overcastDays.Name = "overcastDays";
            this.overcastDays.Size = new System.Drawing.Size(23, 25);
            this.overcastDays.TabIndex = 14;
            this.overcastDays.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 645);
            this.Controls.Add(this.overcastDays);
            this.Controls.Add(this.stDistCloudy);
            this.Controls.Add(this.stDistOverc);
            this.Controls.Add(this.cloudyDays);
            this.Controls.Add(this.stDistClear);
            this.Controls.Add(this.clearDays);
            this.Controls.Add(this.edTime);
            this.Controls.Add(this.edAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startStopBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edAmount;
        private System.Windows.Forms.NumericUpDown edTime;
        private System.Windows.Forms.Label clearDays;
        private System.Windows.Forms.Label stDistClear;
        private System.Windows.Forms.Label cloudyDays;
        private System.Windows.Forms.Label stDistOverc;
        private System.Windows.Forms.Label stDistCloudy;
        private System.Windows.Forms.Label overcastDays;
        private System.Windows.Forms.Timer timer1;
    }
}

