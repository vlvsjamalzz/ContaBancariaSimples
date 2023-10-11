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
        
        public string abrirConta(string Abrir)
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
            
            return Abrir;
        }

       /* public string fecharConta()
        {

        }
        public double depositar()
        {

        }*/

        public double sacar()
        {
            Console.WriteLine("Quanto deseja sacar?");
            double.Parse(Console.ReadLine());
            saldo = saldo - sacar();
            return saldo;
        }

        public double pagarMensal()
        {
            if(tipo == "ContaCorrente")
            {
                saldo = saldo - 12.00;
            }
            else if(tipo == "ContaPoupança")
            {
                saldo = saldo - 20.00;
            }
            return saldo;
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
