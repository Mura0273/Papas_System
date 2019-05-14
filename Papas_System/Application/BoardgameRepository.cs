using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Papas_System.Application
{
    public static class BoardgameRepository
    {
        static string WriteBoardgameName = "Navn på brætspil: ";
        static string WriteNoOfPlayers = "Anbefalet antal af spillere: ";
        static string WriteAudience = "Anbefalet aldersgruppe: ";
        static string WriteGameTime = "Forventet spilletid: ";
        static string WriteDistributor = "Distributør: ";
        static string WriteGameTag = "Spilgenre: ";
        public static void MenuBoardgame()
        {

            bool runWhileTrue = true;
            while (runWhileTrue)
            {
                Console.Clear();
                Console.WriteLine("1. Tilføj nyt brætspil");
                Console.WriteLine("2. Vis alle brætspil");
                int menuInput = int.Parse(Console.ReadLine());
                switch (menuInput)
                {
                    case 0:
                        runWhileTrue = false;
                        break;
                    case 1:
                        Console.WriteLine("Tilføj nyt brætspil");

                        //AddBoardgame();
                            Console.Clear();
                            Console.Write(WriteBoardgameName);
                            string boardgameName = Console.ReadLine();
                            Console.Write(WriteNoOfPlayers);
                            string numberOfPlayers = Console.ReadLine();
                            Console.Write(WriteAudience);
                            string audience = Console.ReadLine();
                            Console.Write(WriteGameTime);
                            string expectedGameTime = Console.ReadLine();
                            Console.Write(WriteDistributor);
                            string distributor = Console.ReadLine();                          
                            Console.Write(WriteGameTag);
                            string gameTag = Console.ReadLine();
                            Console.Clear();


                       Console.WriteLine($"Du er ved at tilføje {boardgameName}");

                       Console.WriteLine
                          
                           ($"Ser følgende rigtigt ud?\n{WriteNoOfPlayers}{numberOfPlayers}\n{WriteAudience}{audience}\n{WriteGameTime}{expectedGameTime}\n{WriteDistributor}{distributor}\n{WriteGameTag}{gameTag}");


                        Console.ReadKey();
                        InsertBoardgame(boardgameName, numberOfPlayers, audience, expectedGameTime, distributor, gameTag);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Viser alle brætspil");
                        GetBoardgame();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:

                        break;
                }
            }

        }

            public static void InsertBoardgame(string boardgameName, string numberOfPlayers, string audience, string expectedGameTime, string distributor,/* int boardgameId,*/ string gameTag)
        {

            using (SqlConnection con = new SqlConnection(DataBaseController.connectionString))
            {
                string query1 = "INSERT INTO [C_DB13_2018].[dbo].[Game_Library] (Boardgame_Name, Player_Count, Audience, Game_Time, Distributor, GameTag) VALUES " +
                    "(@Boardgame_Name, @Player_Count, @Audience, @Game_Time, @Distributor, @GameTag)";


                using (SqlCommand inserToBoardgame = new SqlCommand(query1, con))
                {
                    try
                    {
                        inserToBoardgame.Parameters.Add(new SqlParameter("@Boardgame_Name", boardgameName));
                        inserToBoardgame.Parameters.Add(new SqlParameter("@Player_Count", numberOfPlayers));
                        inserToBoardgame.Parameters.Add(new SqlParameter("@Audience", audience));
                        inserToBoardgame.Parameters.Add(new SqlParameter("@Game_Time", expectedGameTime));
                        inserToBoardgame.Parameters.Add(new SqlParameter("@Distributor", distributor));                   
                        inserToBoardgame.Parameters.Add(new SqlParameter("@GameTag", gameTag));

                        con.Open();
                        inserToBoardgame.ExecuteNonQuery();
                        con.Close();

                        Console.WriteLine($"Brætspil {boardgameName} er tilføjet");
                        Console.ReadLine();
                }
                    catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            }
        }
        //public DeleteBoardgame()
        //{

        //}
        public static void GetBoardgame()
        {

            using (SqlConnection con = new SqlConnection(DataBaseController.connectionString))
            {
                string query2 = "SELECT (@Boardgame_Name, @Player_Count, @Audience, @Game_Time, @Distributor, @GameTag, @Boardgame_Id)  FROM [C_DB13_2018].[dbo].[Game_Library]"
                  ;
                try
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    //cmd2.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string boardgameName = reader["Boardgame_Name"].ToString();
                            string numberOfPlayers = reader["Player_Count"].ToString();
                            string audience = reader["Audience"].ToString();
                            string expectedGameTime = reader["Game_Time"].ToString();
                            string distributor = reader["Distributor"].ToString();
                            string gameTag = reader["GameTag"].ToString();
                            string boardgameId = reader["Boardgame_Id"].ToString();
                           
                            Console.WriteLine($"\nBoardgame_Name: {boardgameName} \nPlayer_Count: {numberOfPlayers} \nAudience: {audience} " +
                            $"\nGame_Time: {expectedGameTime} \nDistributor: {distributor}\nGameTag {gameTag}\n\nBoardgame_Id: {boardgameId}");
                            Console.ReadKey();
                            con.Close();
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }

    }
}
        //public ModifyBoardgame()
        //{

        //}
        //public RecommendBoardgame()
        //{

        //}
    

