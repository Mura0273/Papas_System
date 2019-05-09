using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Papas_System.Application
{
    public class BoardgameRepository : DataBaseController
    {

        public void AddBoardgame()
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
                            Console.Write("Indtast navn på brætspil: ");
                            string boardgameName = Console.ReadLine();
                            Console.Write("Anbefalet antal af spillere: ");
                            string numberOfPlayers = Console.ReadLine();
                            Console.Write("Anbefalet aldersgruppe: ");
                            string audience = Console.ReadLine();
                            Console.Write("Forventet spilletid: ");
                            string expectedGameTime = Console.ReadLine();
                            Console.Write("Distributør: ");
                            string distributor =Console.ReadLine();
                            Console.Write("Brætspils Id: ");
                            int boardgameId = int.Parse(Console.ReadLine());
                            Console.Write("Spilgenre: ");
                            string gameTag = Console.ReadLine();

                        InsertBoardgame(boardgameName, numberOfPlayers, audience, expectedGameTime, distributor, boardgameId, gameTag);
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Viser alle brætspil");
                            //GetBoardgame(); SKal implementeres længere nede
                            Console.Clear();
                            break;
                        default:

                            break;
                    }
                }

        }

            public void InsertBoardgame(string boardgameName, string numberOfPlayers, string audience, string expectedGameTime, string distributor, int boardgameId, string gameTag)
            {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                    string query = "INSERT INTO Game_Libary (Boardgame_Name, Player_Count, Audience, Game_Time, Distributor, GameTag, Boardgame_Id) VALUES " +
                        "(@Boardgame_Name, @Player_Count, @Audience, @Game_Time, @Distributor, @GameTag, @Boardgame_Id)";
                

                using (SqlCommand command = new SqlCommand(query, con))
                    {
                        try
                        {
                            command.Parameters.Add(new SqlParameter("@Boardgame_Name", boardgameName));
                            command.Parameters.Add(new SqlParameter("@Player_Count", numberOfPlayers));                            
                            command.Parameters.Add(new SqlParameter("@Audience", audience));
                            command.Parameters.Add(new SqlParameter("@Game_Time", expectedGameTime));
                            command.Parameters.Add(new SqlParameter("@Distributor",distributor));
                            command.Parameters.Add(new SqlParameter("@Boardgame_Id", boardgameId));
                            command.Parameters.Add(new SqlParameter("@GameTag", gameTag));

                        con.Open();
                            command.ExecuteNonQuery();
                            con.Close();

                            Console.WriteLine("Brætspil er tilføjet");
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
        }
        //public DeleteBoardgame()
        //{

        //}
        //public void GetBoardgame()
        //{
        //using (SqlConnection con = new SqlConnection(connectionString))
        //{
        //    string query = "SELECT * FROM PET";
        //    using (SqlCommand command = new SqlCommand(query, con))
        //    {
        //        try
        //        {
        //            con.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    int PetID = int.Parse(reader["PetID"].ToString());
        //                    string PetName = reader["PetName"].ToString();
        //                    string PetType = reader["PetType"].ToString();
        //                    string PetBreed = reader["PetBreed"].ToString();
        //                    string PetDOBl = reader["PetDOBl"].ToString();
        //                    string petWeight = reader["petWeight"].ToString();
        //                    int OwnerID = int.Parse(reader["OwnerID"].ToString());
        //                    Console.WriteLine(PetID + ", " + PetName + ", " + PetType + ", " + PetBreed + ", " + PetDOBl + ", " + petWeight + ", " + OwnerID);
        //                }
        //            }

        //            con.Close();

        //            Console.ReadLine();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.ReadLine();
        //        }
        //    }
        //}

    }
        //public ModifyBoardgame()
        //{

        //}
        //public RecommendBoardgame()
        //{

        //}
    

