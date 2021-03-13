using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomExplorer
{
    public enum  RowType
    {
        NORMAL = 0,
        FAVORITE = 1
    }
    public partial class MainForm : Form
    {
        private int prevRowNo = 0;
        private int prevColNo = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ExplorerList.RowTemplate.Height = 70;
            ExplorerList.Rows.Add(Image.FromFile(@"image\favorite.png"), "お気に入り", RowType.FAVORITE);
            prevRowNo = ExplorerList.CurrentRow.Index;
        }

        /// <summary>
        /// エクスプローラーリストにデータを追加する
        /// </summary>
        /// <param name="sender">自動生成</param>
        /// <param name="e">自動生成</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Object[] insData = new Object[] { Image.FromFile(@"image\folder_close.png"), "テストデータ1です", RowType.NORMAL};
            ExplorerList.Rows.Insert(0, insData);
        }

        /// <summary>
        /// 選択されているデータをエクスプローラーリストから削除する
        /// </summary>
        /// <param name="sender">自動生成</param>
        /// <param name="e">自動生成</param>
        private void SubButton_Click(object sender, EventArgs e)
        {
            if ( ExplorerList.CurrentRow.Cells[2].Value.Equals(RowType.NORMAL) )
            {
                ExplorerList.Rows.Remove(ExplorerList.CurrentRow);
            } 
        }

        /// <summary>
        /// キー押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExplorerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (ExplorerList.CurrentRow.Cells[2].Value.Equals(RowType.NORMAL))
            {
                switch (e.KeyCode)
                {
                    // F2キー
                    case Keys.F2:
                        ExplorerList.CurrentRow.Cells[1].ReadOnly = false;
                        ExplorerList.CurrentRow.Cells[1].Selected = true;
                        ExplorerList.BeginEdit(true);
                        break;

                }
            }
            prevRowNo = ExplorerList.CurrentRow.Index;
        }

        /// <summary>
        /// 選択項目更処理
        /// </summary>
        /// <param name="sender">自動生成</param>
        /// <param name="e">自動生成</param>
        private void ExplorerList_SelectionChanged(object sender, EventArgs e)
        {
            // 全行で変更した値を初期化する
            ExplorerList.CurrentRow.Cells[1].ReadOnly = true;

            // 直前に参照していた行が Normal の時、画像を変更する
            if (ExplorerList.Rows[prevRowNo].Cells[2].Value.Equals(RowType.NORMAL))
            {
                ExplorerList.Rows[prevRowNo].Cells[0].Value = Image.FromFile(@"image\folder_close.png");
            }

            // 参照行が Normal の時、画像を変更する
            if (ExplorerList.CurrentRow.Cells[2].Value.Equals(RowType.NORMAL))
            {
                ExplorerList.CurrentRow.Cells[0].Value = Image.FromFile(@"image\folder_open.png");
            }
            prevRowNo = ExplorerList.CurrentRow.Index;
        }

        /// <summary>
        /// セルクリック処理
        /// </summary>
        /// <param name="sender">自動生成</param>
        /// <param name="e">自動生成</param>
        private void ExplorerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// フォーカス時の枠線を非表示化する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExplorerList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //フォーカス枠を描画しない
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
    }
}
