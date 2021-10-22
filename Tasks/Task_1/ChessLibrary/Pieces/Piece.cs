using System;

namespace ChessLibrary
{
    /// <summary>
    /// Шахматная фигура.
    /// </summary>
    public abstract class Piece
    {
        private Position position;

        private readonly PieceColor color;

        /// <summary>
        /// Инициализатор класса Piece.
        /// </summary>
        /// <param name="position"> Позиция фигуры. </param>
        /// <param name="color"> Цвет фигуры. </param>
        public Piece(Position position, PieceColor color)
        {
            this.position = position;
            this.color = color;
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
        /// Цвет фигуры.
        /// </summary>
        public PieceColor Color
        {
            get { return color; }
        }

        /// <summary>
        /// Сравнение фигур на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства фигур, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                Piece piece = (Piece)obj;

                return this.position.Equals(piece.Position) && (this.color == piece.color);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();      
        }

        /// <summary>
        /// Название фигуры.
        /// </summary>
        /// <returns> Название фигуры. </returns>
        public override string ToString()
        {
            return $"{this.GetType().Name[0]}";
        }
    }
}
