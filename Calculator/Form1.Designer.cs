namespace Calculator
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
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.button0 = new System.Windows.Forms.Button();
      this.decimalPoint = new System.Windows.Forms.Button();
      this.evaluate = new System.Windows.Forms.Button();
      this.inputField = new System.Windows.Forms.TextBox();
      this.buttonPlus = new System.Windows.Forms.Button();
      this.buttonMinus = new System.Windows.Forms.Button();
      this.buttonMultiply = new System.Windows.Forms.Button();
      this.buttonDivide = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.labelCurrentValue = new System.Windows.Forms.Label();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.buttonClearMem = new System.Windows.Forms.Button();
      this.buttonC = new System.Windows.Forms.Button();
      this.buttonCA = new System.Windows.Forms.Button();
      this.labelMemory = new System.Windows.Forms.Label();
      this.buttonSign = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
      this.button1.Location = new System.Drawing.Point(93, 87);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(55, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(165, 87);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(55, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(237, 87);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(55, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(93, 129);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(55, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "4";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(165, 129);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(55, 23);
      this.button5.TabIndex = 4;
      this.button5.Text = "5";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(237, 129);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(55, 23);
      this.button6.TabIndex = 5;
      this.button6.Text = "6";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(93, 171);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(55, 23);
      this.button7.TabIndex = 6;
      this.button7.Text = "7";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(165, 171);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(55, 23);
      this.button8.TabIndex = 7;
      this.button8.Text = "8";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(237, 171);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(55, 23);
      this.button9.TabIndex = 8;
      this.button9.Text = "9";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // button0
      // 
      this.button0.Location = new System.Drawing.Point(165, 214);
      this.button0.Name = "button0";
      this.button0.Size = new System.Drawing.Size(55, 23);
      this.button0.TabIndex = 9;
      this.button0.Text = "0";
      this.button0.UseVisualStyleBackColor = true;
      this.button0.Click += new System.EventHandler(this.button0_Click);
      // 
      // decimalPoint
      // 
      this.decimalPoint.Location = new System.Drawing.Point(93, 213);
      this.decimalPoint.Name = "decimalPoint";
      this.decimalPoint.Size = new System.Drawing.Size(55, 23);
      this.decimalPoint.TabIndex = 10;
      this.decimalPoint.Text = ".";
      this.decimalPoint.UseVisualStyleBackColor = true;
      // 
      // evaluate
      // 
      this.evaluate.Location = new System.Drawing.Point(237, 256);
      this.evaluate.Name = "evaluate";
      this.evaluate.Size = new System.Drawing.Size(55, 23);
      this.evaluate.TabIndex = 11;
      this.evaluate.Text = "=";
      this.evaluate.UseVisualStyleBackColor = true;
      this.evaluate.Click += new System.EventHandler(this.evaluate_Click);
      // 
      // inputField
      // 
      this.inputField.Location = new System.Drawing.Point(15, 45);
      this.inputField.Name = "inputField";
      this.inputField.Size = new System.Drawing.Size(277, 22);
      this.inputField.TabIndex = 12;
      // 
      // buttonPlus
      // 
      this.buttonPlus.Location = new System.Drawing.Point(15, 87);
      this.buttonPlus.Name = "buttonPlus";
      this.buttonPlus.Size = new System.Drawing.Size(58, 23);
      this.buttonPlus.TabIndex = 13;
      this.buttonPlus.Text = "+";
      this.buttonPlus.UseVisualStyleBackColor = true;
      this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
      // 
      // buttonMinus
      // 
      this.buttonMinus.Location = new System.Drawing.Point(15, 129);
      this.buttonMinus.Name = "buttonMinus";
      this.buttonMinus.Size = new System.Drawing.Size(58, 23);
      this.buttonMinus.TabIndex = 14;
      this.buttonMinus.Text = "-";
      this.buttonMinus.UseVisualStyleBackColor = true;
      this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
      // 
      // buttonMultiply
      // 
      this.buttonMultiply.Location = new System.Drawing.Point(15, 171);
      this.buttonMultiply.Name = "buttonMultiply";
      this.buttonMultiply.Size = new System.Drawing.Size(58, 23);
      this.buttonMultiply.TabIndex = 15;
      this.buttonMultiply.Text = "*";
      this.buttonMultiply.UseVisualStyleBackColor = true;
      this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
      // 
      // buttonDivide
      // 
      this.buttonDivide.Location = new System.Drawing.Point(15, 213);
      this.buttonDivide.Name = "buttonDivide";
      this.buttonDivide.Size = new System.Drawing.Size(58, 23);
      this.buttonDivide.TabIndex = 16;
      this.buttonDivide.Text = "/";
      this.buttonDivide.UseVisualStyleBackColor = true;
      this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(58, 0);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(8, 8);
      this.progressBar1.TabIndex = 17;
      // 
      // labelCurrentValue
      // 
      this.labelCurrentValue.AutoSize = true;
      this.labelCurrentValue.Location = new System.Drawing.Point(12, 13);
      this.labelCurrentValue.Name = "labelCurrentValue";
      this.labelCurrentValue.Size = new System.Drawing.Size(99, 17);
      this.labelCurrentValue.TabIndex = 1;
      this.labelCurrentValue.Text = "[current value]";
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(15, 318);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(60, 23);
      this.buttonSave.TabIndex = 19;
      this.buttonSave.Text = "Save";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(95, 318);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(55, 23);
      this.buttonLoad.TabIndex = 20;
      this.buttonLoad.Text = "Load";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
      // 
      // buttonClearMem
      // 
      this.buttonClearMem.Location = new System.Drawing.Point(167, 318);
      this.buttonClearMem.Name = "buttonClearMem";
      this.buttonClearMem.Size = new System.Drawing.Size(87, 23);
      this.buttonClearMem.TabIndex = 21;
      this.buttonClearMem.Text = "ClrMem";
      this.buttonClearMem.UseVisualStyleBackColor = true;
      this.buttonClearMem.Click += new System.EventHandler(this.buttonClearMem_Click);
      // 
      // buttonC
      // 
      this.buttonC.Location = new System.Drawing.Point(187, 7);
      this.buttonC.Name = "buttonC";
      this.buttonC.Size = new System.Drawing.Size(44, 23);
      this.buttonC.TabIndex = 22;
      this.buttonC.Text = "C";
      this.buttonC.UseVisualStyleBackColor = true;
      this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
      // 
      // buttonCA
      // 
      this.buttonCA.Location = new System.Drawing.Point(246, 7);
      this.buttonCA.Name = "buttonCA";
      this.buttonCA.Size = new System.Drawing.Size(46, 23);
      this.buttonCA.TabIndex = 23;
      this.buttonCA.Text = "CA";
      this.buttonCA.UseVisualStyleBackColor = true;
      this.buttonCA.Click += new System.EventHandler(this.buttonCA_Click);
      // 
      // labelMemory
      // 
      this.labelMemory.AutoSize = true;
      this.labelMemory.Location = new System.Drawing.Point(17, 359);
      this.labelMemory.Name = "labelMemory";
      this.labelMemory.Size = new System.Drawing.Size(92, 17);
      this.labelMemory.TabIndex = 24;
      this.labelMemory.Text = "[saved value]";
      // 
      // buttonSign
      // 
      this.buttonSign.Location = new System.Drawing.Point(237, 214);
      this.buttonSign.Name = "buttonSign";
      this.buttonSign.Size = new System.Drawing.Size(55, 23);
      this.buttonSign.TabIndex = 25;
      this.buttonSign.Text = "+/-";
      this.buttonSign.UseVisualStyleBackColor = true;
      this.buttonSign.Click += new System.EventHandler(this.button10_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 420);
      this.Controls.Add(this.buttonSign);
      this.Controls.Add(this.labelMemory);
      this.Controls.Add(this.buttonCA);
      this.Controls.Add(this.buttonC);
      this.Controls.Add(this.buttonClearMem);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.labelCurrentValue);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.buttonDivide);
      this.Controls.Add(this.buttonMultiply);
      this.Controls.Add(this.buttonMinus);
      this.Controls.Add(this.buttonPlus);
      this.Controls.Add(this.inputField);
      this.Controls.Add(this.evaluate);
      this.Controls.Add(this.decimalPoint);
      this.Controls.Add(this.button0);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button0;
    private System.Windows.Forms.Button decimalPoint;
    private System.Windows.Forms.Button evaluate;
    private System.Windows.Forms.TextBox inputField;
    private System.Windows.Forms.Button buttonMinus;
    private System.Windows.Forms.Button buttonMultiply;
    private System.Windows.Forms.Button buttonDivide;
    internal System.Windows.Forms.Button buttonPlus;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label labelCurrentValue;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.Button buttonClearMem;
    private System.Windows.Forms.Button buttonC;
    private System.Windows.Forms.Button buttonCA;
    private System.Windows.Forms.Label labelMemory;
    private System.Windows.Forms.Button buttonSign;
  }
}

