namespace HESAPMAKİNESİ
{
    public partial class Form1 : Form
    {
        HesapMakinesi makine = new HesapMakinesi();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //her sayı butonuna tıklandığında anık olarak buradaki değeri bizim lable a göndermemiz gerekiyor.
        }

        private void btn_eşittir_Click(object sender, EventArgs e)
        {
            // her şey buradan classa yönlendirilecek

            int sonuc = makine.Hesaplamaisleri(lbl_işlem.Text);
            lbl_sonuc.Text = sonuc.ToString();
            lbl_işlem.Text = "";
            string gecmisdegeri = makine.gecmisyazdırma();
            lbl_gecmis.Text = gecmisdegeri;
            makine.temizleme();

        }

        private void btn_sıfır_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(0);
            lbl_işlem.Text = label;

        }

        private void btn_bir_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(1);
            lbl_işlem.Text = label;

        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(2);
            lbl_işlem.Text = label;

        }

        private void btn_üç_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(3);
            lbl_işlem.Text = label;

        }

        private void btn_dört_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(4);
            lbl_işlem.Text = label;

        }

        private void btn_beş_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(5);
            lbl_işlem.Text = label;

        }

        private void btn_altı_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(6);
            lbl_işlem.Text = label;

        }

        private void btn_yedi_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(7);
            lbl_işlem.Text = label;

        }

        private void btn_sekiz_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(8);
            lbl_işlem.Text = label;

        }

        private void btn_dokuz_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma(9);
            lbl_işlem.Text = label;

        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma('+');
            lbl_işlem.Text = label;
            makine.islemturu = 1;
        }

        private void btn_çıkarma_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma('-');
            lbl_işlem.Text = label;
            makine.islemturu = 2;
        }

        private void btn_çarpma_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma('x');
            lbl_işlem.Text = label;
            makine.islemturu = 3;
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            string label = makine.labelyazdırma('/');
            lbl_işlem.Text = label;
            makine.islemturu = 4;
        }

        private void btn_sonişlemsilme_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = "";
            makine.temizleme();
            ///////////////////////////////////////////
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            makine.işlemkactayız();
        }

        private void btn_geçmişişlemsilme_Click(object sender, EventArgs e)
        {
            makine.gecmissilme();
            lbl_gecmis.Text = "";
        }

        private void lbl_işlem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_gecmis_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
