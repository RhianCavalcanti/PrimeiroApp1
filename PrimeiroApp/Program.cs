using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[,] agendacontatos = new string[100, 11];
            string variavelloopmain = "iniciar";
            string variavellooppesq = "iniciar";
            agendacontatos[0, 0] = "Nome:" + "Rhian";
            agendacontatos[0, 1] = "Sobrenome:" + "Costa";
            agendacontatos[0, 2] = "Tipo de Contato:" + "Pessoal";
            agendacontatos[0, 3] = "Telefone:" + "81 985441003";
            agendacontatos[0, 4] = "Email:" + "rhianqw@gmail.com";
            agendacontatos[0, 5] = "Bairro:" + "Artur Lundgren 2";
            agendacontatos[0, 6] = "Cidade:" + "Paulista";
            agendacontatos[0, 7] = "Estado:" + "Pernambuco";
            agendacontatos[0, 8] = "Data de Nascimento:" + "05/07/2003";
            agendacontatos[0, 9] = "OBS:" + "Aluno do Curso de C#";
            agendacontatos[0, 10] = "------------------------------------------------";


            agendacontatos[1, 0] = "Nome:" + "Rhian";
            agendacontatos[1, 1] = "Sobrenome:" + "Branco";
            agendacontatos[1, 2] = "Tipo de Contato:" + "Pessoal";
            agendacontatos[1, 3] = "Telefone:" + "81 985441003";
            agendacontatos[1, 4] = "Email:" + "rhianqw@gmail.com";
            agendacontatos[1, 5] = "Bairro:" + "Artur Lundgren 2";
            agendacontatos[1, 6] = "Cidade:" + "Paulista";
            agendacontatos[1, 7] = "Estado:" + "Pernambuco";
            agendacontatos[1, 8] = "Data de Nascimento:" + "05/07/2003";
            agendacontatos[1, 9] = "OBS:" + "Aluno do Curso de C#";
            agendacontatos[1, 10] = "------------------------------------------------";


            while (variavelloopmain=="iniciar")
            {
                Console.WriteLine("Digite o número do que você quer fazer\n" +
                    "1-Ver Lista;\n" +
                    "2-Inserir Contato;\n" +
                    "3-Excluir Contato;\n" +
                    "4-Pesquisar Contato;\n" +
                    "5-Sair");
                string acao = Console.ReadLine();
                //0-nome 1-sobrenome 2-tipocontato 3- telefone 4-email 5- bairro 6-cidade 7-estado 8-data 9-obs
                if (acao == "1")
                {
                    for (int i = 0; i < agendacontatos.GetLength(0); i++)
                    {
                        Console.WriteLine(agendacontatos[i, 0] + "\n" + agendacontatos[i, 1] + "\n" +
                                        agendacontatos[i, 2] + "\n" + agendacontatos[i, 3] + "\n" + agendacontatos[i, 4] + "\n" + agendacontatos[i, 10])
                        
                        
                        
                    }


                }
                else if (acao == "2")
                {
                    string nomeadd;
                    string sobrenomeadd;
                    string tipocontatoadd;
                    string telefoneadd;
                    string emailadd;
                    string bairroadd;
                    string cidadeadd;
                    string estadoadd;
                    string dataadd;
                    string obsadd;
                    Console.WriteLine("Digite o Nome(Iniciais Maiúsculas)");
                    nomeadd = Console.ReadLine();
                    Console.WriteLine("Digite o Sobrenome(Iniciais Maiúsculas)");
                    sobrenomeadd = Console.ReadLine();
                    Console.WriteLine("Digite o Tipo de Contato(Celular, Trabalho, Casa, Principal, Pager, Fax Trabalho, Fax Casa ou Outro.)");
                    tipocontatoadd = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone(ex:xx xxxxxxxxx");
                    telefoneadd = Console.ReadLine();
                    Console.WriteLine("Digite o E-mail");
                    emailadd = Console.ReadLine();
                    Console.WriteLine("Digite o Bairro(Iniciais Maiúsculas)");
                    bairroadd = Console.ReadLine();
                    Console.WriteLine("Digite a Cidade(Iniciais Maiúsculas)");
                    cidadeadd = Console.ReadLine();
                    Console.WriteLine("Digite o Estado(Iniciais Maiúsculas)");
                    estadoadd = Console.ReadLine();
                    Console.WriteLine("Digite a Data de Nascimento(ex: dd/mm/aa");
                    dataadd = Console.ReadLine();
                    Console.WriteLine("Digite a Observação");
                    obsadd = Console.ReadLine();

                    for (int i = 0; i < agendacontatos.GetLength(0); i++)
                    {
                        object variavelvalor = agendacontatos.GetValue(i, 0);
                        if (variavelvalor == null)
                        {
                            agendacontatos[i, 0] = "Nome:" + nomeadd;
                            agendacontatos[i, 1] = "Sobrenome:" + sobrenomeadd;
                            agendacontatos[i, 2] = "Tipo de Contato:" + tipocontatoadd;
                            agendacontatos[i, 3] = "Telefone:" + telefoneadd;
                            agendacontatos[i, 4] = "Email:" + emailadd;
                            agendacontatos[i, 5] = "Bairro:" + bairroadd;
                            agendacontatos[i, 6] = "Cidade:" + cidadeadd;
                            agendacontatos[i, 7] = "Estado:" + estadoadd;
                            agendacontatos[i, 8] = "Data de Nascimento:" + dataadd;
                            agendacontatos[i, 9] = "OBS:" + obsadd;
                            agendacontatos[i, 10] = "------------------------------------------------";
                            break;
                        }
                    }
                    


                    





                }
                else if (acao == "3")
                {
                    Console.WriteLine("Digite o Primeiro Nome para excluir:");
                    string variavelnomeexc = "Nome:" + Console.ReadLine();
                    Console.WriteLine("Digite o Sobrenome para excluir:");
                    string variavelsobrenomeexc = "Sobrenome:" + Console.ReadLine();
                    Console.WriteLine("Digite o Telefone para excluir(ex: 81912345678):");
                    string variaveltelefoneexc = "Telefone:" + Console.ReadLine();

          
                    for (int i = 0; i < agendacontatos.GetLength(0); i++)
                    {   
                    
                        if (agendacontatos[i, 0] == variavelnomeexc & agendacontatos[i, 1] == variavelsobrenomeexc & agendacontatos[i, 3] == variaveltelefoneexc)
                        {

                            agendacontatos.SetValue(null, i,0);
                            agendacontatos.SetValue(null, i,1);
                            agendacontatos.SetValue(null, i,2);
                            agendacontatos.SetValue(null, i,3);
                            agendacontatos.SetValue(null, i,4);
                            agendacontatos.SetValue(null, i,5);
                            agendacontatos.SetValue(null, i,6);
                            agendacontatos.SetValue(null, i,7);
                            agendacontatos.SetValue(null, i,8);
                            agendacontatos.SetValue(null, i,9);
                            agendacontatos.SetValue(null, i,10);

                            Console.WriteLine("Contato Removido Com Sucesso!!");

                        }

                        



                    }
                }
                else if (acao == "4")
                {
                    while (variavellooppesq == "iniciar")
                    {
                        Console.WriteLine("Digite o número do que você quer fazer\n" +
                    "1-Pesquisar pelo Primeiro Nome;\n" +
                    "2-Pesquisar pelo Nome Completo;\n" +
                    "3-Pesquisar pelo Tipo de Contato;\n" +
                    "4-Pesquisar pela Cidade;\n" +
                    "5-Sair");
                        string variavelifpesq = Console.ReadLine();
                        if (variavelifpesq == "1")
                        {
                            Console.WriteLine("Digite o Primeiro Nome(Inicial Maiúscula):");
                            string variavelnomepesq = "Nome:" + Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                if (agendacontatos[i, 0] == variavelnomepesq)
                                {

                                    Console.WriteLine(agendacontatos[i, 0] + "\n" + agendacontatos[i, 1] + "\n" +
                                        agendacontatos[i, 2] + "\n" + agendacontatos[i, 3] + "\n" + agendacontatos[i, 4] + "\n" + agendacontatos[i, 10]);
                                    variavelachar = true;

                                }

                                if (!variavelachar)
                                {
                                    Console.WriteLine("Não existe esse contato!!\n");
                                    break;
                                }


                            }
                        }
                        else if (variavelifpesq == "2")
                        {
                            Console.WriteLine("Digite o Primeiro Nome(Inicial Maiúscula):");
                            string variavelnomepesq = "Nome:" + Console.ReadLine();
                            Console.WriteLine("Digite o Sobrenome(Inicial Maiúscula):");
                            string variavelsobrenomepesq = "Sobrenome:" + Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                if (agendacontatos[i, 0] == variavelnomepesq & agendacontatos[i, 1] == variavelsobrenomepesq)
                                {

                                    Console.WriteLine(agendacontatos[i, 0] + "\n" + agendacontatos[i, 1] + "\n" +
                                        agendacontatos[i, 2] + "\n" + agendacontatos[i, 3] + "\n" + agendacontatos[i, 4] + "\n" + agendacontatos[i, 10]);
                                    variavelachar = true;

                                }

                                if (!variavelachar)
                                {
                                    Console.WriteLine("Não existe esse contato!!\n");

                                }


                            }
                        }
                        else if (variavelifpesq == "3")
                        {
                            Console.WriteLine("Digite o Tipo de Contato(Inicial Maiúscula):");
                            string variavelcontatopesq = "Tipo de Contato:" + Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                if (agendacontatos[i, 2] == variavelcontatopesq)
                                {

                                    Console.WriteLine(agendacontatos[i, 0] + "\n" + agendacontatos[i, 1] + "\n" +
                                        agendacontatos[i, 2] + "\n" + agendacontatos[i, 3] + "\n" + agendacontatos[i, 4] + "\n" + agendacontatos[i, 10]);
                                    variavelachar = true;

                                }

                                if (!variavelachar)
                                {
                                    Console.WriteLine("Não existe esse contato!!\n");

                                }


                            }
                        }
                        else if (variavelifpesq == "4")
                        {
                            Console.WriteLine("Digite a Cidade(Inicial Maiúscula):");
                            string variavelcidadepesq = "Cidade:" + Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                if (agendacontatos[i, 6] == variavelcidadepesq)
                                {

                                    Console.WriteLine(agendacontatos[i, 0] + "\n" + agendacontatos[i, 1] + "\n" +
                                        agendacontatos[i, 2] + "\n" + agendacontatos[i, 3] + "\n" + agendacontatos[i, 4] + "\n" + agendacontatos[i, 10]);
                                    variavelachar = true;


                                }

                                if (!variavelachar)
                                {
                                    Console.WriteLine("Não existe esse contato!!\n");

                                }


                            }
                        }
                        else if (variavelifpesq == "5")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Não Entendi, digite de novo.");
                        }
                    }

                }
                else if (acao == "5")
                {
                    Console.WriteLine("ok");
                    break;
                }
                else
                {
                    Console.WriteLine("Não Entendi, digite de novo.");
                }
            }
        }
        
      
    }
}
