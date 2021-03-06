﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Queue_Challenge
{
    public class ClientRepository
    {
        private Queue<Client> _clientQueue;

        public ClientRepository()
        {
            _clientQueue = new Queue<Client>();
        }

        public Queue<Client> GetClientQueue()
        {
            return _clientQueue;
        }

        public void AddClientToQueue(Client client)
        {
            _clientQueue.Enqueue(client);
        }

        public Client ProcessClaim()
        {
            var client = _clientQueue.Dequeue();
            return client;
        }

        public Client PeekNextClient()
        {
            if (_clientQueue.Count == 0)
                return null;

            return _clientQueue.Peek();
        }
    }
}
