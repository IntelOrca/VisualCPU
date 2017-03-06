namespace VisualCPU
{
	partial class OptionsForm
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
			if (disposing && (components != null)) {
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabAppearance = new System.Windows.Forms.TabPage();
			this.grpTaskAppearance = new System.Windows.Forms.GroupBox();
			this.chkShowMemorySize = new System.Windows.Forms.CheckBox();
			this.grpBackground = new System.Windows.Forms.GroupBox();
			this.lblSat = new System.Windows.Forms.Label();
			this.txtSat = new VisualCPU.NumericTextBox();
			this.lblHue = new System.Windows.Forms.Label();
			this.txtHue = new VisualCPU.NumericTextBox();
			this.tabBehavior = new System.Windows.Forms.TabPage();
			this.grpShockwaveBehavior = new System.Windows.Forms.GroupBox();
			this.txtPower = new VisualCPU.NumericTextBox();
			this.lblPower = new System.Windows.Forms.Label();
			this.txtRange = new VisualCPU.NumericTextBox();
			this.lblRange = new System.Windows.Forms.Label();
			this.grpTaskBehavior = new System.Windows.Forms.GroupBox();
			this.txtAngularSpeed = new VisualCPU.NumericTextBox();
			this.lblAngularSpeed = new System.Windows.Forms.Label();
			this.txtTopSpeed = new VisualCPU.NumericTextBox();
			this.lblTopSpeed = new System.Windows.Forms.Label();
			this.txtDrag = new VisualCPU.NumericTextBox();
			this.lblDrag = new System.Windows.Forms.Label();
			this.txtResizeSpeed = new VisualCPU.NumericTextBox();
			this.lblResizeSpeed = new System.Windows.Forms.Label();
			this.txtAcceleration = new VisualCPU.NumericTextBox();
			this.lblAcceleration = new System.Windows.Forms.Label();
			this.tabTiming = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtRefreshSpeed = new VisualCPU.NumericTextBox();
			this.lblRefreshSpeed = new System.Windows.Forms.Label();
			this.txtDrawSpeed = new VisualCPU.NumericTextBox();
			this.lblDrawSpeed = new System.Windows.Forms.Label();
			this.txtUpdateSpeed = new VisualCPU.NumericTextBox();
			this.lblUpdateSpeed = new System.Windows.Forms.Label();
			this.tabUpdating = new System.Windows.Forms.TabPage();
			this.grpCheckForUpdates = new System.Windows.Forms.GroupBox();
			this.chkAutoCheckForUpdates = new System.Windows.Forms.CheckBox();
			this.btnSetColour = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabAppearance.SuspendLayout();
			this.grpTaskAppearance.SuspendLayout();
			this.grpBackground.SuspendLayout();
			this.tabBehavior.SuspendLayout();
			this.grpShockwaveBehavior.SuspendLayout();
			this.grpTaskBehavior.SuspendLayout();
			this.tabTiming.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabUpdating.SuspendLayout();
			this.grpCheckForUpdates.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(187, 319);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(268, 319);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabAppearance);
			this.tabControl.Controls.Add(this.tabBehavior);
			this.tabControl.Controls.Add(this.tabTiming);
			this.tabControl.Controls.Add(this.tabUpdating);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(331, 301);
			this.tabControl.TabIndex = 2;
			// 
			// tabAppearance
			// 
			this.tabAppearance.Controls.Add(this.grpTaskAppearance);
			this.tabAppearance.Controls.Add(this.grpBackground);
			this.tabAppearance.Location = new System.Drawing.Point(4, 22);
			this.tabAppearance.Name = "tabAppearance";
			this.tabAppearance.Padding = new System.Windows.Forms.Padding(3);
			this.tabAppearance.Size = new System.Drawing.Size(323, 275);
			this.tabAppearance.TabIndex = 0;
			this.tabAppearance.Text = "Appearance";
			this.tabAppearance.UseVisualStyleBackColor = true;
			// 
			// grpTaskAppearance
			// 
			this.grpTaskAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpTaskAppearance.Controls.Add(this.chkShowMemorySize);
			this.grpTaskAppearance.Location = new System.Drawing.Point(6, 82);
			this.grpTaskAppearance.Name = "grpTaskAppearance";
			this.grpTaskAppearance.Size = new System.Drawing.Size(311, 67);
			this.grpTaskAppearance.TabIndex = 1;
			this.grpTaskAppearance.TabStop = false;
			this.grpTaskAppearance.Text = "Tasks";
			// 
			// chkShowMemorySize
			// 
			this.chkShowMemorySize.AutoSize = true;
			this.chkShowMemorySize.Location = new System.Drawing.Point(9, 19);
			this.chkShowMemorySize.Name = "chkShowMemorySize";
			this.chkShowMemorySize.Size = new System.Drawing.Size(116, 17);
			this.chkShowMemorySize.TabIndex = 0;
			this.chkShowMemorySize.Text = "Show Memory Size";
			this.chkShowMemorySize.UseVisualStyleBackColor = true;
			// 
			// grpBackground
			// 
			this.grpBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpBackground.Controls.Add(this.btnSetColour);
			this.grpBackground.Controls.Add(this.lblSat);
			this.grpBackground.Controls.Add(this.txtSat);
			this.grpBackground.Controls.Add(this.lblHue);
			this.grpBackground.Controls.Add(this.txtHue);
			this.grpBackground.Location = new System.Drawing.Point(6, 6);
			this.grpBackground.Name = "grpBackground";
			this.grpBackground.Size = new System.Drawing.Size(311, 70);
			this.grpBackground.TabIndex = 0;
			this.grpBackground.TabStop = false;
			this.grpBackground.Text = "Background";
			// 
			// lblSat
			// 
			this.lblSat.AutoSize = true;
			this.lblSat.Location = new System.Drawing.Point(76, 22);
			this.lblSat.Name = "lblSat";
			this.lblSat.Size = new System.Drawing.Size(23, 13);
			this.lblSat.TabIndex = 3;
			this.lblSat.Text = "Sat";
			// 
			// txtSat
			// 
			this.txtSat.Location = new System.Drawing.Point(79, 38);
			this.txtSat.MaximumValue = 240;
			this.txtSat.MinimumValue = 0;
			this.txtSat.Name = "txtSat";
			this.txtSat.Size = new System.Drawing.Size(55, 20);
			this.txtSat.TabIndex = 2;
			this.txtSat.Text = "0";
			this.txtSat.Value = 0;
			// 
			// lblHue
			// 
			this.lblHue.AutoSize = true;
			this.lblHue.Location = new System.Drawing.Point(6, 22);
			this.lblHue.Name = "lblHue";
			this.lblHue.Size = new System.Drawing.Size(27, 13);
			this.lblHue.TabIndex = 1;
			this.lblHue.Text = "Hue";
			// 
			// txtHue
			// 
			this.txtHue.Location = new System.Drawing.Point(9, 38);
			this.txtHue.MaximumValue = 240;
			this.txtHue.MinimumValue = 0;
			this.txtHue.Name = "txtHue";
			this.txtHue.Size = new System.Drawing.Size(55, 20);
			this.txtHue.TabIndex = 0;
			this.txtHue.Text = "0";
			this.txtHue.Value = 0;
			// 
			// tabBehavior
			// 
			this.tabBehavior.Controls.Add(this.grpShockwaveBehavior);
			this.tabBehavior.Controls.Add(this.grpTaskBehavior);
			this.tabBehavior.Location = new System.Drawing.Point(4, 22);
			this.tabBehavior.Name = "tabBehavior";
			this.tabBehavior.Size = new System.Drawing.Size(323, 275);
			this.tabBehavior.TabIndex = 3;
			this.tabBehavior.Text = "Behavior";
			this.tabBehavior.UseVisualStyleBackColor = true;
			// 
			// grpShockwaveBehavior
			// 
			this.grpShockwaveBehavior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpShockwaveBehavior.Controls.Add(this.txtPower);
			this.grpShockwaveBehavior.Controls.Add(this.lblPower);
			this.grpShockwaveBehavior.Controls.Add(this.txtRange);
			this.grpShockwaveBehavior.Controls.Add(this.lblRange);
			this.grpShockwaveBehavior.Location = new System.Drawing.Point(3, 149);
			this.grpShockwaveBehavior.Name = "grpShockwaveBehavior";
			this.grpShockwaveBehavior.Size = new System.Drawing.Size(317, 101);
			this.grpShockwaveBehavior.TabIndex = 1;
			this.grpShockwaveBehavior.TabStop = false;
			this.grpShockwaveBehavior.Text = "Shockwave";
			// 
			// txtPower
			// 
			this.txtPower.Integer = false;
			this.txtPower.Location = new System.Drawing.Point(9, 71);
			this.txtPower.MaximumValue = 2147483647;
			this.txtPower.MinimumValue = 0;
			this.txtPower.Name = "txtPower";
			this.txtPower.Size = new System.Drawing.Size(100, 20);
			this.txtPower.TabIndex = 7;
			this.txtPower.Text = "0";
			this.txtPower.Value = 0;
			// 
			// lblPower
			// 
			this.lblPower.AutoSize = true;
			this.lblPower.Location = new System.Drawing.Point(6, 55);
			this.lblPower.Name = "lblPower";
			this.lblPower.Size = new System.Drawing.Size(37, 13);
			this.lblPower.TabIndex = 6;
			this.lblPower.Text = "Power";
			// 
			// txtRange
			// 
			this.txtRange.Integer = false;
			this.txtRange.Location = new System.Drawing.Point(9, 32);
			this.txtRange.MaximumValue = 2147483647;
			this.txtRange.MinimumValue = 0;
			this.txtRange.Name = "txtRange";
			this.txtRange.Size = new System.Drawing.Size(100, 20);
			this.txtRange.TabIndex = 5;
			this.txtRange.Text = "0";
			this.txtRange.Value = 0;
			// 
			// lblRange
			// 
			this.lblRange.AutoSize = true;
			this.lblRange.Location = new System.Drawing.Point(6, 16);
			this.lblRange.Name = "lblRange";
			this.lblRange.Size = new System.Drawing.Size(39, 13);
			this.lblRange.TabIndex = 4;
			this.lblRange.Text = "Range";
			// 
			// grpTaskBehavior
			// 
			this.grpTaskBehavior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpTaskBehavior.Controls.Add(this.txtAngularSpeed);
			this.grpTaskBehavior.Controls.Add(this.lblAngularSpeed);
			this.grpTaskBehavior.Controls.Add(this.txtTopSpeed);
			this.grpTaskBehavior.Controls.Add(this.lblTopSpeed);
			this.grpTaskBehavior.Controls.Add(this.txtDrag);
			this.grpTaskBehavior.Controls.Add(this.lblDrag);
			this.grpTaskBehavior.Controls.Add(this.txtResizeSpeed);
			this.grpTaskBehavior.Controls.Add(this.lblResizeSpeed);
			this.grpTaskBehavior.Controls.Add(this.txtAcceleration);
			this.grpTaskBehavior.Controls.Add(this.lblAcceleration);
			this.grpTaskBehavior.Location = new System.Drawing.Point(3, 3);
			this.grpTaskBehavior.Name = "grpTaskBehavior";
			this.grpTaskBehavior.Size = new System.Drawing.Size(317, 140);
			this.grpTaskBehavior.TabIndex = 0;
			this.grpTaskBehavior.TabStop = false;
			this.grpTaskBehavior.Text = "Tasks";
			// 
			// txtAngularSpeed
			// 
			this.txtAngularSpeed.Integer = false;
			this.txtAngularSpeed.Location = new System.Drawing.Point(9, 110);
			this.txtAngularSpeed.MaximumValue = 2147483647;
			this.txtAngularSpeed.MinimumValue = 0;
			this.txtAngularSpeed.Name = "txtAngularSpeed";
			this.txtAngularSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtAngularSpeed.TabIndex = 9;
			this.txtAngularSpeed.Text = "0";
			this.txtAngularSpeed.Value = 0;
			// 
			// lblAngularSpeed
			// 
			this.lblAngularSpeed.AutoSize = true;
			this.lblAngularSpeed.Location = new System.Drawing.Point(6, 94);
			this.lblAngularSpeed.Name = "lblAngularSpeed";
			this.lblAngularSpeed.Size = new System.Drawing.Size(77, 13);
			this.lblAngularSpeed.TabIndex = 8;
			this.lblAngularSpeed.Text = "Angular Speed";
			// 
			// txtTopSpeed
			// 
			this.txtTopSpeed.Integer = false;
			this.txtTopSpeed.Location = new System.Drawing.Point(143, 71);
			this.txtTopSpeed.MaximumValue = 2147483647;
			this.txtTopSpeed.MinimumValue = 0;
			this.txtTopSpeed.Name = "txtTopSpeed";
			this.txtTopSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtTopSpeed.TabIndex = 7;
			this.txtTopSpeed.Text = "0";
			this.txtTopSpeed.Value = 0;
			// 
			// lblTopSpeed
			// 
			this.lblTopSpeed.AutoSize = true;
			this.lblTopSpeed.Location = new System.Drawing.Point(140, 55);
			this.lblTopSpeed.Name = "lblTopSpeed";
			this.lblTopSpeed.Size = new System.Drawing.Size(60, 13);
			this.lblTopSpeed.TabIndex = 6;
			this.lblTopSpeed.Text = "Top Speed";
			// 
			// txtDrag
			// 
			this.txtDrag.Integer = false;
			this.txtDrag.Location = new System.Drawing.Point(143, 32);
			this.txtDrag.MaximumValue = 2147483647;
			this.txtDrag.MinimumValue = 0;
			this.txtDrag.Name = "txtDrag";
			this.txtDrag.Size = new System.Drawing.Size(100, 20);
			this.txtDrag.TabIndex = 5;
			this.txtDrag.Text = "0";
			this.txtDrag.Value = 0;
			// 
			// lblDrag
			// 
			this.lblDrag.AutoSize = true;
			this.lblDrag.Location = new System.Drawing.Point(140, 16);
			this.lblDrag.Name = "lblDrag";
			this.lblDrag.Size = new System.Drawing.Size(30, 13);
			this.lblDrag.TabIndex = 4;
			this.lblDrag.Text = "Drag";
			// 
			// txtResizeSpeed
			// 
			this.txtResizeSpeed.Integer = false;
			this.txtResizeSpeed.Location = new System.Drawing.Point(9, 71);
			this.txtResizeSpeed.MaximumValue = 2147483647;
			this.txtResizeSpeed.MinimumValue = 0;
			this.txtResizeSpeed.Name = "txtResizeSpeed";
			this.txtResizeSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtResizeSpeed.TabIndex = 3;
			this.txtResizeSpeed.Text = "0";
			this.txtResizeSpeed.Value = 0;
			// 
			// lblResizeSpeed
			// 
			this.lblResizeSpeed.AutoSize = true;
			this.lblResizeSpeed.Location = new System.Drawing.Point(6, 55);
			this.lblResizeSpeed.Name = "lblResizeSpeed";
			this.lblResizeSpeed.Size = new System.Drawing.Size(73, 13);
			this.lblResizeSpeed.TabIndex = 2;
			this.lblResizeSpeed.Text = "Resize Speed";
			// 
			// txtAcceleration
			// 
			this.txtAcceleration.Integer = false;
			this.txtAcceleration.Location = new System.Drawing.Point(9, 32);
			this.txtAcceleration.MaximumValue = 2147483647;
			this.txtAcceleration.MinimumValue = 0;
			this.txtAcceleration.Name = "txtAcceleration";
			this.txtAcceleration.Size = new System.Drawing.Size(100, 20);
			this.txtAcceleration.TabIndex = 1;
			this.txtAcceleration.Text = "0";
			this.txtAcceleration.Value = 0;
			// 
			// lblAcceleration
			// 
			this.lblAcceleration.AutoSize = true;
			this.lblAcceleration.Location = new System.Drawing.Point(6, 16);
			this.lblAcceleration.Name = "lblAcceleration";
			this.lblAcceleration.Size = new System.Drawing.Size(66, 13);
			this.lblAcceleration.TabIndex = 0;
			this.lblAcceleration.Text = "Acceleration";
			// 
			// tabTiming
			// 
			this.tabTiming.Controls.Add(this.groupBox1);
			this.tabTiming.Location = new System.Drawing.Point(4, 22);
			this.tabTiming.Name = "tabTiming";
			this.tabTiming.Padding = new System.Windows.Forms.Padding(3);
			this.tabTiming.Size = new System.Drawing.Size(323, 275);
			this.tabTiming.TabIndex = 1;
			this.tabTiming.Text = "Timing";
			this.tabTiming.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtRefreshSpeed);
			this.groupBox1.Controls.Add(this.lblRefreshSpeed);
			this.groupBox1.Controls.Add(this.txtDrawSpeed);
			this.groupBox1.Controls.Add(this.lblDrawSpeed);
			this.groupBox1.Controls.Add(this.txtUpdateSpeed);
			this.groupBox1.Controls.Add(this.lblUpdateSpeed);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 103);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Update Rates (ms)";
			// 
			// txtRefreshSpeed
			// 
			this.txtRefreshSpeed.Location = new System.Drawing.Point(143, 32);
			this.txtRefreshSpeed.MaximumValue = 2147483647;
			this.txtRefreshSpeed.MinimumValue = 0;
			this.txtRefreshSpeed.Name = "txtRefreshSpeed";
			this.txtRefreshSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtRefreshSpeed.TabIndex = 5;
			this.txtRefreshSpeed.Text = "0";
			this.txtRefreshSpeed.Value = 0;
			// 
			// lblRefreshSpeed
			// 
			this.lblRefreshSpeed.AutoSize = true;
			this.lblRefreshSpeed.Location = new System.Drawing.Point(140, 16);
			this.lblRefreshSpeed.Name = "lblRefreshSpeed";
			this.lblRefreshSpeed.Size = new System.Drawing.Size(78, 13);
			this.lblRefreshSpeed.TabIndex = 4;
			this.lblRefreshSpeed.Text = "Refresh Speed";
			// 
			// txtDrawSpeed
			// 
			this.txtDrawSpeed.Location = new System.Drawing.Point(9, 71);
			this.txtDrawSpeed.MaximumValue = 2147483647;
			this.txtDrawSpeed.MinimumValue = 0;
			this.txtDrawSpeed.Name = "txtDrawSpeed";
			this.txtDrawSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtDrawSpeed.TabIndex = 3;
			this.txtDrawSpeed.Text = "0";
			this.txtDrawSpeed.Value = 0;
			// 
			// lblDrawSpeed
			// 
			this.lblDrawSpeed.AutoSize = true;
			this.lblDrawSpeed.Location = new System.Drawing.Point(6, 55);
			this.lblDrawSpeed.Name = "lblDrawSpeed";
			this.lblDrawSpeed.Size = new System.Drawing.Size(66, 13);
			this.lblDrawSpeed.TabIndex = 2;
			this.lblDrawSpeed.Text = "Draw Speed";
			// 
			// txtUpdateSpeed
			// 
			this.txtUpdateSpeed.Location = new System.Drawing.Point(9, 32);
			this.txtUpdateSpeed.MaximumValue = 2147483647;
			this.txtUpdateSpeed.MinimumValue = 0;
			this.txtUpdateSpeed.Name = "txtUpdateSpeed";
			this.txtUpdateSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtUpdateSpeed.TabIndex = 1;
			this.txtUpdateSpeed.Text = "0";
			this.txtUpdateSpeed.Value = 0;
			// 
			// lblUpdateSpeed
			// 
			this.lblUpdateSpeed.AutoSize = true;
			this.lblUpdateSpeed.Location = new System.Drawing.Point(6, 16);
			this.lblUpdateSpeed.Name = "lblUpdateSpeed";
			this.lblUpdateSpeed.Size = new System.Drawing.Size(76, 13);
			this.lblUpdateSpeed.TabIndex = 0;
			this.lblUpdateSpeed.Text = "Update Speed";
			// 
			// tabUpdating
			// 
			this.tabUpdating.Controls.Add(this.grpCheckForUpdates);
			this.tabUpdating.Location = new System.Drawing.Point(4, 22);
			this.tabUpdating.Name = "tabUpdating";
			this.tabUpdating.Size = new System.Drawing.Size(323, 275);
			this.tabUpdating.TabIndex = 2;
			this.tabUpdating.Text = "Updating";
			this.tabUpdating.UseVisualStyleBackColor = true;
			// 
			// grpCheckForUpdates
			// 
			this.grpCheckForUpdates.Controls.Add(this.chkAutoCheckForUpdates);
			this.grpCheckForUpdates.Location = new System.Drawing.Point(3, 3);
			this.grpCheckForUpdates.Name = "grpCheckForUpdates";
			this.grpCheckForUpdates.Size = new System.Drawing.Size(317, 52);
			this.grpCheckForUpdates.TabIndex = 0;
			this.grpCheckForUpdates.TabStop = false;
			// 
			// chkAutoCheckForUpdates
			// 
			this.chkAutoCheckForUpdates.AutoSize = true;
			this.chkAutoCheckForUpdates.Location = new System.Drawing.Point(6, 19);
			this.chkAutoCheckForUpdates.Name = "chkAutoCheckForUpdates";
			this.chkAutoCheckForUpdates.Size = new System.Drawing.Size(177, 17);
			this.chkAutoCheckForUpdates.TabIndex = 0;
			this.chkAutoCheckForUpdates.Text = "Automatically check for updates";
			this.chkAutoCheckForUpdates.UseVisualStyleBackColor = true;
			// 
			// btnSetColour
			// 
			this.btnSetColour.Location = new System.Drawing.Point(140, 37);
			this.btnSetColour.Name = "btnSetColour";
			this.btnSetColour.Size = new System.Drawing.Size(75, 20);
			this.btnSetColour.TabIndex = 4;
			this.btnSetColour.Text = "Set Colour";
			this.btnSetColour.UseVisualStyleBackColor = true;
			this.btnSetColour.Click += new System.EventHandler(this.btnSetColour_Click);
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(355, 354);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "OptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.tabControl.ResumeLayout(false);
			this.tabAppearance.ResumeLayout(false);
			this.grpTaskAppearance.ResumeLayout(false);
			this.grpTaskAppearance.PerformLayout();
			this.grpBackground.ResumeLayout(false);
			this.grpBackground.PerformLayout();
			this.tabBehavior.ResumeLayout(false);
			this.grpShockwaveBehavior.ResumeLayout(false);
			this.grpShockwaveBehavior.PerformLayout();
			this.grpTaskBehavior.ResumeLayout(false);
			this.grpTaskBehavior.PerformLayout();
			this.tabTiming.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabUpdating.ResumeLayout(false);
			this.grpCheckForUpdates.ResumeLayout(false);
			this.grpCheckForUpdates.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabAppearance;
		private System.Windows.Forms.TabPage tabTiming;
		private System.Windows.Forms.TabPage tabBehavior;
		private System.Windows.Forms.TabPage tabUpdating;
		private System.Windows.Forms.GroupBox grpBackground;
		private NumericTextBox txtHue;
		private System.Windows.Forms.Label lblSat;
		private NumericTextBox txtSat;
		private System.Windows.Forms.Label lblHue;
		private System.Windows.Forms.GroupBox grpTaskAppearance;
		private System.Windows.Forms.CheckBox chkShowMemorySize;
		private System.Windows.Forms.GroupBox grpTaskBehavior;
		private System.Windows.Forms.GroupBox grpShockwaveBehavior;
		private NumericTextBox txtDrag;
		private System.Windows.Forms.Label lblDrag;
		private NumericTextBox txtResizeSpeed;
		private System.Windows.Forms.Label lblResizeSpeed;
		private NumericTextBox txtAcceleration;
		private System.Windows.Forms.Label lblAcceleration;
		private NumericTextBox txtPower;
		private System.Windows.Forms.Label lblPower;
		private NumericTextBox txtRange;
		private System.Windows.Forms.Label lblRange;
		private System.Windows.Forms.GroupBox groupBox1;
		private NumericTextBox txtRefreshSpeed;
		private System.Windows.Forms.Label lblRefreshSpeed;
		private NumericTextBox txtDrawSpeed;
		private System.Windows.Forms.Label lblDrawSpeed;
		private NumericTextBox txtUpdateSpeed;
		private System.Windows.Forms.Label lblUpdateSpeed;
		private System.Windows.Forms.GroupBox grpCheckForUpdates;
		private System.Windows.Forms.CheckBox chkAutoCheckForUpdates;
		private NumericTextBox txtTopSpeed;
		private System.Windows.Forms.Label lblTopSpeed;
		private NumericTextBox txtAngularSpeed;
		private System.Windows.Forms.Label lblAngularSpeed;
		private System.Windows.Forms.Button btnSetColour;
	}
}