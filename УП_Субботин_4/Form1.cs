namespace УП_Субботин_4
{
    public partial class Form1 : Form
    {
        public static List<Weapon> weapons = new List<Weapon>(0);
        public List<Personage> personages = new List<Personage>(0);
        public int power;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text) && string.IsNullOrEmpty(textBox9.Text) && string.IsNullOrEmpty(comboBox2.Text))
                {
                    Weapon weapones = new Weapon();
                    weapons.Add(new Weapon());
                    listBox1.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                    comboBox1.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                    comboBox3.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                    comboBox4.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                    Weapon.Weaponlist.Add(weapones);
                }
                else
                {
                    if (comboBox2.Text == "Меч" || comboBox2.Text == "Щит" || comboBox2.Text == "Клинки" || comboBox2.Text == "Лук")
                    {
                        weapons.Add(new Weapon(textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text), comboBox2.Text));
                        listBox1.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                        comboBox1.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                        comboBox3.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                        comboBox4.Items.Add(weapons[weapons.Count - 1].GetWeapon());
                    }
                    else
                        MessageBox.Show("Пожалуйста, выберите тип оружия, что вам дан, а не придумывайте свой.");
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста, проверьте информацию.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text) && string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Пусто пока");
                }
                else
                { 
                    power = Personage.GetPower(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox2.Text), Weapon.Weaponlist[comboBox1.SelectedIndex - 1].Lvl, Weapon.Weaponlist[comboBox1.SelectedIndex - 1].Damage);
                    label3.Text = Convert.ToString(power);
                    label1.Text = Personage.GetTitle(power, Weapon.Weaponlist[comboBox1.SelectedIndex - 1].Type_Weapon);
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста, проверьте введенную вами информацию.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureBox pictureBox = (PictureBox)sender;
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}