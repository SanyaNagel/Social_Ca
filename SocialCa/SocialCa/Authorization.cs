using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialCa
{
    public partial class Authorization : Form
    {
        public int id = 0;

        public Authorization()
        {
            InitializeComponent();
        }

        public void findId(String login, String password)
        {
            id = 1;
        }

        public int getId()
        {
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Если кнопка регистрации не активна, то текущая задача зарегестрировать
            if(registration_B.Visible == false)
            {
                //Регистрация
            }
            else
            {
                //Иначе вход
            }
            findId(login_TB.Text, pasword_TB.Text);
            this.Close();
        }

        private void registration_B_Click(object sender, EventArgs e)
        {
            registration_B.Visible = false;
            input_B.Text = "Зарегестрировать";
        }
    }
}
