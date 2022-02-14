using System.ComponentModel;

namespace PROJECTDEVS

{ 
    public class CARDS
    {
        private string TITLE { get; set; }
        private int TIME;
        private string DESCR = string.Empty;
        private int IDc = 0;
        private int IDu = 0;
        private int IDs = 0;
        public enum STATUS
        {
            [Description("A fazer")] Fazer,
            [Description("Em andamento")] Andamento,
            [Description("Finalizado")] Finalizado
        }

    }
}
