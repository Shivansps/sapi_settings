
namespace SAPI_Settings
{
    partial class MainUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.testRichTextBox = new System.Windows.Forms.RichTextBox();
            this.speak_play_button = new System.Windows.Forms.Button();
            this.voiceList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.langid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newInstalledVoicesLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stopSpeech = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.voiceVolume = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.voicePitch = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.voiceRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copyVoicesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openSettingsWindows10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voiceVolume)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voicePitch)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voiceRate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // testRichTextBox
            // 
            this.testRichTextBox.Location = new System.Drawing.Point(6, 193);
            this.testRichTextBox.Name = "testRichTextBox";
            this.testRichTextBox.Size = new System.Drawing.Size(357, 207);
            this.testRichTextBox.TabIndex = 0;
            this.testRichTextBox.Text = resources.GetString("testRichTextBox.Text");
            // 
            // speak_play_button
            // 
            this.speak_play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speak_play_button.Location = new System.Drawing.Point(46, 19);
            this.speak_play_button.Name = "speak_play_button";
            this.speak_play_button.Size = new System.Drawing.Size(90, 56);
            this.speak_play_button.TabIndex = 1;
            this.speak_play_button.Text = "SPEAK";
            this.speak_play_button.UseVisualStyleBackColor = true;
            this.speak_play_button.Click += new System.EventHandler(this.speak_play_button_Click);
            // 
            // voiceList
            // 
            this.voiceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.langid,
            this.gender,
            this.lang});
            this.voiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceList.FullRowSelect = true;
            this.voiceList.GridLines = true;
            this.voiceList.HideSelection = false;
            this.voiceList.Location = new System.Drawing.Point(6, 19);
            this.voiceList.MultiSelect = false;
            this.voiceList.Name = "voiceList";
            this.voiceList.Size = new System.Drawing.Size(505, 666);
            this.voiceList.TabIndex = 2;
            this.voiceList.UseCompatibleStateImageBehavior = false;
            this.voiceList.View = System.Windows.Forms.View.Details;
            this.voiceList.SelectedIndexChanged += new System.EventHandler(this.statusVoiceList_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 230;
            // 
            // langid
            // 
            this.langid.Text = "LangID";
            this.langid.Width = 71;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 73;
            // 
            // lang
            // 
            this.lang.Text = "Language";
            this.lang.Width = 120;
            // 
            // newInstalledVoicesLabel
            // 
            this.newInstalledVoicesLabel.AutoSize = true;
            this.newInstalledVoicesLabel.Location = new System.Drawing.Point(418, 49);
            this.newInstalledVoicesLabel.Name = "newInstalledVoicesLabel";
            this.newInstalledVoicesLabel.Size = new System.Drawing.Size(13, 13);
            this.newInstalledVoicesLabel.TabIndex = 5;
            this.newInstalledVoicesLabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voiceList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 697);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installed SAPI Voices - Click to test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stopSpeech);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.testRichTextBox);
            this.groupBox2.Controls.Add(this.speak_play_button);
            this.groupBox2.Location = new System.Drawing.Point(536, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 412);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voice Settings Test - Select one from the list first";
            // 
            // stopSpeech
            // 
            this.stopSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopSpeech.Location = new System.Drawing.Point(157, 19);
            this.stopSpeech.Name = "stopSpeech";
            this.stopSpeech.Size = new System.Drawing.Size(90, 56);
            this.stopSpeech.TabIndex = 7;
            this.stopSpeech.Text = "STOP";
            this.stopSpeech.UseVisualStyleBackColor = true;
            this.stopSpeech.Click += new System.EventHandler(this.stopSpeech_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(6, 82);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(274, 100);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Text Tags";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.voiceVolume);
            this.groupBox6.Location = new System.Drawing.Point(286, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(77, 56);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Volume";
            // 
            // voiceVolume
            // 
            this.voiceVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceVolume.Location = new System.Drawing.Point(10, 19);
            this.voiceVolume.Name = "voiceVolume";
            this.voiceVolume.Size = new System.Drawing.Size(55, 26);
            this.voiceVolume.TabIndex = 2;
            this.voiceVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.voicePitch);
            this.groupBox5.Location = new System.Drawing.Point(286, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 56);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pitch";
            // 
            // voicePitch
            // 
            this.voicePitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voicePitch.Location = new System.Drawing.Point(16, 19);
            this.voicePitch.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.voicePitch.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.voicePitch.Name = "voicePitch";
            this.voicePitch.Size = new System.Drawing.Size(44, 26);
            this.voicePitch.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.voiceRate);
            this.groupBox4.Location = new System.Drawing.Point(286, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(77, 56);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rate";
            // 
            // voiceRate
            // 
            this.voiceRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceRate.Location = new System.Drawing.Point(16, 19);
            this.voiceRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.voiceRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.voiceRate.Name = "voiceRate";
            this.voiceRate.Size = new System.Drawing.Size(44, 26);
            this.voiceRate.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.newInstalledVoicesLabel);
            this.groupBox3.Location = new System.Drawing.Point(536, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 279);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Install New SAPI Voices";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.copyVoicesButton);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.openSettingsWindows10);
            this.groupBox8.Location = new System.Drawing.Point(7, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(356, 253);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Windows 10 / 11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = " to copy the new tokens to sapi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "3) After the new voices are installed, clic the button below";
            // 
            // copyVoicesButton
            // 
            this.copyVoicesButton.Location = new System.Drawing.Point(91, 167);
            this.copyVoicesButton.Name = "copyVoicesButton";
            this.copyVoicesButton.Size = new System.Drawing.Size(182, 23);
            this.copyVoicesButton.TabIndex = 9;
            this.copyVoicesButton.Text = "Copy OneCore Voices to Sapi";
            this.copyVoicesButton.UseVisualStyleBackColor = true;
            this.copyVoicesButton.Click += new System.EventHandler(this.copyVoicesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "2) Click \"Add Voices\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "1) Open:";
            // 
            // openSettingsWindows10
            // 
            this.openSettingsWindows10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSettingsWindows10.Location = new System.Drawing.Point(70, 14);
            this.openSettingsWindows10.Name = "openSettingsWindows10";
            this.openSettingsWindows10.Size = new System.Drawing.Size(182, 28);
            this.openSettingsWindows10.TabIndex = 6;
            this.openSettingsWindows10.Text = "Settings->Region->Speech";
            this.openSettingsWindows10.UseVisualStyleBackColor = true;
            this.openSettingsWindows10.Click += new System.EventHandler(this.openSettingsWindows10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "*Must run with admin rights";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 714);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "SAPI Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voiceVolume)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voicePitch)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voiceRate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox testRichTextBox;
        private System.Windows.Forms.Button speak_play_button;
        private System.Windows.Forms.ListView voiceList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader langid;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.Label newInstalledVoicesLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown voiceRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown voicePitch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown voiceVolume;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button stopSpeech;
        private System.Windows.Forms.ColumnHeader lang;
        private System.Windows.Forms.Button openSettingsWindows10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyVoicesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

