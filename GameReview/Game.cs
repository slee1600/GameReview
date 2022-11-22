using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview
{
    public class Game : BaseClass
    {
        public int GameId { get; set; }
        public string? Title { get; set; }

        public List<Review> Reviews { get; } = new();

        public Game()
        {
            Title = "Default";
        }

        public override bool CreateNewItem(string Title)
        {
            // Calling the base class method:
            return base.CreateNewItem(Title);
        }

        public override bool DeleteNewGame(string Title)
        {
            // Calling the base class method:
            return base.DeleteNewGame(Title);
        }

        public override bool DeleteAllGames()
        {
            // Calling the base class method:
            return base.DeleteAllGames();
        }       

    }
}
