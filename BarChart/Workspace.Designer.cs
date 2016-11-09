namespace BarChart
{
    partial class Workspace
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBoxForOriginal = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartForOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxForNegative = new System.Windows.Forms.PictureBox();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelAfter = new System.Windows.Forms.Label();
            this.labelHistogramBefore = new System.Windows.Forms.Label();
            this.labelHustogrAfter = new System.Windows.Forms.Label();
            this.chartForNegative = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonNegtive = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelValueOfBrightness = new System.Windows.Forms.Label();
            this.panelForBrightness = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonEdgeDetection = new System.Windows.Forms.Button();
            this.buttonSharpness = new System.Windows.Forms.Button();
            this.labelForPanelButtons = new System.Windows.Forms.Label();
            this.labelForPanelBritness = new System.Windows.Forms.Label();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForOriginal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForNegative)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.panelForBrightness.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxForOriginal
            // 
            this.pictureBoxForOriginal.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBoxForOriginal.Location = new System.Drawing.Point(15, 41);
            this.pictureBoxForOriginal.Name = "pictureBoxForOriginal";
            this.pictureBoxForOriginal.Size = new System.Drawing.Size(344, 200);
            this.pictureBoxForOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForOriginal.TabIndex = 0;
            this.pictureBoxForOriginal.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // chartForOriginal
            // 
            this.chartForOriginal.BackColor = System.Drawing.Color.DarkGray;
            this.chartForOriginal.BorderlineColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartAreaBrightness";
            this.chartForOriginal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartForOriginal.Legends.Add(legend3);
            this.chartForOriginal.Location = new System.Drawing.Point(9, 41);
            this.chartForOriginal.Name = "chartForOriginal";
            this.chartForOriginal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartAreaBrightness";
            series3.Legend = "Legend1";
            series3.Name = "Brightness";
            this.chartForOriginal.Series.Add(series3);
            this.chartForOriginal.Size = new System.Drawing.Size(420, 196);
            this.chartForOriginal.TabIndex = 2;
            this.chartForOriginal.Text = "chart1";
            // 
            // pictureBoxForNegative
            // 
            this.pictureBoxForNegative.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBoxForNegative.Location = new System.Drawing.Point(15, 288);
            this.pictureBoxForNegative.Name = "pictureBoxForNegative";
            this.pictureBoxForNegative.Size = new System.Drawing.Size(344, 196);
            this.pictureBoxForNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForNegative.TabIndex = 3;
            this.pictureBoxForNegative.TabStop = false;
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBefore.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelBefore.Location = new System.Drawing.Point(11, 15);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(61, 20);
            this.labelBefore.TabIndex = 4;
            this.labelBefore.Text = "Before:";
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAfter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelAfter.Location = new System.Drawing.Point(11, 262);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(48, 20);
            this.labelAfter.TabIndex = 5;
            this.labelAfter.Text = "After:";
            // 
            // labelHistogramBefore
            // 
            this.labelHistogramBefore.AutoSize = true;
            this.labelHistogramBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHistogramBefore.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelHistogramBefore.Location = new System.Drawing.Point(5, 15);
            this.labelHistogramBefore.Name = "labelHistogramBefore";
            this.labelHistogramBefore.Size = new System.Drawing.Size(182, 20);
            this.labelHistogramBefore.TabIndex = 6;
            this.labelHistogramBefore.Text = "Histogram of brightness:";
            // 
            // labelHustogrAfter
            // 
            this.labelHustogrAfter.AutoSize = true;
            this.labelHustogrAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHustogrAfter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelHustogrAfter.Location = new System.Drawing.Point(5, 261);
            this.labelHustogrAfter.Name = "labelHustogrAfter";
            this.labelHustogrAfter.Size = new System.Drawing.Size(182, 20);
            this.labelHustogrAfter.TabIndex = 7;
            this.labelHustogrAfter.Text = "Histogram of brightness:";
            // 
            // chartForNegative
            // 
            this.chartForNegative.BackColor = System.Drawing.Color.DarkGray;
            this.chartForNegative.BorderlineColor = System.Drawing.Color.Silver;
            chartArea4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.Name = "ChartArea1";
            this.chartForNegative.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartForNegative.Legends.Add(legend4);
            this.chartForNegative.Location = new System.Drawing.Point(12, 288);
            this.chartForNegative.Name = "chartForNegative";
            this.chartForNegative.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Brightness";
            this.chartForNegative.Series.Add(series4);
            this.chartForNegative.Size = new System.Drawing.Size(420, 196);
            this.chartForNegative.TabIndex = 8;
            this.chartForNegative.Text = "chart1";
            // 
            // buttonNegtive
            // 
            this.buttonNegtive.BackColor = System.Drawing.Color.Gray;
            this.buttonNegtive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNegtive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNegtive.ForeColor = System.Drawing.Color.Silver;
            this.buttonNegtive.Location = new System.Drawing.Point(17, 41);
            this.buttonNegtive.Name = "buttonNegtive";
            this.buttonNegtive.Size = new System.Drawing.Size(149, 33);
            this.buttonNegtive.TabIndex = 9;
            this.buttonNegtive.Text = "Negative";
            this.buttonNegtive.UseVisualStyleBackColor = false;
            this.buttonNegtive.Click += new System.EventHandler(this.buttonNegtive_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar.Location = new System.Drawing.Point(15, 486);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(344, 23);
            this.progressBar.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(17, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBoxForOriginal);
            this.panel1.Controls.Add(this.labelBefore);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.labelAfter);
            this.panel1.Controls.Add(this.pictureBoxForNegative);
            this.panel1.Location = new System.Drawing.Point(201, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 518);
            this.panel1.TabIndex = 12;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(3, 32);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = -100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(146, 45);
            this.trackBarBrightness.TabIndex = 13;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // labelValueOfBrightness
            // 
            this.labelValueOfBrightness.AutoSize = true;
            this.labelValueOfBrightness.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValueOfBrightness.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelValueOfBrightness.Location = new System.Drawing.Point(67, 6);
            this.labelValueOfBrightness.Name = "labelValueOfBrightness";
            this.labelValueOfBrightness.Size = new System.Drawing.Size(20, 23);
            this.labelValueOfBrightness.TabIndex = 14;
            this.labelValueOfBrightness.Text = "0";
            // 
            // panelForBrightness
            // 
            this.panelForBrightness.BackColor = System.Drawing.Color.Gray;
            this.panelForBrightness.Controls.Add(this.buttonApply);
            this.panelForBrightness.Controls.Add(this.trackBarBrightness);
            this.panelForBrightness.Controls.Add(this.labelValueOfBrightness);
            this.panelForBrightness.Location = new System.Drawing.Point(17, 355);
            this.panelForBrightness.Name = "panelForBrightness";
            this.panelForBrightness.Size = new System.Drawing.Size(152, 129);
            this.panelForBrightness.TabIndex = 15;
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply.ForeColor = System.Drawing.Color.DimGray;
            this.buttonApply.Location = new System.Drawing.Point(3, 83);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(146, 29);
            this.buttonApply.TabIndex = 16;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // panelForButtons
            // 
            this.panelForButtons.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelForButtons.Controls.Add(this.buttonBlur);
            this.panelForButtons.Controls.Add(this.buttonEdgeDetection);
            this.panelForButtons.Controls.Add(this.buttonSharpness);
            this.panelForButtons.Controls.Add(this.labelForPanelButtons);
            this.panelForButtons.Controls.Add(this.labelForPanelBritness);
            this.panelForButtons.Controls.Add(this.buttonBrightness);
            this.panelForButtons.Controls.Add(this.button1);
            this.panelForButtons.Controls.Add(this.panelForBrightness);
            this.panelForButtons.Controls.Add(this.buttonNegtive);
            this.panelForButtons.Location = new System.Drawing.Point(12, 27);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(183, 518);
            this.panelForButtons.TabIndex = 11;
            // 
            // buttonBlur
            // 
            this.buttonBlur.BackColor = System.Drawing.Color.Gray;
            this.buttonBlur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBlur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlur.ForeColor = System.Drawing.Color.Silver;
            this.buttonBlur.Location = new System.Drawing.Point(17, 119);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(149, 33);
            this.buttonBlur.TabIndex = 20;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = false;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // buttonEdgeDetection
            // 
            this.buttonEdgeDetection.BackColor = System.Drawing.Color.Gray;
            this.buttonEdgeDetection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdgeDetection.ForeColor = System.Drawing.Color.Silver;
            this.buttonEdgeDetection.Location = new System.Drawing.Point(17, 197);
            this.buttonEdgeDetection.Name = "buttonEdgeDetection";
            this.buttonEdgeDetection.Size = new System.Drawing.Size(149, 33);
            this.buttonEdgeDetection.TabIndex = 19;
            this.buttonEdgeDetection.Text = "Edge detection";
            this.buttonEdgeDetection.UseVisualStyleBackColor = false;
            this.buttonEdgeDetection.Click += new System.EventHandler(this.buttonEdgeDetection_Click);
            // 
            // buttonSharpness
            // 
            this.buttonSharpness.BackColor = System.Drawing.Color.Gray;
            this.buttonSharpness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSharpness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSharpness.ForeColor = System.Drawing.Color.Silver;
            this.buttonSharpness.Location = new System.Drawing.Point(17, 158);
            this.buttonSharpness.Name = "buttonSharpness";
            this.buttonSharpness.Size = new System.Drawing.Size(149, 33);
            this.buttonSharpness.TabIndex = 18;
            this.buttonSharpness.Text = "Sharpness";
            this.buttonSharpness.UseVisualStyleBackColor = false;
            this.buttonSharpness.Click += new System.EventHandler(this.buttonSharpness_Click);
            // 
            // labelForPanelButtons
            // 
            this.labelForPanelButtons.AutoSize = true;
            this.labelForPanelButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForPanelButtons.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelForPanelButtons.Location = new System.Drawing.Point(13, 15);
            this.labelForPanelButtons.Name = "labelForPanelButtons";
            this.labelForPanelButtons.Size = new System.Drawing.Size(156, 20);
            this.labelForPanelButtons.TabIndex = 11;
            this.labelForPanelButtons.Text = "Select the operation:";
            // 
            // labelForPanelBritness
            // 
            this.labelForPanelBritness.AutoSize = true;
            this.labelForPanelBritness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForPanelBritness.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelForPanelBritness.Location = new System.Drawing.Point(16, 332);
            this.labelForPanelBritness.Name = "labelForPanelBritness";
            this.labelForPanelBritness.Size = new System.Drawing.Size(163, 20);
            this.labelForPanelBritness.TabIndex = 11;
            this.labelForPanelBritness.Text = "Select the brightness:";
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.BackColor = System.Drawing.Color.Gray;
            this.buttonBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBrightness.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrightness.Location = new System.Drawing.Point(17, 80);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(149, 33);
            this.buttonBrightness.TabIndex = 16;
            this.buttonBrightness.Text = "Brightness";
            this.buttonBrightness.UseVisualStyleBackColor = false;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.labelHistogramBefore);
            this.panel2.Controls.Add(this.chartForOriginal);
            this.panel2.Controls.Add(this.labelHustogrAfter);
            this.panel2.Controls.Add(this.chartForNegative);
            this.panel2.Location = new System.Drawing.Point(587, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 518);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1032, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelForButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MiSOI. Bar chart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForOriginal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForNegative)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.panelForBrightness.ResumeLayout(false);
            this.panelForBrightness.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelForButtons.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForOriginal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForOriginal;
        private System.Windows.Forms.PictureBox pictureBoxForNegative;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.Label labelHistogramBefore;
        private System.Windows.Forms.Label labelHustogrAfter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForNegative;
        private System.Windows.Forms.Button buttonNegtive;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label labelValueOfBrightness;
        private System.Windows.Forms.Panel panelForBrightness;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.Label labelForPanelButtons;
        private System.Windows.Forms.Label labelForPanelBritness;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSharpness;
        private System.Windows.Forms.Button buttonEdgeDetection;
        private System.Windows.Forms.Button buttonBlur;
    }
}

