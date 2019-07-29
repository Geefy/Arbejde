using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaBall
{
    class UserDb : DatabaseCon
    {
        public string[] GetLogin(string username)
        {
            string cmd = "SELECT * FROM Users WHERE Username = '" + username + "'";

            DataTable inf = this.GetData(cmd);

            List<string> usernames = new List<string>();

            foreach (DataRow row in inf.Rows)
            {
                usernames.Add(row[0].ToString());
                usernames.Add(row[1].ToString());
            }

            return usernames.ToArray();
        }

        public string[] GetCharacterNames()
        {
            string cmd = "SELECT CharName FROM DragonballCharacters;";
            List<string> names = new List<string>();
            DataTable inf = this.GetData(cmd);
            foreach (DataRow row in inf.Rows)
            {
                names.Add(row[0].ToString());
            }
            return names.ToArray();
        }
        
        public DragonballCharacterDTO DBZ(string name)
        {
            string cmd = "SELECT * FROM DragonballCharacters WHERE CharName = '" + name + "'";
            DataTable inf = this.GetData(cmd);
            
            foreach (DataRow row in inf.Rows)
            {
                try
                {
                    int powerlevel;
                    int health;
                    int energy;
                    bool transformation;
                    bool picked;
                    Int32.TryParse(row.ItemArray[2].ToString(), out powerlevel);
                    Int32.TryParse(row.ItemArray[3].ToString(), out health);
                    Int32.TryParse(row.ItemArray[4].ToString(), out energy);
                    Boolean.TryParse(row.ItemArray[5].ToString(), out transformation);
                    Boolean.TryParse(row.ItemArray[6].ToString(), out picked);
                    byte[] img = (byte[])row[7];


                    return new DragonballCharacterDTO(row.ItemArray[1].ToString(), powerlevel, health, energy, transformation, picked, img);
                     
                }
                catch(Exception e)
                {
                    throw e;
                }    
            }
            return null;
        }
    }
}
