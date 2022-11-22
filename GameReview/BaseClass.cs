using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview
{
    public class BaseClass
    {
        public virtual bool CreateNewItem(string name)
        {
            bool created = false;
            using var db = new DatabaseContext();
            db.Add(new Game { Title = name });
            db.SaveChanges();
            created = true;
            return created;
        }

        public virtual bool DeleteNewGame(string name)
        {
            bool deleted = false;
            using var db = new DatabaseContext();
            if(db.Games != null)
            {
                db.Remove(db.Games.Single(g => g.Title == name));
                db.SaveChanges();
                return deleted = true;
            }
            return deleted;
        }

        public virtual bool DeleteAllGames()
        {
            bool deleted = false;
            using var db = new DatabaseContext();
            if(db.Games != null)
            {
                foreach (var item in db.Games)
                {
                    db.Games.Remove(item);
                }
                db.SaveChanges();
                return deleted = true;
            }              
            return deleted;
        }
    }
}
