﻿using System;
using System.Drawing;
using System.Windows.Forms;


// Why there's no counter app!?!?
// That's why I made this. quality? nevermind.
namespace JustCountIt {
	public partial class MainForm : Form {

		//Counter value but call CountUpdate() or else nothing will change in GUI
		int Count = 0;

		// When this is true and when the destroyerTimer ticks, the counter value set to 0
		bool IsDestroyerOn = false;

		public MainForm() {
			InitializeComponent();
		}

		private void CountUpdate() {
			CountLabel.Text = Count.ToString();
		}

		private void CountUpdate(int ChangeAmount) {
			Count += ChangeAmount;
			CountLabel.Text = Count.ToString();
			CountLabel.AccessibleDescription = "値は " + Count.ToString() + "です";
		}

		private void Inc1Btn_Click(object sender, EventArgs e) {
			CountUpdate(1);
		}

		private void Inc10Btn_Click(object sender, EventArgs e) {
			CountUpdate(10);
		}

		private void Dec1Btn_Click(object sender, EventArgs e) {
			CountUpdate(-1);
		}

		private void Dec10Btn_Click(object sender, EventArgs e) {
			CountUpdate(-10);
		}

		private void Destroyer_MouseDown(object sender, MouseEventArgs e) {
			// start destroyer timer
			IsDestroyerOn = true;
			CountLabel.BackColor = Color.FromArgb(255, 200, 200);
			Destroyer.Text = "長押し";
			DestroyTimer.Start();
		}

		private void Destroyer_MouseUp(object sender, MouseEventArgs e) {
			// stop destroyer timer
			CountLabel.BackColor = SystemColors.Control;
			Destroyer.Text = "リセット";
			IsDestroyerOn = false;
			DestroyTimer.Stop();
		}

		//Boom!
		private void DestroyTimer_Tick(object sender, EventArgs e) {
			if (IsDestroyerOn == true) {
				// Reset the counter
				CountLabel.BackColor = SystemColors.Control;
				Destroyer.Text = "リセット";
				CountUpdate(-Count);
				DestroyTimer.Stop();
			}
		}

		// 地味に必要かもしれない。最前面描画
		 private void BringFrontCB_CheckedChanged(object sender, EventArgs e) {
			this.TopMost = BringFrontCB.Checked;
		 }

		private void NameText_TextChanged(object sender, EventArgs e) {
			if (NameText.Text != "") {
				this.Text = NameText.Text + " - Just Count It";
			} else {
				this.Text = "Just Count It";
			}
		}
	}
}
