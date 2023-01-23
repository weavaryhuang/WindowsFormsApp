using System;

namespace WindowsFormsApp
{
    partial class UserInfoFrame
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
            this.Usergroup = new System.Windows.Forms.GroupBox();
            this.demotbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demodbDataSet = new WindowsFormsApp.DemodbDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.demotbTableAdapter = new WindowsFormsApp.DemodbDataSetTableAdapters.demotbTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.demotbTableAdapter1 = new WindowsFormsApp.DemodbDataSetTableAdapters.demotbTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Usergroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demotbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usergroup
            // 
            this.Usergroup.Controls.Add(this.textBox4);
            this.Usergroup.Controls.Add(this.textBox5);
            this.Usergroup.Controls.Add(this.textBox3);
            this.Usergroup.Controls.Add(this.label5);
            this.Usergroup.Controls.Add(this.label4);
            this.Usergroup.Controls.Add(this.label3);
            this.Usergroup.Controls.Add(this.textBox2);
            this.Usergroup.Controls.Add(this.textBox1);
            this.Usergroup.Controls.Add(this.label2);
            this.Usergroup.Controls.Add(this.label1);
            this.Usergroup.Location = new System.Drawing.Point(30, 37);
            this.Usergroup.Name = "Usergroup";
            this.Usergroup.Size = new System.Drawing.Size(418, 334);
            this.Usergroup.TabIndex = 0;
            this.Usergroup.TabStop = false;
            this.Usergroup.Text = "Usergroup";
            this.Usergroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // demotbBindingSource
            // 
            this.demotbBindingSource.DataMember = "demotb";
            this.demotbBindingSource.DataSource = this.demodbDataSet;
            // 
            // demodbDataSet
            // 
            this.demodbDataSet.DataSetName = "DemodbDataSet";
            this.demodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.demotbBindingSource, "UserContent", true));
            this.textBox5.Location = new System.Drawing.Point(204, 242);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 70);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.demotbBindingSource, "UserStatus", true));
            this.textBox3.Location = new System.Drawing.Point(204, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Content";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Connecting Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Status";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.demotbBindingSource, "UserBasicInfo", true));
            this.textBox2.Location = new System.Drawing.Point(204, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.demotbBindingSource, "UserID", true));
            this.textBox1.Location = new System.Drawing.Point(204, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Basic Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_showResult);
            // 
            // demotbTableAdapter
            // 
            this.demotbTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_updateValues);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_insertValues);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_deletValues);
            // 
            // demotbTableAdapter1
            // 
            this.demotbTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(521, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 33);
            this.button5.TabIndex = 7;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(204, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // UserInfoFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 391);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Usergroup);
            this.Name = "UserInfoFrame";
            this.Text = "UserInfoFrame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Usergroup.ResumeLayout(false);
            this.Usergroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demotbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Usergroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DemodbDataSetTableAdapters.demotbTableAdapter demotbTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DemodbDataSet demodbDataSet;
        private System.Windows.Forms.BindingSource demotbBindingSource;
        private DemodbDataSetTableAdapters.demotbTableAdapter demotbTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

