using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

using System.Runtime.InteropServices;

namespace Clasificacion_Texturas
{
    
    public partial class Form2 : Form
    {
        int cR, cG, cB;
        int rtx, btx, gtx;
        int rnrc,rngc,rnbc;
        int idr;

        public Bitmap bmpg;
        public Bitmap bmpt;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Bitmap bm, Bitmap bt)
        {
            InitializeComponent();
            bmpg = bm;
            bmpt = bt;
            pictureBox1.Image = bm;

        }
        public void select2() {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;User Id=postgres;Password=root;Database=TextureColors");
            con.Open();
            String sql = "select * from textura";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();



            while (rdr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                dataGridView1.Rows[n].Cells[2].Value = rdr.GetInt32(2);
                dataGridView1.Rows[n].Cells[3].Value = rdr.GetInt32(3);
                dataGridView1.Rows[n].Cells[4].Value = rdr.GetInt32(4);

                dataGridView1.Rows[n].Cells[5].Value = rdr.GetInt32(5);
                dataGridView1.Rows[n].Cells[6].Value = rdr.GetInt32(6);
                dataGridView1.Rows[n].Cells[7].Value = rdr.GetInt32(7);

            }
            con.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=TextureColors");
            con.Open();
            int id = Int32.Parse(dataGridView1.Rows[idr].Cells[0].Value + "");
            
            String sql = $"delete from textura where id = {id}";

            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            
            select2();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idr = e.RowIndex;

            String nom = dataGridView1.Rows[idr].Cells[1].Value + "";
            String rt = dataGridView1.Rows[idr].Cells[2].Value + "";
            String gt = dataGridView1.Rows[idr].Cells[3].Value + "";
            String bt = dataGridView1.Rows[idr].Cells[4].Value + "";
            String rc = dataGridView1.Rows[idr].Cells[5].Value + "";
            String gc = dataGridView1.Rows[idr].Cells[6].Value + "";
            String bc = dataGridView1.Rows[idr].Cells[7].Value + "";



            nomText.Text = nom;
            Rcol.Text = rc;
            Gcol.Text = gc;
            Bcol.Text = bc;

            rtxtr.Text = rt;
            gtxrt.Text = gt;
            btxtr.Text = bt;



        }

        public void clear() {
            nomText.Text = "";
            Rcol.Text = "";
            Gcol.Text = "";
            Bcol.Text = "";

            rtxtr.Text = "";
            gtxrt.Text = "";
            btxtr.Text = "";
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=TextureColors");
            con.Open();
            int id = Int32.Parse(dataGridView1.Rows[idr].Cells[0].Value + "");
            String nom = nomText.Text;
            String rc = Rcol.Text;
            String gc = Gcol.Text;
            String bc = Bcol.Text;
            String rt = rtxtr.Text;
            String gt = gtxrt.Text;
            String bt = btxtr.Text;

            String sql = $"update textura set nombre = '{nom}', rtext = {rt}, gtext = {gt}, btext = {bt}, rcolor = {rc}, gcolor = {gc}, bcolor = {bc} where id = {id}";
            
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            
            select2();
            clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }



        public List<String[]> select()
        {
            List<String[]> textures = new List<String[]>();


            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=TextureColors");
            con.Open();
            String sql = "select * from textura";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                String[] txr = new String[8];
                txr[0] = rdr.GetInt32(0) + "";
                txr[1] = rdr.GetString(1) + "";
                txr[2] = rdr.GetInt32(2) + "";
                txr[3] = rdr.GetInt32(3) + "";
                txr[4] = rdr.GetInt32(4) + "";
                txr[5] = rdr.GetInt32(5) + "";
                txr[6] = rdr.GetInt32(6) + "";
                txr[7] = rdr.GetInt32(7) + "";

                textures.Add(txr);
            }

            con.Close();


