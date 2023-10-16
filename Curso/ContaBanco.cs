using System.Globalization;
namespace Course
{
    class ContaBanco
    {
        public int numConta;
        protected string tipo;
        private string dono;
        private double saldo;
        private bool status;
        
        public void abrirConta(string Abrir)
        {
            if (Abrir == "Sim" && status != true)
            {
                setstatus(true);
                setDono();
                setnumConta();
                Console.WriteLine("Qual tipo de conta? Conta Corrente(CC) ou Conta Poupança(CP)");
                setTipo(Console.ReadLine());
                if (tipo == "ContaCorrente")
                {
                    setSaldo(50.0);
                }
                else if (tipo == "ContaPoupança")
                {
                    setSaldo(150.0);
                }
            }
            else
            {
                Console.WriteLine("Encerrando abertura de conta.");
            }
            
        }

        public void fecharConta()
        {
            Console.WriteLine("Deseja mesmo encerrar sua conta?");
            string encerrar = Console.ReadLine();
            if (encerrar == "Sim" && status == true && saldo == 0.0)
            {
                setstatus(false);
            }
            else if (encerrar == "Sim" && status != true)
            {
                Console.WriteLine("Essa conta não existe.");
            }
            else
            {
                Console.WriteLine("Sua conta possui pendências. Entre em contato para solucionar antes do encerramento da conta.");
            }
        }

        public void depositar()
        {
            Console.WriteLine("Deseja fazer um depósito? (SIM ou NÃO)");
            string Depositar = Console.ReadLine();
            if (Depositar == "Sim" && status == true)
            {
                Console.WriteLine("Digite o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                saldo = saldo + deposito;
            }
            else if (Depositar == "Sim" && status != true)
            {
                Console.WriteLine("Conta inexistente.");
            }
            else if (Depositar == "Não" && status == true)
            {
                Console.WriteLine("Encerrando painel de depósito");
            }
            else
            {
                Console.WriteLine("Não entendi, por favor digite SIM se deseja fazer um depósito ou NÃO para sair.");
            }
        }

        public void sacar()
        {
            Console.WriteLine("Deseja fazer um saque? (SIM ou NÃO)");
            string Sacar = Console.ReadLine();
            if (Sacar == "Sim" && status == true) 
            {
                Console.WriteLine("Digite o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                if (saldo >= saque) 
                {
                    saldo = saldo - saque;
                }  
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                    Console.WriteLine("Seu saldo atual é: R$", getSaldo().ToString("F2"));
                }                
            }
            else if (Sacar == "Sim" && status != true)
            {
                Console.WriteLine("Conta inexistente.");
            }
            else if (Sacar == "Não" && status == true)
            {
                Console.WriteLine("Encerrando painel de saque");
            }
            else
            {
                Console.WriteLine("Não entendi, por favor digite SIM se deseja fazer um saque.");
            }
        }

        public void pagarMensal()
        {
            if(tipo == "ContaCorrente" && status == true)
            {
                saldo = saldo - 12.00;
            }
            else if(tipo == "ContaPoupança" && status == true)
            {
                saldo = saldo - 20.00;
            }
            else
            {
                Console.WriteLine("Conta inexistente.");
            }
        }

        public int getnumConta()
        {
            return numConta;
        }

        public void setnumConta()
        {
            numConta = numConta + 1;
        }

        public string getTipo()
        {            
            return tipo;
        }
        
        public void setTipo(string Tipo)
        {
            if (Tipo == "CC")
            {
                tipo = "ContaCorrente";               
            }
            else if (Tipo == "CP")
            {
                tipo = "ContaPoupança";                
            }
        }

        public string getDono()
        {
            return dono;
        }

        public void setDono() 
        {
            Console.WriteLine("Digite o nome do titular da conta: ");
            string Titular = Console.ReadLine();
            dono = Titular;
            
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void setSaldo(double Saldo)
        {
            saldo = Saldo;
        }

        public bool getStatus()
        {
            return status;
        }
        public void setstatus(bool Status)
        {
            status = Status;
        }
    }
}
