using System;



public class Pessoa
{

    public double peso;
    public double altura;


    //Método CalculoImc
    public double CalculoImc()
    {
        return peso / (altura * altura);
    }
    //Método Verificador
    public string  VerificadorImc(double imc)
    {
        if (imc < 18.5)
        {

            return "Abaixo do Peso";

        }
        else if (imc < 25)
        {


            return  "Peso Normal";

        }
        else if (imc < 30)
        {


            return  "Acima do peso";

        }
        else if (imc < 35)
        {


            return  "Obesidade I";

        }
        else if (imc < 40)
        {

            return  "Obesidade II";

        }
        else  
        {

            return  "Obesidade II";

        }

    }

    //Método Mensagem
    
    public void Mensagem()
    {
        Double obterPeso = peso;
        Double obterAltura = altura;
        Double obterImc = CalculoImc();
        String obterVerificacao = VerificadorImc(obterImc);

        Console.WriteLine("Seu peso é: {0} \n Sua altura é: {1} \n Seu IMC é de {2} - {3} ", obterPeso, obterAltura , obterImc , obterVerificacao);




    }


}
