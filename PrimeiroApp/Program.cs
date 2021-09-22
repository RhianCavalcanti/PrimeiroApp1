using System;


namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Contato[] agendacontatos = new Contato[100];
            string variavelloopmain = "iniciar";
            string variavellooppesq = "iniciar";
            string data1 = "05/11/2003";
            string data2 = "15/12/2002";
            string data3 = "31/01/2001";
            agendacontatos[0].nome = "Rhian";
            agendacontatos[0].sobrenome = "Costa";
            agendacontatos[0].tipocontato = "Casa";
            agendacontatos[0].telefone = "81985441003";
            agendacontatos[0].email = "rhianqw@gmail.com";
            agendacontatos[0].bairro = "Paratibe";
            agendacontatos[0].cidade = "Paulista";
            agendacontatos[0].estado = "Pernambuco";
            agendacontatos[0].dataniver = DateTime.ParseExact(data1, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            agendacontatos[0].obs = "Aluno IFPE";


            agendacontatos[3].nome = "Rhian";
            agendacontatos[3].sobrenome = "Branco";
            agendacontatos[3].tipocontato = "Casa";
            agendacontatos[3].telefone = "81985441003";
            agendacontatos[3].email = "rhianqw@gmail.com";
            agendacontatos[3].bairro = "Paratibe";
            agendacontatos[3].cidade = "Paulista";
            agendacontatos[3].estado = "Pernambuco";
            agendacontatos[3].dataniver = DateTime.ParseExact(data2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            agendacontatos[3].obs = "Aluno do Curso";


            agendacontatos[99].nome = "Rhuan";
            agendacontatos[99].sobrenome = "Cavalcanti";
            agendacontatos[99].tipocontato = "Casa";
            agendacontatos[99].telefone = "81985441003";
            agendacontatos[99].email = "rhianqw@gmail.com";
            agendacontatos[99].bairro = "Paratibe";
            agendacontatos[99].cidade = "Paulista";
            agendacontatos[99].estado = "Pernambuco";
            agendacontatos[99].dataniver = DateTime.ParseExact(data3, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            agendacontatos[99].obs = "Colega de Trabalho";


            agendacontatos[97].nome = "Pedro";
            agendacontatos[97].sobrenome = "Barros";
            agendacontatos[97].tipocontato = "Pessoal";
            agendacontatos[97].telefone = "81985441003";
            agendacontatos[97].email = "rhianqw@gmail.com";
            agendacontatos[97].bairro = "Peixinhos";
            agendacontatos[97].cidade = "Olinda";
            agendacontatos[97].estado = "Pernambuco";
            agendacontatos[97].dataniver = DateTime.ParseExact(data3, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            agendacontatos[97].obs = "Colega de Trabalho";


            while (variavelloopmain == "iniciar")
            {
                Console.WriteLine("Digite o número do que você quer fazer\n" +
                    "1-Ver Lista;\n" +
                    "2-Inserir Contato;\n" +
                    "3-Excluir Contato;\n" +
                    "4-Pesquisar Contato;\n" +
                    "5-Sair");
                string acao = Console.ReadLine();
                


                if (acao == "1")
                {
                    for (int i = 0; i < agendacontatos.GetLength(0); i++)
                    {
                        int mes = agendacontatos[i].dataniver.Month;
                        int dia = agendacontatos[i].dataniver.Day;
                        if (agendacontatos[i].nome!=null)
                        {
                            DateTime DataConta = new DateTime(DateTime.Today.Year, mes, dia);
                            int resultado = (int)DataConta.Subtract(DateTime.Today).TotalDays;
                            if (DataConta > DateTime.Today)
                            {
                                Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                        agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                        "Falta: " + resultado + " dias para seu aniversário" + "\n" + "----------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                        agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                        "O aniversário do contato já passou." + "\n" + "----------------------------------------");
                            }
                        }
                        
                        




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
                    DateTime dataadd;
                    string datastring;
                    string obsadd;
                    Console.WriteLine("Digite o Nome(Iniciais Maiúsculas)");
                    nomeadd = Console.ReadLine();
                    Console.WriteLine("Digite o Sobrenome(Iniciais Maiúsculas)");
                    sobrenomeadd = Console.ReadLine();
                    Console.WriteLine("Digite o Tipo de Contato(Iniciais Maiúsculas/ Tipos: Celular, Trabalho, Casa, Principal, Pager, Fax Trabalho, Fax Casa ou Outro.)");
                    tipocontatoadd = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone(ex:81912345678");
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
                    datastring = Console.ReadLine();
                    dataadd = DateTime.ParseExact(datastring,"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine("Digite a Observação");
                    obsadd = Console.ReadLine();

                    for (int i = 0; i < agendacontatos.GetLength(0); i++)
                    {   
                        
                        if (agendacontatos[i].nome == null)
                        {
                            agendacontatos[i].nome = nomeadd;
                            agendacontatos[i].sobrenome = sobrenomeadd;
                            agendacontatos[i].tipocontato = tipocontatoadd;
                            agendacontatos[i].telefone = telefoneadd;
                            agendacontatos[i].email = emailadd;
                            agendacontatos[i].bairro = bairroadd;
                            agendacontatos[i].cidade = cidadeadd;
                            agendacontatos[i].estado = estadoadd;
                            agendacontatos[i].dataniver = dataadd;
                            agendacontatos[i].obs = obsadd;
                            
                            break;
                        }
                    }









                }
                else if (acao == "3")
                {
                    Console.WriteLine("Digite o Primeiro Nome para excluir:");
                    string variavelnomeexc = Console.ReadLine();
                    Console.WriteLine("Digite o Sobrenome para excluir:");
                    string variavelsobrenomeexc = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone para excluir(ex: 81912345678):");
                    string variaveltelefoneexc = Console.ReadLine();


                    for (int i = 0; i < agendacontatos.GetLength(0); i++)
                    {

                        if (agendacontatos[i].nome == variavelnomeexc & agendacontatos[i].sobrenome == variavelsobrenomeexc & agendacontatos[i].telefone == variaveltelefoneexc)
                        {

                            agendacontatos.SetValue(null, i);
                          

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
                            string variavelnomepesq = Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                int mes = agendacontatos[i].dataniver.Month;
                                int dia = agendacontatos[i].dataniver.Day;

                                DateTime DataConta = new DateTime(DateTime.Today.Year, mes, dia);
                                int resultado = (int)DataConta.Subtract(DateTime.Today).TotalDays;

                                if (agendacontatos[i].nome == variavelnomepesq)
                                {

                                    if (DataConta > DateTime.Today)
                                    {
                                        Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                                agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                                "Falta: " + resultado + " dias para seu aniversário" + "\n" + "----------------------------------------");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                                agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                                "O aniversário do contato já passou." + "\n" + "----------------------------------------");
                                    }
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
                            string variavelnomepesq = Console.ReadLine();
                            Console.WriteLine("Digite o Sobrenome(Inicial Maiúscula):");
                            string variavelsobrenomepesq = Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                int mes = agendacontatos[i].dataniver.Month;
                                int dia = agendacontatos[i].dataniver.Day;

                                DateTime DataConta = new DateTime(DateTime.Today.Year, mes, dia);
                                int resultado = (int)DataConta.Subtract(DateTime.Today).TotalDays;

                                if (agendacontatos[i].nome == variavelnomepesq & agendacontatos[i].sobrenome == variavelsobrenomepesq & agendacontatos[i].nome != null)
                                {


                                    if (DataConta > DateTime.Today)
                                    {
                                        Console.WriteLine("Nome: "+agendacontatos[i].nome + "\n" + "Sobrenome: "+ agendacontatos[i].sobrenome + "\n" +"Tipo de Contato: "+
                                                agendacontatos[i].tipocontato + "\n" +"Telefone: "+ agendacontatos[i].telefone + "\n" +"E-mail: "+ agendacontatos[i].email + "\n" +
                                                "Falta: " + resultado + " dias para seu aniversário" + "\n" + "----------------------------------------");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nome: "+agendacontatos[i].nome + "\n" + "Sobrenome: "+ agendacontatos[i].sobrenome + "\n" +"Tipo de Contato: "+
                                                agendacontatos[i].tipocontato + "\n" +"Telefone: "+ agendacontatos[i].telefone + "\n" +"E-mail: "+ agendacontatos[i].email + "\n" +
                                                "O aniversário do contato já passou." + "\n" + "----------------------------------------");
                                    }

                                }

                                if (!variavelachar)
                                {
                                    Console.WriteLine("Não existe esse contato!!\n");

                                }


                            }
                        }
                        else if (variavelifpesq == "3")
                        {
                            Console.WriteLine("Digite o Tipo de Contato(Inicial Maiúscula/ Tipos:Celular, Trabalho, Casa, Principal, Pager, Fax Trabalho, Fax Casa ou Outro.):");
                            string variavelcontatopesq = Console.ReadLine();
                            bool variavelachar = false;
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                int mes = agendacontatos[i].dataniver.Month;
                                int dia = agendacontatos[i].dataniver.Day;

                                DateTime DataConta = new DateTime(DateTime.Today.Year, mes, dia);
                                int resultado = (int)DataConta.Subtract(DateTime.Today).TotalDays;

                                if (agendacontatos[i].tipocontato == variavelcontatopesq & agendacontatos[i].tipocontato != null)
                                {

                                    if (DataConta > DateTime.Today)
                                    {
                                        Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                                agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                                "Falta: " + resultado + " dias para seu aniversário" + "\n" + "----------------------------------------");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                                agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                                "O aniversário do contato já passou." + "\n" + "----------------------------------------");
                                    }




                                }   }
                        }
                        else if (variavelifpesq == "4")
                        {
                            Console.WriteLine("Digite a Cidade(Inicial Maiúscula):");
                            string variavelcidadepesq = Console.ReadLine();
                            
                            for (int i = 0; i < agendacontatos.GetLength(0); i++)
                            {
                                int mes = agendacontatos[i].dataniver.Month;
                                int dia = agendacontatos[i].dataniver.Day;

                                DateTime DataConta = new DateTime(DateTime.Today.Year, mes, dia);
                                int resultado = (int)DataConta.Subtract(DateTime.Today).TotalDays;

                                if (agendacontatos[i].cidade == variavelcidadepesq & agendacontatos[i].cidade != null)
                                {

                                    if (DataConta > DateTime.Today)
                                    {
                                        Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                                agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                                "Falta: " + resultado + " dias para seu aniversário" + "\n" + "----------------------------------------");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nome: " + agendacontatos[i].nome + "\n" + "Sobrenome: " + agendacontatos[i].sobrenome + "\n" + "Tipo de Contato: " +
                                                agendacontatos[i].tipocontato + "\n" + "Telefone: " + agendacontatos[i].telefone + "\n" + "E-mail: " + agendacontatos[i].email + "\n" +
                                                "O aniversário do contato já passou." + "\n" + "----------------------------------------");
                                    }

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
