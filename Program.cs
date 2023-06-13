using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string primeiro;
                string segundo;
                string endereço;
                string bairro;
                string cidade;
                string estado;

                int passado;
                int viagem;
            int ano = 2022;
            int anos = 2023;
            int total = 2022 + 1;
               
               
            

            Console.WriteLine(" \n\n BEM-VINDO A AGÊNCIA DE VIAGENS CONRAD \n\n ");
            Console.WriteLine(" \n Vamos começar fazendo um cadastro para melhorar seu atendimento! \n ");
            Console.WriteLine(" \n\n --- INFORMAÇÕES CADASTRAIS \n\n ");

            Console.WriteLine($"Digite seu primeiro nome: ");
                primeiro = Console.ReadLine();
            Console.WriteLine($"Agora digite seu sobrenome: ");
                segundo = Console.ReadLine();

            Console.WriteLine($" \n\n Olá, Sr(a). {primeiro} {segundo},vamos continuar seu cadastro... \n\n ");

            Console.WriteLine("Digite seu Endereço:");
                 endereço = Console.ReadLine();
            Console.WriteLine("Bairro:");
                 bairro = Console.ReadLine();
            Console.WriteLine("Cidade:");
                 cidade = Console.ReadLine();
            Console.WriteLine("Estado:");
                 estado = Console.ReadLine();

            Console.WriteLine( $" \n\n O Sr(a) {segundo}, mora na cidade de {cidade}-{estado}, no endereço {endereço},localizado no bairro {bairro} \n\n ");

            Console.WriteLine(" \n -- CONTINUANDO... \n ");
            Console.WriteLine("Quantas viagens você fez no ano passado");
                 passado=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas viagens você planejou fazer esse ano?");
                 viagem=Int32.Parse(Console.ReadLine());
            Console.WriteLine($"TOTAL DE VIAGENS FEITAS: {passado+viagem}");
            Console.WriteLine($"QUANTAS VIAGENS FALTA PARA COMPLETAR 10 VIAGENS AO TODO:{total}");
            ////// ESTUDAR //////
            






















            Console.ReadKey();
        }



    } void Atividade05()
    {

    }
}
