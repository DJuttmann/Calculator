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


    private void refresh ()
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
      refresh ();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('2');
      refresh ();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('3');
      refresh ();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('4');
      refresh ();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('5');
      refresh ();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('6');
      refresh ();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('7');
      refresh ();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('8');
      refresh ();
    }

    private void button9_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('9');
      refresh ();
    }

    private void button0_Click(object sender, EventArgs e)
    {
      MainCalculator.AddInputChar ('0');
      refresh ();
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.add);
      refresh ();
    }

    private void buttonMinus_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.subtract);
      refresh ();
    }

    private void buttonMultiply_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.multiply);
      refresh ();
    }

    private void buttonDivide_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.divide);
      refresh ();
    }

    private void evaluate_Click(object sender, EventArgs e)
    {
      MainCalculator.HandleButtonPress (Operation.none);
      refresh ();
    }

    private void buttonC_Click(object sender, EventArgs e)
    {
      MainCalculator.ClearInput ();
      refresh ();
    }

    private void buttonCA_Click(object sender, EventArgs e)
    {
      MainCalculator.ClearCalculation ();
      refresh ();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      MainCalculator.SaveMemory ();
      refresh ();
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
      MainCalculator.LoadMemory ();
      refresh ();
    }

    private void buttonClearMem_Click(object sender, EventArgs e)
    {
      MainCalculator.ClearMemory ();
      refresh ();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      refresh ();
    }

    private void button10_Click(object sender, EventArgs e)
    {
      MainCalculator.ToggleSign ();
      refresh ();
    }
  }
}
