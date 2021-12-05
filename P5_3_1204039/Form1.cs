using System.Text.RegularExpressions;

namespace P5_3_1204039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 298);
        }

        private void PilihMatkulButton_Click(object sender, EventArgs e)
        {
            if (NimTextBox.Text != "")
            {
                if (NamaTextBox.Text != "")
                {
                    if (LakiRB.Checked || PerempuanRB.Checked)
                    {
                        if (AlamatTextBox.Text != "")
                        {
                            if (ProdiComboBox.Text != "– Pilih Program Studi –")
                            {
                                if (TahunAkademikTextBox.Text != "" && Regex.IsMatch(TahunAkademikTextBox.Text, @"^\d{4}/\d{4}$"))
                                {
                                    if (SemesterTextBox.Text != "")
                                    {
                                        MessageBox.Show
                                                    ("Lengkap!",
                                                    "Informasi Data Submit",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(816, 640);

                                    } else
                                    {
                                        MessageBox.Show
                                                    ("Semester belum diisi!",
                                                    "Informasi Data Submit",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                } else
                                {
                                    if (TahunAkademikTextBox.Text != "")
                                    {
                                        if (Regex.IsMatch(TahunAkademikTextBox.Text, @"^\d{4}/\d{4}$"))
                                        {
                                            errorProvider1.SetError(TahunAkademikTextBox, "");
                                        }
                                        else
                                        {
                                            errorProvider1.SetError(TahunAkademikTextBox, "Format Tahun Akademik Salah!");
                                            MessageBox.Show
                                                ("Format Tahun Akademik Salah!",
                                                "Informasi Data Submit",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    } else
                                    {
                                        MessageBox.Show
                                                ("Tahun Akademik belum diisi!",
                                                "Informasi Data Submit",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }                                  
                                }
                            } else
                            {
                                MessageBox.Show
                                            ("Program Studi belum diisi!",
                                            "Informasi Data Submit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        } else
                        {
                            MessageBox.Show
                                        ("Alamat belum diisi!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else
                    {
                        MessageBox.Show
                                    ("Jenis Kelamin belum diisi!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                                ("Nama belum diisi!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show
                            ("NIM belum diisi!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (TahunAkademikTextBox.Text != "")
            {
                if (Regex.IsMatch(TahunAkademikTextBox.Text, @"^\d{4}/\d{4}$"))
                {
                    errorProvider1.SetError(TahunAkademikTextBox, "");
                }
                else
                {
                    errorProvider1.SetError(TahunAkademikTextBox, "Format Tahun Akademik Salah!");
                }
            }
            else
            {
                errorProvider1.SetError(TahunAkademikTextBox, "Wajib Diisi");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Kur06RB.Checked)
            {
                MatematikaCB.Enabled = true; MatematikaCB.Checked = false;
                Pemrog1CB.Enabled = true; Pemrog1CB.Checked = false;
                Pemrog2CB.Enabled = true; Pemrog2CB.Checked = false;
                Pemrog3CB.Enabled = true; Pemrog3CB.Checked = false;
                Pemrog4CB.Enabled = true; Pemrog4CB.Checked = false;
                Pemrog5CB.Enabled = true; Pemrog5CB.Checked = false;
                Pemrog6CB.Enabled = true; Pemrog6CB.Checked = false;
                Pemrog7CB.Enabled = true; Pemrog7CB.Checked = false;
                JarkomCB.Enabled = true; JarkomCB.Checked = false;
                SisOpCB.Enabled = true; SisOpCB.Checked = false;
                PLCB.Enabled = false; PLCB.Checked = false;
                MRPCB.Enabled = false; MRPCB.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MatematikaCB.Enabled = false; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = true; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = true; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = true; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = true; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = true; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = true; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = true; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = true; JarkomCB.Checked = false;
            SisOpCB.Enabled = true; SisOpCB.Checked = false;
            PLCB.Enabled = false; PLCB.Checked = false;
            MRPCB.Enabled = true; MRPCB.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MatematikaCB.Enabled = false; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = true; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = true; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = true; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = true; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = true; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = true; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = true; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = true; JarkomCB.Checked = false;
            SisOpCB.Enabled = true; SisOpCB.Checked = false;
            PLCB.Enabled = true; PLCB.Checked = false;
            MRPCB.Enabled = false; MRPCB.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenisKelamin = null;
            if (LakiRB.Checked)
            {
                jenisKelamin = LakiRB.Text;
            } else if (PerempuanRB.Checked)
            {
                jenisKelamin = PerempuanRB.Text;
            }

            string kurikulum = null;
            if (Kur06RB.Checked)
            {
                kurikulum = Kur06RB.Text;
            }
            else if (Kur10RB.Checked)
            {
                kurikulum = Kur10RB.Text;
            }
            else if (Kur14RB.Checked)
            {
                kurikulum = Kur14RB.Text;
            }

            string matkul = null;
            if (MatematikaCB.Checked)
            {
                matkul += MatematikaCB.Text + ", ";
            }
            if (Pemrog1CB.Checked)
            {
                matkul += Pemrog1CB.Text + ", ";
            }
            if (Pemrog2CB.Checked)
            {
                matkul += Pemrog2CB.Text + ", ";
            }
            if (Pemrog3CB.Checked)
            {
                matkul += Pemrog3CB.Text + ", ";
            }
            if (Pemrog4CB.Checked)
            {
                matkul += Pemrog4CB.Text + ", ";
            }
            if (Pemrog5CB.Checked)
            {
                matkul += Pemrog5CB.Text + ", ";
            }
            if (Pemrog6CB.Checked)
            {
                matkul += Pemrog6CB.Text + ", ";
            }
            if (Pemrog7CB.Checked)
            {
                matkul += Pemrog7CB.Text + ", ";
            }
            if (PLCB.Checked)
            {
                matkul += PLCB.Text + ", ";
            }
            if (JarkomCB.Checked)
            {
                matkul += JarkomCB.Text + ", ";
            }
            if (SisOpCB.Checked)
            {
                matkul += SisOpCB.Text + ", ";
            }
            if (MRPCB.Checked)
            {
                matkul += MRPCB.Text + ", ";
            }

            MessageBox.Show
                        ("NIM: "+NimTextBox.Text+
                        "\nNama: "+NamaTextBox.Text+
                        "\nJenis Kelamin: " + jenisKelamin+
                        "\nAlamat: " + AlamatTextBox.Text+
                        "\nProgram Studi: " + ProdiComboBox.Text+
                        "\nTahun Akademik: " + TahunAkademikTextBox.Text+
                        "\nSemester: " + SemesterTextBox.Text+
                        "\n=================================="+
                        "\nKurikulum: " + kurikulum+
                        "\nMata Kuliah: " + matkul,
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NimTextBox.Text = null;
            NamaTextBox.Text = null;
            LakiRB.Checked = false;
            PerempuanRB.Checked = false;
            AlamatTextBox.Text = null;
            ProdiComboBox.Text = null;
            TahunAkademikTextBox.Text = null;
            SemesterTextBox.Text = null;

            Kur06RB.Checked = false;
            Kur10RB.Checked = false;
            Kur14RB.Checked = false;

            MatematikaCB.Enabled = false; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = false; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = false; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = false; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = false; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = false; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = false; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = false; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = false; JarkomCB.Checked = false;
            SisOpCB.Enabled = false; SisOpCB.Checked = false;
            PLCB.Enabled = false; PLCB.Checked = false;
            MRPCB.Enabled = false; MRPCB.Checked = false;

            this.Size = new Size(816, 298);

            MessageBox.Show
                        ("Form telah direset",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}