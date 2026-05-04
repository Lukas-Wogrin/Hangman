namespace Aufgabe31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        string wort;
        string auswahl;
        int versuch = 10;
        string falscheBuchstabe;
        private void button2_Click(object sender, EventArgs e)
        {
            string[] strArry = new string[10]
            {
                new string ("Haus"),
                new string ("Katze"),
                new string ("Familienwohnung"),
                new string ("Stuhl"),
                new string ("Tisch"),
                new string ("Golf"),
                new string ("Strom"),
                new string ("Handy"),
                new string ("Maus"),
                new string ("Computer"),
            };

            auswahl = strArry[rnd.Next(0, 9)];

            wort = "";

            for (int i = 0; i < auswahl.Length; i++)
            {
                wort += "_";
            }

            lbWort.Text = wort;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (auswahl == null)
                return;

            char buchstabe = Convert.ToChar(txtEingabe.Text);
            char[] wortArray = wort.ToCharArray();
            lbVerbleib.Text = Convert.ToString(versuch);
            bool drinnen = false;


            if (versuch > 0)
            {
                for (int i = 0; i < auswahl.Length; i++)
                {
                    if (buchstabe == auswahl[i])
                    {
                        wortArray[i] = buchstabe;
                        drinnen = true;
                    }
                }
                if (drinnen == false)
                {
                    versuch--;
                    lbVerbleib.Text = Convert.ToString(versuch);
                    falscheBuchstabe += Convert.ToString(buchstabe) + ", ";
                    //picBox.Image = System.Drawing.Image.FromFile("bildxx.png");
                    drinnen = true;
                    lbFalsch.Text = falscheBuchstabe;
                }
            }
            else if (Convert.ToInt32(lbVerbleib) == 0)
            {
                lbWort.Text = "VERLOREN";
            }

            wort = new string(wortArray);
            lbWort.Text = wort;
        }
    }
}
