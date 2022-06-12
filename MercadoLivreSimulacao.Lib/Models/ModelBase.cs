namespace MercadoLivreSimulacao.Lib.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public bool DataEMaiorQueDataAtual(DateTime data)
        {
            if (data > DateTime.Now)
            {
                return true;
            }
            return false;
        }
        public virtual void SetEmail(string email)
        {
            if (EmailContemArroba(email))
            {
               
            }
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