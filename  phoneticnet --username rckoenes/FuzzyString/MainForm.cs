/*
 * Fuzzy String
 * Copyright (c) 2006, Triple Software
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, are 
 * permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice, this list 
 *   of conditions and the following disclaimer.
 * 
 * - Redistributions in binary form must reproduce the above copyright notice, this list
 *   of conditions and the following disclaimer in the documentation and/or other materials 
 *   provided with the distribution.
 * 
 * - Neither the name of the Triple Software nor the names of its contributors may be used to 
 *   endorse or promote products derived from this software without specific prior written 
 *   permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS &AS IS& AND ANY EXPRESS 
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY 
 * AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
 * IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT 
 * OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using TripleSoftware.Phonetic;
using TripleSoftware.StringCompare;

namespace FuzzyString
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
        private IPhonetic phonetic;
        private IStringCompare stringCompare;

        private AboutForm aboutForm;

		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
        private void Phonetic_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (phoneticComboBox.SelectedIndex)
            {
                case 0:
                    phonetic = new Soundex();
                    inputTextBox_TextChanged(sender, e);
                    break;
                case 1:
                    phonetic = new DaitchMokotoff();
                    inputTextBox_TextChanged(sender, e);
                    break;                  
                case 2:
                    phonetic = new Metaphone();
                    inputTextBox_TextChanged(sender, e);
                    break;
                case 3:
                    phonetic = new DoubleMetaphone();
                    inputTextBox_TextChanged(sender, e);
                    break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if(phonetic != null && inputTextBox.Text.Length >= 1) {
               phonetic.GenerateKey(inputTextBox.Text);
               primaryTextBox.Text = phonetic.PrimaryKey;
               alternateTextBox.Text = phonetic.AlternateKey;
        	}
        }

        private void fuzzyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fuzzyComboBox.SelectedIndex)
            {
                case 0:
                    stringCompare = new Levenshtein();
                    Compare_TextChanged(sender, e);
                    break;
                case 1:
                    stringCompare = new DamerauLevenshtein();
                    Compare_TextChanged(sender, e);
                    break;
            }

        }

        private void Compare_TextChanged(object sender, EventArgs e)
        {
            if (originaleTextBox.Text.Length > 1 && compareTextBox.Text.Length > 1 && stringCompare != null)
                responseTextBox.Text = Convert.ToString(stringCompare.Compare(originaleTextBox.Text, compareTextBox.Text));

        }
       
        /// <summary>
        /// Cleanup the closing of the about dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisposeAbout(object sender, System.EventArgs e)
        {
            aboutForm = null;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new AboutForm();
                aboutForm.Disposed += new EventHandler(this.DisposeAbout);
                aboutForm.Show();
            }
            else
            {
                aboutForm.BringToFront();
            }
        }
		
        private void button1_Click(object sender,EventArgs e)
        {
            soundexLabel.Text = Measure( new Soundex()).ToString() ;
            dmLabel.Text = Measure(new DaitchMokotoff()).ToString();
            metaphoneLabel.Text = Measure(new Metaphone()).ToString();
            dmetaphoneLabel.Text = Measure(new DoubleMetaphone()).ToString();
        }

        private void closeButton_Click_1(object sender,EventArgs e)
        {
            this.Close();
        }

        private long Measure(IPhonetic phontic)
        {
            TextReader reader = new StringReader(wordListTextBox.Text);
            long begin,end;
            string word = "";

            begin = System.DateTime.Now.Ticks;
            while((word = reader.ReadLine()) != null) {
                phontic.GenerateKey(word);
            }
            end = System.DateTime.Now.Ticks;
            return (end - begin);
        }
	}
}
;
