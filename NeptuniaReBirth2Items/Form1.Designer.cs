namespace NeptuniaReBirth2Items
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_gamediscs = new System.Windows.Forms.CheckBox();
            this.ch_everything = new System.Windows.Forms.CheckBox();
            this.ch_procunits = new System.Windows.Forms.CheckBox();
            this.ch_ideachips = new System.Windows.Forms.CheckBox();
            this.ch_plans = new System.Windows.Forms.CheckBox();
            this.ch_materials = new System.Windows.Forms.CheckBox();
            this.ch_memexpand = new System.Windows.Forms.CheckBox();
            this.ch_medals = new System.Windows.Forms.CheckBox();
            this.ch_tools = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_weapons = new System.Windows.Forms.Button();
            this.b_armor = new System.Windows.Forms.Button();
            this.b_accessories = new System.Windows.Forms.Button();
            this.b_stone = new System.Windows.Forms.Button();
            this.b_starfragments = new System.Windows.Forms.Button();
            this.cb_stoneeffect1 = new System.Windows.Forms.ComboBox();
            this.cb_stoneeffect2 = new System.Windows.Forms.ComboBox();
            this.cb_stoneeffect3 = new System.Windows.Forms.ComboBox();
            this.cb_stoneeffect4 = new System.Windows.Forms.ComboBox();
            this.cb_stonename = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_clearstones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Hexadecimal = true;
            this.numericUpDown1.Location = new System.Drawing.Point(57, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Click";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Offset";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_gamediscs);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.ch_everything);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ch_procunits);
            this.groupBox1.Controls.Add(this.ch_ideachips);
            this.groupBox1.Controls.Add(this.ch_plans);
            this.groupBox1.Controls.Add(this.ch_materials);
            this.groupBox1.Controls.Add(this.ch_memexpand);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ch_medals);
            this.groupBox1.Controls.Add(this.ch_tools);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // ch_gamediscs
            // 
            this.ch_gamediscs.AutoSize = true;
            this.ch_gamediscs.Location = new System.Drawing.Point(6, 182);
            this.ch_gamediscs.Name = "ch_gamediscs";
            this.ch_gamediscs.Size = new System.Drawing.Size(83, 17);
            this.ch_gamediscs.TabIndex = 8;
            this.ch_gamediscs.Text = "Game Discs";
            this.ch_gamediscs.UseVisualStyleBackColor = true;
            // 
            // ch_everything
            // 
            this.ch_everything.AutoSize = true;
            this.ch_everything.Checked = true;
            this.ch_everything.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_everything.Location = new System.Drawing.Point(6, 205);
            this.ch_everything.Name = "ch_everything";
            this.ch_everything.Size = new System.Drawing.Size(99, 17);
            this.ch_everything.TabIndex = 7;
            this.ch_everything.Text = "Everything Else";
            this.ch_everything.UseVisualStyleBackColor = true;
            // 
            // ch_procunits
            // 
            this.ch_procunits.AutoSize = true;
            this.ch_procunits.Checked = true;
            this.ch_procunits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_procunits.Location = new System.Drawing.Point(6, 135);
            this.ch_procunits.Name = "ch_procunits";
            this.ch_procunits.Size = new System.Drawing.Size(100, 17);
            this.ch_procunits.TabIndex = 6;
            this.ch_procunits.Text = "Processor Units";
            this.ch_procunits.UseVisualStyleBackColor = true;
            // 
            // ch_ideachips
            // 
            this.ch_ideachips.AutoSize = true;
            this.ch_ideachips.Checked = true;
            this.ch_ideachips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ideachips.Location = new System.Drawing.Point(6, 158);
            this.ch_ideachips.Name = "ch_ideachips";
            this.ch_ideachips.Size = new System.Drawing.Size(76, 17);
            this.ch_ideachips.TabIndex = 5;
            this.ch_ideachips.Text = "Idea Chips";
            this.ch_ideachips.UseVisualStyleBackColor = true;
            // 
            // ch_plans
            // 
            this.ch_plans.AutoSize = true;
            this.ch_plans.Location = new System.Drawing.Point(6, 89);
            this.ch_plans.Name = "ch_plans";
            this.ch_plans.Size = new System.Drawing.Size(52, 17);
            this.ch_plans.TabIndex = 4;
            this.ch_plans.Text = "Plans";
            this.ch_plans.UseVisualStyleBackColor = true;
            // 
            // ch_materials
            // 
            this.ch_materials.AutoSize = true;
            this.ch_materials.Checked = true;
            this.ch_materials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_materials.Location = new System.Drawing.Point(6, 112);
            this.ch_materials.Name = "ch_materials";
            this.ch_materials.Size = new System.Drawing.Size(68, 17);
            this.ch_materials.TabIndex = 3;
            this.ch_materials.Text = "Materials";
            this.ch_materials.UseVisualStyleBackColor = true;
            // 
            // ch_memexpand
            // 
            this.ch_memexpand.AutoSize = true;
            this.ch_memexpand.Checked = true;
            this.ch_memexpand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_memexpand.Location = new System.Drawing.Point(6, 65);
            this.ch_memexpand.Name = "ch_memexpand";
            this.ch_memexpand.Size = new System.Drawing.Size(120, 17);
            this.ch_memexpand.TabIndex = 2;
            this.ch_memexpand.Text = "Memory Expansions";
            this.ch_memexpand.UseVisualStyleBackColor = true;
            // 
            // ch_medals
            // 
            this.ch_medals.AutoSize = true;
            this.ch_medals.Checked = true;
            this.ch_medals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_medals.Location = new System.Drawing.Point(6, 42);
            this.ch_medals.Name = "ch_medals";
            this.ch_medals.Size = new System.Drawing.Size(60, 17);
            this.ch_medals.TabIndex = 1;
            this.ch_medals.Text = "Medals";
            this.ch_medals.UseVisualStyleBackColor = true;
            // 
            // ch_tools
            // 
            this.ch_tools.AutoSize = true;
            this.ch_tools.Checked = true;
            this.ch_tools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_tools.Location = new System.Drawing.Point(6, 19);
            this.ch_tools.Name = "ch_tools";
            this.ch_tools.Size = new System.Drawing.Size(52, 17);
            this.ch_tools.TabIndex = 0;
            this.ch_tools.Text = "Tools";
            this.ch_tools.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear Inventory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Save Existing";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_clearstones);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_stonename);
            this.groupBox2.Controls.Add(this.cb_stoneeffect4);
            this.groupBox2.Controls.Add(this.cb_stoneeffect3);
            this.groupBox2.Controls.Add(this.cb_stoneeffect2);
            this.groupBox2.Controls.Add(this.cb_stoneeffect1);
            this.groupBox2.Controls.Add(this.b_starfragments);
            this.groupBox2.Controls.Add(this.b_stone);
            this.groupBox2.Controls.Add(this.b_accessories);
            this.groupBox2.Controls.Add(this.b_armor);
            this.groupBox2.Controls.Add(this.b_weapons);
            this.groupBox2.Location = new System.Drawing.Point(159, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 332);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stella\'s Dungeon";
            // 
            // b_weapons
            // 
            this.b_weapons.Location = new System.Drawing.Point(7, 19);
            this.b_weapons.Name = "b_weapons";
            this.b_weapons.Size = new System.Drawing.Size(75, 23);
            this.b_weapons.TabIndex = 0;
            this.b_weapons.Text = "Weapons";
            this.b_weapons.UseVisualStyleBackColor = true;
            this.b_weapons.Click += new System.EventHandler(this.b_weapons_Click);
            // 
            // b_armor
            // 
            this.b_armor.Location = new System.Drawing.Point(7, 49);
            this.b_armor.Name = "b_armor";
            this.b_armor.Size = new System.Drawing.Size(75, 23);
            this.b_armor.TabIndex = 1;
            this.b_armor.Text = "Armor";
            this.b_armor.UseVisualStyleBackColor = true;
            this.b_armor.Click += new System.EventHandler(this.b_armor_Click);
            // 
            // b_accessories
            // 
            this.b_accessories.Location = new System.Drawing.Point(7, 79);
            this.b_accessories.Name = "b_accessories";
            this.b_accessories.Size = new System.Drawing.Size(75, 23);
            this.b_accessories.TabIndex = 2;
            this.b_accessories.Text = "Accessories";
            this.b_accessories.UseVisualStyleBackColor = true;
            this.b_accessories.Click += new System.EventHandler(this.b_accessories_Click);
            // 
            // b_stone
            // 
            this.b_stone.Location = new System.Drawing.Point(7, 303);
            this.b_stone.Name = "b_stone";
            this.b_stone.Size = new System.Drawing.Size(75, 23);
            this.b_stone.TabIndex = 3;
            this.b_stone.Text = "Get Stone";
            this.b_stone.UseVisualStyleBackColor = true;
            this.b_stone.Click += new System.EventHandler(this.b_stone_Click);
            // 
            // b_starfragments
            // 
            this.b_starfragments.Location = new System.Drawing.Point(7, 109);
            this.b_starfragments.Name = "b_starfragments";
            this.b_starfragments.Size = new System.Drawing.Size(75, 23);
            this.b_starfragments.TabIndex = 4;
            this.b_starfragments.Text = "Star Shards";
            this.b_starfragments.UseVisualStyleBackColor = true;
            this.b_starfragments.Click += new System.EventHandler(this.b_starfragments_Click);
            // 
            // cb_stoneeffect1
            // 
            this.cb_stoneeffect1.FormattingEnabled = true;
            this.cb_stoneeffect1.Location = new System.Drawing.Point(6, 195);
            this.cb_stoneeffect1.Name = "cb_stoneeffect1";
            this.cb_stoneeffect1.Size = new System.Drawing.Size(128, 21);
            this.cb_stoneeffect1.TabIndex = 5;
            // 
            // cb_stoneeffect2
            // 
            this.cb_stoneeffect2.FormattingEnabled = true;
            this.cb_stoneeffect2.Location = new System.Drawing.Point(7, 222);
            this.cb_stoneeffect2.Name = "cb_stoneeffect2";
            this.cb_stoneeffect2.Size = new System.Drawing.Size(128, 21);
            this.cb_stoneeffect2.TabIndex = 6;
            // 
            // cb_stoneeffect3
            // 
            this.cb_stoneeffect3.FormattingEnabled = true;
            this.cb_stoneeffect3.Location = new System.Drawing.Point(7, 249);
            this.cb_stoneeffect3.Name = "cb_stoneeffect3";
            this.cb_stoneeffect3.Size = new System.Drawing.Size(128, 21);
            this.cb_stoneeffect3.TabIndex = 7;
            // 
            // cb_stoneeffect4
            // 
            this.cb_stoneeffect4.FormattingEnabled = true;
            this.cb_stoneeffect4.Location = new System.Drawing.Point(7, 276);
            this.cb_stoneeffect4.Name = "cb_stoneeffect4";
            this.cb_stoneeffect4.Size = new System.Drawing.Size(128, 21);
            this.cb_stoneeffect4.TabIndex = 8;
            // 
            // cb_stonename
            // 
            this.cb_stonename.FormattingEnabled = true;
            this.cb_stonename.Location = new System.Drawing.Point(7, 168);
            this.cb_stonename.Name = "cb_stonename";
            this.cb_stonename.Size = new System.Drawing.Size(127, 21);
            this.cb_stonename.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stone Creator";
            // 
            // b_clearstones
            // 
            this.b_clearstones.Location = new System.Drawing.Point(89, 303);
            this.b_clearstones.Name = "b_clearstones";
            this.b_clearstones.Size = new System.Drawing.Size(75, 23);
            this.b_clearstones.TabIndex = 12;
            this.b_clearstones.Text = "Clear Stones";
            this.b_clearstones.UseVisualStyleBackColor = true;
            this.b_clearstones.Click += new System.EventHandler(this.b_clearstones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDown1);
            this.MaximumSize = new System.Drawing.Size(360, 430);
            this.Name = "Form1";
            this.Text = " NeptuniaReBirth2Items";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ch_tools;
        private System.Windows.Forms.CheckBox ch_medals;
        private System.Windows.Forms.CheckBox ch_memexpand;
        private System.Windows.Forms.CheckBox ch_materials;
        private System.Windows.Forms.CheckBox ch_plans;
        private System.Windows.Forms.CheckBox ch_ideachips;
        private System.Windows.Forms.CheckBox ch_procunits;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ch_everything;
        private System.Windows.Forms.CheckBox ch_gamediscs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_stone;
        private System.Windows.Forms.Button b_accessories;
        private System.Windows.Forms.Button b_armor;
        private System.Windows.Forms.Button b_weapons;
        private System.Windows.Forms.Button b_starfragments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_stonename;
        private System.Windows.Forms.ComboBox cb_stoneeffect4;
        private System.Windows.Forms.ComboBox cb_stoneeffect3;
        private System.Windows.Forms.ComboBox cb_stoneeffect2;
        private System.Windows.Forms.ComboBox cb_stoneeffect1;
        private System.Windows.Forms.Button b_clearstones;
    }
}

