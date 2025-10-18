using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeData_GridWiew
{
    public partial class Form1 : Form
    {
        Database DB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            DB = db;
            List<Musteri> musteriListe = db.MusteriListele();

            // 1. Data bize lazım ama kullanıcıya göstermek istemiyoruz
            dgwMusteriListe.DataSource = musteriListe;
            dgwMusteriListe.Columns[0].Visible = false;
            dgwMusteriListe.Columns["id"].Visible = true;

            dgwMusteriListe.Columns.Clear();

            // 2. Data bize lazım değil. Göstermeye de gerek yok
            var dgwListe = from I in musteriListe select new
            {
                id = I.id,
                isim = I.isim,
                soyisim = I.soyisim,
                tamAdi = I.tamAdi,
                Email = I.Email
            };
            dgwMusteriListe.DataSource = dgwListe.ToList();

            // data gridwiew içerisinde bulunan kolonların isimlerini değiştrimek
            dgwMusteriListe.Columns[0].HeaderText = "Müşteri isim";
            dgwMusteriListe.Columns[1].HeaderText = "Müşteri soyisim";
            dgwMusteriListe.Columns[2].HeaderText = "Müşteri tam isim";
            dgwMusteriListe.Columns[3].HeaderText = "Müşteri E-postasi";
            dgwMusteriListe.Columns[3].Width = 200;
        }

        private void dgwMusteriListe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Guid musteriID = (Guid)dgwMusteriListe[0, dgwMusteriListe.CurrentCell.RowIndex].Value;
            // MessageBox.Show(musteriID.ToString(), "seçilen veri id", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Musteri bulunanmusteri = DB.MusteriListele().FindAll(i=> i.id == musteriID).FirstOrDefault();
            Form popup = new PopupMessage(bulunanmusteri);
            popup.ShowDialog();
        }
    }
}
