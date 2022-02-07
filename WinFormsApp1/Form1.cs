namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBox1.Checked)
                {
                    if (!(textBox1.Text.Trim().Length == 10))
                    {
                        MessageBox.Show("failed");
                        return;
                    }
                    char[] chArray = textBox1.Text.Trim().ToCharArray();
                    int[] numArray = new int[chArray.Length];
                    for (int i = 0; i < chArray.Length; i++)
                    {
                        numArray[i] = (int)char.GetNumericValue(chArray[i]);
                    }

                    int num2 = numArray[9];
                    switch (textBox1.Text.Trim())
                    {
                        case "0000000000":
                        case "1111111111":
                        case "22222222222":
                        case "33333333333":
                        case "4444444444":
                        case "5555555555":
                        case "6666666666":
                        case "7777777777":
                        case "8888888888":
                        case "9999999999":
                            MessageBox.Show("failed");
                            return;
                    }
                    int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4))
                                    + (numArray[7] * 3)) + (numArray[8] * 2);
                    int num4 = num3 - ((num3 / 11) * 11);
                    if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                    {
                        MessageBox.Show("Correct");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("failed");
                        return;
                    }
                }
                else
                {
                    if (!(textBox1.Text.Trim().Length == 11))
                    {
                        MessageBox.Show("failed");
                        return;
                    }
                    switch (textBox1.Text.Trim())
                    {
                        case "00000000000":
                        case "11111111111":
                        case "222222222222":
                        case "333333333333":
                        case "44444444444":
                        case "55555555555":
                        case "66666666666":
                        case "77777777777":
                        case "88888888888":
                        case "99999999999":
                            MessageBox.Show("failed");
                            return;
                    }

                    char[] chArray = textBox1.Text.Trim().ToCharArray();
                    int[] numArray = new int[chArray.Length];
                    for (int i = 0; i < chArray.Length; i++)
                    {
                        numArray[i] = (int)char.GetNumericValue(chArray[i]);
                    }

                    int endNum = numArray[10];
                    int checkNum = numArray[9] + 2;

                    int sumNum = (((numArray[0] + checkNum) * 29) + ((numArray[1] + checkNum) * 27) + ((numArray[2] + checkNum) * 23) + ((numArray[3] + checkNum) * 19) +
                                    ((numArray[4] + checkNum) * 17) + ((numArray[5] + checkNum) * 29) + ((numArray[6] + checkNum) * 27) + ((numArray[7] + checkNum) * 23) +
                                    ((numArray[8] + checkNum) * 19) + ((numArray[9] + checkNum) * 17));
                    int checkSum = sumNum % 11 == 10 ? 0 : sumNum % 11;
                    if (checkSum == endNum)
                    {
                        MessageBox.Show("Correct");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("failed");
                        return;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("failed");
                return;
            }
        }
    }
}