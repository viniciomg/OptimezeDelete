namespace OptimizeDelete
{
    public sealed class BancoDados
    {
        static BancoDados _instancia;
        public static BancoDados Instancia
        {
            get { return _instancia ?? (_instancia = new BancoDados()); }
        }
        private BancoDados() { }
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

    }
}
