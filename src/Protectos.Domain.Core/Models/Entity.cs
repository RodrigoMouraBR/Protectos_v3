﻿using FluentValidation;
using FluentValidation.Results;
using System;
namespace Protectos.Domain.Core.Models
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
            Id = Guid.NewGuid();
           
        }
        public Guid Id { get; protected set; }
        public bool Ativo { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public Guid CadastradoPor { get; protected set; }
        public DateTime DataAlteracao { get; protected set; }
        public Guid AlteradoPor { get; protected set; }
        public abstract bool IsValid();
        public ValidationResult ValidationResult { get; protected set; }
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<T>;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;
            return Id.Equals(compareTo.Id);
        }
        public static bool operator ==(Entity<T> a, Entity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return a.Equals(b);
        }
        public static bool operator !=(Entity<T> a, Entity<T> b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }
    }
}
