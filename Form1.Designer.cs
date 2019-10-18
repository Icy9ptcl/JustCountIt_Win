namespace JustCountIt {
	partial class MainForm {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && ( components != null )) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.MainTLP = new System.Windows.Forms.TableLayoutPanel();
			this.CountLabel = new System.Windows.Forms.Label();
			this.ButtonsTLP = new System.Windows.Forms.TableLayoutPanel();
			this.Destroyer = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Inc10Btn = new System.Windows.Forms.Button();
			this.Inc1Btn = new System.Windows.Forms.Button();
			this.Dec1Btn = new System.Windows.Forms.Button();
			this.Dec10Btn = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.DestroyTimer = new System.Windows.Forms.Timer(this.components);
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.NameText = new System.Windows.Forms.TextBox();
			this.BringFrontCB = new System.Windows.Forms.CheckBox();
			this.MainTLP.SuspendLayout();
			this.ButtonsTLP.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTLP
			// 
			this.MainTLP.ColumnCount = 1;
			this.MainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTLP.Controls.Add(this.ButtonsTLP, 0, 2);
			this.MainTLP.Controls.Add(this.CountLabel, 0, 1);
			this.MainTLP.Controls.Add(this.panel1, 0, 0);
			this.MainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTLP.Location = new System.Drawing.Point(0, 0);
			this.MainTLP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MainTLP.Name = "MainTLP";
			this.MainTLP.RowCount = 3;
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.MainTLP.Size = new System.Drawing.Size(404, 311);
			this.MainTLP.TabIndex = 0;
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CountLabel.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CountLabel.Location = new System.Drawing.Point(5, 64);
			this.CountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(394, 119);
			this.CountLabel.TabIndex = 1;
			this.CountLabel.Text = "0";
			this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonsTLP
			// 
			this.ButtonsTLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonsTLP.ColumnCount = 3;
			this.ButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.ButtonsTLP.Controls.Add(this.Destroyer, 2, 0);
			this.ButtonsTLP.Controls.Add(this.flowLayoutPanel2, 0, 0);
			this.ButtonsTLP.Controls.Add(this.flowLayoutPanel3, 1, 0);
			this.ButtonsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonsTLP.Location = new System.Drawing.Point(5, 189);
			this.ButtonsTLP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.ButtonsTLP.Name = "ButtonsTLP";
			this.ButtonsTLP.RowCount = 1;
			this.ButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ButtonsTLP.Size = new System.Drawing.Size(394, 116);
			this.ButtonsTLP.TabIndex = 1;
			// 
			// Destroyer
			// 
			this.Destroyer.AutoSize = true;
			this.Destroyer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Destroyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
			this.Destroyer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Destroyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Destroyer.ForeColor = System.Drawing.Color.White;
			this.Destroyer.Location = new System.Drawing.Point(279, 6);
			this.Destroyer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Destroyer.Name = "Destroyer";
			this.Destroyer.Size = new System.Drawing.Size(110, 104);
			this.Destroyer.TabIndex = 5;
			this.Destroyer.Text = "リセット";
			this.Destroyer.UseVisualStyleBackColor = false;
			this.Destroyer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Destroyer_MouseDown);
			this.Destroyer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Destroyer_MouseUp);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.HeaderPanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(404, 64);
			this.panel1.TabIndex = 3;
			// 
			// Inc10Btn
			// 
			this.Inc10Btn.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.Inc10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inc10Btn.Location = new System.Drawing.Point(5, 64);
			this.Inc10Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Inc10Btn.Name = "Inc10Btn";
			this.Inc10Btn.Size = new System.Drawing.Size(125, 46);
			this.Inc10Btn.TabIndex = 3;
			this.Inc10Btn.Text = "+10";
			this.Inc10Btn.UseVisualStyleBackColor = false;
			this.Inc10Btn.Click += new System.EventHandler(this.Inc10Btn_Click);
			// 
			// Inc1Btn
			// 
			this.Inc1Btn.AutoSize = true;
			this.Inc1Btn.BackColor = System.Drawing.Color.YellowGreen;
			this.Inc1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Inc1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.Inc1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inc1Btn.Location = new System.Drawing.Point(5, 6);
			this.Inc1Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Inc1Btn.Name = "Inc1Btn";
			this.Inc1Btn.Size = new System.Drawing.Size(125, 46);
			this.Inc1Btn.TabIndex = 1;
			this.Inc1Btn.Text = "+1";
			this.Inc1Btn.UseVisualStyleBackColor = false;
			this.Inc1Btn.Click += new System.EventHandler(this.Inc1Btn_Click);
			// 
			// Dec1Btn
			// 
			this.Dec1Btn.BackColor = System.Drawing.Color.LightBlue;
			this.Dec1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.Dec1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Dec1Btn.Location = new System.Drawing.Point(5, 6);
			this.Dec1Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Dec1Btn.Name = "Dec1Btn";
			this.Dec1Btn.Size = new System.Drawing.Size(125, 46);
			this.Dec1Btn.TabIndex = 2;
			this.Dec1Btn.Text = "-1";
			this.Dec1Btn.UseVisualStyleBackColor = false;
			this.Dec1Btn.Click += new System.EventHandler(this.Dec1Btn_Click);
			// 
			// Dec10Btn
			// 
			this.Dec10Btn.BackColor = System.Drawing.Color.CadetBlue;
			this.Dec10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Dec10Btn.Location = new System.Drawing.Point(5, 64);
			this.Dec10Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Dec10Btn.Name = "Dec10Btn";
			this.Dec10Btn.Size = new System.Drawing.Size(125, 46);
			this.Dec10Btn.TabIndex = 4;
			this.Dec10Btn.Text = "-10";
			this.Dec10Btn.UseVisualStyleBackColor = false;
			this.Dec10Btn.Click += new System.EventHandler(this.Dec10Btn_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.Dec1Btn);
			this.flowLayoutPanel2.Controls.Add(this.Dec10Btn);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(135, 116);
			this.flowLayoutPanel2.TabIndex = 5;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.Controls.Add(this.Inc1Btn);
			this.flowLayoutPanel3.Controls.Add(this.Inc10Btn);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(138, 0);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(135, 116);
			this.flowLayoutPanel3.TabIndex = 4;
			// 
			// DestroyTimer
			// 
			this.DestroyTimer.Interval = 1000;
			this.DestroyTimer.Tick += new System.EventHandler(this.DestroyTimer_Tick);
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HeaderPanel.Controls.Add(this.BringFrontCB);
			this.HeaderPanel.Controls.Add(this.NameText);
			this.HeaderPanel.Location = new System.Drawing.Point(21, 12);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(364, 42);
			this.HeaderPanel.TabIndex = 0;
			// 
			// NameText
			// 
			this.NameText.Location = new System.Drawing.Point(5, 5);
			this.NameText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(271, 31);
			this.NameText.TabIndex = 1;
			this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BringFrontCB
			// 
			this.BringFrontCB.AutoSize = true;
			this.BringFrontCB.Location = new System.Drawing.Point(284, 8);
			this.BringFrontCB.Name = "BringFrontCB";
			this.BringFrontCB.Size = new System.Drawing.Size(77, 28);
			this.BringFrontCB.TabIndex = 2;
			this.BringFrontCB.Text = "最前面";
			this.BringFrontCB.UseVisualStyleBackColor = true;
			this.BringFrontCB.CheckedChanged += new System.EventHandler(this.BringFrontCB_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 311);
			this.Controls.Add(this.MainTLP);
			this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "MainForm";
			this.Text = "Just Count it";
			this.MainTLP.ResumeLayout(false);
			this.MainTLP.PerformLayout();
			this.ButtonsTLP.ResumeLayout(false);
			this.ButtonsTLP.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainTLP;
		private System.Windows.Forms.TableLayoutPanel ButtonsTLP;
		private System.Windows.Forms.Button Destroyer;
		private System.Windows.Forms.Label CountLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button Dec1Btn;
		private System.Windows.Forms.Button Dec10Btn;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button Inc1Btn;
		private System.Windows.Forms.Button Inc10Btn;
		private System.Windows.Forms.Timer DestroyTimer;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.CheckBox BringFrontCB;
		private System.Windows.Forms.TextBox NameText;
	}
}

