using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;

namespace ChessLibraryTests
{
    /// <summary>
    /// Тестирование класса Game.
    /// </summary>
    [TestClass()]
    public class GameTests
    {
        /// <summary>
        /// Тестирование метода Move().
        /// </summary>
        [TestMethod()]
        public void Move_RightMove_ReturnsTrue()
        {
            // Arrange.         
            var whitePlayer = new WhitePlayer();
            var blackPlayer = new BlackPlayer();
            var game = new Game(ref whitePlayer, ref blackPlayer);

            // Act.
            whitePlayer.MovingPiece = new Pawn(new Position("A2"), PieceColor.White);

            bool actual = game.Move(whitePlayer, new Position("A4"));

            // Assert.            
            Assert.AreEqual(true, actual);
        }
    }
}