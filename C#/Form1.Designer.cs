namespace FileCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.path1 = new System.Windows.Forms.TextBox();
            this.file1 = new System.Windows.Forms.TextBox();
            this.file2 = new System.Windows.Forms.TextBox();
            this.path2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.duplicate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.Label();
            this.extension1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sort1 = new System.Windows.Forms.Button();
            this.uniq1 = new System.Windows.Forms.Button();
            this.count2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compare = new System.Windows.Forms.Button();
            this.inBothLabel = new System.Windows.Forms.Label();
            this.onlyInALabel = new System.Windows.Forms.Label();
            this.onlyIn1 = new System.Windows.Forms.TextBox();
            this.onlyInBLabel = new System.Windows.Forms.Label();
            this.onlyIn2 = new System.Windows.Forms.TextBox();
            this.noPath1 = new System.Windows.Forms.Button();
            this.countInBoth = new System.Windows.Forms.Label();
            this.countOnlyA = new System.Windows.Forms.Label();
            this.countOnlyB = new System.Windows.Forms.Label();
            this.match = new System.Windows.Forms.Button();
            this.pattern = new System.Windows.Forms.TextBox();
            this.basename1 = new System.Windows.Forms.Button();
            this.basename2 = new System.Windows.Forms.Button();
            this.noPath2 = new System.Windows.Forms.Button();
            this.uniq2 = new System.Windows.Forms.Button();
            this.sort2 = new System.Windows.Forms.Button();
            this.extension2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.TextBox();
            this.extractField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "(a) Dir:";
            // 
            // path1
            // 
            this.path1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path1.Location = new System.Drawing.Point(70, 13);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(282, 23);
            this.path1.TabIndex = 1;
            this.path1.TextChanged += new System.EventHandler(this.path1_Changed);
            // 
            // file1
            // 
            this.file1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.file1.Location = new System.Drawing.Point(23, 104);
            this.file1.MaxLength = 1000000000;
            this.file1.Multiline = true;
            this.file1.Name = "file1";
            this.file1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.file1.Size = new System.Drawing.Size(329, 425);
            this.file1.TabIndex = 2;
            this.file1.TextChanged += new System.EventHandler(this.file1_TextChanged);
            this.file1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.file1_KeyDown);
            // 
            // file2
            // 
            this.file2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.file2.Location = new System.Drawing.Point(377, 104);
            this.file2.MaxLength = 1000000000;
            this.file2.Multiline = true;
            this.file2.Name = "file2";
            this.file2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.file2.Size = new System.Drawing.Size(329, 426);
            this.file2.TabIndex = 5;
            this.file2.TextChanged += new System.EventHandler(this.file2_TextChanged);
            this.file2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.file2_KeyDown);
            // 
            // path2
            // 
            this.path2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path2.Location = new System.Drawing.Point(422, 13);
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(282, 23);
            this.path2.TabIndex = 4;
            this.path2.TextChanged += new System.EventHandler(this.path2_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "(b) Dir:";
            // 
            // duplicate
            // 
            this.duplicate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.duplicate.Location = new System.Drawing.Point(771, 55);
            this.duplicate.MaxLength = 1000000000;
            this.duplicate.Multiline = true;
            this.duplicate.Name = "duplicate";
            this.duplicate.ReadOnly = true;
            this.duplicate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.duplicate.Size = new System.Drawing.Size(329, 161);
            this.duplicate.TabIndex = 8;
            this.duplicate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.duplicate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Count: ";
            // 
            // count1
            // 
            this.count1.AutoSize = true;
            this.count1.Location = new System.Drawing.Point(58, 532);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(0, 13);
            this.count1.TabIndex = 10;
            // 
            // extension1
            // 
            this.extension1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extension1.Location = new System.Drawing.Point(88, 68);
            this.extension1.Name = "extension1";
            this.extension1.Size = new System.Drawing.Size(40, 20);
            this.extension1.TabIndex = 12;
            this.extension1.Text = "xlsx";
            this.extension1.TextChanged += new System.EventHandler(this.extension1_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "extension:";
            // 
            // sort1
            // 
            this.sort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort1.Location = new System.Drawing.Point(266, 68);
            this.sort1.Name = "sort1";
            this.sort1.Size = new System.Drawing.Size(35, 20);
            this.sort1.TabIndex = 13;
            this.sort1.Text = "sort";
            this.sort1.UseVisualStyleBackColor = true;
            this.sort1.Click += new System.EventHandler(this.sort_Click);
            // 
            // uniq1
            // 
            this.uniq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniq1.Location = new System.Drawing.Point(307, 68);
            this.uniq1.Name = "uniq1";
            this.uniq1.Size = new System.Drawing.Size(42, 20);
            this.uniq1.TabIndex = 14;
            this.uniq1.Text = "uniq";
            this.uniq1.UseVisualStyleBackColor = true;
            this.uniq1.Click += new System.EventHandler(this.uniq_Click);
            // 
            // count2
            // 
            this.count2.AutoSize = true;
            this.count2.Location = new System.Drawing.Point(412, 533);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(0, 13);
            this.count2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Count: ";
            // 
            // compare
            // 
            this.compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compare.Location = new System.Drawing.Point(771, 29);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(99, 20);
            this.compare.TabIndex = 17;
            this.compare.Text = "check dups in (a)";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // inBothLabel
            // 
            this.inBothLabel.AutoSize = true;
            this.inBothLabel.Location = new System.Drawing.Point(710, 55);
            this.inBothLabel.Name = "inBothLabel";
            this.inBothLabel.Size = new System.Drawing.Size(59, 13);
            this.inBothLabel.TabIndex = 18;
            this.inBothLabel.Text = "dups in (a):";
            // 
            // onlyInALabel
            // 
            this.onlyInALabel.AutoSize = true;
            this.onlyInALabel.Location = new System.Drawing.Point(710, 222);
            this.onlyInALabel.Name = "onlyInALabel";
            this.onlyInALabel.Size = new System.Drawing.Size(61, 13);
            this.onlyInALabel.TabIndex = 20;
            this.onlyInALabel.Text = "uniqs in (a):";
            // 
            // onlyIn1
            // 
            this.onlyIn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.onlyIn1.Location = new System.Drawing.Point(771, 222);
            this.onlyIn1.MaxLength = 1000000000;
            this.onlyIn1.Multiline = true;
            this.onlyIn1.Name = "onlyIn1";
            this.onlyIn1.ReadOnly = true;
            this.onlyIn1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.onlyIn1.Size = new System.Drawing.Size(329, 161);
            this.onlyIn1.TabIndex = 19;
            this.onlyIn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onlyIn1_KeyDown);
            // 
            // onlyInBLabel
            // 
            this.onlyInBLabel.AutoSize = true;
            this.onlyInBLabel.Location = new System.Drawing.Point(710, 389);
            this.onlyInBLabel.Name = "onlyInBLabel";
            this.onlyInBLabel.Size = new System.Drawing.Size(0, 13);
            this.onlyInBLabel.TabIndex = 22;
            // 
            // onlyIn2
            // 
            this.onlyIn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.onlyIn2.Location = new System.Drawing.Point(771, 389);
            this.onlyIn2.MaxLength = 1000000000;
            this.onlyIn2.Multiline = true;
            this.onlyIn2.Name = "onlyIn2";
            this.onlyIn2.ReadOnly = true;
            this.onlyIn2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.onlyIn2.Size = new System.Drawing.Size(329, 161);
            this.onlyIn2.TabIndex = 21;
            this.onlyIn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onlyIn2_KeyDown);
            // 
            // noPath1
            // 
            this.noPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPath1.Location = new System.Drawing.Point(134, 68);
            this.noPath1.Name = "noPath1";
            this.noPath1.Size = new System.Drawing.Size(56, 20);
            this.noPath1.TabIndex = 23;
            this.noPath1.Text = "no path";
            this.noPath1.UseVisualStyleBackColor = true;
            this.noPath1.Click += new System.EventHandler(this.noPath_Click);
            // 
            // countInBoth
            // 
            this.countInBoth.AutoSize = true;
            this.countInBoth.Location = new System.Drawing.Point(716, 71);
            this.countInBoth.Name = "countInBoth";
            this.countInBoth.Size = new System.Drawing.Size(0, 13);
            this.countInBoth.TabIndex = 24;
            // 
            // countOnlyA
            // 
            this.countOnlyA.AutoSize = true;
            this.countOnlyA.Location = new System.Drawing.Point(716, 239);
            this.countOnlyA.Name = "countOnlyA";
            this.countOnlyA.Size = new System.Drawing.Size(0, 13);
            this.countOnlyA.TabIndex = 25;
            // 
            // countOnlyB
            // 
            this.countOnlyB.AutoSize = true;
            this.countOnlyB.Location = new System.Drawing.Point(716, 406);
            this.countOnlyB.Name = "countOnlyB";
            this.countOnlyB.Size = new System.Drawing.Size(0, 13);
            this.countOnlyB.TabIndex = 26;
            // 
            // match
            // 
            this.match.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match.Location = new System.Drawing.Point(293, 42);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(56, 20);
            this.match.TabIndex = 28;
            this.match.Text = "match";
            this.match.UseVisualStyleBackColor = true;
            this.match.Click += new System.EventHandler(this.match_Click);
            // 
            // pattern
            // 
            this.pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pattern.Location = new System.Drawing.Point(70, 42);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(212, 20);
            this.pattern.TabIndex = 27;
            this.pattern.Text = ".*?\\.(.*)";
            this.pattern.TextChanged += new System.EventHandler(this.pattern_TextChanged);
            // 
            // basename1
            // 
            this.basename1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basename1.Location = new System.Drawing.Point(196, 68);
            this.basename1.Name = "basename1";
            this.basename1.Size = new System.Drawing.Size(64, 20);
            this.basename1.TabIndex = 29;
            this.basename1.Text = "basename";
            this.basename1.UseVisualStyleBackColor = true;
            this.basename1.Click += new System.EventHandler(this.basename_Click);
            // 
            // basename2
            // 
            this.basename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basename2.Location = new System.Drawing.Point(548, 68);
            this.basename2.Name = "basename2";
            this.basename2.Size = new System.Drawing.Size(64, 20);
            this.basename2.TabIndex = 35;
            this.basename2.Text = "basename";
            this.basename2.UseVisualStyleBackColor = true;
            this.basename2.Click += new System.EventHandler(this.basename2_Click);
            // 
            // noPath2
            // 
            this.noPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPath2.Location = new System.Drawing.Point(486, 68);
            this.noPath2.Name = "noPath2";
            this.noPath2.Size = new System.Drawing.Size(56, 20);
            this.noPath2.TabIndex = 34;
            this.noPath2.Text = "no path";
            this.noPath2.UseVisualStyleBackColor = true;
            this.noPath2.Click += new System.EventHandler(this.noPath2_Click);
            // 
            // uniq2
            // 
            this.uniq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniq2.Location = new System.Drawing.Point(659, 68);
            this.uniq2.Name = "uniq2";
            this.uniq2.Size = new System.Drawing.Size(42, 20);
            this.uniq2.TabIndex = 33;
            this.uniq2.Text = "uniq";
            this.uniq2.UseVisualStyleBackColor = true;
            this.uniq2.Click += new System.EventHandler(this.uniq2_Click);
            // 
            // sort2
            // 
            this.sort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort2.Location = new System.Drawing.Point(618, 68);
            this.sort2.Name = "sort2";
            this.sort2.Size = new System.Drawing.Size(35, 20);
            this.sort2.TabIndex = 32;
            this.sort2.Text = "sort";
            this.sort2.UseVisualStyleBackColor = true;
            this.sort2.Click += new System.EventHandler(this.sort2_Click);
            // 
            // extension2
            // 
            this.extension2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extension2.Location = new System.Drawing.Point(440, 68);
            this.extension2.Name = "extension2";
            this.extension2.Size = new System.Drawing.Size(40, 20);
            this.extension2.TabIndex = 31;
            this.extension2.Text = "xlsx";
            this.extension2.TextChanged += new System.EventHandler(this.extension2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "extension:";
            // 
            // field
            // 
            this.field.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field.Location = new System.Drawing.Point(440, 43);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(40, 20);
            this.field.TabIndex = 37;
            this.field.Text = "0";
            // 
            // extractField
            // 
            this.extractField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractField.Location = new System.Drawing.Point(486, 43);
            this.extractField.Name = "extractField";
            this.extractField.Size = new System.Drawing.Size(69, 20);
            this.extractField.TabIndex = 38;
            this.extractField.Text = "extract field";
            this.extractField.UseVisualStyleBackColor = true;
            this.extractField.Click += new System.EventHandler(this.extractField_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 568);
            this.Controls.Add(this.extractField);
            this.Controls.Add(this.field);
            this.Controls.Add(this.basename2);
            this.Controls.Add(this.noPath2);
            this.Controls.Add(this.uniq2);
            this.Controls.Add(this.sort2);
            this.Controls.Add(this.extension2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.basename1);
            this.Controls.Add(this.match);
            this.Controls.Add(this.pattern);
            this.Controls.Add(this.countOnlyB);
            this.Controls.Add(this.countOnlyA);
            this.Controls.Add(this.countInBoth);
            this.Controls.Add(this.noPath1);
            this.Controls.Add(this.onlyInBLabel);
            this.Controls.Add(this.onlyIn2);
            this.Controls.Add(this.onlyInALabel);
            this.Controls.Add(this.onlyIn1);
            this.Controls.Add(this.inBothLabel);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uniq1);
            this.Controls.Add(this.sort1);
            this.Controls.Add(this.extension1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.duplicate);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ListEZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.TextBox file1;
        private System.Windows.Forms.TextBox file2;
        private System.Windows.Forms.TextBox path2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duplicate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.TextBox extension1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sort1;
        private System.Windows.Forms.Button uniq1;
        private System.Windows.Forms.Label count2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Label inBothLabel;
        private System.Windows.Forms.Label onlyInALabel;
        private System.Windows.Forms.TextBox onlyIn1;
        private System.Windows.Forms.Label onlyInBLabel;
        private System.Windows.Forms.TextBox onlyIn2;
        private System.Windows.Forms.Button noPath1;
        private System.Windows.Forms.Label countInBoth;
        private System.Windows.Forms.Label countOnlyA;
        private System.Windows.Forms.Label countOnlyB;
        private System.Windows.Forms.Button match;
        private System.Windows.Forms.TextBox pattern;
        private System.Windows.Forms.Button basename1;
        private System.Windows.Forms.Button basename2;
        private System.Windows.Forms.Button noPath2;
        private System.Windows.Forms.Button uniq2;
        private System.Windows.Forms.Button sort2;
        private System.Windows.Forms.TextBox extension2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox field;
        private System.Windows.Forms.Button extractField;
    }
}

