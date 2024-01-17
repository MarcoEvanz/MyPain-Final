namespace Tuan2
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
            this.ShapeBox = new System.Windows.Forms.GroupBox();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.BrushBox = new System.Windows.Forms.GroupBox();
            this.lbFillColor = new System.Windows.Forms.Label();
            this.btFillColor = new System.Windows.Forms.Button();
            this.rbPatternFill = new System.Windows.Forms.RadioButton();
            this.rbColorFill = new System.Windows.Forms.RadioButton();
            this.rbNoFill = new System.Windows.Forms.RadioButton();
            this.PenBox = new System.Windows.Forms.GroupBox();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.cdBrushColor = new System.Windows.Forms.ColorDialog();
            this.ShapeBox.SuspendLayout();
            this.BrushBox.SuspendLayout();
            this.PenBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapeBox
            // 
            this.ShapeBox.Controls.Add(this.rbCircle);
            this.ShapeBox.Controls.Add(this.rbRectangle);
            this.ShapeBox.Location = new System.Drawing.Point(763, 313);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(200, 137);
            this.ShapeBox.TabIndex = 22;
            this.ShapeBox.TabStop = false;
            this.ShapeBox.Text = "Shape";
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(19, 48);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(62, 20);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(19, 21);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(90, 20);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // BrushBox
            // 
            this.BrushBox.Controls.Add(this.lbFillColor);
            this.BrushBox.Controls.Add(this.btFillColor);
            this.BrushBox.Controls.Add(this.rbPatternFill);
            this.BrushBox.Controls.Add(this.rbColorFill);
            this.BrushBox.Controls.Add(this.rbNoFill);
            this.BrushBox.Location = new System.Drawing.Point(763, 136);
            this.BrushBox.Name = "BrushBox";
            this.BrushBox.Size = new System.Drawing.Size(200, 154);
            this.BrushBox.TabIndex = 21;
            this.BrushBox.TabStop = false;
            this.BrushBox.Text = "Brush";
            // 
            // lbFillColor
            // 
            this.lbFillColor.AutoSize = true;
            this.lbFillColor.Location = new System.Drawing.Point(16, 116);
            this.lbFillColor.Name = "lbFillColor";
            this.lbFillColor.Size = new System.Drawing.Size(39, 16);
            this.lbFillColor.TabIndex = 4;
            this.lbFillColor.Text = "Color";
            // 
            // btFillColor
            // 
            this.btFillColor.Location = new System.Drawing.Point(63, 113);
            this.btFillColor.Name = "btFillColor";
            this.btFillColor.Size = new System.Drawing.Size(120, 23);
            this.btFillColor.TabIndex = 3;
            this.btFillColor.Text = "Chọn Màu Tô";
            this.btFillColor.UseVisualStyleBackColor = true;
            this.btFillColor.Click += new System.EventHandler(this.btFillColor_Click);
            // 
            // rbPatternFill
            // 
            this.rbPatternFill.AutoSize = true;
            this.rbPatternFill.Location = new System.Drawing.Point(19, 87);
            this.rbPatternFill.Name = "rbPatternFill";
            this.rbPatternFill.Size = new System.Drawing.Size(90, 20);
            this.rbPatternFill.TabIndex = 2;
            this.rbPatternFill.TabStop = true;
            this.rbPatternFill.Text = "Pattern Fill";
            this.rbPatternFill.UseVisualStyleBackColor = true;
            // 
            // rbColorFill
            // 
            this.rbColorFill.AutoSize = true;
            this.rbColorFill.Location = new System.Drawing.Point(19, 61);
            this.rbColorFill.Name = "rbColorFill";
            this.rbColorFill.Size = new System.Drawing.Size(80, 20);
            this.rbColorFill.TabIndex = 1;
            this.rbColorFill.TabStop = true;
            this.rbColorFill.Text = "Color Fill";
            this.rbColorFill.UseVisualStyleBackColor = true;
            // 
            // rbNoFill
            // 
            this.rbNoFill.AutoSize = true;
            this.rbNoFill.Location = new System.Drawing.Point(19, 34);
            this.rbNoFill.Name = "rbNoFill";
            this.rbNoFill.Size = new System.Drawing.Size(66, 20);
            this.rbNoFill.TabIndex = 0;
            this.rbNoFill.TabStop = true;
            this.rbNoFill.Text = "No Fill";
            this.rbNoFill.UseVisualStyleBackColor = true;
            // 
            // PenBox
            // 
            this.PenBox.Controls.Add(this.lblPenColor);
            this.PenBox.Controls.Add(this.inpPenWidth);
            this.PenBox.Controls.Add(this.lblColor);
            this.PenBox.Controls.Add(this.btnColor);
            this.PenBox.Location = new System.Drawing.Point(763, 12);
            this.PenBox.Name = "PenBox";
            this.PenBox.Size = new System.Drawing.Size(198, 94);
            this.PenBox.TabIndex = 20;
            this.PenBox.TabStop = false;
            this.PenBox.Text = "Pen";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(16, 29);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(24, 16);
            this.lblPenColor.TabIndex = 11;
            this.lblPenColor.Text = "Cỡ";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(63, 29);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(120, 22);
            this.inpPenWidth.TabIndex = 9;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(16, 60);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(33, 16);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Màu";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(63, 57);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 23);
            this.btnColor.TabIndex = 10;
            this.btnColor.Text = "Chọn Màu";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(733, 438);
            this.mainPanel.TabIndex = 19;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 465);
            this.Controls.Add(this.ShapeBox);
            this.Controls.Add(this.BrushBox);
            this.Controls.Add(this.PenBox);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShapeBox.ResumeLayout(false);
            this.ShapeBox.PerformLayout();
            this.BrushBox.ResumeLayout(false);
            this.BrushBox.PerformLayout();
            this.PenBox.ResumeLayout(false);
            this.PenBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ShapeBox;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.GroupBox BrushBox;
        private System.Windows.Forms.Label lbFillColor;
        private System.Windows.Forms.Button btFillColor;
        private System.Windows.Forms.RadioButton rbPatternFill;
        private System.Windows.Forms.RadioButton rbColorFill;
        private System.Windows.Forms.RadioButton rbNoFill;
        private System.Windows.Forms.GroupBox PenBox;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.ColorDialog cdBrushColor;
    }
}

