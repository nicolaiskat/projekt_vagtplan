using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    //SkillService indeholder alt forretningslogikken for hvordan data hentes og lægges til en volunteer
    //Dette betyder at du her kan finde kode CRUD på en/flere volunteer(s)
    public class SkillService
    {
        //Initialiserer string til connection-uri
        private readonly string _connectionString;
        public SkillService(IConfiguration configuration)
        {
            //Henter connection-uri til _connectionString
            _connectionString = configuration.GetConnectionString("postgres");
        }

        //Method til at forbinde fra connectionstreng til faktiske connection
        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        //Get method for alle volunteers
        public IEnumerable<Skill> Get()
        {
            //Åbner forbindelsen til databasen
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                var query = @"select * from all_skills";

                //Kører en query 
                var list = conn.Query<Skill, Team, Volunteer, Skill>(
                query,
                (s, t, v) =>
                {
                    //Initialiserer 0..* forholdende mellem klasserne
                    //Og gemmer dataen tilhørende den enkelte skill
                   
                    s.teams = new(); s.volunteers = new();
                    s.teams.Add(t);
                    s.volunteers.Add(v);
                    

                    //Retunere hver volunteer og laver en liste ud af det til => var list
                    return s;
                },
                //Værdierne de unikke data query skal bruge til at identificere hver klasse (skal i rækkefølge)
                //'splitOn:' står som det gør, fordi vi vælger at ændre i splitOn og ikke de andre parametre i 'Query' method fra Dapper
                splitOn: "skill_id, team_id, volunteer_id");

                //Gruppere data i "list" ud fra hver volunteer
                var result = list.GroupBy(s => s.skill_id).Select(g =>
                {
                    //Starter ved "first" i gruppen
                    var groupedList = g.First();

                    //Sætter gruppens klasse-lister i grupper, så det kommer ud som arrays pr. liste
                    groupedList.teams = g.Select(s => s.teams.Single()).ToList();
                    groupedList.volunteers = g.Select(s => s.volunteers.Single()).ToList();
                   

                    //Fjerner alle objekter i listerne, som er lig med null (data trimming)
                    groupedList.teams.RemoveAll(x => x == null);
                    groupedList.volunteers.RemoveAll(x => x == null);
                  

                    //Returnerer grupperet liste
                    return groupedList;
                });
                //Returnerer IEnumerable<Skill>
                return result;
            }

        }

        // Method til at hente enkelt volunteer
        //Hvis Get() indeholder kun én parameter, som string, så køres denne Get()
        public Skill Get(int id)
        {
            //Henter data på alle volunteers fra ovennstående/tidligere Get()
            //Anvender LINQ for at finde unik volunteer på email (email parameter fås fra controller)
            var listen = Get().First(x => x.skill_id == id);
            return listen;
        }

        //Method til at insert ny volunteer i database (tager imod et Skill objekt som parameter)
        public Skill Create(Skill obj)
        {
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                //Alle '@' inde i strengen er parametre i stored procedure som ændres afhængigt at inndhold fra Skill-objektet
                var query = @"CALL add_skill(@name)";

                //Definerer alle værdierne fra Skill-objektet til query-parametrenes værdier
                var values = new
                {
                    //f.eks er @first_name det samme som
                    //obj.first_name når kode køres:

                    name = obj.name,
                   
                };

                //Eksekverer 'query' med 'values' som parametre
                conn.Execute(query, values);

                //Returnerer samme obj tilbage som modtaget i parameteren
                return obj;
            }
        }

        //Method til at update eksisterende volunteer i database (tager imod et Skill objekt som parameter)
        public Skill Update(Skill obj)
        {
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                //Alle '@' inde i strengen er parametre i stored procedure som ændres afhængigt at inndhold fra Skill-objektet
                var query = @"CALL edit_skill(@id, @name)";

                //Definerer alle værdierne fra Skill-objektet til query-parametrenes værdier
                var values = new
                {
                    //f.eks er @id det samme som
                    //obj.volunteer_id når kode køres:

                    id = obj.skill_id,
                    name = obj.name
                };

                //Eksekverer 'query' med 'values' som parametre
                conn.Execute(query, values);

                //Returnerer samme obj tilbage som modtaget i parameteren
                return obj;
            }
        }

        //Method til at delete eksisterende volunteer i database (tager imod et id-int som parameter)
        public int Delete(int id)
        {
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                //Alle '@' inde i strengen er parametre i stored procedure som ændres afhængigt at input fra controller
                var query = @"CALL delete_skill(@_id)";

                //Definerer id fra input i controller til query-parameterens værdi
                var value = new
                {
                    //f.eks er @_id det samme som
                    //id når kode køres:

                    _id = id
                };

                //Eksekverer 'query' med 'value' som parametre
                conn.ExecuteAsync(query, value);

                //Returnerer samme id tilbage som modtaget i parameteren
                return id;
            }
        }
    }
}
