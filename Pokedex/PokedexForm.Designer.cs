namespace Pokedex
{
    partial class PokedexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokedexForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EvolutionsButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BaseExperienceInfoLabel = new System.Windows.Forms.Label();
            this.BaseExperienceLabel = new System.Windows.Forms.Label();
            this.WeightInfoLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightInfoLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.TypeInfoLabel = new System.Windows.Forms.Label();
            this.NumberInfoLabel = new System.Windows.Forms.Label();
            this.NameInfoLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImageFrontBox = new System.Windows.Forms.PictureBox();
            this.ImageBackBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AbilitiesListView = new System.Windows.Forms.ListView();
            this.AbilityHeader = new System.Windows.Forms.ColumnHeader();
            this.HiddenHeader = new System.Windows.Forms.ColumnHeader();
            this.StatsListView = new System.Windows.Forms.ListView();
            this.StatNameHeader = new System.Windows.Forms.ColumnHeader();
            this.StatBaseHeader = new System.Windows.Forms.ColumnHeader();
            this.StatEffortHeader = new System.Windows.Forms.ColumnHeader();
            this.MovementsListView = new System.Windows.Forms.ListView();
            this.MoveHeader = new System.Windows.Forms.ColumnHeader();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.MovementsLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrontBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.EvolutionsButton);
            this.panel1.Controls.Add(this.ProgressBar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 379);
            this.panel1.TabIndex = 1;
            // 
            // EvolutionsButton
            // 
            this.EvolutionsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EvolutionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EvolutionsButton.FlatAppearance.BorderSize = 2;
            this.EvolutionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvolutionsButton.Location = new System.Drawing.Point(287, 196);
            this.EvolutionsButton.Name = "EvolutionsButton";
            this.EvolutionsButton.Size = new System.Drawing.Size(75, 23);
            this.EvolutionsButton.TabIndex = 5;
            this.EvolutionsButton.UseVisualStyleBackColor = false;
            this.EvolutionsButton.Click += new System.EventHandler(this.EvolutionsButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(20, 353);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(312, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.BaseExperienceInfoLabel);
            this.panel4.Controls.Add(this.BaseExperienceLabel);
            this.panel4.Controls.Add(this.WeightInfoLabel);
            this.panel4.Controls.Add(this.WeightLabel);
            this.panel4.Controls.Add(this.HeightInfoLabel);
            this.panel4.Controls.Add(this.HeightLabel);
            this.panel4.Controls.Add(this.TypeInfoLabel);
            this.panel4.Controls.Add(this.NumberInfoLabel);
            this.panel4.Controls.Add(this.NameInfoLabel);
            this.panel4.Controls.Add(this.TypeLabel);
            this.panel4.Controls.Add(this.NumberLabel);
            this.panel4.Controls.Add(this.NameLabel);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(20, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 120);
            this.panel4.TabIndex = 3;
            // 
            // BaseExperienceInfoLabel
            // 
            this.BaseExperienceInfoLabel.BackColor = System.Drawing.Color.White;
            this.BaseExperienceInfoLabel.Font = new System.Drawing.Font("Arial Terminal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseExperienceInfoLabel.Location = new System.Drawing.Point(162, 92);
            this.BaseExperienceInfoLabel.Name = "BaseExperienceInfoLabel";
            this.BaseExperienceInfoLabel.Size = new System.Drawing.Size(156, 17);
            this.BaseExperienceInfoLabel.TabIndex = 12;
            // 
            // BaseExperienceLabel
            // 
            this.BaseExperienceLabel.AutoSize = true;
            this.BaseExperienceLabel.BackColor = System.Drawing.Color.White;
            this.BaseExperienceLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseExperienceLabel.Location = new System.Drawing.Point(19, 92);
            this.BaseExperienceLabel.Name = "BaseExperienceLabel";
            this.BaseExperienceLabel.Size = new System.Drawing.Size(137, 17);
            this.BaseExperienceLabel.TabIndex = 11;
            this.BaseExperienceLabel.Text = "Base Experience:";
            // 
            // WeightInfoLabel
            // 
            this.WeightInfoLabel.BackColor = System.Drawing.Color.White;
            this.WeightInfoLabel.Font = new System.Drawing.Font("Arial Terminal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightInfoLabel.Location = new System.Drawing.Point(162, 76);
            this.WeightInfoLabel.Name = "WeightInfoLabel";
            this.WeightInfoLabel.Size = new System.Drawing.Size(156, 17);
            this.WeightInfoLabel.TabIndex = 10;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.White;
            this.WeightLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightLabel.Location = new System.Drawing.Point(19, 76);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(63, 17);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "Weight:";
            // 
            // HeightInfoLabel
            // 
            this.HeightInfoLabel.BackColor = System.Drawing.Color.White;
            this.HeightInfoLabel.Font = new System.Drawing.Font("Arial Terminal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightInfoLabel.Location = new System.Drawing.Point(162, 58);
            this.HeightInfoLabel.Name = "HeightInfoLabel";
            this.HeightInfoLabel.Size = new System.Drawing.Size(156, 17);
            this.HeightInfoLabel.TabIndex = 8;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.White;
            this.HeightLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightLabel.Location = new System.Drawing.Point(19, 58);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(60, 17);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Height:";
            // 
            // TypeInfoLabel
            // 
            this.TypeInfoLabel.BackColor = System.Drawing.Color.White;
            this.TypeInfoLabel.Font = new System.Drawing.Font("Arial Terminal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeInfoLabel.Location = new System.Drawing.Point(162, 41);
            this.TypeInfoLabel.Name = "TypeInfoLabel";
            this.TypeInfoLabel.Size = new System.Drawing.Size(156, 17);
            this.TypeInfoLabel.TabIndex = 6;
            // 
            // NumberInfoLabel
            // 
            this.NumberInfoLabel.BackColor = System.Drawing.Color.White;
            this.NumberInfoLabel.Font = new System.Drawing.Font("Arial Terminal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberInfoLabel.Location = new System.Drawing.Point(162, 24);
            this.NumberInfoLabel.Name = "NumberInfoLabel";
            this.NumberInfoLabel.Size = new System.Drawing.Size(156, 17);
            this.NumberInfoLabel.TabIndex = 5;
            // 
            // NameInfoLabel
            // 
            this.NameInfoLabel.BackColor = System.Drawing.Color.White;
            this.NameInfoLabel.Font = new System.Drawing.Font("Arial Terminal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInfoLabel.Location = new System.Drawing.Point(162, 7);
            this.NameInfoLabel.Name = "NameInfoLabel";
            this.NameInfoLabel.Size = new System.Drawing.Size(156, 17);
            this.NameInfoLabel.TabIndex = 4;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.White;
            this.TypeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.Location = new System.Drawing.Point(19, 41);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(48, 17);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.White;
            this.NumberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberLabel.Location = new System.Drawing.Point(19, 24);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(71, 17);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.White;
            this.NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(19, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(336, 114);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(20, 197);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(101, 197);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Name or ID";
            this.SearchBox.Size = new System.Drawing.Size(180, 23);
            this.SearchBox.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.ImageFrontBox);
            this.panel3.Controls.Add(this.ImageBackBox);
            this.panel3.Location = new System.Drawing.Point(20, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 159);
            this.panel3.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(405, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 379);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.AbilitiesListView);
            this.panel5.Controls.Add(this.StatsListView);
            this.panel5.Controls.Add(this.MovementsListView);
            this.panel5.Controls.Add(this.StatsLabel);
            this.panel5.Controls.Add(this.MovementsLabel);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(20, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 314);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Abilities";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbilitiesListView
            // 
            this.AbilitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AbilityHeader,
            this.HiddenHeader});
            this.AbilitiesListView.Location = new System.Drawing.Point(173, 30);
            this.AbilitiesListView.Name = "AbilitiesListView";
            this.AbilitiesListView.Size = new System.Drawing.Size(155, 122);
            this.AbilitiesListView.TabIndex = 15;
            this.AbilitiesListView.UseCompatibleStateImageBehavior = false;
            this.AbilitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // AbilityHeader
            // 
            this.AbilityHeader.Text = "Ability";
            this.AbilityHeader.Width = 67;
            // 
            // HiddenHeader
            // 
            this.HiddenHeader.Text = "Hidden";
            this.HiddenHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HiddenHeader.Width = 67;
            // 
            // StatsListView
            // 
            this.StatsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StatNameHeader,
            this.StatBaseHeader,
            this.StatEffortHeader});
            this.StatsListView.Location = new System.Drawing.Point(17, 184);
            this.StatsListView.Name = "StatsListView";
            this.StatsListView.Size = new System.Drawing.Size(311, 122);
            this.StatsListView.TabIndex = 14;
            this.StatsListView.UseCompatibleStateImageBehavior = false;
            this.StatsListView.View = System.Windows.Forms.View.Details;
            // 
            // StatNameHeader
            // 
            this.StatNameHeader.Text = "Stat";
            this.StatNameHeader.Width = 98;
            // 
            // StatBaseHeader
            // 
            this.StatBaseHeader.Text = "Base";
            this.StatBaseHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StatBaseHeader.Width = 96;
            // 
            // StatEffortHeader
            // 
            this.StatEffortHeader.Text = "Effort";
            this.StatEffortHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StatEffortHeader.Width = 96;
            // 
            // MovementsListView
            // 
            this.MovementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MoveHeader});
            this.MovementsListView.Location = new System.Drawing.Point(17, 30);
            this.MovementsListView.Name = "MovementsListView";
            this.MovementsListView.Size = new System.Drawing.Size(155, 122);
            this.MovementsListView.TabIndex = 13;
            this.MovementsListView.UseCompatibleStateImageBehavior = false;
            this.MovementsListView.View = System.Windows.Forms.View.Details;
            // 
            // MoveHeader
            // 
            this.MoveHeader.Text = "Move";
            this.MoveHeader.Width = 134;
            // 
            // StatsLabel
            // 
            this.StatsLabel.BackColor = System.Drawing.Color.White;
            this.StatsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatsLabel.Location = new System.Drawing.Point(17, 161);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(311, 21);
            this.StatsLabel.TabIndex = 12;
            this.StatsLabel.Text = "Stats";
            this.StatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovementsLabel
            // 
            this.MovementsLabel.BackColor = System.Drawing.Color.White;
            this.MovementsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovementsLabel.Location = new System.Drawing.Point(17, 6);
            this.MovementsLabel.Name = "MovementsLabel";
            this.MovementsLabel.Size = new System.Drawing.Size(155, 21);
            this.MovementsLabel.TabIndex = 11;
            this.MovementsLabel.Text = "Movements";
            this.MovementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(3, 158);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(336, 153);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(336, 153);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(350, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PokedexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrontBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button SearchButton;
        private TextBox SearchBox;
        private Panel panel3;
        private PictureBox ImageBackBox;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label TypeInfoLabel;
        private Label NumberInfoLabel;
        private Label NameInfoLabel;
        private Label TypeLabel;
        private Label NumberLabel;
        private Label NameLabel;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label WeightInfoLabel;
        private Label WeightLabel;
        private Label HeightInfoLabel;
        private Label HeightLabel;
        private PictureBox ImageFrontBox;
        private PictureBox pictureBox5;
        private ListView StatsListView;
        private ListView MovementsListView;
        private Label StatsLabel;
        private Label MovementsLabel;
        protected ColumnHeader StatNameHeader;
        protected ColumnHeader StatBaseHeader;
        protected ColumnHeader StatEffortHeader;
        protected ColumnHeader MoveHeader;
        private ProgressBar ProgressBar;
        private ListView AbilitiesListView;
        protected ColumnHeader AbilityHeader;
        private Label label1;
        private ColumnHeader HiddenHeader;
        private Label BaseExperienceLabel;
        private Label BaseExperienceInfoLabel;
        private Button EvolutionsButton;
    }
}