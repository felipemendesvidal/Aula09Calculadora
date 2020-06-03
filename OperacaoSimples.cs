namespace calc
{
    public class OperacaoSimples
    {
        public float numeroX;
        public float numeroY;
        public float resultado;
        public string operador;

        //use o void para não precisar do return, não precisa colocar o tipo de dado quando tem void
        public void Somar(){
            resultado = numeroX + numeroY;
        }

        public void Subtrair(){
            resultado = numeroX - numeroY;
        }

        public void Multiplicar(){
            resultado = numeroX * numeroY;
        }

        public void Dividir(){
            resultado = numeroX / numeroY;
        }
    }
}