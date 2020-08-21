namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            teste.MetodoInterno();
            // teste.MetodoPrivado();
            // teste.MetodoProtegido();
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoPublico();
            MetodoPublico();
            // MetodoPrivado();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            // Visível apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            // Visível apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            // Visível apenas para o projeto ByteBank.Modelos!
        }
    }
}
