namespace E7Gear {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gboxScore = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.gboxPreview = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboxSub1 = new System.Windows.Forms.ComboBox();
            this.cboxSub2 = new System.Windows.Forms.ComboBox();
            this.cboxSub3 = new System.Windows.Forms.ComboBox();
            this.cboxSub4 = new System.Windows.Forms.ComboBox();
            this.numSub1 = new System.Windows.Forms.NumericUpDown();
            this.numSub2 = new System.Windows.Forms.NumericUpDown();
            this.numSub3 = new System.Windows.Forms.NumericUpDown();
            this.numSub4 = new System.Windows.Forms.NumericUpDown();
            this.cboxGearLevel = new System.Windows.Forms.ComboBox();
            this.cboxGearRarity = new System.Windows.Forms.ComboBox();
            this.cboxGearEnhance = new System.Windows.Forms.ComboBox();
            this.lblGearLevel = new System.Windows.Forms.Label();
            this.lblGearRarity = new System.Windows.Forms.Label();
            this.lblGearEnhance = new System.Windows.Forms.Label();
            this.tblGearValueRead = new System.Windows.Forms.TableLayoutPanel();
            this.panelGeatValueRead = new System.Windows.Forms.Panel();
            this.numMain = new System.Windows.Forms.NumericUpDown();
            this.cboxMain = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gboxScore.SuspendLayout();
            this.gboxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub4)).BeginInit();
            this.tblGearValueRead.SuspendLayout();
            this.panelGeatValueRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxScore
            // 
            this.gboxScore.BackColor = System.Drawing.Color.Transparent;
            this.gboxScore.Controls.Add(this.lblScore);
            this.gboxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxScore.ForeColor = System.Drawing.Color.White;
            this.gboxScore.Location = new System.Drawing.Point(572, 12);
            this.gboxScore.Name = "gboxScore";
            this.gboxScore.Size = new System.Drawing.Size(128, 100);
            this.gboxScore.TabIndex = 0;
            this.gboxScore.TabStop = false;
            this.gboxScore.Text = "Gear Score";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(6, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(116, 75);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "--";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxPreview
            // 
            this.gboxPreview.BackColor = System.Drawing.Color.Transparent;
            this.gboxPreview.Controls.Add(this.picPreview);
            this.gboxPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPreview.ForeColor = System.Drawing.Color.White;
            this.gboxPreview.Location = new System.Drawing.Point(12, 12);
            this.gboxPreview.Name = "gboxPreview";
            this.gboxPreview.Size = new System.Drawing.Size(180, 257);
            this.gboxPreview.TabIndex = 1;
            this.gboxPreview.TabStop = false;
            this.gboxPreview.Text = "Gear Preview";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(6, 21);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(168, 230);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(572, 118);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(128, 32);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Manual Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(572, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboxSub1
            // 
            this.cboxSub1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSub1.FormattingEnabled = true;
            this.cboxSub1.Items.AddRange(new object[] {
            "Attack",
            "Flat Attack",
            "Health",
            "Flat Health",
            "Defense",
            "Flat Defense",
            "Effectiveness",
            "Effect Resistance",
            "Critical Hit Chance",
            "Critical Hit Damage",
            "Speed"});
            this.cboxSub1.Location = new System.Drawing.Point(6, 80);
            this.cboxSub1.Name = "cboxSub1";
            this.cboxSub1.Size = new System.Drawing.Size(187, 21);
            this.cboxSub1.TabIndex = 0;
            // 
            // cboxSub2
            // 
            this.cboxSub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSub2.FormattingEnabled = true;
            this.cboxSub2.Items.AddRange(new object[] {
            "Attack",
            "Flat Attack",
            "Health",
            "Flat Health",
            "Defense",
            "Flat Defense",
            "Effectiveness",
            "Effect Resistance",
            "Critical Hit Chance",
            "Critical Hit Damage",
            "Speed"});
            this.cboxSub2.Location = new System.Drawing.Point(7, 107);
            this.cboxSub2.Name = "cboxSub2";
            this.cboxSub2.Size = new System.Drawing.Size(187, 21);
            this.cboxSub2.TabIndex = 1;
            // 
            // cboxSub3
            // 
            this.cboxSub3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSub3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSub3.FormattingEnabled = true;
            this.cboxSub3.Items.AddRange(new object[] {
            "Attack",
            "Flat Attack",
            "Health",
            "Flat Health",
            "Defense",
            "Flat Defense",
            "Effectiveness",
            "Effect Resistance",
            "Critical Hit Chance",
            "Critical Hit Damage",
            "Speed"});
            this.cboxSub3.Location = new System.Drawing.Point(7, 134);
            this.cboxSub3.Name = "cboxSub3";
            this.cboxSub3.Size = new System.Drawing.Size(187, 21);
            this.cboxSub3.TabIndex = 2;
            // 
            // cboxSub4
            // 
            this.cboxSub4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSub4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSub4.FormattingEnabled = true;
            this.cboxSub4.Items.AddRange(new object[] {
            "Attack",
            "Flat Attack",
            "Health",
            "Flat Health",
            "Defense",
            "Flat Defense",
            "Effectiveness",
            "Effect Resistance",
            "Critical Hit Chance",
            "Critical Hit Damage",
            "Speed"});
            this.cboxSub4.Location = new System.Drawing.Point(7, 161);
            this.cboxSub4.Name = "cboxSub4";
            this.cboxSub4.Size = new System.Drawing.Size(187, 21);
            this.cboxSub4.TabIndex = 3;
            // 
            // numSub1
            // 
            this.numSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSub1.Location = new System.Drawing.Point(199, 80);
            this.numSub1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSub1.Name = "numSub1";
            this.numSub1.Size = new System.Drawing.Size(98, 20);
            this.numSub1.TabIndex = 4;
            // 
            // numSub2
            // 
            this.numSub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSub2.Location = new System.Drawing.Point(199, 107);
            this.numSub2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSub2.Name = "numSub2";
            this.numSub2.Size = new System.Drawing.Size(98, 20);
            this.numSub2.TabIndex = 5;
            // 
            // numSub3
            // 
            this.numSub3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSub3.Location = new System.Drawing.Point(199, 134);
            this.numSub3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSub3.Name = "numSub3";
            this.numSub3.Size = new System.Drawing.Size(98, 20);
            this.numSub3.TabIndex = 6;
            // 
            // numSub4
            // 
            this.numSub4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSub4.Location = new System.Drawing.Point(199, 161);
            this.numSub4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSub4.Name = "numSub4";
            this.numSub4.Size = new System.Drawing.Size(98, 20);
            this.numSub4.TabIndex = 7;
            // 
            // cboxGearLevel
            // 
            this.cboxGearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGearLevel.FormattingEnabled = true;
            this.cboxGearLevel.Items.AddRange(new object[] {
            "85",
            "88-90"});
            this.cboxGearLevel.Location = new System.Drawing.Point(6, 16);
            this.cboxGearLevel.Name = "cboxGearLevel";
            this.cboxGearLevel.Size = new System.Drawing.Size(64, 24);
            this.cboxGearLevel.TabIndex = 8;
            // 
            // cboxGearRarity
            // 
            this.cboxGearRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGearRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGearRarity.FormattingEnabled = true;
            this.cboxGearRarity.Items.AddRange(new object[] {
            "Heroic",
            "Epic"});
            this.cboxGearRarity.Location = new System.Drawing.Point(76, 16);
            this.cboxGearRarity.Name = "cboxGearRarity";
            this.cboxGearRarity.Size = new System.Drawing.Size(64, 24);
            this.cboxGearRarity.TabIndex = 9;
            // 
            // cboxGearEnhance
            // 
            this.cboxGearEnhance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGearEnhance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGearEnhance.FormattingEnabled = true;
            this.cboxGearEnhance.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboxGearEnhance.Location = new System.Drawing.Point(233, 16);
            this.cboxGearEnhance.Name = "cboxGearEnhance";
            this.cboxGearEnhance.Size = new System.Drawing.Size(64, 24);
            this.cboxGearEnhance.TabIndex = 10;
            // 
            // lblGearLevel
            // 
            this.lblGearLevel.AutoSize = true;
            this.lblGearLevel.Location = new System.Drawing.Point(3, 0);
            this.lblGearLevel.Name = "lblGearLevel";
            this.lblGearLevel.Size = new System.Drawing.Size(38, 13);
            this.lblGearLevel.TabIndex = 11;
            this.lblGearLevel.Text = "Level";
            // 
            // lblGearRarity
            // 
            this.lblGearRarity.AutoSize = true;
            this.lblGearRarity.Location = new System.Drawing.Point(73, 0);
            this.lblGearRarity.Name = "lblGearRarity";
            this.lblGearRarity.Size = new System.Drawing.Size(40, 13);
            this.lblGearRarity.TabIndex = 12;
            this.lblGearRarity.Text = "Rarity";
            // 
            // lblGearEnhance
            // 
            this.lblGearEnhance.AutoSize = true;
            this.lblGearEnhance.Location = new System.Drawing.Point(230, 0);
            this.lblGearEnhance.Name = "lblGearEnhance";
            this.lblGearEnhance.Size = new System.Drawing.Size(57, 13);
            this.lblGearEnhance.TabIndex = 13;
            this.lblGearEnhance.Text = "Enhance";
            // 
            // tblGearValueRead
            // 
            this.tblGearValueRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblGearValueRead.BackColor = System.Drawing.Color.Transparent;
            this.tblGearValueRead.ColumnCount = 1;
            this.tblGearValueRead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGearValueRead.Controls.Add(this.panelGeatValueRead, 0, 0);
            this.tblGearValueRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblGearValueRead.ForeColor = System.Drawing.Color.White;
            this.tblGearValueRead.Location = new System.Drawing.Point(198, 12);
            this.tblGearValueRead.Name = "tblGearValueRead";
            this.tblGearValueRead.RowCount = 1;
            this.tblGearValueRead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGearValueRead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tblGearValueRead.Size = new System.Drawing.Size(368, 251);
            this.tblGearValueRead.TabIndex = 5;
            // 
            // panelGeatValueRead
            // 
            this.panelGeatValueRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGeatValueRead.Controls.Add(this.numMain);
            this.panelGeatValueRead.Controls.Add(this.cboxMain);
            this.panelGeatValueRead.Controls.Add(this.numSub4);
            this.panelGeatValueRead.Controls.Add(this.lblGearEnhance);
            this.panelGeatValueRead.Controls.Add(this.numSub3);
            this.panelGeatValueRead.Controls.Add(this.lblGearLevel);
            this.panelGeatValueRead.Controls.Add(this.numSub2);
            this.panelGeatValueRead.Controls.Add(this.cboxGearEnhance);
            this.panelGeatValueRead.Controls.Add(this.numSub1);
            this.panelGeatValueRead.Controls.Add(this.lblGearRarity);
            this.panelGeatValueRead.Controls.Add(this.cboxSub4);
            this.panelGeatValueRead.Controls.Add(this.cboxGearRarity);
            this.panelGeatValueRead.Controls.Add(this.cboxSub3);
            this.panelGeatValueRead.Controls.Add(this.cboxGearLevel);
            this.panelGeatValueRead.Controls.Add(this.cboxSub2);
            this.panelGeatValueRead.Controls.Add(this.cboxSub1);
            this.panelGeatValueRead.Location = new System.Drawing.Point(34, 32);
            this.panelGeatValueRead.Name = "panelGeatValueRead";
            this.panelGeatValueRead.Size = new System.Drawing.Size(300, 187);
            this.panelGeatValueRead.TabIndex = 6;
            // 
            // numMain
            // 
            this.numMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMain.Location = new System.Drawing.Point(199, 46);
            this.numMain.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMain.Name = "numMain";
            this.numMain.Size = new System.Drawing.Size(98, 26);
            this.numMain.TabIndex = 15;
            // 
            // cboxMain
            // 
            this.cboxMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMain.FormattingEnabled = true;
            this.cboxMain.Items.AddRange(new object[] {
            "Attack",
            "Flat Attack",
            "Health",
            "Flat Health",
            "Defense",
            "Flat Defense",
            "Effectiveness",
            "Effect Resistance",
            "Critical Hit Chance",
            "Critical Hit Damage",
            "Speed"});
            this.cboxMain.Location = new System.Drawing.Point(6, 46);
            this.cboxMain.Name = "cboxMain";
            this.cboxMain.Size = new System.Drawing.Size(187, 28);
            this.cboxMain.TabIndex = 14;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(572, 195);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(128, 32);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 281);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tblGearValueRead);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.gboxPreview);
            this.Controls.Add(this.gboxScore);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Potential | E7 Gear Score Calculator";
            this.gboxScore.ResumeLayout(false);
            this.gboxPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSub4)).EndInit();
            this.tblGearValueRead.ResumeLayout(false);
            this.panelGeatValueRead.ResumeLayout(false);
            this.panelGeatValueRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxScore;
        private System.Windows.Forms.GroupBox gboxPreview;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ComboBox cboxSub4;
        private System.Windows.Forms.ComboBox cboxSub3;
        private System.Windows.Forms.ComboBox cboxSub2;
        private System.Windows.Forms.ComboBox cboxSub1;
        private System.Windows.Forms.NumericUpDown numSub4;
        private System.Windows.Forms.NumericUpDown numSub3;
        private System.Windows.Forms.NumericUpDown numSub2;
        private System.Windows.Forms.NumericUpDown numSub1;
        private System.Windows.Forms.ComboBox cboxGearLevel;
        private System.Windows.Forms.ComboBox cboxGearRarity;
        private System.Windows.Forms.ComboBox cboxGearEnhance;
        private System.Windows.Forms.Label lblGearEnhance;
        private System.Windows.Forms.Label lblGearRarity;
        private System.Windows.Forms.Label lblGearLevel;
        private System.Windows.Forms.TableLayoutPanel tblGearValueRead;
        private System.Windows.Forms.Panel panelGeatValueRead;
        private System.Windows.Forms.NumericUpDown numMain;
        private System.Windows.Forms.ComboBox cboxMain;
        private System.Windows.Forms.Button btnCalc;
    }
}

