namespace LunchOrder
{
    public partial class Form1 : Form
    {
        private void AddOns_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Text = "Add-on items ($.75/each)";
                checkBox1.Text = "Lettuce, Tomato, Onions";
                checkBox2.Text = "Mayo & Mustard";
                checkBox3.Text = "French Fries";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (radioButton2.Checked)
            {
                groupBox1.Text = "Add-on items ($.50/each)";
                checkBox1.Text = "Pepperoni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (radioButton3.Checked)
            {
                groupBox1.Text = "Add-on items ($.25/each)";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon Bits";
                checkBox3.Text = "Bread Sticks";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        public Form1()
            {
                InitializeComponent();
            }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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