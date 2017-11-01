//========================================================================================
// Basic calculator using Windows Forms.
// By Daan Juttmann - 2017-10-31
// GNU General Public License 3.0 (https://www.gnu.org/licenses/gpl-3.0.en.html).
//========================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

//========================================================================================


namespace Calculator
{
  public enum Operation // supported operations
  {none, add, subtract, multiply, divide};


  class Calc
  {

    // PROPERTIES

    private double currentValue; // last evaluated value
    public double CurrentValue
    {
      get {return currentValue;}
      private set
      {
        currentValue = value;
        hasCurrentValue = true;
      }
    }

    private bool hasCurrentValue; // true if evaluated value exists
    public bool HasCurrentValue
    {
      get {return hasCurrentValue;}
    }

    public Nullable <double> Memory
    {
      get;
      set;
    }

    private Operation currentOperation; // currently selected operation
    public Operation CurrentOperation
    {
      get {return currentOperation;}
      set
      {      
        if (hasCurrentValue)
          currentOperation = value;
      }
    }

    private StringBuilder inputString; // numerical user input
    public string InputString
    {
      get {return inputString.ToString ();}
    }

    private bool inputIsNegative; // sign of the numerical user input
    public bool InputIsNegative
    {
      get {return inputIsNegative;}
    }

    // METHODS

    // Constructor.
    public Calc ()
    {
      inputString = new StringBuilder ("");
      ClearCalculation ();
      Memory = null;
    } // Calc


    // Clear the numerical input (set to empty string).
    public void ClearInput ()
    {
      inputString.Clear ();
      inputIsNegative = false;
    } // ClearInput


    // Clear input, evaluation and current operation.
    public void ClearCalculation ()
    {
      ClearInput ();
      currentValue = 0.0;
      hasCurrentValue = false;
      currentOperation = Operation.none;
    } // ClearCalculation


    // Return the input string and sign as a double.
    double InputToDouble ()
    {
      double output = Convert.ToDouble(inputString.ToString());
      if (inputIsNegative)
        output = -output;
      return output;
    }


    // Check if character can be appended to the current input.
    private bool IsValidChar (char c)
    {
      if (c >= '0' && c <= '9')
        return true;
      if (c == '.') {
        if (inputString.ToString ().IndexOf ('.') == -1)
          return true; // only valid character if no decimal point in input yet.
      }
      return false;
    } // IsValidChar


    // Append character to input string.
    public void AddInputChar (char c)
    {
      if (IsValidChar (c))
      inputString.Append (c);
    } // AddInputChar


    // Toggle the sign of the numerical input.
    public void ToggleSign () {
      inputIsNegative = !inputIsNegative;
    } // ToggleSign


    // Evaluate the current equation.
    public void Evaluate ()
    {
      double newValue = InputToDouble ();;
      switch (currentOperation) 
      {
        case Operation.none:
          CurrentValue = newValue;
          break;
        case Operation.add:
          CurrentValue = CurrentValue + newValue;
          break;
        case Operation.subtract:
          CurrentValue = CurrentValue - newValue;
          break;
        case Operation.multiply:
          CurrentValue = CurrentValue * newValue;
          break;
        case Operation.divide:
          if (newValue != 0.0)
          {
            CurrentValue = CurrentValue / newValue;
            hasCurrentValue = true;
          }
          break;
        default:
          break;
      }
    } // Evaluate

    
    // Save input string to memory, or if empty save evaluated number instead.
    public void SaveMemory ()
    {
      if (InputString.Length > 0)
      {
        Memory = InputToDouble ();
      }
      else if (HasCurrentValue)
      {
        Memory = CurrentValue;
      }
      else
      {
        Memory = null;
      }
    } // SaveMemory


    // Load the number from memory and use it as input string.
    public void LoadMemory ()
    {
      if (Memory != null)
      {
        inputString.Clear ();
        inputString.Append (Memory.ToString ());
      }
    } // LoadMemory


    // Clear the memory.
    public void ClearMemory ()
    {
      Memory = null;
    } // ClearMemory


    // Process operation/evaluation button press.
    public void HandleButtonPress (Operation op)
    {
      switch (op) {
        case Operation.add:
        case Operation.subtract:
        case Operation.multiply:
        case Operation.divide:
        case Operation.none:
          if (inputString.Length == 0)
          {
            if (hasCurrentValue) {
              CurrentOperation = op;
            }
          }
          else {
            if (hasCurrentValue)
            {
              Evaluate ();
            }
            else
            {
              CurrentValue = InputToDouble ();
            }
            ClearInput ();
            CurrentOperation = op;
          }
          break;
        default:
          break;
      }
    } // HandleButtonPress
  } // Calc



  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main ()
    {
      Application.EnableVisualStyles ();
      Application.SetCompatibleTextRenderingDefault (false);
      Application.Run (new Form1 ());
    }
  }
}
