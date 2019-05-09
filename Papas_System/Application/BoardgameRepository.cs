using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Papas_System.Application
{
    public class BoardgameRepository
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
                            GetBoardgame();
                            Console.Clear();
                            break;
                        default:

                            break;
                    }
                }

        }

            public void InsertBoardgame(string boardgameName, string numberOfPlayers, string audience, string expectedGameTime, string distributor, int boardgameId, string gameTag)
            {
                using (connectionString con = new connectionString(connectionString))
                {
                    string query = "INSERT INTO PET (PetName, PetType, PetBreed, PetDOBl, PetWeight, OwnerID) VALUES " +
                        "(@PetName, @PetType, @PetBreed, @PetDOBl, @PetWeight, @OwnerID)";
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
        public DeleteBoardgame()
        {

        }
        public GetBoardgame()
        {

        }
        public ModifyBoardgame()
        {

        }
        public RecommendBoardgame()
        {

        }
    }

