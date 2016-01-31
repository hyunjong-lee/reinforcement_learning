namespace ReinforcementLearning
{
    partial class ReinforcementLearning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReinforcementLearning));
            this.learningTimer = new System.Windows.Forms.Timer(this.components);
            this.labelRenderingArea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectNextStep = new System.Windows.Forms.Button();
            this.listViewEpisodeLogs = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalReward = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotalReward = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonResetModel = new System.Windows.Forms.Button();
            this.buttonRunEpisode = new System.Windows.Forms.Button();
            this.buttonGotoNextStep = new System.Windows.Forms.Button();
            this.buttonPreviewNextStep = new System.Windows.Forms.Button();
            this.trackBarEpsilon = new System.Windows.Forms.TrackBar();
            this.labelEpsilon = new System.Windows.Forms.Label();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.labelGamma = new System.Windows.Forms.Label();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.labelStepCount = new System.Windows.Forms.Label();
            this.textBoxStepCount = new System.Windows.Forms.TextBox();
            this.stepCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEpisode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // learningTimer
            // 
            this.learningTimer.Enabled = true;
            this.learningTimer.Tick += new System.EventHandler(this.learningTimer_Tick);
            // 
            // labelRenderingArea
            // 
            this.labelRenderingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRenderingArea.BackColor = System.Drawing.Color.White;
            this.labelRenderingArea.Location = new System.Drawing.Point(12, 12);
            this.labelRenderingArea.Name = "labelRenderingArea";
            this.labelRenderingArea.Size = new System.Drawing.Size(832, 681);
            this.labelRenderingArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxEpisode);
            this.panel1.Controls.Add(this.textBoxStepCount);
            this.panel1.Controls.Add(this.labelStepCount);
            this.panel1.Controls.Add(this.buttonSelectNextStep);
            this.panel1.Controls.Add(this.listViewEpisodeLogs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTotalReward);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonResetModel);
            this.panel1.Controls.Add(this.buttonRunEpisode);
            this.panel1.Controls.Add(this.buttonGotoNextStep);
            this.panel1.Controls.Add(this.buttonPreviewNextStep);
            this.panel1.Controls.Add(this.trackBarEpsilon);
            this.panel1.Controls.Add(this.labelEpsilon);
            this.panel1.Controls.Add(this.trackBarGamma);
            this.panel1.Controls.Add(this.labelGamma);
            this.panel1.Controls.Add(this.trackBarAlpha);
            this.panel1.Controls.Add(this.labelAlpha);
            this.panel1.Location = new System.Drawing.Point(850, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 681);
            this.panel1.TabIndex = 1;
            // 
            // buttonSelectNextStep
            // 
            this.buttonSelectNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectNextStep.Location = new System.Drawing.Point(3, 224);
            this.buttonSelectNextStep.Name = "buttonSelectNextStep";
            this.buttonSelectNextStep.Size = new System.Drawing.Size(234, 25);
            this.buttonSelectNextStep.TabIndex = 15;
            this.buttonSelectNextStep.Text = "Select Next Step";
            this.buttonSelectNextStep.UseVisualStyleBackColor = true;
            this.buttonSelectNextStep.Click += new System.EventHandler(this.buttonSelectNextStep_Click);
            // 
            // listViewEpisodeLogs
            // 
            this.listViewEpisodeLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEpisodeLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.stepCount,
            this.result,
            this.totalReward});
            this.listViewEpisodeLogs.Location = new System.Drawing.Point(3, 402);
            this.listViewEpisodeLogs.Name = "listViewEpisodeLogs";
            this.listViewEpisodeLogs.Size = new System.Drawing.Size(234, 276);
            this.listViewEpisodeLogs.TabIndex = 14;
            this.listViewEpisodeLogs.UseCompatibleStateImageBehavior = false;
            this.listViewEpisodeLogs.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            this.no.Text = "No";
            this.no.Width = 34;
            // 
            // result
            // 
            this.result.Text = "Result";
            // 
            // totalReward
            // 
            this.totalReward.Text = "Reward";
            this.totalReward.Width = 62;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Episodes";
            // 
            // textBoxTotalReward
            // 
            this.textBoxTotalReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalReward.Location = new System.Drawing.Point(98, 342);
            this.textBoxTotalReward.Name = "textBoxTotalReward";
            this.textBoxTotalReward.ReadOnly = true;
            this.textBoxTotalReward.Size = new System.Drawing.Size(139, 25);
            this.textBoxTotalReward.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Reward";
            // 
            // buttonResetModel
            // 
            this.buttonResetModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetModel.Location = new System.Drawing.Point(3, 3);
            this.buttonResetModel.Name = "buttonResetModel";
            this.buttonResetModel.Size = new System.Drawing.Size(234, 34);
            this.buttonResetModel.TabIndex = 9;
            this.buttonResetModel.Text = "Reset Model";
            this.buttonResetModel.UseVisualStyleBackColor = true;
            this.buttonResetModel.Click += new System.EventHandler(this.buttonResetModel_Click);
            // 
            // buttonRunEpisode
            // 
            this.buttonRunEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunEpisode.Location = new System.Drawing.Point(3, 280);
            this.buttonRunEpisode.Name = "buttonRunEpisode";
            this.buttonRunEpisode.Size = new System.Drawing.Size(164, 25);
            this.buttonRunEpisode.TabIndex = 8;
            this.buttonRunEpisode.Text = "Run Episode";
            this.buttonRunEpisode.UseVisualStyleBackColor = true;
            this.buttonRunEpisode.Click += new System.EventHandler(this.buttonRunEpisode_Click);
            // 
            // buttonGotoNextStep
            // 
            this.buttonGotoNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGotoNextStep.Location = new System.Drawing.Point(3, 252);
            this.buttonGotoNextStep.Name = "buttonGotoNextStep";
            this.buttonGotoNextStep.Size = new System.Drawing.Size(234, 25);
            this.buttonGotoNextStep.TabIndex = 7;
            this.buttonGotoNextStep.Text = "Goto Next Step";
            this.buttonGotoNextStep.UseVisualStyleBackColor = true;
            this.buttonGotoNextStep.Click += new System.EventHandler(this.buttonGotoNextStep_Click);
            // 
            // buttonPreviewNextStep
            // 
            this.buttonPreviewNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreviewNextStep.Location = new System.Drawing.Point(3, 196);
            this.buttonPreviewNextStep.Name = "buttonPreviewNextStep";
            this.buttonPreviewNextStep.Size = new System.Drawing.Size(234, 25);
            this.buttonPreviewNextStep.TabIndex = 6;
            this.buttonPreviewNextStep.Text = "Preview Next Step";
            this.buttonPreviewNextStep.UseVisualStyleBackColor = true;
            this.buttonPreviewNextStep.Click += new System.EventHandler(this.buttonPreviewNextStep_Click);
            // 
            // trackBarEpsilon
            // 
            this.trackBarEpsilon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarEpsilon.Location = new System.Drawing.Point(98, 145);
            this.trackBarEpsilon.Maximum = 20;
            this.trackBarEpsilon.Name = "trackBarEpsilon";
            this.trackBarEpsilon.Size = new System.Drawing.Size(135, 45);
            this.trackBarEpsilon.TabIndex = 5;
            this.trackBarEpsilon.ValueChanged += new System.EventHandler(this.trackBarEpsilon_ValueChanged);
            // 
            // labelEpsilon
            // 
            this.labelEpsilon.AutoSize = true;
            this.labelEpsilon.Location = new System.Drawing.Point(6, 145);
            this.labelEpsilon.Name = "labelEpsilon";
            this.labelEpsilon.Size = new System.Drawing.Size(88, 17);
            this.labelEpsilon.TabIndex = 4;
            this.labelEpsilon.Text = "epsilon (0.01)";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGamma.Location = new System.Drawing.Point(98, 94);
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(135, 45);
            this.trackBarGamma.TabIndex = 3;
            this.trackBarGamma.ValueChanged += new System.EventHandler(this.trackBarGamma_ValueChanged);
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Location = new System.Drawing.Point(5, 94);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(89, 17);
            this.labelGamma.TabIndex = 2;
            this.labelGamma.Text = "gamma (0.01)";
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarAlpha.Location = new System.Drawing.Point(98, 43);
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(135, 45);
            this.trackBarAlpha.TabIndex = 1;
            this.trackBarAlpha.ValueChanged += new System.EventHandler(this.trackBarAlpha_ValueChanged);
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(17, 43);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(78, 17);
            this.labelAlpha.TabIndex = 0;
            this.labelAlpha.Text = "alpha (0.01)";
            // 
            // labelStepCount
            // 
            this.labelStepCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStepCount.AutoSize = true;
            this.labelStepCount.Location = new System.Drawing.Point(9, 316);
            this.labelStepCount.Name = "labelStepCount";
            this.labelStepCount.Size = new System.Drawing.Size(75, 17);
            this.labelStepCount.TabIndex = 16;
            this.labelStepCount.Text = "Step Count";
            // 
            // textBoxStepCount
            // 
            this.textBoxStepCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStepCount.Location = new System.Drawing.Point(98, 311);
            this.textBoxStepCount.Name = "textBoxStepCount";
            this.textBoxStepCount.ReadOnly = true;
            this.textBoxStepCount.Size = new System.Drawing.Size(139, 25);
            this.textBoxStepCount.TabIndex = 17;
            // 
            // stepCount
            // 
            this.stepCount.Text = "Step";
            this.stepCount.Width = 49;
            // 
            // textBoxEpisode
            // 
            this.textBoxEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpisode.Location = new System.Drawing.Point(173, 280);
            this.textBoxEpisode.Name = "textBoxEpisode";
            this.textBoxEpisode.Size = new System.Drawing.Size(64, 25);
            this.textBoxEpisode.TabIndex = 18;
            this.textBoxEpisode.Text = "1";
            // 
            // ReinforcementLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1095, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRenderingArea);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReinforcementLearning";
            this.Text = "Q-Learning Simulator";
            this.Load += new System.EventHandler(this.ReinforcementLearning_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer learningTimer;
        private System.Windows.Forms.Label labelRenderingArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TrackBar trackBarEpsilon;
        private System.Windows.Forms.Label labelEpsilon;
        private System.Windows.Forms.Button buttonPreviewNextStep;
        private System.Windows.Forms.Button buttonGotoNextStep;
        private System.Windows.Forms.Button buttonRunEpisode;
        private System.Windows.Forms.Button buttonResetModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalReward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewEpisodeLogs;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader result;
        private System.Windows.Forms.ColumnHeader totalReward;
        private System.Windows.Forms.Button buttonSelectNextStep;
        private System.Windows.Forms.Label labelStepCount;
        private System.Windows.Forms.TextBox textBoxStepCount;
        private System.Windows.Forms.ColumnHeader stepCount;
        private System.Windows.Forms.TextBox textBoxEpisode;
    }
}

