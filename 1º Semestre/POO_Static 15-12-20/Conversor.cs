namespace POO_Static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;

        private static float cotacaoEuro = 6.2f;

        public static float valorUsuario;

        public static float DolarPraReal(float valorRS)
        {
            return valorRS * cotacaoDolar;
        }

        public static float RealPraDolar(float valorUS)
        {
            return valorUS / cotacaoDolar;
        }

        public static float EuroPraReal(float valorRS)
        {
            return valorRS * cotacaoEuro;
        }

        public static float RealPraEuro(float valorEuro)
        {
            return valorEuro / cotacaoEuro;
        }
    }
}