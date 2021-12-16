using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    //VolunteerService indeholder alt forretningslogikken for hvordan data hentes og lægges til en volunteer
    //Dette betyder at du her kan finde kode CRUD på en/flere volunteer(s)
    public class VolunteerService
    {
        //Initialiserer string til connection-uri
        private readonly string _connectionString;
        public VolunteerService(IConfiguration configuration)
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
        public IEnumerable<Volunteer> Get()
        {
            //Åbner forbindelsen til databasen
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                var query = @"select * from all_volunteers";

                //Kører en query 
                var list = conn.Query<Volunteer, Shift, Coupon, Skill, Volunteer>(
                query,
                (v, sh, c, sk) =>
                {
                    //Initialiserer 0..* forholdende mellem klasserne
                    //Og gemmer dataen tilhørende den enkelte volunteer
                    //v = volunteer, sh = shift, c = coupon, sk = skill
                    v.coupons = new(); v.shifts = new(); v.skills = new();
                    v.shifts.Add(sh);
                    v.coupons.Add(c);
                    v.skills.Add(sk);

                    //Retunere hver volunteer og laver en liste ud af det til => var list
                    return v;
                },
                //Værdierne de unikke data query skal bruge til at identificere hver klasse (skal i rækkefølge)
                //'splitOn:' står som det gør, fordi vi vælger at ændre i splitOn og ikke de andre parametre i 'Query' method fra Dapper
                splitOn: "volunteer_id, shift_id, coupon_id, skill_id");

                //Gruppere data i "list" ud fra hver volunteer
                var result = list.GroupBy(v => v.volunteer_id).Select(g =>
                {
                    //Starter ved "first" i gruppen
                    var groupedList = g.First();

                    //Sætter gruppens klasse-lister i grupper, så det kommer ud som arrays pr. liste
                    groupedList.shifts = g.Select(v => v.shifts.Single()).ToList();
                    groupedList.coupons = g.Select(v => v.coupons.Single()).ToList();
                    groupedList.skills = g.Select(v => v.skills.Single()).ToList();

                    //Fjerner alle objekter i listerne, som er lig med null (data trimming)
                    groupedList.shifts.RemoveAll(sh => sh == null);
                    groupedList.coupons.RemoveAll(c => c == null);
                    groupedList.skills.RemoveAll(sk => sk == null);

                    //Returnerer grupperet liste
                    return groupedList;
                });
                //Returnerer IEnumerable<Volunteer>
                return result;
            }

        }

        // Method til at hente enkelt volunteer
        //Hvis Get() indeholder kun én parameter, som string, så køres denne Get()
        public Volunteer Get(string em)
        {
            //Henter data på alle volunteers fra ovennstående/tidligere Get()
            //Anvender LINQ for at finde unik volunteer på email (email parameter fås fra controller)
            var vol = Get().First(x => x.email == em);
            return vol;
        }

        //Method til at insert ny volunteer i database (tager imod et Volunteer objekt som parameter)
        public Volunteer Create(Volunteer obj)
        {
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                //Alle '@' inde i strengen er parametre i stored procedure som ændres afhængigt at inndhold fra Volunteer-objektet
                var query = @"CALL add_volunteer(@first_name, @last_name, @mobile, @email, @address, @gender, @cpr, @password)";

                //Definerer alle værdierne fra Volunteer-objektet til query-parametrenes værdier
                var values = new
                {
                    //f.eks er @first_name det samme som
                    //obj.first_name når kode køres:

                    first_name = obj.first_name,
                    last_name = obj.last_name,
                    mobile = obj.mobile,
                    email = obj.email,
                    address = obj.address,
                    gender = obj.gender,
                    cpr = obj.cpr,
                    password = obj.password
                };

                //Eksekverer 'query' med 'values' som parametre
                conn.Execute(query, values);

                //Returnerer samme obj tilbage som modtaget i parameteren
                return obj;
            }
        }

        //Method til at update eksisterende volunteer i database (tager imod et Volunteer objekt som parameter)
        public Volunteer Update(Volunteer obj)
        {
            //Alt kode i denne 'using' kan forbbindes med databasen
            using (var conn = OpenConnection(_connectionString))
            {
                //Query gemmes som string
                //Alle '@' inde i strengen er parametre i stored procedure som ændres afhængigt at inndhold fra Volunteer-objektet
                var query = @"CALL edit_volunteer(@id, @first_name, @last_name, @mobile, @email, @address, @cpr, @gender)";

                //Definerer alle værdierne fra Volunteer-objektet til query-parametrenes værdier
                var values = new
                {
                    //f.eks er @id det samme som
                    //obj.volunteer_id når kode køres:

                    id = obj.volunteer_id,
                    first_name = obj.first_name,
                    last_name = obj.last_name,
                    mobile = obj.mobile,
                    email = obj.email,
                    address = obj.address,
                    cpr = obj.cpr,
                    gender = obj.gender
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
                var query = @"CALL delete_volunteer(@_id)";

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
