using System;
using ChessLibrary.Board;

namespace ChessLibrary.Pieces
{
    /// <summary>
    /// Шахматная фигура.
    /// </summary>
    public abstract class Piece
    {
        private Position position;

        /// <summary>
        /// Инициализатор класса Piece.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        public Piece(Position position)
        {
            this.position = position;
        }

        /// <summary>
        /// Позиция фигуры.
        /// </summary>
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        /// <summary>
        /// Сравнение фигур на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Результат сравнения. </returns>
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                Piece piece = (Piece)obj;

                return this.position.Equals(piece.Position);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();      
        }

        /// <summary>
        /// Информация о фигуре.
        /// </summary>
        /// <returns> Название и позиция фигуры. </returns>
        public override string ToString()
        {
            return $"{this.GetType().Name} - {position}";
        }
    }
}
