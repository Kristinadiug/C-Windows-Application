namespace WindowsForms
{
    partial class DishForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddDishButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveASButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColdCheck = new System.Windows.Forms.CheckBox();
            this.HeavyCheck = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DiscountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(209, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddDishButton
            // 
            this.AddDishButton.Location = new System.Drawing.Point(17, 27);
            this.AddDishButton.Name = "AddDishButton";
            this.AddDishButton.Size = new System.Drawing.Size(175, 55);
            this.AddDishButton.TabIndex = 1;
            this.AddDishButton.Text = "Add dish";
            this.AddDishButton.UseVisualStyleBackColor = true;
            this.AddDishButton.Click += new System.EventHandler(this.AddDishButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(662, 43);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(118, 39);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(786, 43);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 39);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Menu";
            // 
            // ReadButton
            // 
            this.ReadButton.Enabled = false;
            this.ReadButton.Location = new System.Drawing.Point(17, 230);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(115, 38);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(17, 287);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 38);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(17, 175);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(115, 36);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveASButton
            // 
            this.SaveASButton.Location = new System.Drawing.Point(17, 346);
            this.SaveASButton.Name = "SaveASButton";
            this.SaveASButton.Size = new System.Drawing.Size(115, 36);
            this.SaveASButton.TabIndex = 8;
            this.SaveASButton.Text = "Save As ..";
            this.SaveASButton.UseVisualStyleBackColor = true;
            this.SaveASButton.Click += new System.EventHandler(this.SaveASButton_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.header.Location = new System.Drawing.Point(235, 18);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(166, 52);
            this.header.TabIndex = 9;
            this.header.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(982, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtering";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(963, 150);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(140, 36);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset filters";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(963, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search: ";
            // 
            // ColdCheck
            // 
            this.ColdCheck.AutoSize = true;
            this.ColdCheck.Location = new System.Drawing.Point(963, 262);
            this.ColdCheck.Name = "ColdCheck";
            this.ColdCheck.Size = new System.Drawing.Size(90, 21);
            this.ColdCheck.TabIndex = 14;
            this.ColdCheck.Text = "Cold food";
            this.ColdCheck.UseVisualStyleBackColor = true;
            this.ColdCheck.CheckedChanged += new System.EventHandler(this.ColdCheck_CheckedChanged);
            // 
            // HeavyCheck
            // 
            this.HeavyCheck.AutoSize = true;
            this.HeavyCheck.Location = new System.Drawing.Point(963, 297);
            this.HeavyCheck.Name = "HeavyCheck";
            this.HeavyCheck.Size = new System.Drawing.Size(70, 21);
            this.HeavyCheck.TabIndex = 15;
            this.HeavyCheck.Text = "Heavy";
            this.HeavyCheck.UseVisualStyleBackColor = true;
            this.HeavyCheck.CheckedChanged += new System.EventHandler(this.HeavyCheck_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(963, 361);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 56);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Minimum price";
            // 
            // DiscountButton
            // 
            this.DiscountButton.Location = new System.Drawing.Point(963, 423);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(208, 50);
            this.DiscountButton.TabIndex = 18;
            this.DiscountButton.Text = "Apply 20% dicount to all hot food";
            this.DiscountButton.UseVisualStyleBackColor = true;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // DishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 534);
            this.Controls.Add(this.DiscountButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.HeavyCheck);
            this.Controls.Add(this.ColdCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.SaveASButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddDishButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DishForm";
            this.Text = "DishForm";
            this.Load += new System.EventHandler(this.DishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddDishButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveASButton;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ColdCheck;
        private System.Windows.Forms.CheckBox HeavyCheck;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button DiscountButton;
    }
}