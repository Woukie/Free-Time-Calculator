
namespace Free_Time_Calculator
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btn_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nudMarks = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinutesWorked = new System.Windows.Forms.Label();
            this.lblWorkPlay = new System.Windows.Forms.Label();
            this.nudPlay = new System.Windows.Forms.NumericUpDown();
            this.nudWork = new System.Windows.Forms.NumericUpDown();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblFreeTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalWorked = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lblTotalEarned = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPausePlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWork)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nudMarks
            // 
            resources.ApplyResources(this.nudMarks, "nudMarks");
            this.nudMarks.Name = "nudMarks";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lblMinutesWorked);
            this.panel1.Controls.Add(this.lblWorkPlay);
            this.panel1.Controls.Add(this.nudPlay);
            this.panel1.Controls.Add(this.nudWork);
            this.panel1.Controls.Add(this.lblMarks);
            this.panel1.Controls.Add(this.nudMarks);
            this.panel1.Controls.Add(this.lblFreeTime);
            this.panel1.Name = "panel1";
            // 
            // lblMinutesWorked
            // 
            resources.ApplyResources(this.lblMinutesWorked, "lblMinutesWorked");
            this.lblMinutesWorked.Name = "lblMinutesWorked";
            // 
            // lblWorkPlay
            // 
            resources.ApplyResources(this.lblWorkPlay, "lblWorkPlay");
            this.lblWorkPlay.Name = "lblWorkPlay";
            // 
            // nudPlay
            // 
            resources.ApplyResources(this.nudPlay, "nudPlay");
            this.nudPlay.Name = "nudPlay";
            this.nudPlay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudWork
            // 
            resources.ApplyResources(this.nudWork, "nudWork");
            this.nudWork.Name = "nudWork";
            this.nudWork.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblMarks
            // 
            resources.ApplyResources(this.lblMarks, "lblMarks");
            this.lblMarks.Name = "lblMarks";
            // 
            // lblFreeTime
            // 
            resources.ApplyResources(this.lblFreeTime, "lblFreeTime");
            this.lblFreeTime.Name = "lblFreeTime";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.lblTotalWorked);
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Controls.Add(this.lblTotalEarned);
            this.panel2.Controls.Add(this.lblLog);
            this.panel2.Name = "panel2";
            // 
            // lblTotalWorked
            // 
            resources.ApplyResources(this.lblTotalWorked, "lblTotalWorked");
            this.lblTotalWorked.Name = "lblTotalWorked";
            // 
            // txtLog
            // 
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // lblTotalEarned
            // 
            resources.ApplyResources(this.lblTotalEarned, "lblTotalEarned");
            this.lblTotalEarned.Name = "lblTotalEarned";
            // 
            // lblLog
            // 
            resources.ApplyResources(this.lblLog, "lblLog");
            this.lblLog.Name = "lblLog";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPausePlay
            // 
            resources.ApplyResources(this.btnPausePlay, "btnPausePlay");
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.UseVisualStyleBackColor = true;
            this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPausePlay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.panel1);
            this.Name = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.nudMarks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWork)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown nudMarks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblFreeTime;
        private System.Windows.Forms.Label lblWorkPlay;
        private System.Windows.Forms.NumericUpDown nudPlay;
        private System.Windows.Forms.NumericUpDown nudWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalEarned;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Label lblMinutesWorked;
        private System.Windows.Forms.Label lblTotalWorked;
    }
}

