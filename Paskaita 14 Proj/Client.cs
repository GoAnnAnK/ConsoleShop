using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14_Proj
{
    class Client 
    {
        // protected readonly  _basket;
        protected double _balance;
        protected readonly string _name;
        protected readonly int _clientID;
        
        public void ShowBalance()
        {
            Console.WriteLine("Jusu likutis pinigu: " +_name.ToString() + " " + _balance.ToString() );
        }
        public Client(string name , int balance) 
        {

        }
        public void ChangeBalance(int newBalance)
        {
            _balance = newBalance;
        }
/*        puliv override string ToString()
        {
            return $"Client: '{_name}'; ChangeBalance: {_balance}; Client ID { _clientID}; " ;
        }

        public void AddToBascet(Product product)
        {
            _basket
        }*/
    

