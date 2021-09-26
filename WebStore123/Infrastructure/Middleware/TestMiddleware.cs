﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace WebStore123.Infrastructure.Middleware
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _Next;
        private readonly ILogger<TestMiddleware> _Logger;

        public TestMiddleware(RequestDelegate next, ILogger<TestMiddleware> Logger)
        {
            _Next = next;
            _Logger = Logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //context.Response.WriteAsJsonAsync()

            // Предобработка

            var processing = _Next(context); // Запуск следующего слоя промежуточного ПО

            // Обработка параллельно


            await processing; // Ожидание завершения обработки следующей частью конвейера

            // Постобработка данных
        }
    }
}
