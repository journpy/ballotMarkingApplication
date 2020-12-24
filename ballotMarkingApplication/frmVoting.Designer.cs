namespace ballotMarkingApplication
{
    partial class frmVoting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoting));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueInkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenInkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redInkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markBallotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ballotPb = new System.Windows.Forms.PictureBox();
            this.lblXY = new System.Windows.Forms.Label();
            this.lblARGB = new System.Windows.Forms.Label();
            this.lblWH = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConservatives = new System.Windows.Forms.TextBox();
            this.txtLabour = new System.Windows.Forms.TextBox();
            this.txtLiberalDemocrats = new System.Windows.Forms.TextBox();
            this.txtNeutral = new System.Windows.Forms.TextBox();
            this.txtInvalid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incrementConservatives = new System.Windows.Forms.RadioButton();
            this.decrementConservatives = new System.Windows.Forms.RadioButton();
            this.incrementLabour = new System.Windows.Forms.RadioButton();
            this.decrementLabour = new System.Windows.Forms.RadioButton();
            this.incrementLiberalDemocrats = new System.Windows.Forms.RadioButton();
            this.decrementLiberalDemocrats = new System.Windows.Forms.RadioButton();
            this.incrementNeutral = new System.Windows.Forms.RadioButton();
            this.decrementNeutral = new System.Windows.Forms.RadioButton();
            this.incrementInvalid = new System.Windows.Forms.RadioButton();
            this.decrementInvalid = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballotPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.markToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueInkToolStripMenuItem,
            this.greenInkToolStripMenuItem,
            this.redInkToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // blueInkToolStripMenuItem
            // 
            this.blueInkToolStripMenuItem.Name = "blueInkToolStripMenuItem";
            this.blueInkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.blueInkToolStripMenuItem.Text = "Blue Ink";
            this.blueInkToolStripMenuItem.Click += new System.EventHandler(this.blueInkToolStripMenuItem_Click);
            // 
            // greenInkToolStripMenuItem
            // 
            this.greenInkToolStripMenuItem.Name = "greenInkToolStripMenuItem";
            this.greenInkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.greenInkToolStripMenuItem.Text = "Green Ink";
            this.greenInkToolStripMenuItem.Click += new System.EventHandler(this.greenInkToolStripMenuItem_Click);
            // 
            // redInkToolStripMenuItem
            // 
            this.redInkToolStripMenuItem.Name = "redInkToolStripMenuItem";
            this.redInkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.redInkToolStripMenuItem.Text = "Red Ink";
            this.redInkToolStripMenuItem.Click += new System.EventHandler(this.redInkToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markBallotToolStripMenuItem});
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.markToolStripMenuItem.Text = "Mark";
            // 
            // markBallotToolStripMenuItem
            // 
            this.markBallotToolStripMenuItem.Name = "markBallotToolStripMenuItem";
            this.markBallotToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.markBallotToolStripMenuItem.Text = "Mark ballot";
            this.markBallotToolStripMenuItem.Click += new System.EventHandler(this.markBallotToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.loadTableToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // loadTableToolStripMenuItem
            // 
            this.loadTableToolStripMenuItem.Name = "loadTableToolStripMenuItem";
            this.loadTableToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadTableToolStripMenuItem.Text = "Load Table";
            this.loadTableToolStripMenuItem.Click += new System.EventHandler(this.loadTableToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // ballotPb
            // 
            this.ballotPb.Location = new System.Drawing.Point(0, 44);
            this.ballotPb.Name = "ballotPb";
            this.ballotPb.Size = new System.Drawing.Size(668, 644);
            this.ballotPb.TabIndex = 1;
            this.ballotPb.TabStop = false;
            this.ballotPb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ballotPb_MouseMove);
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(14, 719);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(41, 13);
            this.lblXY.TabIndex = 2;
            this.lblXY.Text = "label1";
            // 
            // lblARGB
            // 
            this.lblARGB.AutoSize = true;
            this.lblARGB.Location = new System.Drawing.Point(278, 719);
            this.lblARGB.Name = "lblARGB";
            this.lblARGB.Size = new System.Drawing.Size(41, 13);
            this.lblARGB.TabIndex = 3;
            this.lblARGB.Text = "label2";
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.Location = new System.Drawing.Point(688, 719);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(41, 13);
            this.lblWH.TabIndex = 4;
            this.lblWH.Text = "label3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(691, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 421);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtConservatives
            // 
            this.txtConservatives.Location = new System.Drawing.Point(829, 70);
            this.txtConservatives.Name = "txtConservatives";
            this.txtConservatives.Size = new System.Drawing.Size(186, 20);
            this.txtConservatives.TabIndex = 6;
            // 
            // txtLabour
            // 
            this.txtLabour.Location = new System.Drawing.Point(829, 112);
            this.txtLabour.Name = "txtLabour";
            this.txtLabour.Size = new System.Drawing.Size(186, 20);
            this.txtLabour.TabIndex = 7;
            // 
            // txtLiberalDemocrats
            // 
            this.txtLiberalDemocrats.Location = new System.Drawing.Point(829, 152);
            this.txtLiberalDemocrats.Name = "txtLiberalDemocrats";
            this.txtLiberalDemocrats.Size = new System.Drawing.Size(186, 20);
            this.txtLiberalDemocrats.TabIndex = 8;
            // 
            // txtNeutral
            // 
            this.txtNeutral.Location = new System.Drawing.Point(829, 191);
            this.txtNeutral.Name = "txtNeutral";
            this.txtNeutral.Size = new System.Drawing.Size(186, 20);
            this.txtNeutral.TabIndex = 9;
            // 
            // txtInvalid
            // 
            this.txtInvalid.Location = new System.Drawing.Point(829, 230);
            this.txtInvalid.Name = "txtInvalid";
            this.txtInvalid.Size = new System.Drawing.Size(186, 20);
            this.txtInvalid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Conservatives:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Labour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Liberal Democrats:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Neutral:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Invalid:";
            // 
            // incrementConservatives
            // 
            this.incrementConservatives.AutoSize = true;
            this.incrementConservatives.Location = new System.Drawing.Point(1081, 70);
            this.incrementConservatives.Name = "incrementConservatives";
            this.incrementConservatives.Size = new System.Drawing.Size(81, 17);
            this.incrementConservatives.TabIndex = 16;
            this.incrementConservatives.TabStop = true;
            this.incrementConservatives.Text = "Increment";
            this.incrementConservatives.UseVisualStyleBackColor = true;
            this.incrementConservatives.CheckedChanged += new System.EventHandler(this.incrementConservatives_CheckedChanged);
            // 
            // decrementConservatives
            // 
            this.decrementConservatives.AutoSize = true;
            this.decrementConservatives.Location = new System.Drawing.Point(1207, 70);
            this.decrementConservatives.Name = "decrementConservatives";
            this.decrementConservatives.Size = new System.Drawing.Size(86, 17);
            this.decrementConservatives.TabIndex = 17;
            this.decrementConservatives.TabStop = true;
            this.decrementConservatives.Text = "Decrement";
            this.decrementConservatives.UseVisualStyleBackColor = true;
            this.decrementConservatives.CheckedChanged += new System.EventHandler(this.decrementConservatives_CheckedChanged);
            // 
            // incrementLabour
            // 
            this.incrementLabour.AutoSize = true;
            this.incrementLabour.Location = new System.Drawing.Point(1081, 111);
            this.incrementLabour.Name = "incrementLabour";
            this.incrementLabour.Size = new System.Drawing.Size(81, 17);
            this.incrementLabour.TabIndex = 18;
            this.incrementLabour.TabStop = true;
            this.incrementLabour.Text = "Increment";
            this.incrementLabour.UseVisualStyleBackColor = true;
            this.incrementLabour.CheckedChanged += new System.EventHandler(this.incrementLabour_CheckedChanged);
            // 
            // decrementLabour
            // 
            this.decrementLabour.AutoSize = true;
            this.decrementLabour.Location = new System.Drawing.Point(1207, 111);
            this.decrementLabour.Name = "decrementLabour";
            this.decrementLabour.Size = new System.Drawing.Size(86, 17);
            this.decrementLabour.TabIndex = 19;
            this.decrementLabour.TabStop = true;
            this.decrementLabour.Text = "Decrement";
            this.decrementLabour.UseVisualStyleBackColor = true;
            this.decrementLabour.CheckedChanged += new System.EventHandler(this.decrementLabour_CheckedChanged);
            // 
            // incrementLiberalDemocrats
            // 
            this.incrementLiberalDemocrats.AutoSize = true;
            this.incrementLiberalDemocrats.Location = new System.Drawing.Point(1081, 151);
            this.incrementLiberalDemocrats.Name = "incrementLiberalDemocrats";
            this.incrementLiberalDemocrats.Size = new System.Drawing.Size(81, 17);
            this.incrementLiberalDemocrats.TabIndex = 20;
            this.incrementLiberalDemocrats.TabStop = true;
            this.incrementLiberalDemocrats.Text = "Increment";
            this.incrementLiberalDemocrats.UseVisualStyleBackColor = true;
            this.incrementLiberalDemocrats.CheckedChanged += new System.EventHandler(this.incrementLiberalDemocrats_CheckedChanged);
            // 
            // decrementLiberalDemocrats
            // 
            this.decrementLiberalDemocrats.AutoSize = true;
            this.decrementLiberalDemocrats.Location = new System.Drawing.Point(1207, 151);
            this.decrementLiberalDemocrats.Name = "decrementLiberalDemocrats";
            this.decrementLiberalDemocrats.Size = new System.Drawing.Size(86, 17);
            this.decrementLiberalDemocrats.TabIndex = 21;
            this.decrementLiberalDemocrats.TabStop = true;
            this.decrementLiberalDemocrats.Text = "Decrement";
            this.decrementLiberalDemocrats.UseVisualStyleBackColor = true;
            this.decrementLiberalDemocrats.CheckedChanged += new System.EventHandler(this.decrementLiberalDemocrats_CheckedChanged);
            // 
            // incrementNeutral
            // 
            this.incrementNeutral.AutoSize = true;
            this.incrementNeutral.Location = new System.Drawing.Point(1081, 191);
            this.incrementNeutral.Name = "incrementNeutral";
            this.incrementNeutral.Size = new System.Drawing.Size(81, 17);
            this.incrementNeutral.TabIndex = 22;
            this.incrementNeutral.TabStop = true;
            this.incrementNeutral.Text = "Increment";
            this.incrementNeutral.UseVisualStyleBackColor = true;
            this.incrementNeutral.CheckedChanged += new System.EventHandler(this.incrementNeutral_CheckedChanged);
            // 
            // decrementNeutral
            // 
            this.decrementNeutral.AutoSize = true;
            this.decrementNeutral.Location = new System.Drawing.Point(1207, 191);
            this.decrementNeutral.Name = "decrementNeutral";
            this.decrementNeutral.Size = new System.Drawing.Size(86, 17);
            this.decrementNeutral.TabIndex = 23;
            this.decrementNeutral.TabStop = true;
            this.decrementNeutral.Text = "Decrement";
            this.decrementNeutral.UseVisualStyleBackColor = true;
            this.decrementNeutral.CheckedChanged += new System.EventHandler(this.decrementNeutral_CheckedChanged);
            // 
            // incrementInvalid
            // 
            this.incrementInvalid.AutoSize = true;
            this.incrementInvalid.Location = new System.Drawing.Point(1081, 233);
            this.incrementInvalid.Name = "incrementInvalid";
            this.incrementInvalid.Size = new System.Drawing.Size(81, 17);
            this.incrementInvalid.TabIndex = 24;
            this.incrementInvalid.TabStop = true;
            this.incrementInvalid.Text = "Increment";
            this.incrementInvalid.UseVisualStyleBackColor = true;
            this.incrementInvalid.CheckedChanged += new System.EventHandler(this.incrementInvalid_CheckedChanged);
            // 
            // decrementInvalid
            // 
            this.decrementInvalid.AutoSize = true;
            this.decrementInvalid.Location = new System.Drawing.Point(1207, 233);
            this.decrementInvalid.Name = "decrementInvalid";
            this.decrementInvalid.Size = new System.Drawing.Size(86, 17);
            this.decrementInvalid.TabIndex = 25;
            this.decrementInvalid.TabStop = true;
            this.decrementInvalid.Text = "Decrement";
            this.decrementInvalid.UseVisualStyleBackColor = true;
            this.decrementInvalid.CheckedChanged += new System.EventHandler(this.decrementInvalid_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(829, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 20);
            this.txtID.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID:";
            // 
            // frmVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.decrementInvalid);
            this.Controls.Add(this.incrementInvalid);
            this.Controls.Add(this.decrementNeutral);
            this.Controls.Add(this.incrementNeutral);
            this.Controls.Add(this.decrementLiberalDemocrats);
            this.Controls.Add(this.incrementLiberalDemocrats);
            this.Controls.Add(this.decrementLabour);
            this.Controls.Add(this.incrementLabour);
            this.Controls.Add(this.decrementConservatives);
            this.Controls.Add(this.incrementConservatives);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvalid);
            this.Controls.Add(this.txtNeutral);
            this.Controls.Add(this.txtLiberalDemocrats);
            this.Controls.Add(this.txtLabour);
            this.Controls.Add(this.txtConservatives);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWH);
            this.Controls.Add(this.lblARGB);
            this.Controls.Add(this.lblXY);
            this.Controls.Add(this.ballotPb);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmVoting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ballot Marking Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballotPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueInkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenInkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redInkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markBallotToolStripMenuItem;
        private System.Windows.Forms.PictureBox ballotPb;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.Label lblARGB;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtConservatives;
        private System.Windows.Forms.TextBox txtLabour;
        private System.Windows.Forms.TextBox txtLiberalDemocrats;
        private System.Windows.Forms.TextBox txtNeutral;
        private System.Windows.Forms.TextBox txtInvalid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton incrementConservatives;
        private System.Windows.Forms.RadioButton decrementConservatives;
        private System.Windows.Forms.RadioButton incrementLabour;
        private System.Windows.Forms.RadioButton decrementLabour;
        private System.Windows.Forms.RadioButton incrementLiberalDemocrats;
        private System.Windows.Forms.RadioButton decrementLiberalDemocrats;
        private System.Windows.Forms.RadioButton incrementNeutral;
        private System.Windows.Forms.RadioButton decrementNeutral;
        private System.Windows.Forms.RadioButton incrementInvalid;
        private System.Windows.Forms.RadioButton decrementInvalid;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
    }
}