            return textures;
        }
        private void button6_Click(object sender, EventArgs e)
        {

            Bitmap bmp2 = new Bitmap(bmpg.Width, bmpg.Height);
            List<String[]> textures = select();


            int ciR, ciG, ciB;
            Color c = new Color();
            int interv = 10;

            for (int i = 0; i < bmpt.Width; i++)
            {
                for (int j = 0; j < bmpt.Height; j++)
                {

                    c = bmpg.GetPixel(i, j);
                    int[] cls = { c.R, c.G, c.B };

                    foreach (String[] k in textures)
                    {
                        bool sw = true;
                        int r = Int32.Parse(k[2]);
                        int g = Int32.Parse(k[3]);
                        int b = Int32.Parse(k[4]);
                        int[] clText = { r, g, b };

                        for (int l = 0; l < clText.Length; l++)
                        {
                            if (!(clText[l] - interv < cls[l] && cls[l] < clText[l] + interv))
                            {
                                sw = false;
                                break;
                            }

                        }

                        if (sw)
                        {
                            int rc = Int32.Parse(k[5]);
                            int gc = Int32.Parse(k[6]);
                            int bc = Int32.Parse(k[7]);


                            Color clr = Color.FromArgb(rc, gc, bc);
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, clr);
                                }

                            break;

                        }
                        else
                        {
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, c);
                                }
                        }
                    }

                }
            }
            pictureBox1.Image = bmp2;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            select2();
            dataGridView1.ClearSelection();


           
            List<String[]> textures = select();
            ListViewGroup texturas = new ListViewGroup("Nombre Textura");
            foreach (String[] i in textures)
            {
                ListViewItem l = new ListViewItem(i[1], texturas);
                int r = Int32.Parse(i[5]);
                int g = Int32.Parse(i[6]);
                int b = Int32.Parse(i[7]);

                l.BackColor = Color.FromArgb(r, g, b);
                l.ForeColor = Color.White;

                listView1.Items.Add(l);
            }


            listView1.Groups.Add(texturas);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=TextureColors");
            con.Open();

            String nom = nomText.Text;
            String rc = Rcol.Text;
            String gc = Gcol.Text;
            String bc = Bcol.Text;
            String rt = rtxtr.Text;
            String gt = gtxrt.Text;
            String bt = btxtr.Text;

            String sql = $"insert into textura(nombre,	rtext,gtext,btext,rcolor,gcolor,bcolor) values ('{nom}',{rt},{gt}, {bt},{rc}, {gc},{bc})";

            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            
            select2();
            clear();

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileName = data as String[];
                if (fileName.Length > 0)
                {
                    Bitmap bmp = new Bitmap(fileName[0]);
                    pictureBox1.Image = bmp;
                    bmpg = new Bitmap(fileName[0]);
                    calcular();
                }
            }

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            rtx = btx = gtx = 0;

            for (int i = e.X; i < e.X + 5; i++)
                for (int j = e.Y; j < e.Y + 5; j++)
                {
                    c = bmp.GetPixel(i, j);
                    rtx += c.R;
                    gtx += c.G;
                    btx += c.B;
                }
            rtx /= 25;
            gtx /= 25;
            btx /= 25;
            rtxtr.Text = rtx.ToString();
            gtxrt.Text = gtx.ToString();
            btxtr.Text = btx.ToString();

            if (Rcol.Text == "" && Gcol.Text == "" && Bcol.Text == "") {
                Random rnd = new Random();
                rnrc = rnd.Next(256);
                rngc = rnd.Next(256);
                rnbc = rnd.Next(256);
                Rcol.Text = rnrc.ToString();
                Gcol.Text = rngc.ToString();
                Bcol.Text = rnbc.ToString();
            }

        }


        public void calcular()
        {
            int n = 5;
            int n2 = n * n;

            bmpt = new Bitmap(bmpg.Width - n, bmpg.Height - n);

            int ciR, ciG, ciB;
            Color c = new Color();

            for (int i = 0; i < bmpg.Width - n; i++)
            {
                for (int j = 0; j < bmpg.Height - n; j++)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;

                    for (int x = i; x < i + n; x++)
                        for (int y = j; y < j + n; y++)
                        {
                            c = bmpg.GetPixel(x, y);
                            ciR += c.R;
                            ciG += c.G;
                            ciB += c.B;
                        }
                    ciR /= n2;
                    ciG /= n2;
                    ciB /= n2;

                    bmpt.SetPixel(i, j, Color.FromArgb(ciR, ciG, ciB));

                }
            }


        }

    }   
}
