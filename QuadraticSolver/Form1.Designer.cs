namespace QuadraticSolver
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblA;
    private System.Windows.Forms.Label lblB;
    private System.Windows.Forms.Label lblC;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.TextBox txtC;
    private System.Windows.Forms.Button btnDiscriminant;
    private System.Windows.Forms.Button btnVieta;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TextBox txtResult;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
        components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblA = new System.Windows.Forms.Label();
      this.lblB = new System.Windows.Forms.Label();
      this.lblC = new System.Windows.Forms.Label();
      this.txtA = new System.Windows.Forms.TextBox();
      this.txtB = new System.Windows.Forms.TextBox();
      this.txtC = new System.Windows.Forms.TextBox();
      this.btnDiscriminant = new System.Windows.Forms.Button();
      this.btnVieta = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.SuspendLayout();

      this.lblA.Location = new System.Drawing.Point(20, 20);
      this.lblA.Size = new System.Drawing.Size(30, 20);
      this.lblA.Text = "a =";

      this.txtA.Location = new System.Drawing.Point(55, 20);
      this.txtA.Size = new System.Drawing.Size(70, 20);
      this.txtA.Text = "1";

      this.lblB.Location = new System.Drawing.Point(140, 20);
      this.lblB.Size = new System.Drawing.Size(30, 20);
      this.lblB.Text = "b =";

      this.txtB.Location = new System.Drawing.Point(175, 20);
      this.txtB.Size = new System.Drawing.Size(70, 20);
      this.txtB.Text = "0";

      this.lblC.Location = new System.Drawing.Point(260, 20);
      this.lblC.Size = new System.Drawing.Size(30, 20);
      this.lblC.Text = "c =";

      this.txtC.Location = new System.Drawing.Point(295, 20);
      this.txtC.Size = new System.Drawing.Size(70, 20);
      this.txtC.Text = "0";

      this.btnDiscriminant.Location = new System.Drawing.Point(20, 60);
      this.btnDiscriminant.Size = new System.Drawing.Size(160, 35);
      this.btnDiscriminant.Text = "Через дискриминант";
      this.btnDiscriminant.Click += new System.EventHandler(this.btnDiscriminant_Click);

      this.btnVieta.Location = new System.Drawing.Point(190, 60);
      this.btnVieta.Size = new System.Drawing.Size(160, 35);
      this.btnVieta.Text = "Проверка по Виета";
      this.btnVieta.Click += new System.EventHandler(this.btnVieta_Click);

      this.btnClear.Location = new System.Drawing.Point(360, 60);
      this.btnClear.Size = new System.Drawing.Size(100, 35);
      this.btnClear.Text = "Очистить";
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

      this.txtResult.Location = new System.Drawing.Point(20, 110);
      this.txtResult.Size = new System.Drawing.Size(440, 250);
      this.txtResult.Multiline = true;
      this.txtResult.ReadOnly = true;
      this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

      this.ClientSize = new System.Drawing.Size(480, 380);
      this.Controls.Add(this.lblA);
      this.Controls.Add(this.txtA);
      this.Controls.Add(this.lblB);
      this.Controls.Add(this.txtB);
      this.Controls.Add(this.lblC);
      this.Controls.Add(this.txtC);
      this.Controls.Add(this.btnDiscriminant);
      this.Controls.Add(this.btnVieta);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.txtResult);
      this.Name = "Form1";
      this.Text = "Квадратные уравнения";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
    }
  }
}