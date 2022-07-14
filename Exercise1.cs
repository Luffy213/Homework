using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Exercise1 : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        int i=0;

        public void startGame()
        {
            if (MessageBox.Show("Хотите ли вы сыграть в игру?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;



            else
            {
                Close();
            }
        }
        public Exercise1()

        {
            startGame();
            InitializeComponent();
            UpdateState(userNumber, random.Next(20));
        }
        private void UpdateState(int userNumber)
        {
            labelUserNumber.Text = $"текущее число:{userNumber}";
        }
        private void UpdateState(int userNumber, int computerNumber)
        {
            UpdateState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число:{computerNumber}";

        }
        private void command (int i)
        {
            
            labelCommand.Text = $"Текущее количество команд:{i}";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            i= 0;
            UpdateState(userNumber, random.Next(20));
            CheckWin();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            userNumber = userNumber + 1;
            UpdateState(userNumber);
            CheckWin();
            i++;
            command(i);
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            userNumber = userNumber * 2;
            UpdateState(userNumber);
            i++;
            command(i);
            
        }
        private void CheckWin()
        {
            if(userNumber == computerNumber)
            {
                MessageBox.Show("Вы успешно завершили игру!", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);

               if( MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    i= 0;
                    userNumber = 0;
                    UpdateState(userNumber, random.Next(20));
                }
                else
                {
                    Close();
                } 
                    
            }
        }

        
    }
}
