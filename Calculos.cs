namespace AulaPOOOverload
{
    public class Calculos
    {
        public string Calcular() {
            return "Não há o que calcular.";
        }

        public string Calcular(int num1) {
            return num1+" ao quadrado é "+(num1*num1)+".";
        }

        public string Calcular(int num1, int num2) {
            return num1+" dividido por "+num2+" é "+(num1/num2)+".";
        }

        public string Calcular(string num1, string num2) {
            return "O primeiro número escolhido foi "+num1+", e o segundo foi "+num2+".";
        }

    }
}