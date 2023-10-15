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
                setnumConta();
                setstatus(true);
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
            
        }

       /* public string fecharConta()
        {

        }

        public double depositar()
        {

        }*/

        public void sacar()
        {
            Console.WriteLine("Deseja fazer um saque?");
            string Sacar = Console.ReadLine();
            if (Sacar == "Sim" && status != false) 
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
                    Console.WriteLine("Seu saldo atual é: ", getSaldo().ToString("F2"));
                }                
            } 
            else
            {
                Console.WriteLine("Conta inexistente.");
            }
        }

        public void pagarMensal()
        {
            if(tipo == "ContaCorrente")
            {
                saldo = saldo - 12.00;
            }
            else if(tipo == "ContaPoupança")
            {
                saldo = saldo - 20.00;
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
