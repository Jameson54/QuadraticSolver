using System;
using System.Windows.Forms;

namespace QuadraticSolver
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnDiscriminant_Click(object sender, EventArgs e)
    {
      double a = Convert.ToDouble(txtA.Text);
      double b = Convert.ToDouble(txtB.Text);
      double c = Convert.ToDouble(txtC.Text);

      if (a == 0)
      {
        txtResult.Text = "Ошибка: a не может быть равно 0!";
        return;
      }

      double D = b * b - 4 * a * c;

      if (D > 0)
      {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        txtResult.Text = "D = " + D + Environment.NewLine +
                         "D > 0, два корня:" + Environment.NewLine +
                         "x1 = " + x1 + Environment.NewLine +
                         "x2 = " + x2;
      }
      else if (D == 0)
      {
        double x = -b / (2 * a);
        txtResult.Text = "D = 0, один корень:" + Environment.NewLine +
                         "x = " + x;
      }
      else
      {
        txtResult.Text = "D = " + D + Environment.NewLine +
                         "D < 0, корней нет";
      }
    }

    private void btnVieta_Click(object sender, EventArgs e)
    {
      double a = Convert.ToDouble(txtA.Text);
      double b = Convert.ToDouble(txtB.Text);
      double c = Convert.ToDouble(txtC.Text);

      if (a == 0)
      {
        txtResult.Text = "Ошибка: a не может быть равно 0!";
        return;
      }

      double D = b * b - 4 * a * c;

      if (D < 0)
      {
        txtResult.Text = "D < 0, корней нет — теорему Виета не проверить";
        return;
      }

      double x1, x2;
      if (D == 0)
      {
        x1 = -b / (2 * a);
        x2 = x1;
      }
      else
      {
        x1 = (-b + Math.Sqrt(D)) / (2 * a);
        x2 = (-b - Math.Sqrt(D)) / (2 * a);
      }

      double summa = x1 + x2;
      double proizvedenie = x1 * x2;
      double summaPoVieta = -b / a;
      double proizvPoVieta = c / a;

      string text = "";
      text = text + "Корни: x1 = " + x1 + ", x2 = " + x2 + Environment.NewLine;
      text = text + Environment.NewLine;
      text = text + "Проверка по Виета:" + Environment.NewLine;
      text = text + "x1 + x2 = " + summa + " (должно быть " + summaPoVieta + ")" + Environment.NewLine;
      text = text + "x1 * x2 = " + proizvedenie + " (должно быть " + proizvPoVieta + ")";

      txtResult.Text = text;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtA.Text = "1";
      txtB.Text = "0";
      txtC.Text = "0";
      txtResult.Text = "";
    }
  }
}