using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_Lib;


namespace CGS_Windows
{
    public partial class MainCGS : Form
    {
        Gallery gallery = new Gallery();
        public MainCGS()
        {
            InitializeComponent();
            gallery.galleryReadCurator();
            gallery.galleryReadArtist();
            gallery.galleryPieces();
        }

        private void btnAddCurator_Click(object sender, EventArgs e)
        {
            string message = gallery.AddCurator(txtFirstName.Text, txtLastName.Text, txtId.Text);
            MessageBox.Show(message);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtId.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnViewCurator_Click(object sender, EventArgs e)
        {
            rtxtBox1.Clear();
            string allCuratorsInfo = gallery.getAllCuratorsInfo();
            rtxtBox1.AppendText(allCuratorsInfo);
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            string message = gallery.AddArtist(txtFirstNameArtist.Text, txtLastNameArtist.Text, txtArtistId.Text);
            MessageBox.Show(message);
            txtFirstNameArtist.Clear();
            txtLastNameArtist.Clear();
            txtArtistId.Clear();
        }

        private void btnViewArtist_Click(object sender, EventArgs e)
        {
            rtxtBox1.Clear();
            string allArtistInfo = gallery.getAllartistInfo();
            rtxtBox1.AppendText(allArtistInfo);
        }

        private void btnSaveCurator_Click(object sender, EventArgs e)
        {
            string message = gallery.gallerySaveCuratorsInfo();
            MessageBox.Show(message);
        }

        private void btnSaveArtist_Click(object sender, EventArgs e)
        {
            string message = gallery.gallerySaveArtistInfo();
            MessageBox.Show(message);
        }

        private void btnAddArtPiece_Click(object sender, EventArgs e)
        {

            char status = rbtnInStore.Checked ? 'S' : 'D';

            string message = gallery.AddArtPiece(txtArtPieceId.Text, txtArtPieceTittle.Text, Convert.ToInt16(txtArtPieceYear.Text), Convert.ToDouble(txtArtPieceValue.Text), txtArtPieceArtistId.Text, txtArtPieceCuratorId.Text, status);
            MessageBox.Show(message);
            txtArtPieceId.Clear();
            txtArtPieceTittle.Clear();
            txtArtPieceYear.Clear();
            txtArtPieceValue.Clear();
            txtArtPieceArtistId.Clear();
            txtArtPieceCuratorId.Clear();
        }

        private void btnListPieces_Click(object sender, EventArgs e)
        {
            rtxtBox1.Clear();
            string allPieces = gallery.getAllPieces();
            rtxtBox1.AppendText(allPieces);
        }

        private void btnSavePieces_Click(object sender, EventArgs e)
        {
            string message = gallery.gallerySavePieces();
            MessageBox.Show(message);
        }
    }
}
