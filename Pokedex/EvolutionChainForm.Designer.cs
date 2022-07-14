namespace Pokedex
{
    partial class EvolutionChainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvolutionChainForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EvolutionTreeView = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ImageFrontBox = new System.Windows.Forms.PictureBox();
            this.ImageBackBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrontBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(350, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(405, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 379);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 379);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.EvolutionTreeView);
            this.panel3.Location = new System.Drawing.Point(20, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 314);
            this.panel3.TabIndex = 0;
            // 
            // EvolutionTreeView
            // 
            this.EvolutionTreeView.Location = new System.Drawing.Point(3, 3);
            this.EvolutionTreeView.Name = "EvolutionTreeView";
            this.EvolutionTreeView.Size = new System.Drawing.Size(336, 308);
            this.EvolutionTreeView.TabIndex = 0;
            this.EvolutionTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EvolutionTreeView_AfterSelect);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.ImageFrontBox);
            this.panel4.Controls.Add(this.ImageBackBox);
            this.panel4.Location = new System.Drawing.Point(20, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 159);
            this.panel4.TabIndex = 1;
            // 
            // ImageFrontBox
            // 
            this.ImageFrontBox.BackColor = System.Drawing.Color.White;
            this.ImageFrontBox.Location = new System.Drawing.Point(172, 3);
            this.ImageFrontBox.Name = "ImageFrontBox";
            this.ImageFrontBox.Size = new System.Drawing.Size(167, 153);
            this.ImageFrontBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageFrontBox.TabIndex = 1;
            this.ImageFrontBox.TabStop = false;
            // 
            // ImageBackBox
            // 
            this.ImageBackBox.BackColor = System.Drawing.Color.White;
            this.ImageBackBox.Location = new System.Drawing.Point(3, 3);
            this.ImageBackBox.Name = "ImageBackBox";
            this.ImageBackBox.Size = new System.Drawing.Size(167, 153);
            this.ImageBackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageBackBox.TabIndex = 0;
            this.ImageBackBox.TabStop = false;
            // 
            // EvolutionChainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EvolutionChainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvolutionChainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrontBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private TreeView EvolutionTreeView;
        private Panel panel4;
        private PictureBox ImageFrontBox;
        private PictureBox ImageBackBox;
    }
}