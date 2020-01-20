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
        public Authorization()
        {
            InitializeComponent();
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
        }

        private void registration_B_Click(object sender, EventArgs e)
        {
            registration_B.Visible = false;
            input_B.Text = "Зарегестрировать";
        }
    }
}
