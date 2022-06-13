namespace MercadoLivreSimulacao.Lib.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public bool DataEMenorQueDataAtual(DateTime data)
        {
            if (data < DateTime.Now)
            {
                return true;
            }
            return false;
        }
 
        public bool EmailContemArroba(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            return false;
        }

    }
}