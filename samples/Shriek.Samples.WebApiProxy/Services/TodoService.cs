﻿using Shriek.Samples.WebApiProxy.Contracts;
using Shriek.Samples.WebApiProxy.Models;
using System;
using System.Threading.Tasks;

namespace Shriek.Samples.WebApiProxy.Services
{
    public class TodoService : ITodoService
    {
        public Task<Todo> Create(Todo todo)
        {
            return Task.FromResult(todo);
        }

        public Task<Todo> Get(int id)
        {
            return Task.FromResult(new Todo { AggregateId = Guid.NewGuid(), Name = "起床", Desception = "上班", FinishTime = DateTime.Now });
        }

        public Task<Todo> Get(string name)
        {
            return Task.FromResult(new Todo { AggregateId = Guid.NewGuid(), Name = name, Desception = "上班", FinishTime = DateTime.Now });
        }
    }
}