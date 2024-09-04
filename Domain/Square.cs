﻿namespace Domain
{
    /// <summary>
    /// Класс квадрат
    /// </summary>
    public class Square : IEquatable<Square>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Square"/>
        /// </summary>
        /// <param name="side">Сторона</param>
        /// <exception cref="ArgumentException">TЕсли сторона меньше или равно нуля.</exception>
        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля");
            }

            this.Side = side;
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        public double Side { get; }

        public double GetArea() => this.Side * this.Side;

        public override string ToString() => $"Сторона = {this.Side}";

        public override bool Equals(object? obj) => 
            obj is Square other && this.Equals(other);

        public bool Equals(Square? other) => other is not null && this.Id == other.Id;

        public override int GetHashCode() => this.Id.GetHashCode();

    }
}