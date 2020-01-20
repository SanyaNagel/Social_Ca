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
    public partial class Form1 : Form
    {
        private User user;
        public Form1()
        {
            InitializeComponent();
            Authorization form = new Authorization();
            form.ShowDialog();
            user = new User(form.getId());
            label1.Text = Convert.ToString(user.id);
        }
    }
}
