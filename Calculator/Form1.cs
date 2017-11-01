using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
  public partial class Form1 : Form
  {
    Calculator.Calc MainCalculator = new Calculator.Calc ();

    public Form1()
    {
      InitializeComponent();
    }


    private void RefreshView ()
    {
      string op = "";
      switch (MainCalculator.CurrentOperation) {
        case Operation.none:
          break;
        case Operation.add:
          op = " +";
          break;
        case Operation.subtract:
          op = " -";
          break;
        case Operation.multiply:
          op = " *";
          break;
        case Operation.divide:
          op = " /";
          break;
        default:
          break;
      }

      string sign = MainCalculator.InputIsNegative ? "-" : "";
      inputField.Text = sign + MainCalculator.InputString;

      if (MainCalculator.HasCurrentValue)
        labelCurrentValue.Text = MainCalculator.CurrentValue.ToString () + op;
      else
        labelCurrentValue.Text = "[answer]";
      if (MainCalculator.Memory != null)
        labelMemory.Text = MainCalculator.Memory.ToString ();
      else
        labelMemory.Text = "[saved value]";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('1');
      RefreshView ();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('2');
      RefreshView ();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('3');
      RefreshView ();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('4');
      RefreshView ();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('5');
      RefreshView ();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('6');
      RefreshView ();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('7');
      RefreshView ();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('8');
      RefreshView ();
    }

    private void button9_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('9');
      RefreshView ();
    }

    private void button0_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('0');
      RefreshView ();
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.add);
      RefreshView ();
    }

    private void buttonMinus_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.subtract);
      RefreshView ();
    }

    private void buttonMultiply_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.multiply);
      RefreshView ();
    }

    private void buttonDivide_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.divide);
      RefreshView ();
    }

    private void evaluate_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.none);
      RefreshView ();
    }

    private void buttonC_Click(object sender, EventArgs e)
    {
      MainCalculator.ClearInput ();
      RefreshView ();
    }

    private void buttonCA_Click(object sender, EventArgs e)
    {
      MainCalculator.ClearCalculation ();
      RefreshView ();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      MainCalculator.SaveMemory ();
      RefreshView ();
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
      MainCalculator.LoadMemory ();
      RefreshView ();
    }

    private void buttonClearMem_Click(object sender, EventArgs e)
    {
      MainCalculator.ClearMemory ();
      RefreshView ();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      RefreshView ();
    }

    private void button10_Click(object sender, EventArgs e)
    {
      MainCalculator.ToggleSign ();
      RefreshView ();
    }

    private void decimalPoint_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('.');
      RefreshView ();
    }
  }
}
