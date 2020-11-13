using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Entities
{
    public class ContoCorrente
    {
        private string numeroConto;
        private double saldo;
        private Cliente owner;
        public List<Movimento> Movimenti { get; } //da fuori li puoi solo leggere

        public ContoCorrente()
        {

        }
        public ContoCorrente(Cliente owner)
        {
            Movimenti = new List<Movimento>();
            this.owner = owner;
        }

        public Cliente GetOwner()
        {
            return this.owner;
        }
        public string GetNumeroConto()
        {
            return numeroConto;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public ContoCorrente (string numeroConto)
        {
            this.numeroConto = numeroConto;
            saldo = 0;
        }

        public OperationResult Deposita(double cifra)
        {
            saldo += cifra;
            Movimento deposito = new Movimento()
            {
                Tipo = TipoMovimento.Deposita,
                Importo = cifra,
                Data = DateTime.Now
            };

            // si può scrivere anche così:
            //Movimento deposito = new Movimento()
            // deposito.Tipo = TipoMovimento.Deposita;
            // deposito.Importo = cifra,
            // deposito.Data = DateTime.Now
            //
            Movimenti.Add(deposito);
            return OperationResult.Operazione_OK;
        }

        public OperationResult Preleva(double cifra)
        {
            OperationResult result = OperationResult.Fondi_Insufficienti;
            if (saldo >= cifra)
            {
                saldo -= cifra;

                Movimenti.Add(new Movimento()
                {
                    Tipo = TipoMovimento.Prelieva,
                    Importo = cifra,
                    Data = DateTime.Now
                });

                result = OperationResult.Operazione_OK;
            }
            return result;
        }

        public OperationResult Bonifico(double cifra, ContoCorrente beneficiario)
        {
            Movimenti.Add(new Movimento()
            {
                Tipo = TipoMovimento.Bonifico,
                Importo = cifra,
                Data = DateTime.Now,
                Beneficiario = beneficiario.GetNumeroConto()
            });
            return OperationResult.Operazione_OK;

        }

    }
}
