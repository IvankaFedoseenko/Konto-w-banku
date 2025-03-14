namespace Bank
{
    public class Konto
    {
        private string klient;  //nazwa klienta
        private decimal bilans;  //aktualny stan środków na koncie
        private bool zablokowane = false; //stan konta
        public string Nazwa { get { return klient; } }
        public decimal Bilans { get { return bilans; } }
        public bool Zablokowane { get { return zablokowane; } }

        private Konto() { }
        public Konto(string klient, decimal bilansNaStart = 0)
        {
            this.klient = klient;
            bilans = bilansNaStart;
        }
        public void Wplata(decimal kwota)
        {
            if(kwota <= 0)
                throw new ArgumentException("Kwota musi być dodatnia");
            if(zablokowane)
                throw new ArgumentException("Konto jest zabłokowane");
            else
            bilans += kwota;
        }
        public void Wypłata(decimal kwota)
        {
            if(kwota <= 0) 
            throw new ArgumentException("Kwota musi być dodatnia");
            if (zablokowane)
                throw new ArgumentException("Konto jest zabłokowane");
            if (kwota > bilans)
                throw new ArgumentException("Nie ma wystarczająco pieniędzy na koncie");
            else
                bilans -= kwota;
        }
        public void BlokujKonto()
        {
            zablokowane = true;
        }
        public void OdblokujKonto()
        {
            zablokowane = false;
        }

    }
}
