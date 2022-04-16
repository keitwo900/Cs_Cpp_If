using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CppCLR; // C++ CLRプロジェクトのnamespaceを追加

namespace Cs_Cpp_If
{
    public partial class Form1 : Form
    {
        Cpp_CLR_Class cppClrClass; // C++ CLRプロジェクトのクラス

        public Form1()
        {
            // ----------------------------------------------------------------------------
            // コンストラクタ
            // ----------------------------------------------------------------------------
            InitializeComponent();

            cppClrClass = new Cpp_CLR_Class();

        }

        // ----------------------------------------------------------------------------
        // 加算実行ボタンクリックイベント
        // ----------------------------------------------------------------------------
        private void button_Add_Click(object sender, EventArgs e)
        {
            int a, b;
            int ans;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            ans = cppClrClass.AdderWrap(a, b); // CLR API関数のコール
            textBox_AddAnaswer.Text = ans.ToString(); // 回答をテキストボックスに表示
        }
    }
}
