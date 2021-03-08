
namespace PDF2IMAGE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_selectPDF = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.textbox_selectedPDF = new System.Windows.Forms.TextBox();
            this.textbox_output = new System.Windows.Forms.TextBox();
            this.label_PageCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button_selectPDF
            // 
            this.button_selectPDF.Location = new System.Drawing.Point(12, 12);
            this.button_selectPDF.Name = "button_selectPDF";
            this.button_selectPDF.Size = new System.Drawing.Size(89, 23);
            this.button_selectPDF.TabIndex = 0;
            this.button_selectPDF.Text = "Select PDF";
            this.button_selectPDF.UseVisualStyleBackColor = true;
            this.button_selectPDF.Click += new System.EventHandler(this.button_selectPDF_Click);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(12, 41);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(89, 23);
            this.button_output.TabIndex = 1;
            this.button_output.Text = "Output Folder";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_generate
            // 
            this.button_generate.Enabled = false;
            this.button_generate.Location = new System.Drawing.Point(12, 112);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(356, 23);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Generate Images";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // textbox_selectedPDF
            // 
            this.textbox_selectedPDF.Location = new System.Drawing.Point(107, 12);
            this.textbox_selectedPDF.Name = "textbox_selectedPDF";
            this.textbox_selectedPDF.ReadOnly = true;
            this.textbox_selectedPDF.Size = new System.Drawing.Size(261, 23);
            this.textbox_selectedPDF.TabIndex = 3;
            this.textbox_selectedPDF.TextChanged += new System.EventHandler(this.textboxSelectedPDF_TextChanged);
            // 
            // textbox_output
            // 
            this.textbox_output.Location = new System.Drawing.Point(107, 41);
            this.textbox_output.Name = "textbox_output";
            this.textbox_output.ReadOnly = true;
            this.textbox_output.Size = new System.Drawing.Size(261, 23);
            this.textbox_output.TabIndex = 4;
            this.textbox_output.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // label_PageCount
            // 
            this.label_PageCount.AutoSize = true;
            this.label_PageCount.Location = new System.Drawing.Point(12, 94);
            this.label_PageCount.Name = "label_PageCount";
            this.label_PageCount.Size = new System.Drawing.Size(96, 15);
            this.label_PageCount.TabIndex = 5;
            this.label_PageCount.Text = "label_PageCount";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 171);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_PageCount);
            this.Controls.Add(this.textbox_output);
            this.Controls.Add(this.textbox_selectedPDF);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_selectPDF);
            this.Name = "Form1";
            this.Text = "PDF2Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selectPDF;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textbox_selectedPDF;
        private System.Windows.Forms.TextBox textbox_output;
        private System.Windows.Forms.Label label_PageCount;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

