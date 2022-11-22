using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameReview.Interfaces;

namespace GameReview
{    public class Review:ReviewInterface
    {
        public int ReviewId { get; set; }
        public string? Title { get; set; }
        public string? ReviewContent { get; set; }

        public int GameId { get; set; }
        public Game? Game { get; set; }

        public virtual bool AddNewReview(Game game, string title, string reviewContent)
        {
            try
            {
                using var db = new DatabaseContext();
                game.Reviews.Add(
                new Review {Title = title, ReviewContent = reviewContent});
                db.SaveChanges();
            }
            catch(Exception)
            {return false;}
            
            return true;
        }
    }
}
