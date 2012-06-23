using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using srtProcessor;

namespace SrtCombiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstSrtButton_Click(object sender, EventArgs e)
        {
            if (firstSrtOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                firstSrtTextBox.Text = firstSrtOpenFileDialog.FileName;
                ValidateInputFields();
            }
        }

        private void secondSrtButton_Click(object sender, EventArgs e)
        {
            if (secondSrtOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                secondSrtTextBox.Text = secondSrtOpenFileDialog.FileName;
                ValidateInputFields();
            }
        }

        private void videoFileButton_Click(object sender, EventArgs e)
        {
            if (firstVideoFileOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                videoFileTextBox.Text = firstVideoFileOpenFileDialog.FileName;
                ValidateInputFields();
            }
        }

        private void ValidateInputFields()
        {
            if (   !string.IsNullOrEmpty(firstSrtTextBox.Text)
                && !string.IsNullOrEmpty(secondSrtTextBox.Text)
                && !string.IsNullOrEmpty(videoFileTextBox.Text))
            {
                generateButton.Enabled = true;
            }
            else
            {
                generateButton.Enabled = false;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (saveCombinedSrtDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                Video v = Video.FromFile(videoFileTextBox.Text);

                ISubtitleCollection firstSrtFile = SubtitleCollectionFactory.LoadSrtFile(firstSrtTextBox.Text);
                ISubtitleCollection secondSrtFile = SubtitleCollectionFactory.LoadSrtFile(secondSrtTextBox.Text);

                firstSrtFile.AppendCollection(secondSrtFile,Convert.ToInt64(Math.Truncate(v.Duration*1000)));
                firstSrtFile.Save(saveCombinedSrtDialog.FileName);

            }
        }


    }
}