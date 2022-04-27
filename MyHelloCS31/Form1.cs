using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCS31
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요! 김유진입니다~",
                "말풍선", // 창 제목
                MessageBoxButtons.YesNo, // MessageBoxButtons의 옵션
                MessageBoxIcon.Question);
        }
    }
}
