using Microsoft.EntityFrameworkCore;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Team>().HasData(
            GetTeams()
        );
        modelBuilder.Entity<Player>().HasData(
            GetPlayers()
        );
    }
    public static List<Team> GetTeams() {
        List<Team> teams = new List<Team>() {
            new Team() {    // 1
                TeamName="Canucks",
                City="Vancouver",
                Province="BC",
                Country="Canada",
            },
            new Team() {    //2
                TeamName="Sharks",
                City="San Jose",
                Province="CA",
                Country="USA",
            },
            new Team() {    // 3
                TeamName="Oilers",
                City="Edmonton",
                Province="AB",
                Country="Canada",
            },
            new Team() {    // 4
                TeamName="Flames",
                City="Calgary",
                Province="AB",
                Country="Canada",
            },
            new Team() {    // 5
                TeamName="Leafs",
                City="Toronto",
                Province="ON",
                Country="Canada",
            },
            new Team() {    // 6
                TeamName="Ducks",
                City="Anaheim",
                Province="CA",
                Country="USA",
            },
            new Team() {    // 7
                TeamName="Lightening",
                City="Tampa Bay",
                Province="FL",
                Country="USA",
            },
            new Team() {    // 8
                TeamName="Blackhawks",
                City="Chicago",
                Province="IL",
                Country="USA",
            },
        };

        return teams;
    }

    public static List<Player> GetPlayers() {
        List<Player> players = new List<Player>() {
            new Player {
                PlayerId = 1,
                FirstName = "Sven",
                LastName = "Baertschi",
                TeamName = "Canucks",
                Position = "Forward"
            },
            new Player {
                PlayerId = 2,
                FirstName = "Hendrik",
                LastName = "Sedin",
                TeamName = "Canucks",
                Position = "Left Wing"
            },
            new Player {
                PlayerId = 3,
                FirstName = "John",
                LastName = "Rooster",
                TeamName = "Flames",
                Position = "Right Wing"
            },
            new Player {
                PlayerId = 4,
                FirstName = "Bob",
                LastName = "Plumber",
                TeamName = "Oilers",
                Position = "Defense"
            },
        };

        return players;
    }
}