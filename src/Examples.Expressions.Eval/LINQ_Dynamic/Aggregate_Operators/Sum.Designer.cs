﻿namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    partial class Sum
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiSum_Simple_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiSum_Simple_LINQ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiResult = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiSum_Projection_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiSum_Projection_LINQ = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uiSum_Grouped_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiSum_Grouped_LINQ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiSum_Simple_LINQ_Execute);
            this.groupBox1.Controls.Add(this.uiSum_Simple_LINQ);
            this.groupBox1.Location = new System.Drawing.Point(19, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sum - Simple";
            // 
            // uiSum_Simple_LINQ_Execute
            // 
            this.uiSum_Simple_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiSum_Simple_LINQ_Execute.Name = "uiSum_Simple_LINQ_Execute";
            this.uiSum_Simple_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiSum_Simple_LINQ_Execute.TabIndex = 2;
            this.uiSum_Simple_LINQ_Execute.Text = "LINQ Execute";
            this.uiSum_Simple_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiSum_Simple_LINQ_Execute.Click += new System.EventHandler(this.uiSum_Simple_LINQ_Execute_Click);
            // 
            // uiSum_Simple_LINQ
            // 
            this.uiSum_Simple_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiSum_Simple_LINQ.Name = "uiSum_Simple_LINQ";
            this.uiSum_Simple_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiSum_Simple_LINQ.TabIndex = 0;
            this.uiSum_Simple_LINQ.Text = "LINQ";
            this.uiSum_Simple_LINQ.UseVisualStyleBackColor = true;
            this.uiSum_Simple_LINQ.Click += new System.EventHandler(this.uiSum_Simple_LINQ_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // uiResult
            // 
            this.uiResult.Location = new System.Drawing.Point(7, 35);
            this.uiResult.Name = "uiResult";
            this.uiResult.Size = new System.Drawing.Size(736, 158);
            this.uiResult.TabIndex = 0;
            this.uiResult.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiSum_Projection_LINQ_Execute);
            this.groupBox3.Controls.Add(this.uiSum_Projection_LINQ);
            this.groupBox3.Location = new System.Drawing.Point(211, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sum - Projection";
            // 
            // uiSum_Projection_LINQ_Execute
            // 
            this.uiSum_Projection_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiSum_Projection_LINQ_Execute.Name = "uiSum_Projection_LINQ_Execute";
            this.uiSum_Projection_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiSum_Projection_LINQ_Execute.TabIndex = 2;
            this.uiSum_Projection_LINQ_Execute.Text = "LINQ Execute";
            this.uiSum_Projection_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiSum_Projection_LINQ_Execute.Click += new System.EventHandler(this.uiSum_Projection_LINQ_Execute_Click);
            // 
            // uiSum_Projection_LINQ
            // 
            this.uiSum_Projection_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiSum_Projection_LINQ.Name = "uiSum_Projection_LINQ";
            this.uiSum_Projection_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiSum_Projection_LINQ.TabIndex = 0;
            this.uiSum_Projection_LINQ.Text = "LINQ";
            this.uiSum_Projection_LINQ.UseVisualStyleBackColor = true;
            this.uiSum_Projection_LINQ.Click += new System.EventHandler(this.uiSum_Projection_LINQ_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uiSum_Grouped_LINQ_Execute);
            this.groupBox4.Controls.Add(this.uiSum_Grouped_LINQ);
            this.groupBox4.Location = new System.Drawing.Point(403, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 135);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sum - Grouped";
            // 
            // uiSum_Grouped_LINQ_Execute
            // 
            this.uiSum_Grouped_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiSum_Grouped_LINQ_Execute.Name = "uiSum_Grouped_LINQ_Execute";
            this.uiSum_Grouped_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiSum_Grouped_LINQ_Execute.TabIndex = 2;
            this.uiSum_Grouped_LINQ_Execute.Text = "LINQ Execute";
            this.uiSum_Grouped_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiSum_Grouped_LINQ_Execute.Click += new System.EventHandler(this.uiSum_Grouped_LINQ_Execute_Click);
            // 
            // uiSum_Grouped_LINQ
            // 
            this.uiSum_Grouped_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiSum_Grouped_LINQ.Name = "uiSum_Grouped_LINQ";
            this.uiSum_Grouped_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiSum_Grouped_LINQ.TabIndex = 0;
            this.uiSum_Grouped_LINQ.Text = "LINQ";
            this.uiSum_Grouped_LINQ.UseVisualStyleBackColor = true;
            this.uiSum_Grouped_LINQ.Click += new System.EventHandler(this.uiSum_Grouped_LINQ_Click);
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sum";
            this.Text = "Sum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiSum_Simple_LINQ_Execute;
        private System.Windows.Forms.Button uiSum_Simple_LINQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox uiResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uiSum_Projection_LINQ_Execute;
        private System.Windows.Forms.Button uiSum_Projection_LINQ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button uiSum_Grouped_LINQ_Execute;
        private System.Windows.Forms.Button uiSum_Grouped_LINQ;
    }
}