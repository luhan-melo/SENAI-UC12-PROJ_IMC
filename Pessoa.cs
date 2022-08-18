namespace UC12_Projeto_IMC
{
    public class Pessoa
    {
        public double peso { get; set; }

        public double altura { get; set; }

        public double imc {get; set;}


        public Pessoa(double argPeso, double argAltura){
            this.peso = argPeso;
            this.altura = argAltura;
            this.imc = calcularIMC(this.peso, this.altura);

        }

        //public double imc {get; set;}

        public double calcularIMC(double argPeso, double argAltura)
        {
            double resultado = argPeso / (argAltura * argAltura);
            return resultado;
        }
        public string classificarIMC(double argIMC){

            string classificacao;

            if(argIMC<18.5){
                classificacao ="abaixo do peso";
            }
            else if (argIMC >= 18.5 && argIMC <25){
            classificacao = "peso normal";
            }
            
            else if (argIMC >= 25 && argIMC <30) {
                classificacao = "sobrepeso";
            }

            else if (argIMC >= 30 && argIMC <35) {
                classificacao = "obesidade I";
            }

            else if (argIMC >= 35 && argIMC <40) {
                classificacao = "obesidade II";
            }

            else{
                classificacao = "obesidade III";
            }
            
            return classificacao;

        }

    }
}