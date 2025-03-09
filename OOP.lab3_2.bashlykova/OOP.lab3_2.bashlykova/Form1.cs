namespace OOP.lab3_2.bashlykova
{
    public partial class Form1 : Form
    {
        Numbers Numbers; //объ€вление пол€ дл€ класса form1
        public Form1()
        {
            InitializeComponent();
            Numbers = new Numbers();
            Numbers.observers += new System.EventHandler(this.update_from_numbers); //подписка на обновлени€ модели
            update_from_numbers(this, null);
        }

        private void update_from_numbers(object sender, EventArgs e)
        {
            // обновл€ем все визуальные элементы при изменении модели
            numericUpDownA.Value = Numbers.get_A();
            textBoxA.Text = Numbers.get_A().ToString();
            trackBarA.Value = Numbers.get_A();

            numericUpDownB.Value = Numbers.get_B();
            textBoxB.Text = Numbers.get_B().ToString();
            trackBarB.Value = Numbers.get_B();

            numericUpDownC.Value = Numbers.get_C();
            textBoxC.Text = Numbers.get_C().ToString();
            trackBarC.Value = Numbers.get_C();
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            Numbers.set_A(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Numbers.set_A(Int32.Parse(textBoxA.Text));
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            Numbers.set_A(trackBarA.Value);
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            Numbers.set_B(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Numbers.set_B(Int32.Parse(textBoxB.Text));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            Numbers.set_B(trackBarB.Value);
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            Numbers.set_C(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Numbers.set_C(Int32.Parse(textBoxC.Text));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            Numbers.set_C(trackBarC.Value);
        }



        private void textBoxA_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxB.Text, out int newValue))
                textBoxC.Text = Numbers.get_A().ToString();
            else
                Numbers.set_A(newValue);
        }



        private void textBoxB_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxB.Text, out int newValue))
                textBoxC.Text = Numbers.get_B().ToString();
            else
                Numbers.set_B(newValue);
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxB.Text, out int newValue))
                textBoxC.Text = Numbers.get_C().ToString();
            else
                Numbers.set_C(newValue);
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // разрешаем цифры, Backspace и Delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // игнорируем ввод
            }
        }
    }
}
