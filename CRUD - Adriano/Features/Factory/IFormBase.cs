﻿namespace CRUD___Adriano.Features.Factory
{
    public interface IFormBase
    {
        void Validar();

        void ValidarComponentes();

        bool Validado { get; set; }

        event ValidarHandle ValidarEvent;
    }
}