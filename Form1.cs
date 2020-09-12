using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma1._1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
private void Form1_Load(object sender, EventArgs e)
		{
		}

		
		private const String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private string rotor1=  "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
		private string rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
		private string rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
		private string reflector = "YRUHQSLDPXNGOKMIEBFZCWVJAT";

		int k = 0;
		int index = 0;
		int letterInd=0;
		int rotor1Ind = 0;
		int rotor2Ind = 0;
		int rotor3Ind = 0;
		int diferent1 = 0;
		int diferent2 = 0;
		char letter;
		bool check = false;
		bool check1 = true;

		int switchInd1 = 0;
		int switchInd2 = 0;
		int switchInd3 = 0;
		int switchInd4 = 0;
		int switchInd5 = 0;
		int switchInd6 = 0;
		int switchInd7 = 0;
		int switchInd8 = 0;

		bool rot2 = true;

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (numericUpDown1.Value == 1)
				label55.Text = "Rotor I";
			if (numericUpDown1.Value == 2)
				label55.Text = "Rotor II";
			if (numericUpDown1.Value == 3)
				label55.Text = "Rotor III";
			if (numericUpDown1.Value == 4)
				label55.Text = "Rotor IV";
			if (numericUpDown1.Value == 5)
				label55.Text = "Rotor V";
			if (numericUpDown1.Value == 6)
				label55.Text = "Rotor VI";
			if (numericUpDown1.Value == 7)
				label55.Text = "Rotor VII";
			if (numericUpDown1.Value == 8)
				label55.Text = "Rotor VIII";
		}//визуализирует какой ротор стоит на 1 позиции
		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			if (numericUpDown2.Value == 1)
				label54.Text = "Rotor I";
			if (numericUpDown2.Value == 2)
				label54.Text = "Rotor II";
			if (numericUpDown2.Value == 3)
				label54.Text = "Rotor III";
			if (numericUpDown2.Value == 4)
				label54.Text = "Rotor IV";
			if (numericUpDown2.Value == 5)
				label54.Text = "Rotor V";
			if (numericUpDown2.Value == 6)
				label54.Text = "Rotor VI";
			if (numericUpDown2.Value == 7)
				label54.Text = "Rotor VII";
			if (numericUpDown2.Value == 8)
				label54.Text = "Rotor VIII";
		}//визуализирует какой ротор стоит на 2 позиции
		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			if (numericUpDown3.Value == 1)
				label53.Text = "Rotor I";
			if (numericUpDown3.Value == 2)
				label53.Text = "Rotor II";
			if (numericUpDown3.Value == 3)
				label53.Text = "Rotor III";
			if (numericUpDown3.Value == 4)
				label53.Text = "Rotor IV";
			if (numericUpDown3.Value == 5)
				label53.Text = "Rotor V";
			if (numericUpDown3.Value == 6)
				label53.Text = "Rotor VI";
			if (numericUpDown3.Value == 7)
				label53.Text = "Rotor VII";
			if (numericUpDown3.Value == 8)
				label53.Text = "Rotor VIII";
		}//визуализирует какой ротор стоит на 3 позиции
		private void vScrollBar12_Scroll(object sender, ScrollEventArgs e)
		{
			if (vScrollBar12.Value == 1)
				label56.Text = "Reflector A";
			if (vScrollBar12.Value == 2)
				label56.Text = "Reflector B";
			if (vScrollBar12.Value == 3)
				label56.Text = "Reflector C";
		}  //визиализирует какое зеркало стоит


		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			textBox1.Text = Convert.ToString(alphabet[vScrollBar1.Value]);
			rotor1Ind = Convert.ToInt32(vScrollBar1.Value);
		}      // визуализация ротора 1
		private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
		{
			textBox2.Text = Convert.ToString(alphabet[vScrollBar2.Value]);
			rotor2Ind = Convert.ToInt32(vScrollBar2.Value);
		}      // визуализация ротора 2
		private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
		{
			textBox3.Text = Convert.ToString(alphabet[vScrollBar3.Value]);
			rotor3Ind = Convert.ToInt32(vScrollBar3.Value);
		}      // визуализация ротора 3


		private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
		{
			textBox4.Text = Convert.ToString(alphabet[vScrollBar4.Value]);
			switchInd1 = Convert.ToInt32(vScrollBar4.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}      //  визуализация коммутатора 1
		private void vScrollBar5_Scroll(object sender, ScrollEventArgs e)
		{
			textBox5.Text = Convert.ToString(alphabet[vScrollBar5.Value]);
			switchInd2 = Convert.ToInt32(vScrollBar5.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}      //  визуализация коммутатора 2
		private void vScrollBar6_Scroll(object sender, ScrollEventArgs e)
		{
			textBox6.Text = Convert.ToString(alphabet[vScrollBar6.Value]);
			switchInd3 = Convert.ToInt32(vScrollBar6.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}      //  визуализация коммутатора 3
		private void vScrollBar7_Scroll(object sender, ScrollEventArgs e)
		{
			textBox7.Text = Convert.ToString(alphabet[vScrollBar7.Value]);
			switchInd4 = Convert.ToInt32(vScrollBar7.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}      //  визуализация коммутатора 4
		private void vScrollBar8_Scroll(object sender, ScrollEventArgs e)
		{
			textBox8.Text = Convert.ToString(alphabet[vScrollBar8.Value]);
			switchInd5 = Convert.ToInt32(vScrollBar8.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}      //  визуализация коммутатора 5
		private void vScrollBar9_Scroll(object sender, ScrollEventArgs e)
		{
			textBox9.Text = Convert.ToString(alphabet[vScrollBar9.Value]);
			switchInd6 = Convert.ToInt32(vScrollBar9.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}      //  визуализация коммутатора 6
		private void vScrollBar10_Scroll(object sender, ScrollEventArgs e)
		{
			textBox10.Text = Convert.ToString(alphabet[vScrollBar10.Value]);
			switchInd7 = Convert.ToInt32(vScrollBar10.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}     //  визуализация коммутатора 7
		private void vScrollBar11_Scroll(object sender, ScrollEventArgs e)
		{
			textBox11.Text = Convert.ToString(alphabet[vScrollBar11.Value]);
			switchInd8 = Convert.ToInt32(vScrollBar11.Value);
			check = false;
			pictureBox2.BackColor = Color.Gray;
		}     //  визуализация коммутатора 8


		private void button27_Click_1(object sender, EventArgs e)
		{
			check1 = true;
			if (vScrollBar4.Value == vScrollBar6.Value || vScrollBar4.Value == vScrollBar7.Value || vScrollBar4.Value == vScrollBar8.Value
				|| vScrollBar4.Value == vScrollBar9.Value || vScrollBar4.Value == vScrollBar10.Value || vScrollBar4.Value == vScrollBar11.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				check1 = false;
			}
			else if (vScrollBar6.Value == vScrollBar4.Value || vScrollBar6.Value == vScrollBar5.Value || vScrollBar6.Value == vScrollBar8.Value
				|| vScrollBar6.Value == vScrollBar9.Value || vScrollBar6.Value == vScrollBar10.Value || vScrollBar6.Value == vScrollBar11.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				 check1 = false;
			}
			else if (vScrollBar8.Value == vScrollBar4.Value || vScrollBar8.Value == vScrollBar5.Value || vScrollBar8.Value == vScrollBar6.Value
				|| vScrollBar8.Value == vScrollBar7.Value || vScrollBar8.Value == vScrollBar10.Value || vScrollBar8.Value == vScrollBar11.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				 check1 = false;
			}
			else if(vScrollBar10.Value == vScrollBar4.Value || vScrollBar10.Value == vScrollBar5.Value || vScrollBar10.Value == vScrollBar6.Value
				|| vScrollBar10.Value == vScrollBar7.Value || vScrollBar10.Value == vScrollBar8.Value || vScrollBar10.Value == vScrollBar9.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				check1 = false;
			}
			else if(vScrollBar5.Value == vScrollBar6.Value || vScrollBar5.Value == vScrollBar7.Value || vScrollBar5.Value == vScrollBar8.Value
				|| vScrollBar5.Value == vScrollBar9.Value || vScrollBar5.Value == vScrollBar10.Value || vScrollBar5.Value == vScrollBar11.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				 check1 = false;
			}
			else if(vScrollBar7.Value == vScrollBar4.Value || vScrollBar7.Value == vScrollBar5.Value || vScrollBar7.Value == vScrollBar8.Value
				|| vScrollBar7.Value == vScrollBar9.Value || vScrollBar7.Value == vScrollBar10.Value || vScrollBar7.Value == vScrollBar11.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				 check1 = false;
			}
			else if(vScrollBar11.Value == vScrollBar4.Value || vScrollBar11.Value == vScrollBar5.Value || vScrollBar11.Value == vScrollBar6.Value
				|| vScrollBar11.Value == vScrollBar7.Value || vScrollBar11.Value == vScrollBar8.Value || vScrollBar11.Value == vScrollBar9.Value)
			{
				MessageBox.Show("Закамутированные буквы не должны повторятся", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
			      check1 = false;
			}
			if (check1)
			{
				check = true;
				pictureBox2.BackColor = Color.Yellow;
			}
		}  //проверяющая какие буквы закамутированы выдает ОШИБКУ, если одикаковые

		private void ConnectLetter()
		{
			bool check4 = true;
			bool check6 = true;
			bool check8 = true;
			bool check10 = true;
			if (check)
			{
				if (letterInd == vScrollBar4.Value)
				{
					if (vScrollBar4.Value != vScrollBar5.Value)
					{
						letterInd = vScrollBar5.Value;
						check4 = false;
					}
				}
				if (letterInd == vScrollBar5.Value && check4)
				{
					if (vScrollBar5.Value != vScrollBar4.Value)
					{
						letterInd = vScrollBar4.Value;
					}
				}
				if (letterInd == vScrollBar6.Value)
				{
					if (vScrollBar6.Value != vScrollBar7.Value)
					{
						letterInd = vScrollBar7.Value;
						check6 = false;
					}
				}
				if (letterInd == vScrollBar7.Value && check6)
				{
					if (vScrollBar7.Value != vScrollBar6.Value)
					{
						letterInd = vScrollBar6.Value;
					}
				}
				if (letterInd == vScrollBar8.Value)
				{
					if (vScrollBar8.Value != vScrollBar9.Value)
					{
						letterInd = vScrollBar9.Value;
						check8 = false;
					}
				}
				if (letterInd == vScrollBar9.Value && check8)
				{
					if (vScrollBar9.Value != vScrollBar8.Value)
					{
						letterInd = vScrollBar8.Value;
					}
				}
				if (letterInd == vScrollBar10.Value)
				{
					if (vScrollBar10.Value != vScrollBar11.Value)
					{
						letterInd = vScrollBar11.Value;
						check10 = false;
					}
				}
				if (letterInd == vScrollBar11.Value && check10)
				{
					if (vScrollBar11.Value != vScrollBar10.Value)
					{
						letterInd = vScrollBar10.Value;
					}
				}
			}
		} //метод , передающий значение закамутированной буквы

		private void Encrypt()
		{
			switch (numericUpDown1.Value)
			{
				case 1:
					rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
				break;
				case 2:
					rotor1 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
				break;
				case 3:
					rotor1 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
				break;
				case 4:
					rotor1 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
				break;
				case 5:
					rotor1 = "VZBRGITYUPSDNHLXAWMJQOFECK";
					break;
				case 6:
					rotor1 = "JPGVOUMFYQBENHZRDKASXLICTW";
					break;
				case 7:
					rotor1 = "NZJHGRCXMYSWBOUFAIVLPEKQDT";
					break;
				case 8:
					rotor1 = "FKQHTLXOCBJSPDZRAMEWNIUYGV";
					break;
			}// проверяет какой ротор стоит на 1 позиции
			switch (numericUpDown2.Value)
			{
				case 1:
					rotor2 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
					break;
				case 2:
					rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
					break;
				case 3:
					rotor2 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
					break;
				case 4:
					rotor2 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
					break;
				case 5:
					rotor2 = "VZBRGITYUPSDNHLXAWMJQOFECK";
					break;
				case 6:
					rotor2 = "JPGVOUMFYQBENHZRDKASXLICTW";
					break;
				case 7:
					rotor2 = "NZJHGRCXMYSWBOUFAIVLPEKQDT";
					break;
				case 8:
					rotor2 = "FKQHTLXOCBJSPDZRAMEWNIUYGV";
					break;
			}// проверяет какой ротор стоит на 2 позиции
			switch (numericUpDown3.Value)
			{
				case 1:
					rotor3 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
					break;
				case 2:
					rotor3 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
					break;
				case 3:
					rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
					break;
				case 4:
					rotor3 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
					break;
				case 5:
					rotor3 = "VZBRGITYUPSDNHLXAWMJQOFECK";
					break;
				case 6:
					rotor3 = "JPGVOUMFYQBENHZRDKASXLICTW";
					break;
				case 7:
					rotor3 = "NZJHGRCXMYSWBOUFAIVLPEKQDT";
					break;
				case 8:
					rotor3 = "FKQHTLXOCBJSPDZRAMEWNIUYGV";
					break;
			}// проверяет какой ротор стоит на 3 позиции
			switch (vScrollBar12.Value)
			{
				case 1:
					reflector = "EJMZALYXVBWFCRQUONTSPIKHGD";
					break;
				case 2:
					reflector = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
					break;
				case 3:
					reflector = "FVPJIAOYEDRZXWGCTKUQSBNMHL";
					break;
			} // проверяет какое зеркало стоит 

			rotor1Ind = (rotor1Ind + 1) % 26;

			if (rotor1Ind == 17 && (rotor1Ind - 1) == 16)
			{
				rotor2Ind = (rotor2Ind + 1) % 26;
				vScrollBar2.Value = (vScrollBar2.Value + 1) % 26;
				textBox2.Text = Convert.ToString(alphabet[vScrollBar2.Value]);
			}                   // вращает 2 ротор, при полном обороте 1
			if (rotor2Ind == 17 && (rotor2Ind - 1) == 16 && rot2)
			{
				rot2 = false;
				rotor3Ind = (rotor3Ind + 1) % 26;
				vScrollBar3.Value = (vScrollBar3.Value + 1) % 26;
				textBox3.Text = Convert.ToString(alphabet[vScrollBar3.Value]);
			}           // вращает 3 ротор, при полном обороте 2
			vScrollBar1.Value = (vScrollBar1.Value + 1) % 26;                  // меняет значение ротора на +1 , показывает на какую букву переключился ротор
			textBox1.Text = Convert.ToString(alphabet[vScrollBar1.Value]);

			letterInd = (letterInd + rotor1Ind) % 26;                    // с INRUT на ROTOR1

			/*richTextBox2.Text += Convert.ToString(alphabet[letterInd]);  показывает переходные буквы
			richTextBox2.Text += Convert.ToString(rotor1[letterInd]);
			richTextBox2.Text += Convert.ToString("   ");*/

			k = 0;
			while (rotor1[letterInd] != alphabet[k])
				k++;
			letterInd = k;

			diferent1 = Math.Abs(rotor2Ind - rotor1Ind);                 // с ROTOR1 на ROTOR2
			diferent2 = rotor2Ind + (26 - rotor1Ind);
			if (diferent1 <= diferent2)
			{
				if ((rotor2Ind - rotor1Ind) < 0)
				{
					letterInd = (letterInd - diferent1) % 26;
					if (letterInd < 0)
						letterInd = 26 + letterInd;
				}
				else
					letterInd = (letterInd + diferent1) % 26;
			}
			else
			{
				letterInd = (letterInd + diferent2) % 26;
			}

			k = 0;

			/*richTextBox2.Text += Convert.ToString(alphabet[letterInd]); показывает переходные буквы
			richTextBox2.Text += Convert.ToString(rotor2[letterInd]);
			richTextBox2.Text += Convert.ToString("   ");*/

			while (rotor2[letterInd] != alphabet[k])
				k++;
			letterInd = k;

			diferent1 = Math.Abs(rotor3Ind - rotor2Ind);         // с ROTOR2 на ROTOR3
			diferent2 = rotor3Ind + (26 - rotor2Ind);
			if (diferent1 <= diferent2)
			{
				if ((rotor3Ind - rotor2Ind) < 0)
				{
					letterInd = (letterInd - diferent1) % 26;
					if (letterInd < 0)
						letterInd = 26 + letterInd;
				}
				else
					letterInd = (letterInd + diferent1) % 26;
			}
			if (diferent2 < diferent1)
			{
				letterInd = (letterInd + diferent2) % 26;
			}

			/*richTextBox2.Text += Convert.ToString(alphabet[letterInd]);  показывает переходные буквы
			richTextBox2.Text += Convert.ToString(rotor3[letterInd]);
			richTextBox2.Text += Convert.ToString("   ");*/

			k = 0;
			while (rotor3[letterInd] != alphabet[k])
				k++;
			letterInd = k;

			diferent1 = Math.Abs(letterInd - rotor3Ind);            // с ROTOR3 на REFLECTOR
			diferent2 = letterInd + (26 - rotor3Ind);
			if (diferent1 <= diferent2)
			{
				if ((letterInd - rotor3Ind) < 0)
					letterInd = 26 - diferent1;
				else
					letterInd = diferent1;
			}
			if (diferent2 < diferent1)
			{
				letterInd = diferent2;
			}

			/*richTextBox2.Text += Convert.ToString(alphabet[letterInd]);  показывает переходные буквы
			richTextBox2.Text += Convert.ToString(reflector[letterInd]);
			richTextBox2.Text += Convert.ToString("   ");*/

			k = 0;
			while (reflector[letterInd] != alphabet[k])
				k++;
			letterInd = k;

			

			letterInd = (letterInd + rotor3Ind) % 26;       // с REFLECTOR на ROTOR3
			k = 0;
			while (alphabet[letterInd] != rotor3[k])
				k++;
			letterInd = k;

			/*richTextBox2.Text += Convert.ToString(rotor3[letterInd]);   показывает переходные буквы
			richTextBox2.Text += Convert.ToString(alphabet[letterInd]);
			richTextBox2.Text += Convert.ToString("   ");*/


			diferent1 = Math.Abs(rotor3Ind - rotor2Ind); // с ROTOR3 на ROTOR2
			diferent2 = rotor3Ind + (26 - rotor2Ind);
			if (diferent1 <= diferent2)
			{
				if ((letterInd - diferent1) >= 0)
				{
					if ((rotor3Ind - rotor2Ind) >= 0)
						letterInd = (letterInd - diferent1) % 26;
					else
						letterInd = (letterInd + diferent1) % 26;
				}
				else
				{
					if ((rotor3Ind - rotor2Ind) >= 0)
						letterInd = ((letterInd - diferent1) + 26) % 26;
					else
						letterInd = ((letterInd + diferent1) + 26) % 26;
				}

			}
			if (diferent2 < diferent1)
			{
				if ((letterInd - diferent2) >= 0)
					letterInd = (letterInd - diferent2) % 26;
				else
					letterInd = ((letterInd - diferent2) + 26) % 26;
			}

			/*richTextBox2.Text += Convert.ToString(rotor2[letterInd]); показывает переходные буквы
			richTextBox2.Text += Convert.ToString(alphabet[letterInd]);
			richTextBox2.Text += Convert.ToString("    ");*/


			k = 0;
			while (alphabet[letterInd] != rotor2[k])
				k++;
			letterInd = k;


			diferent1 = Math.Abs(rotor2Ind - rotor1Ind);   // с ROTOR2 на ROTOR1
			diferent2 = rotor2Ind + (26 - rotor1Ind);
			if (diferent1 <= diferent2)
			{
				if ((letterInd - diferent1) >= 0)
				{
					if ((rotor2Ind - rotor1Ind) >= 0)
						letterInd = (letterInd - diferent1) % 26;
					else
						letterInd = (letterInd + diferent1) % 26;
				}
				else
				{
					if ((rotor2Ind - rotor1Ind) >= 0)
						letterInd = ((letterInd - diferent1) + 26) % 26;
					else
						letterInd = ((letterInd + diferent1) + 26) % 26;
				}
			}
			if (diferent2 < diferent1)
			{
				if ((letterInd - diferent2) >= 0)
					letterInd = (letterInd - diferent2) % 26;
				else
					letterInd = ((letterInd - diferent2) + 26) % 26;
			}

			k = 0;
			while (alphabet[letterInd] != rotor1[k])
				k++;
			letterInd = k;

			/*richTextBox2.Text += Convert.ToString(rotor1[letterInd]); показывает переходные буквы
			richTextBox2.Text += Convert.ToString(alphabet[letterInd]);
			richTextBox2.Text += Convert.ToString("   ");*/


			if ((letterInd - rotor1Ind) >= 0)                // c ROTOR1 на OUTPUT
				letterInd = letterInd - rotor1Ind;
			else
				letterInd = (letterInd - rotor1Ind) + 26;

			if (alphabet[letterInd] == letter)
				letterInd += 1;

			richTextBox2.Text += Convert.ToString(alphabet[letterInd]);   // показывает закодированную букву

			switch (index)
			{
				case 0:
					label37.ForeColor = Color.White;
					break;
				case 1:
					label50.ForeColor = Color.White;
					break;
				case 2:
					label48.ForeColor = Color.White;
					break;
				case 3:
					label39.ForeColor = Color.White;
					break;
				case 4:
					label29.ForeColor = Color.White;
					break;
				case 5:
					label40.ForeColor = Color.White;
					break;
				case 6:
					label41.ForeColor = Color.White;
					break;
				case 7:
					label42.ForeColor = Color.White;
					break;
				case 8:
					label43.ForeColor = Color.White;
					break;
				case 9:
					label34.ForeColor = Color.White;
					break;
				case 10:
					label44.ForeColor = Color.White;
					break;
				case 11:
					label45.ForeColor = Color.White;
					break;
				case 12:
					label52.ForeColor = Color.White;
					break;
				case 13:
					label51.ForeColor = Color.White;
					break;
				case 14:
					label35.ForeColor = Color.White;
					break;
				case 15:
					label36.ForeColor = Color.White;
					break;
				case 16:
					label27.ForeColor = Color.White;
					break;
				case 17:
					label30.ForeColor = Color.White;
					break;
				case 18:
					label38.ForeColor = Color.White;
					break;
				case 19:
					label31.ForeColor = Color.White;
					break;
				case 20:
					label33.ForeColor = Color.White;
					break;
				case 21:
					label49.ForeColor = Color.White;
					break;
				case 22:
					label28.ForeColor = Color.White;
					break;
				case 23:
					label47.ForeColor = Color.White;
					break;
				case 24:
					label32.ForeColor = Color.White;
					break;
				case 25:
					label46.ForeColor = Color.White;
					break;

			}    // выключает подсветку прошлой закодированной буквы
			index = letterInd;
			switch (letterInd)
			{
				case 0:
					label37.ForeColor = Color.Yellow;
					break;
				case 1:
					label50.ForeColor = Color.Yellow;
					break;
				case 2:
					label48.ForeColor = Color.Yellow;
					break;
				case 3:
					label39.ForeColor = Color.Yellow;
					break;
				case 4:
					label29.ForeColor = Color.Yellow;
					break;
				case 5:
					label40.ForeColor = Color.Yellow;
					break;
				case 6:
					label41.ForeColor = Color.Yellow;
					break;
				case 7:
					label42.ForeColor = Color.Yellow;
					break;
				case 8:
					label43.ForeColor = Color.Yellow;
					break;
				case 9:
					label34.ForeColor = Color.Yellow;
					break;
				case 10:
					label44.ForeColor = Color.Yellow;
					break;
				case 11:
					label45.ForeColor = Color.Yellow;
					break;
				case 12:
					label52.ForeColor = Color.Yellow;
					break;
				case 13:
					label51.ForeColor = Color.Yellow;
					break;
				case 14:
					label35.ForeColor = Color.Yellow;
					break;
				case 15:
					label36.ForeColor = Color.Yellow;
					break;
				case 16:
					label27.ForeColor = Color.Yellow;
					break;
				case 17:
					label30.ForeColor = Color.Yellow;
					break;
				case 18:
					label38.ForeColor = Color.Yellow;
					break;
				case 19:
					label31.ForeColor = Color.Yellow;
					break;
				case 20:
					label33.ForeColor = Color.Yellow;
					break;
				case 21:
					label49.ForeColor = Color.Yellow;
					break;
				case 22:
					label28.ForeColor = Color.Yellow;
					break;
				case 23:
					label47.ForeColor = Color.Yellow;
					break;
				case 24:
					label32.ForeColor = Color.Yellow;
					break;
				case 25:
					label46.ForeColor = Color.Yellow;
					break;

			}  // включает подсветку нынешней закодированной буквы

		}



private void button1_Click(object sender, EventArgs e)
		{
			letterInd = 16;
			richTextBox1.Text += "Q";
			letter = 'Q';
			ConnectLetter();
			Encrypt();
		}
        private void label1_Click(object sender, EventArgs e)
		{
			button1_Click(sender, e);
		}
private void button2_Click(object sender, EventArgs e)
		{
			letterInd = 22;
			richTextBox1.Text += "W";
			letter = 'W';
			ConnectLetter();
			Encrypt();
		}
		private void label2_Click(object sender, EventArgs e)
		{
			button2_Click(sender, e);
		}
private void button3_Click(object sender, EventArgs e)
		{
			letterInd = 4;
			richTextBox1.Text += "E";
			letter = 'E';
			ConnectLetter();
			Encrypt();
		}
		private void label3_Click(object sender, EventArgs e)
		{
			button3_Click(sender, e);
		}
private void button4_Click(object sender, EventArgs e)
		{
			letterInd = 17;
			richTextBox1.Text += "R";
			letter = 'R';
			ConnectLetter();
			Encrypt();
		}
		private void label4_Click(object sender, EventArgs e)
		{
			button4_Click(sender, e);
		}
private void button5_Click(object sender, EventArgs e)
		{
			letterInd = 19;
			richTextBox1.Text += "T";
			letter = 'T';
			ConnectLetter();
			Encrypt();
		}
		private void label5_Click(object sender, EventArgs e)
		{
			button5_Click(sender, e);
		}
private void button6_Click(object sender, EventArgs e)
		{
			letterInd = 24;
			richTextBox1.Text += "Y";
			letter = 'Y';
			ConnectLetter();
			Encrypt();
		}
		private void label6_Click(object sender, EventArgs e)
		{
			button6_Click(sender, e);
		}
private void button7_Click(object sender, EventArgs e)
		{
			letterInd = 20;
			richTextBox1.Text += "U";
			letter = 'U';
			ConnectLetter();
			Encrypt();
		}
		private void label7_Click(object sender, EventArgs e)
		{
			button7_Click(sender, e);
		}
private void button8_Click(object sender, EventArgs e)
		{
			letterInd = 8;
			richTextBox1.Text += "I";
			letter = 'I';
			ConnectLetter();
			Encrypt();
		}
		private void label8_Click(object sender, EventArgs e)
		{
			button8_Click(sender, e);
		}
private void button9_Click(object sender, EventArgs e)
		{
			letterInd = 14;
			richTextBox1.Text += "O";
			letter = 'O';
			ConnectLetter();
			Encrypt();
		}
		private void label9_Click(object sender, EventArgs e)
		{
		     button9_Click(sender,e);
		}
private void button10_Click(object sender, EventArgs e)
		{
			letterInd = 15;
			richTextBox1.Text += "P";
			letter = 'P';
			ConnectLetter();
			Encrypt();
		}
		private void label10_Click(object sender, EventArgs e)
		{
			button10_Click(sender, e);
		}
private void button19_Click(object sender, EventArgs e)
		{
			letterInd = 0;
			richTextBox1.Text += "A";
			letter = 'A';
			ConnectLetter();
			Encrypt();
		}
		private void label11_Click(object sender, EventArgs e)
		{
			button19_Click(sender, e);
		}
private void button18_Click(object sender, EventArgs e)
		{
			letterInd = 18;
			richTextBox1.Text += "S";
			letter = 'S';
			ConnectLetter();
			Encrypt();
		}
		private void label12_Click(object sender, EventArgs e)
		{
			button18_Click(sender, e);
		}
private void button17_Click(object sender, EventArgs e)
		{
			letterInd = 3;
			richTextBox1.Text += "D";
			letter = 'D';
			ConnectLetter();
			Encrypt();
		}
		private void label13_Click(object sender, EventArgs e)
		{
			button17_Click(sender, e);
		}
private void button16_Click(object sender, EventArgs e)
		{
			letterInd = 5;
			richTextBox1.Text += "F";
			letter = 'F';
			ConnectLetter();
			Encrypt();
		}
		private void label14_Click(object sender, EventArgs e)
		{
			button16_Click(sender, e);
		}
private void button15_Click(object sender, EventArgs e)
		{
			letterInd = 6;
			richTextBox1.Text += "G";
			letter = 'G';
			ConnectLetter();
			Encrypt();
		}
		private void label15_Click(object sender, EventArgs e)
		{
			button15_Click(sender, e);
		}
private void button14_Click(object sender, EventArgs e)
		{
			letterInd = 7;
			richTextBox1.Text += "H";
			letter = 'H';
			ConnectLetter();
			Encrypt();
		}
		private void label16_Click(object sender, EventArgs e)
		{
			button14_Click(sender, e);
		}
private void button13_Click(object sender, EventArgs e)
		{
			letterInd = 9;
			richTextBox1.Text += "J";
			letter = 'J';
			ConnectLetter();
			Encrypt();
		}
		private void label17_Click(object sender, EventArgs e)
		{
			button13_Click(sender, e);
		}
private void button12_Click(object sender, EventArgs e)
		{
			letterInd = 10;
			richTextBox1.Text += "K";
			letter = 'K';
			ConnectLetter();
			Encrypt();
		}
		private void label18_Click(object sender, EventArgs e)
		{
			button12_Click(sender, e);
		}
private void button11_Click(object sender, EventArgs e)
		{
			letterInd = 11;
			richTextBox1.Text += "L";
			letter = 'L';
			ConnectLetter();
			Encrypt();
		}
		private void label19_Click(object sender, EventArgs e)
		{
			button11_Click(sender, e);
		}
private void button26_Click(object sender, EventArgs e)
		{
			letterInd = 25;
			richTextBox1.Text += "Z";
			letter = 'Z';
			ConnectLetter();
			Encrypt();
		}
		private void label20_Click(object sender, EventArgs e)
		{
			button26_Click(sender, e);
		}
private void button25_Click(object sender, EventArgs e)
		{
			letterInd = 23;
		    richTextBox1.Text += "X";
			letter = 'X';
			ConnectLetter();
			Encrypt();
		}
		private void label21_Click(object sender, EventArgs e)
		{
			button25_Click(sender, e);
		}
private void button24_Click(object sender, EventArgs e)
		{
			letterInd = 2;
			richTextBox1.Text += "C";
			letter = 'C';
			ConnectLetter();
			Encrypt();
		}
		private void label22_Click(object sender, EventArgs e)
		{
			button24_Click(sender, e);
		}
private void button23_Click(object sender, EventArgs e)
		{
			letterInd = 21;
			richTextBox1.Text += "V";
			letter = 'V';
			ConnectLetter();
			Encrypt();
		}
		private void label23_Click(object sender, EventArgs e)
		{
			button23_Click(sender, e);
		}
private void button22_Click(object sender, EventArgs e)
		{
			letterInd = 1;
			richTextBox1.Text += "B";
			letter = 'B';
			ConnectLetter();
			Encrypt();
		}
		private void label24_Click(object sender, EventArgs e)
		{
			button22_Click(sender, e);
		}
private void button21_Click(object sender, EventArgs e)
		{
			letterInd = 13;
			richTextBox1.Text += "N";
			letter = 'N';
			ConnectLetter();
			Encrypt();
		}
		private void label25_Click(object sender, EventArgs e)
		{
			button21_Click(sender, e);
		}
private void button20_Click(object sender, EventArgs e)
		{
			letterInd = 12;
			richTextBox1.Text += "M";
			letter = 'M';
			ConnectLetter();
			Encrypt();
		}
		private void label26_Click(object sender, EventArgs e)
		{
			button20_Click(sender, e);
		}



		private void label31_Click(object sender, EventArgs e)
		{

		}	
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void button27_Click(object sender, EventArgs e)
		{
		}
		private void label63_Click(object sender, EventArgs e)
		{

		}
		private void textBox11_TextChanged(object sender, EventArgs e)
		{

		}

		private void button28_Click(object sender, EventArgs e) // очищает richTextBox1 и 2
		{
			richTextBox1.Text = "";
			richTextBox2.Text = "";
			switch (index)
			{
				case 0:
					label37.ForeColor = Color.White;
					break;
				case 1:
					label50.ForeColor = Color.White;
					break;
				case 2:
					label48.ForeColor = Color.White;
					break;
				case 3:
					label39.ForeColor = Color.White;
					break;
				case 4:
					label29.ForeColor = Color.White;
					break;
				case 5:
					label40.ForeColor = Color.White;
					break;
				case 6:
					label41.ForeColor = Color.White;
					break;
				case 7:
					label42.ForeColor = Color.White;
					break;
				case 8:
					label43.ForeColor = Color.White;
					break;
				case 9:
					label34.ForeColor = Color.White;
					break;
				case 10:
					label44.ForeColor = Color.White;
					break;
				case 11:
					label45.ForeColor = Color.White;
					break;
				case 12:
					label52.ForeColor = Color.White;
					break;
				case 13:
					label51.ForeColor = Color.White;
					break;
				case 14:
					label35.ForeColor = Color.White;
					break;
				case 15:
					label36.ForeColor = Color.White;
					break;
				case 16:
					label27.ForeColor = Color.White;
					break;
				case 17:
					label30.ForeColor = Color.White;
					break;
				case 18:
					label38.ForeColor = Color.White;
					break;
				case 19:
					label31.ForeColor = Color.White;
					break;
				case 20:
					label33.ForeColor = Color.White;
					break;
				case 21:
					label49.ForeColor = Color.White;
					break;
				case 22:
					label28.ForeColor = Color.White;
					break;
				case 23:
					label47.ForeColor = Color.White;
					break;
				case 24:
					label32.ForeColor = Color.White;
					break;
				case 25:
					label46.ForeColor = Color.White;
					break;

			}    // выключает подсветку прошлой закодированной буквы
		}
	}
}
