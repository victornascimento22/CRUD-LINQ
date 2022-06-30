using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Caminhao> caminhao = new List<Caminhao> {

            new Caminhao {Id = 1, Modelo = "Scania", Placa = "8528"},
            new Caminhao {Id = 2, Modelo = "Ford", Placa = "5825"},
            new Caminhao {Id = 3, Modelo = "Scania", Placa ="8687"}

            };

            List<Motorista> motorista = new List<Motorista> {

                new Motorista {Id = 1, Nome = "Roberto", Endereco = "Quinto dos Infernos"},
                new Motorista {Id = 2, Nome = "Joriscleide", Endereco = "Logo ali"},
                new Motorista {Id = 3, Nome = "Ronaldinho Bruxo", Endereco = "Fabrica de Horrorosos"}

            };

            List<Viagem> viagem = new List<Viagem>();

            MenuPrincipal(caminhao, motorista, viagem);
        }

        static void MenuPrincipal(List<Caminhao> caminhao, List<Motorista> motorista, List<Viagem> viagem)
        {
            int opcao;

            do
            {

                Console.WriteLine("1 - Cadastro 2 - Atualizar 3 - Remover 0 - Finalizar o programa");
                Console.Write("Opcão : ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        {

                            MenuCadastro(caminhao, motorista, viagem);
                        }
                        break;

                    case 2:
                        {

                            MenuAtualizar(caminhao, motorista, viagem);

                        }
                        break;

                    case 3:
                        {

                            MenuRemover(caminhao, motorista, viagem);


                        }
                        break;
                    case 0:
                        {

                            Console.ReadKey();
                            break;
                        }
                }

            } while (opcao == 0);

        }

        static void MenuCadastro(List<Caminhao> caminhao, List<Motorista> motorista, List<Viagem> viagem)
        {
            int opcao;
            do
            {

                Console.WriteLine("1 - Cadastrar Caminhao 2 - Cadastrar Motorista 3 - Cadastrar Viagem 0 - Retornar ao Menu Principal ");
                Console.Write("Opcão : ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        {

                            CadastrarCaminhao(caminhao, motorista, viagem);

                        }
                        break;
                    case 2:
                        {
                            CadastrarMotorista(caminhao, motorista, viagem);
                        }
                        break;
                    case 3:
                        {
                            CadastrarViagem(viagem, motorista, caminhao);
                        }
                        break;
                    case 0:
                        {

                            MenuCadastro(caminhao, motorista, viagem);
                        }
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuAtualizar(List<Caminhao> caminhao, List<Motorista> motorista, List<Viagem> viagem)
        {

            int opcao;

            do
            {

                Console.WriteLine("1 - Atualizar Motora 2 - Atualizar Caminhao 3 - Atualizar Viagem 0 - Finalizar o programa");
                Console.Write("Opcão : ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        {
                            AtualizarMotorista(viagem, motorista, caminhao);

                        }
                        break;

                    case 2:
                        {

                            AtualizarCaminhao(viagem, motorista, caminhao);

                        }
                        break;

                    case 3:
                        {
                            AtualizarViagem(viagem, motorista, caminhao);

                        }
                        break;
                    case 0:
                        {

                            Console.ReadKey();
                            break;
                        }
                }

            } while (opcao == 0);



        }

        static void MenuRemover(List<Caminhao> caminhao, List<Motorista> motorista, List<Viagem> viagem)
        {

            int opcao;

            do
            {

                Console.WriteLine("1 - Remover Motorista 2 - Remover Caminhao 3 - Remover Viagem 0 - Finalizar o programa");
                Console.Write("Opcão : ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        {

                            RemoverMotorista(viagem, caminhao, motorista);
                        }
                        break;

                    case 2:
                        {

                            RemoverCaminhao(viagem, caminhao, motorista);

                        }
                        break;

                    case 3:
                        {

                            RemoverViagem(viagem, caminhao, motorista);

                        }
                        break;
                    case 0:
                        {

                            Console.ReadKey();
                            break;
                        }
                }

            } while (opcao == 0);

        }

        private static void CadastrarCaminhao(List<Caminhao> caminhao, List<Motorista> motorista, List<Viagem> viagem)
        {

            Console.Write("Digite o ID do Caminhao : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o modelo do Caminhao : ");
            string modelo = Console.ReadLine();
            Console.Write("Digite a placa do Caminhao : ");
            string placa = Console.ReadLine();

            Caminhao novocaminhao = new Caminhao { Id = id, Modelo = modelo, Placa = placa };

            caminhao.Add(novocaminhao);

            Console.WriteLine("Caminhao adicionado a lista com sucesso");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            MenuCadastro(caminhao, motorista, viagem);

        }

        private static void CadastrarMotorista(List<Caminhao> caminhao, List<Motorista> motorista, List<Viagem> viagem)
        {

            Console.Write("Digite o ID do Motorista : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do Motorista : ");
            string nome = Console.ReadLine();
            Console.Write("Digite o endereço do Motorista : ");
            string end = Console.ReadLine();

            Motorista novomotorista = new() { Id = id, Nome = nome, Endereco = end };

            motorista.Add(novomotorista);

            Console.WriteLine("Motorista adicionado a lista com sucesso");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            MenuCadastro(caminhao, motorista, viagem);

        }

        public static void CadastrarViagem(List<Viagem> viagem, List<Motorista> motorista, List<Caminhao> caminhao)
        {

            if (motorista == null && caminhao == null)
            {
                Console.WriteLine("Para realizar o cadastro da viagem, é necessário ter um motorista e um caminhao cadastrado.");
                MenuCadastro(caminhao, motorista, viagem);
            }

            Console.Write("Digite o ID da Viagem : ");
            int id = Convert.ToInt32(Console.ReadLine());

            var caminhaoSelecionado = BuscarCaminhao(caminhao);
            var motoristaSelecionado = BuscarMotorista(motorista);

            Viagem novaviagem = new Viagem { Id = id, Caminhao = caminhaoSelecionado, Motorista = motoristaSelecionado };
            viagem.Add(novaviagem);
            MenuCadastro(caminhao, motorista, viagem);

        }

        public static Motorista BuscarMotorista(List<Motorista> motorista)
        {

            Console.WriteLine("Digite o nome do Motorista da Viagem");
            string nome = Console.ReadLine();

            var motoristaEncontrado = (from p in motorista
                                       where p.Nome == nome
                                       select p).FirstOrDefault();

            if (motoristaEncontrado == null)
            {
                Console.WriteLine("Motorista inválido");
            }
            return motoristaEncontrado;

        }

        public static Caminhao BuscarCaminhao(List<Caminhao> caminhao)
        {

            Console.WriteLine("Digite o nome do Modelo do Caminhao da Viagem");
            string nome = Console.ReadLine();
            var caminhaoEncontrado = (from p in caminhao
                                      where p.Modelo == nome
                                      select p).FirstOrDefault();

            if (caminhaoEncontrado == null)
            {
                Console.WriteLine("Caminhao inválido");
            }

            return caminhaoEncontrado;

        }

        public static Motorista AtualizarMotorista(List<Viagem> viagem, List<Motorista> motorista, List<Caminhao> caminhao)
        {

            Console.WriteLine("Digite o ID do Motorista que deseja atualizar");
            int idAux = Convert.ToInt32(Console.ReadLine());

            Motorista motoristaAtualizado = motorista.FirstOrDefault(a => a.Id == idAux);

            if (motoristaAtualizado != null)
            {
                Console.WriteLine("Qual o novo nome? ");
                string nome = Console.ReadLine();
                motoristaAtualizado.Nome = nome;

                Console.WriteLine("Qual o novo nome? ");
                string endereco = Console.ReadLine();
                motoristaAtualizado.Endereco = endereco;

                Console.WriteLine("Motorista atualizando com sucesso.");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                MenuAtualizar(caminhao, motorista, viagem);

            }
            else
            {
                Console.WriteLine("Motorista Inválido");

            }

            MenuAtualizar(caminhao, motorista, viagem);
            return motoristaAtualizado;
        }

        public static Caminhao AtualizarCaminhao(List<Viagem> viagem, List<Motorista> motorista, List<Caminhao> caminhao)
        {

            Console.WriteLine("Digite o ID do Caminhao que deseja atualizar");
            int idAux = Convert.ToInt32(Console.ReadLine());

            Caminhao caminhaoAtualizado = caminhao.FirstOrDefault(a => a.Id == idAux);

            if (caminhaoAtualizado != null)
            {
                Console.WriteLine("Qual o novo Modelo? ");
                string nome = Console.ReadLine();
                caminhaoAtualizado.Modelo = nome;

                Console.WriteLine("Qual a nova Placa? ");
                string endereco = Console.ReadLine();
                caminhaoAtualizado.Placa = endereco;

                Console.WriteLine("Caminhao atualizado com sucesso.");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Caminhão Inválido");

            }
            MenuAtualizar(caminhao, motorista, viagem);
            return caminhaoAtualizado;

        }

        public static Viagem AtualizarViagem(List<Viagem> viagem, List<Motorista> motorista, List<Caminhao> caminhao)
        {

            Console.WriteLine("Digite o ID da viagem que deseja atualizar");
            int idAux = Convert.ToInt32(Console.ReadLine());

            Viagem viagemAtualizada = viagem.FirstOrDefault(a => a.Id == idAux);

            if (viagemAtualizada != null)
            {
                Console.WriteLine("Qual o nome do Motorista que deseja alterar? ");

                viagemAtualizada.Motorista = BuscarMotorista(motorista);

                Console.WriteLine("Qual é o caminhao que deseja alterar ?");

                viagemAtualizada.Caminhao = BuscarCaminhao(caminhao);

                Console.WriteLine("Viagem atualizado com sucesso.");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                MenuAtualizar(caminhao, motorista, viagem);
                return viagemAtualizada;

            }
            else
            {
                Console.WriteLine("Viagem Inválida");
                MenuAtualizar(caminhao, motorista, viagem);
                return viagemAtualizada;
            }

        }

        public static void RemoverMotorista(List<Viagem> viagem, List<Caminhao> caminhao, List<Motorista> motorista)
        {

            Console.WriteLine("Digite o ID do motorista que deseja remover");
            int idAux = Convert.ToInt32(Console.ReadLine());

            var motoristaRemovido = motorista.RemoveAll(s => s.Id == idAux);
            MenuRemover(caminhao, motorista, viagem);

        }

        public static void RemoverCaminhao(List<Viagem> viagem, List<Caminhao> caminhao, List<Motorista> motorista)
        {

            Console.WriteLine("Digite o ID do caminhao que deseja remover");
            int idAux = Convert.ToInt32(Console.ReadLine());

            var caminhaoRemovido = caminhao.RemoveAll(s => s.Id == idAux);
            MenuRemover(caminhao, motorista, viagem);

        }

        public static void RemoverViagem(List<Viagem> viagem, List<Caminhao> caminhao, List<Motorista> motorista)
        {
            Console.WriteLine("Digite o ID da viagem que deseja remover");
            int idAux = Convert.ToInt32(Console.ReadLine());

            var viagemRemovida = viagem.RemoveAll(s => s.Id == idAux);
            MenuRemover(caminhao, motorista, viagem);

        }
    }
}
//Tarefa para o fim de semana:
//Faça um programa com as seguintes classes:

//Caminhao
//  Modelo: string;
//Placa: string;
//Id: int;

//Motorista
//  Nome: string;
//Endereco: string;
//Id: int;

//Viagem
//  Caminhao: Caminhao;
//Motorista: Motorista;
//Id: int;

//Crie um cadastro de cada um, e permita fazer as seguintes operações:
//Cadastrar;
//Atualizar;
//Remover.
//No Programa principal, terá uma lista 
//de cada classe e nelas serão feitas as operações usando LINQ (use para encontrar os elementos de acordo).