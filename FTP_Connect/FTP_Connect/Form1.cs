using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace FTP_Connect
{
    public partial class Form1 : Form
    {
        public bool DEBUG_IS = true;

        #region    フォームロードイベント

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DEBUG_IS)
            {
                TextboxIP.Text   = "192.168.0.100";
                TextboxID.Text   = "";
                TextboxPass.Text = "";
            }
        }

        #endregion


        #region    フォームクローズイベント
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion


        #region    ボタンクリックイベント

        /// <summary>
        /// 参照ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            BroesFoldreDialog();
        }

        /// <summary>
        /// ダウンロードボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            string IP       = TextboxIP.Text;
            string ID       = TextboxID.Text;
            string PASS     = TextboxPass.Text;
            string FILENAME = "*.png";
            
            
            FTP_Download(IP,ID,PASS,FILENAME);
        }
        #endregion


        #region    フォルダダイアログ

        private void BroesFoldreDialog()
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            // ダイアログの説明文
            fbDialog.Description = "フォルダを選択してください。";


            // デフォルトのフォルダ
            fbDialog.SelectedPath = @"C:";


            // 「新しいフォルダーの作成する」ボタンを表示する（デフォルトはtrue）
            fbDialog.ShowNewFolderButton = true;


            //フォルダを選択するダイアログを表示する
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                TextboxCopyTo.Text = fbDialog.SelectedPath;
            }
            else
            {
                //textBox1.Text = "キャンセルされました。";
            }
        }
        #endregion


        #region    FTP 通信

        /// <summary>
        /// ダウンロード
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="ID"></param>
        /// <param name="PASS"></param>
        /// <param name="FILENAME"></param>
        private void FTP_Download(string IP, string ID, string PASS, string FILENAME)
        {
            string URL = "ftp://" + IP + "/" + FILENAME;

            WebClient wc = new WebClient();
            wc.Credentials = new NetworkCredential(ID, PASS);
            wc.DownloadFile(URL, FILENAME);
        }

        /// <summary>
        /// アップロード
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="ID"></param>
        /// <param name="PASS"></param>
        /// <param name="FILENAME"></param>
        private void FTP_Upload(string IP, string ID, string PASS, string FILENAME)
        {
            string URL = "ftp://" + IP + "/" + FILENAME;

            WebClient wc = new WebClient();
            wc.Credentials = new NetworkCredential(ID, PASS);
            wc.UploadFile(URL, FILENAME);
        }


        #endregion


    }
}
