using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Media.Imaging;
using System.IO;
using System.Threading;

namespace ArenaBall
{
    class Logik
    {
        UserDb userdb = new UserDb();


        public bool Login(string username, string password)
        {
            string[] usernames = userdb.GetLogin(username);

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && usernames[i+1] == password)
                    return true;
            }

            return false;

        }

        public string[] DbzArray()
        {
            string[] characters = userdb.GetCharacterNames();
            return characters;
        }

        public DragonballCharacter CreateDragonballChar(string name)
        { 

            return new DragonballCharacter(userdb.DBZ(name));
        }

        public BitmapImage ConvertByteArrayToBitmap(byte[] imageData)
        {

            BitmapImage bitmap = new BitmapImage();
            MemoryStream strm = new MemoryStream();

            
            int offset = 0;
            strm.Write(imageData, offset, imageData.Length);


            // Read the image into the bitmap object
            bitmap.BeginInit();
            bitmap.StreamSource = strm;
            bitmap.EndInit();

            return bitmap;

        }

        public bool ConfirmSelection(bool player1, bool player2)
        {
            bool confirmation = false;
            if(player1 && player2 == true)
            {
                confirmation = true;
            }

            return confirmation;
        }

        public bool ConfirmSelection(bool? isChecked1, bool? isChecked2)
        {
            bool confirmation = false;
            if (isChecked1 == true)
            {
                if(isChecked2 == true)
                {
                    confirmation = true;
                }
            }

            return confirmation;
        }

        public void PlayerSelection(string charName1, string charName2)
        {
            DragonballCharacter player1 = CreateDragonballChar(charName1);
            DragonballCharacter player2 = CreateDragonballChar(charName2);
            
                string file_name = "C:\\Users\\rene2756\\Desktop\\ArenaBallText\\PlayerChoice.txt";
                StreamWriter objWriter;
                objWriter = new StreamWriter(file_name);

                objWriter.WriteLine(player1.CharName);
                objWriter.WriteLine(player2.CharName);
                objWriter.Close();
               
        }
    }

}
