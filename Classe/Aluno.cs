    using System;

    namespace AtividadeAlunos.Classe
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;

        public void verMediaFinal(double media) {
            Console.WriteLine($"A média do aluno é:{media}");
        }

        public void VerMensalidade(bool temBolsa, double mensalidade) {
            if(temBolsa == true){
                Console.WriteLine("Esse aluno é bolsista.");
                Console.WriteLine($"Mensalidade sem desconto: {mensalidade}");

                Console.WriteLine($"Mensalidade com desconto: {0.7* mensalidade}");

            }else
                Console.WriteLine("Esse aluno NÃO é bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");
            }   
        }
    }
