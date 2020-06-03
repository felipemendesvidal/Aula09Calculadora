namespace calc
{
    public class Media : OperacaoSimples
    {
        //criação de vetor
        private string [] valor;
        private float valor2;
        private float soma;

        //metodo analisa a string digitada para fazer uma analise no vetor
        public void calcMedia(string txtConsole){
            //Esse é um metodo da classe string, que faz a separação de uma cadeia de caractere 
            //ele retorna um array de string
            //voce define onde vai quebrar se é no espaco ou escole outra
            valor = txtConsole.Split(",");

            //analise do array de acordo com o seu tamanho definido no length
            for(int indice = 0; indice < valor.Length; indice++){
                valor2 = float.Parse(valor[indice]);
                soma += valor2; // soma = soma + valor2;
            }
            //retorna na variavel resultado o valor da media
            resultado = soma / valor.Length;
        }

        //metodo que faz realmente os calculos
        public void ManipularCalculos(string entradaUsuarios){

            //dividindo a entrada do usuario em varias posiçoes
            string[] entrada = entradaUsuarios.Split(' ');

            // Pegamos as entradas separada e atribuímos às nossas vairáveis 
            // entrada[0] = usuario digita
            // entrada[1] = +
            // entrada[2] = usuario digita
             
            numeroX = float.Parse(entrada[0]);
            operador = entrada[1];
            numeroY = float.Parse(entrada[2]);

            //obrigando o null virar +
             if(entrada[1] == null){
                entrada = entradaUsuarios.Split('+');
                if(entrada[1] != null){
                    operador = "+";
                }

                //analisando operador para atribuir as funções
                switch(operador){
                    case "+":
                        Somar();
                    break;

                    case "-":
                        Subtrair();
                    break;

                    case "x":
                        Multiplicar();
                    break;

                    case "/":
                        Dividir();
                    break;

                    default:
                        Somar();
                    break;
                }
            }   
        }
    }
}