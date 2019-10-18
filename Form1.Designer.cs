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
			this.header = new System.Windows.Forms.Panel();
			this.Inc10Btn = new System.Windows.Forms.Button();
			this.Inc1Btn = new System.Windows.Forms.Button();
			this.Dec1Btn = new System.Windows.Forms.Button();
			this.Dec10Btn = new System.Windows.Forms.Button();
			this.DecFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.IncFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.DestroyTimer = new System.Windows.Forms.Timer(this.components);
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.NameText = new System.Windows.Forms.TextBox();
			this.BringFrontCB = new System.Windows.Forms.CheckBox();
			this.MainTLP.SuspendLayout();
			this.ButtonsTLP.SuspendLayout();
			this.header.SuspendLayout();
			this.DecFLP.SuspendLayout();
			this.IncFLP.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTLP
			// 
			this.MainTLP.ColumnCount = 1;
			this.MainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTLP.Controls.Add(this.ButtonsTLP, 0, 2);
			this.MainTLP.Controls.Add(this.CountLabel, 0, 1);
			this.MainTLP.Controls.Add(this.header, 0, 0);
			this.MainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTLP.Location = new System.Drawing.Point(0, 0);
			this.MainTLP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MainTLP.Name = "MainTLP";
			this.MainTLP.RowCount = 3;
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.MainTLP.Size = new System.Drawing.Size(434, 411);
			this.MainTLP.TabIndex = 0;
			// 
			// CountLabel
			// 
			this.CountLabel.AccessibleDescription = "カウンターの値は 0 です";
			this.CountLabel.AccessibleName = "値";
			this.CountLabel.AutoSize = true;
			this.CountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CountLabel.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CountLabel.Location = new System.Drawing.Point(5, 64);
			this.CountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(424, 219);
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
			this.ButtonsTLP.Controls.Add(this.DecFLP, 0, 0);
			this.ButtonsTLP.Controls.Add(this.IncFLP, 1, 0);
			this.ButtonsTLP.Controls.Add(this.Destroyer, 2, 0);
			this.ButtonsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonsTLP.Location = new System.Drawing.Point(5, 289);
			this.ButtonsTLP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.ButtonsTLP.Name = "ButtonsTLP";
			this.ButtonsTLP.RowCount = 1;
			this.ButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ButtonsTLP.Size = new System.Drawing.Size(424, 116);
			this.ButtonsTLP.TabIndex = 0;
			// 
			// Destroyer
			// 
			this.Destroyer.AccessibleDescription = "カウンターの値をリセットします";
			this.Destroyer.AccessibleName = "リセット";
			this.Destroyer.AutoSize = true;
			this.Destroyer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Destroyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
			this.Destroyer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Destroyer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Destroyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Destroyer.ForeColor = System.Drawing.Color.White;
			this.Destroyer.Location = new System.Drawing.Point(309, 6);
			this.Destroyer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Destroyer.Name = "Destroyer";
			this.Destroyer.Size = new System.Drawing.Size(110, 104);
			this.Destroyer.TabIndex = 2;
			this.Destroyer.Text = "リセット";
			this.Destroyer.UseVisualStyleBackColor = false;
			this.Destroyer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Destroyer_MouseDown);
			this.Destroyer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Destroyer_MouseUp);
			// 
			// header
			// 
			this.header.Controls.Add(this.HeaderPanel);
			this.header.Dock = System.Windows.Forms.DockStyle.Fill;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Margin = new System.Windows.Forms.Padding(0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(434, 64);
			this.header.TabIndex = 2;
			// 
			// Inc10Btn
			// 
			this.Inc10Btn.AccessibleDescription = "カウンターの値を 10 増やします";
			this.Inc10Btn.AccessibleName = "+10";
			this.Inc10Btn.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.Inc10Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Inc10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inc10Btn.Location = new System.Drawing.Point(5, 64);
			this.Inc10Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Inc10Btn.Name = "Inc10Btn";
			this.Inc10Btn.Size = new System.Drawing.Size(125, 46);
			this.Inc10Btn.TabIndex = 1;
			this.Inc10Btn.Text = "+10";
			this.Inc10Btn.UseVisualStyleBackColor = false;
			this.Inc10Btn.Click += new System.EventHandler(this.Inc10Btn_Click);
			// 
			// Inc1Btn
			// 
			this.Inc1Btn.AccessibleDescription = "カウンターの値を 1 増やします";
			this.Inc1Btn.AccessibleName = "+1";
			this.Inc1Btn.AutoSize = true;
			this.Inc1Btn.BackColor = System.Drawing.Color.YellowGreen;
			this.Inc1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Inc1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.Inc1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inc1Btn.Location = new System.Drawing.Point(5, 6);
			this.Inc1Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Inc1Btn.Name = "Inc1Btn";
			this.Inc1Btn.Size = new System.Drawing.Size(125, 46);
			this.Inc1Btn.TabIndex = 0;
			this.Inc1Btn.Text = "+1";
			this.Inc1Btn.UseVisualStyleBackColor = false;
			this.Inc1Btn.Click += new System.EventHandler(this.Inc1Btn_Click);
			// 
			// Dec1Btn
			// 
			this.Dec1Btn.AccessibleDescription = "カウンターの値を 1 減らします";
			this.Dec1Btn.AccessibleName = "-1";
			this.Dec1Btn.BackColor = System.Drawing.Color.LightBlue;
			this.Dec1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Dec1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.Dec1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Dec1Btn.Location = new System.Drawing.Point(5, 6);
			this.Dec1Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Dec1Btn.Name = "Dec1Btn";
			this.Dec1Btn.Size = new System.Drawing.Size(125, 46);
			this.Dec1Btn.TabIndex = 0;
			this.Dec1Btn.Text = "-1";
			this.Dec1Btn.UseVisualStyleBackColor = false;
			this.Dec1Btn.Click += new System.EventHandler(this.Dec1Btn_Click);
			// 
			// Dec10Btn
			// 
			this.Dec10Btn.AccessibleDescription = "カウンターの値を 10 減らします";
			this.Dec10Btn.AccessibleName = "-10";
			this.Dec10Btn.BackColor = System.Drawing.Color.CadetBlue;
			this.Dec10Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Dec10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Dec10Btn.Location = new System.Drawing.Point(5, 64);
			this.Dec10Btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Dec10Btn.Name = "Dec10Btn";
			this.Dec10Btn.Size = new System.Drawing.Size(125, 46);
			this.Dec10Btn.TabIndex = 1;
			this.Dec10Btn.Text = "-10";
			this.Dec10Btn.UseVisualStyleBackColor = false;
			this.Dec10Btn.Click += new System.EventHandler(this.Dec10Btn_Click);
			// 
			// DecFLP
			// 
			this.DecFLP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DecFLP.AutoSize = true;
			this.DecFLP.Controls.Add(this.Dec1Btn);
			this.DecFLP.Controls.Add(this.Dec10Btn);
			this.DecFLP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.DecFLP.Location = new System.Drawing.Point(8, 0);
			this.DecFLP.Margin = new System.Windows.Forms.Padding(0);
			this.DecFLP.Name = "DecFLP";
			this.DecFLP.Size = new System.Drawing.Size(135, 116);
			this.DecFLP.TabIndex = 1;
			// 
			// IncFLP
			// 
			this.IncFLP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.IncFLP.AutoSize = true;
			this.IncFLP.Controls.Add(this.Inc1Btn);
			this.IncFLP.Controls.Add(this.Inc10Btn);
			this.IncFLP.Location = new System.Drawing.Point(160, 0);
			this.IncFLP.Margin = new System.Windows.Forms.Padding(0);
			this.IncFLP.Name = "IncFLP";
			this.IncFLP.Size = new System.Drawing.Size(135, 116);
			this.IncFLP.TabIndex = 0;
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
			this.HeaderPanel.Location = new System.Drawing.Point(36, 12);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(364, 42);
			this.HeaderPanel.TabIndex = 0;
			// 
			// NameText
			// 
			this.NameText.AccessibleDescription = "カウンターに付ける名前です";
			this.NameText.AccessibleName = "名前";
			this.NameText.Location = new System.Drawing.Point(5, 5);
			this.NameText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(271, 31);
			this.NameText.TabIndex = 0;
			this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
			// 
			// BringFrontCB
			// 
			this.BringFrontCB.AccessibleDescription = "このウィンドウを最前面に表示します";
			this.BringFrontCB.AccessibleName = "最前面に表示";
			this.BringFrontCB.AutoSize = true;
			this.BringFrontCB.Location = new System.Drawing.Point(284, 8);
			this.BringFrontCB.Name = "BringFrontCB";
			this.BringFrontCB.Size = new System.Drawing.Size(77, 28);
			this.BringFrontCB.TabIndex = 1;
			this.BringFrontCB.Text = "最前面";
			this.BringFrontCB.UseVisualStyleBackColor = true;
			this.BringFrontCB.CheckedChanged += new System.EventHandler(this.BringFrontCB_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 411);
			this.Controls.Add(this.MainTLP);
			this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "MainForm";
			this.Text = "Just Count it";
			this.MainTLP.ResumeLayout(false);
			this.MainTLP.PerformLayout();
			this.ButtonsTLP.ResumeLayout(false);
			this.ButtonsTLP.PerformLayout();
			this.header.ResumeLayout(false);
			this.DecFLP.ResumeLayout(false);
			this.IncFLP.ResumeLayout(false);
			this.IncFLP.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainTLP;
		private System.Windows.Forms.TableLayoutPanel ButtonsTLP;
		private System.Windows.Forms.Button Destroyer;
		private System.Windows.Forms.Label CountLabel;
		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.FlowLayoutPanel DecFLP;
		private System.Windows.Forms.Button Dec1Btn;
		private System.Windows.Forms.Button Dec10Btn;
		private System.Windows.Forms.FlowLayoutPanel IncFLP;
		private System.Windows.Forms.Button Inc1Btn;
		private System.Windows.Forms.Button Inc10Btn;
		private System.Windows.Forms.Timer DestroyTimer;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.CheckBox BringFrontCB;
		private System.Windows.Forms.TextBox NameText;
	}
}

