using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static Aes AesMan = Aes.Create();

        public Form1()
        {
            InitializeComponent();
            LBL_STATUS.Text = "請先選擇要處理的檔案。";
            LBL_SAVINGPATH.Text += "G:\\codes\\測試區";
            //AesMan.Key = Encoding.UTF8.GetBytes("今天天氣不是很好，我來加個密吧！");
            //AesMan.IV = Encoding.UTF8.GetBytes("昨日死今日生，明日如何今日增aa");
            byte[] mykey = {
                0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77,
                0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff
            };
            byte[] myIV = {
                0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff
            };
            AesMan.Key = mykey;
            AesMan.IV = myIV;
        }

        private void BTN_BROWSE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                ofDlg.InitialDirectory = "G:\\codes\\測試區";
                //string filterString = "txt檔|*.txt | 圖片檔|*.jpg;*.jpeg;*.png;*.gif | MS系列檔|*.docx;*.xlsx;*.pptx | MS系列檔(舊)|*.doc;*.xls;*.ppt | 加密檔|*.cryp | 所有檔案|*.*";
                //ofDlg.Filter = filterString;
                //ofDlg.FilterIndex = 1;
                if (ofDlg.ShowDialog() == DialogResult.OK)
                    LBL_FILEPATH.Text = ofDlg.FileName;
            }
        }

        private void BTN_MAKEFILE_Click(object sender, EventArgs e)
        {
            if (File.Exists(LBL_FILEPATH.Text))
            {
                byte[] cipherText;
                string plainText;
                string fileName = LBL_FILEPATH.Text.Split("\\")[^1];
                if (fileName.Split(".")[^1] == "cryp")
                {
                    // 以bytes為單位讀取加密檔
                    cipherText = File.ReadAllBytes(LBL_FILEPATH.Text);
                    // 解密
                    plainText = Decryption(cipherText);
                    // 存檔
                    using (StreamWriter outputFile = new StreamWriter("G:\\codes\\測試區\\" + fileName[0..^5])) {
                        outputFile.Write(plainText);
                    }

                    LBL_STATUS.Text = "解密完成。";
                }
                else
                {
                    // 以字串形式讀取被加密檔
                    using (StreamReader inputFile = new StreamReader(LBL_FILEPATH.Text)) {
                        plainText = inputFile.ReadToEnd();
                    }
                    // 加密
                    cipherText = Encryption(plainText);
                    // 存檔
                    File.WriteAllBytes("G:\\codes\\測試區\\" + fileName + ".cryp", cipherText);

                    LBL_STATUS.Text = "加密完成。";
                }
            }
            else
                MessageBox.Show("請先選擇要加/解密的檔案。", "操作錯誤");
        }

        private void mouse_leaving(object sender, EventArgs e)
        {
            LBL_STATUS.Text = "就緒。";
        }

        private byte[] Encryption(string plainText)
        {
            byte[] encrypted;
            ICryptoTransform Encryptor = AesMan.CreateEncryptor();

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, Encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    encrypted = ms.ToArray();
                }
            }
            return encrypted;
        }

        private string Decryption(byte[] cipherText)
        {
            string decrypted;
            ICryptoTransform Decryptor = AesMan.CreateDecryptor();

            using (MemoryStream ms = new MemoryStream(cipherText))
            {
                using (CryptoStream cs = new CryptoStream(ms, Decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        decrypted = sr.ReadToEnd();
                    }
                }
            }
            return decrypted;
        }

    }
}
