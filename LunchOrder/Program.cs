namespace LunchOrder
{
    public partial class Form1 : Form
    {
        decimal Subtotal;
        decimal Tax = 0.0775m;
        decimal OrderTotal;
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            decimal add = 0m;
            if (checkBox1.Checked)
            {
                add++;
            }
            if (checkBox2.Checked)
            {
                add++;
            }
            if (checkBox3.Checked)
            {
                add++;
            }
            if (radioButton1.Checked)
            {
                decimal Hamburger = Convert.ToDecimal(radioButton1.Checked);
                Hamburger = 6.95m;
                Subtotal = Hamburger + (add * .75m);
                Tax = Subtotal * 0.0775m;
                OrderTotal = Tax + Subtotal;
                textBox1.Text = Subtotal.ToString("c");
                textBox2.Text = Tax.ToString("c");
                textBox3.Text = OrderTotal.ToString("c");
            }
            else if (radioButton2.Checked)
            {
                decimal Pizza = Convert.ToDecimal(radioButton2.Checked);
                Pizza = 5.95m;
                Subtotal = Pizza + (add * .50m);
                Tax = Subtotal * 0.00775m;
                OrderTotal = Tax + Subtotal;
                textBox1.Text = Subtotal.ToString("c");
                textBox2.Text = Tax.ToString("c");
                textBox3.Text = OrderTotal.ToString("c");
            }
            else if (radioButton3.Checked)
            {
                decimal salad = Convert.ToDecimal(radioButton3.Checked);
                salad = 4.95m;
                Subtotal = salad + (add * .25m);
                Tax = Subtotal * 0.0775m;
                OrderTotal = Tax + Subtotal;
                textBox1.Text = Subtotal.ToString("c");
                textBox2.Text = Tax.ToString("c");
                textBox3.Text = OrderTotal.ToString("c");
            }
        }
    }
}
internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LunchOrder.Form1());
        }
    }
