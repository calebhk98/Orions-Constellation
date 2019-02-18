using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Author: Caleb Kirschbaum
Date: 2/12/19
Project: Orion Constellation
Goal: Allow you to toggle the names on the stars for the Orion Constellation. 
	 
*/

namespace OrionConstellation {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void closeBtn_Click( object sender, EventArgs e ) {
			this.Close();//This closes the form
		}

		private void showBtn_Click( object sender, EventArgs e ) {
			bool show = true;//This is to allow copy paste
			betelgeuseLabel.Visible = show;
			alnilamLabel.Visible = show;
			alnitakLabel.Visible = show;
			meissaLabel.Visible = show;
			mintakaLabel.Visible = show;
			rigelLabel.Visible = show;
			saiphLabel.Visible = show;
		}

		private void hideBtn_Click( object sender, EventArgs e ) {
			bool show = false;//This is to allow copy paste
			betelgeuseLabel.Visible = show;
			alnilamLabel.Visible = show;
			alnitakLabel.Visible = show;
			meissaLabel.Visible = show;
			mintakaLabel.Visible = show;
			rigelLabel.Visible = show;
			saiphLabel.Visible = show;
		}

		private void toggleBtn_Click( object sender, EventArgs e ) {
			bool show = !betelgeuseLabel.Visible;
			//This allows me to toggle all of them based on whether it is already visible or not
			betelgeuseLabel.Visible = show;
			alnilamLabel.Visible = show;
			alnitakLabel.Visible = show;
			meissaLabel.Visible = show;
			mintakaLabel.Visible = show;
			rigelLabel.Visible = show;
			saiphLabel.Visible = show;
		}
	}
}
