using GuaranteedRateConsoleApp.DataLayer;
using GuaranteedRateConsoleApp.Models;
using GuaranteedRateTests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GuaranteedRateTests
{
    [TestClass]
    public class UnitTests
    {
        #region Private Fields

        private static Random random = new Random();

        private List<string> ColorList = new List<string>
        {
            "Red",
            "Blue",
            "Green",
            "White",
            "Yellow",
            "Purple",
            "Absolute Zero",
            "Acid green",
            "Aero",
            "Aero blue",
            "African violet",
            "Air superiority blue",
            "Alabaster",
            "Alice blue",
            "Alloy orange",
            "Almond",
            "Amaranth",
            "Amaranth (M&P)",
            "Amaranth pink",
            "Amaranth purple",
            "Amaranth red",
            "Amazon",
            "Amber",
            "Amber (SAE/ECE)",
            "Amethyst",
            "Android green",
            "Antique brass",
            "Antique bronze",
            "Antique fuchsia",
            "Antique ruby",
            "Antique white",
            "Ao (English)",
            "Apple green",
            "Apricot",
            "Aqua",
            "Aquamarine",
            "Arctic lime",
            "Army green",
            "Artichoke",
            "Arylide yellow",
            "Ash gray",
            "Asparagus",
            "Atomic tangerine",
            "Auburn",
            "Aureolin",
            "Avocado",
            "Azure",
            "Azure (X11/web color)",
            "B'dazzled blue",
            "Baby blue",
            "Baby blue eyes",
            "Baby pink",
            "Baby powder",
            "Baker-Miller pink",
            "Banana Mania",
            "Barbie Pink",
            "Barn red",
            "Battleship grey",
            "Beau blue",
            "Beaver",
            "Beige",
            "Big dip o’ruby",
            "Bisque",
            "Bistre",
            "Bistre brown",
            "Bitter lemon",
            "Bitter lime",
            "Bittersweet",
            "Bittersweet shimmer",
            "Black",
            "Black bean",
            "Black chocolate",
            "Black coffee",
            "Black coral",
            "Black olive",
            "Black Shadows",
            "Blanched almond",
            "Blast-off bronze",
            "Bleu de France",
            "Blizzard blue",
            "Blond",
            "Blood red",
            "Blue",
            "Blue (Crayola)",
            "Blue (Munsell)",
            "Blue (NCS)",
            "Blue (Pantone)",
            "Blue (pigment)",
            "Blue (RYB)",
            "Blue bell",
            "Blue jeans",
            "Blue sapphire",
            "Blue yonder",
            "Blue-gray",
            "Blue-green",
            "Blue-green (color wheel)",
            "Blue-violet",
            "Blue-violet (color wheel)",
            "Blue-violet (Crayola)",
            "Bluetiful",
            "Blush",
            "Bole",
            "Bone",
            "Bottle green",
            "Brandy",
            "Brick red",
            "Bright green",
            "Bright lilac",
            "Bright maroon",
            "Bright navy blue",
            "Bright yellow (Crayola)",
            "Brilliant rose",
            "Brink pink",
            "British racing green",
            "Bronze",
            "Brown",
            "Brown sugar",
            "Brunswick green",
            "Bud green",
            "Buff",
            "Burgundy",
            "Burlywood",
            "Burnished brown",
            "Burnt orange",
            "Burnt sienna",
            "Burnt umber",
            "Byzantine",
            "Byzantium",
            "Cadet",
            "Cadet blue",
            "Cadet blue (Crayola)",
            "Cadet grey",
            "Cadmium green",
            "Cadmium orange",
            "Cadmium red",
            "Cadmium yellow",
            "Café au lait",
            "Café noir",
            "Cambridge blue",
            "Camel",
            "Cameo pink",
            "Canary",
            "Canary yellow",
            "Candy apple red",
            "Candy pink",
            "Capri",
            "Caput mortuum",
            "Cardinal",
            "Caribbean green",
            "Carmine",
            "Carmine (M&P)",
            "Carnation pink",
            "Carnelian",
            "Carolina blue",
            "Carrot orange",
            "Castleton green",
            "Catawba",
            "Cedar Chest",
            "Celadon",
            "Celadon blue",
            "Celadon green",
            "Celeste",
            "Celtic blue",
            "Cerise",
            "Cerulean",
            "Cerulean (Crayola)",
            "Cerulean blue",
            "Cerulean frost",
            "CG blue",
            "CG red",
            "Champagne",
            "Champagne pink",
            "Charcoal",
            "Charleston green",
            "Charm pink",
            "Chartreuse (traditional)",
            "Chartreuse (web)",
            "Cherry blossom pink",
            "Chestnut",
            "Chili red",
            "China pink",
            "China rose",
            "Chinese red",
            "Chinese violet",
            "Chinese yellow",
            "Chocolate (traditional)",
            "Chocolate (web)",
            "Chocolate Cosmos",
            "Chrome yellow",
            "Cinereous",
            "Cinnabar",
            "Cinnamon Satin",
            "Citrine",
            "Citron",
            "Claret",
            "Cobalt blue",
            "Cocoa brown",
            "Coffee",
            "Columbia Blue",
            "Congo pink",
            "Cool grey",
            "Copper",
            "Copper (Crayola)",
            "Copper penny",
            "Copper red",
            "Copper rose",
            "Coquelicot",
            "Coral",
            "Coral pink",
            "Cordovan",
            "Corn",
            "Cornell red",
            "Cornflower blue",
            "Cornsilk",
            "Cosmic cobalt",
            "Cosmic latte",
            "Cotton candy",
            "Coyote brown",
            "Cream",
            "Crimson",
            "Crimson (UA)",
            "Crystal",
            "Cultured",
            "Cyan",
            "Cyan (process)",
            "Cyber grape",
            "Cyber yellow",
            "Cyclamen",
            "Dark blue-gray",
            "Dark brown",
            "Dark byzantium",
            "Dark cornflower blue",
            "Dark cyan",
            "Dark electric blue",
            "Dark goldenrod",
            "Dark green",
            "Dark green (X11)",
            "Dark jungle green",
            "Dark khaki",
            "Dark lava",
            "Dark liver",
            "Dark liver (horses)",
            "Dark magenta",
            "Dark moss green",
            "Dark olive green",
            "Dark orange",
            "Dark orchid",
            "Dark pastel green",
            "Dark purple",
            "Dark red",
            "Dark salmon",
            "Dark sea green",
            "Dark sienna",
            "Dark sky blue",
            "Dark slate blue",
            "Dark slate gray",
            "Dark spring green",
            "Dark turquoise",
            "Dark violet",
            "Dartmouth green",
            "Davy's grey",
            "Deep cerise",
            "Deep champagne",
            "Deep chestnut",
            "Deep jungle green",
            "Deep pink",
            "Deep saffron",
            "Deep sky blue",
            "Deep Space Sparkle",
            "Deep taupe",
            "Denim",
            "Denim blue",
            "Desert",
            "Desert sand",
            "Dim gray",
            "Dodger blue",
            "Dogwood rose",
            "Drab",
            "Duke blue",
            "Dutch white",
            "Earth yellow",
            "Ebony",
            "Ecru",
            "Eerie black",
            "Eggplant",
            "Eggshell",
            "Egyptian blue",
            "Eigengrau",
            "Electric blue",
            "Electric green",
            "Electric indigo",
            "Electric lime",
            "Electric purple",
            "Electric violet",
            "Emerald",
            "Eminence",
            "English green",
            "English lavender",
            "English red",
            "English vermillion",
            "English violet",
            "Erin",
            "Eton blue",
            "Fallow",
            "Falu red",
            "Fandango",
            "Fandango pink",
            "Fashion fuchsia",
            "Fawn",
            "Feldgrau",
            "Fern green",
            "Field drab",
            "Fiery rose",
            "Fire engine red",
            "Fire opal",
            "Firebrick",
            "Flame",
            "Flax",
            "Flirt",
            "Floral white",
            "Fluorescent blue",
            "Forest green (Crayola)",
            "Forest green (traditional)",
            "Forest green (web)",
            "French beige",
            "French bistre",
            "French blue",
            "French fuchsia",
            "French lilac",
            "French lime",
            "French mauve",
            "French pink",
            "French raspberry",
            "French rose",
            "French sky blue",
            "French violet",
            "Frostbite",
            "Fuchsia",
            "Fuchsia (Crayola)",
            "Fuchsia purple",
            "Fuchsia rose",
            "Fulvous",
            "Fuzzy Wuzzy"
        };

        private List<string> FirstNameList = new List<string>
        {
            "Sophia",
            "Olivia",
            "Riley",
            "Emma",
            "Ava",
            "Isabella",
            "Aria",
            "Aaliyah",
            "Amelia",
            "Mia",
            "Layla",
            "Zoe",
            "Camilla",
            "Charlotte",
            "Eliana",
            "Mila",
            "Everly",
            "Luna",
            "Avery",
            "Evelyn",
            "Harper",
            "Lily",
            "Ella",
            "Gianna",
            "Chloe",
            "Adalyn",
            "Charlie",
            "Isla",
            "Ellie",
            "Leah",
            "Nora",
            "Scarlett",
            "Maya",
            "Abigail",
            "Madison",
            "Aubrey",
            "Emily",
            "Kinsley",
            "Elena",
            "Paisley",
            "Madelyn",
            "Aurora",
            "Peyton",
            "Nova",
            "Emilia",
            "Hannah",
            "Sarah",
            "Ariana",
            "Penelope",
            "Lila",
            "Liam",
            "Noah",
            "Jackson",
            "Aiden",
            "Elijah",
            "Grayson",
            "Lucas",
            "Oliver",
            "Caden",
            "Mateo",
            "Muhammad",
            "Mason",
            "Carter",
            "Jayden",
            "Ethan",
            "Sebastian",
            "James",
            "Michael",
            "Benjamin",
            "Logan",
            "Leo",
            "Luca",
            "Alexander",
            "Levi",
            "Daniel",
            "Josiah",
            "Henry",
            "Jayce",
            "Julian",
            "Jack",
            "Ryan",
            "Jacob",
            "Asher",
            "Wyatt",
            "William",
            "Owen",
            "Gabriel",
            "Miles",
            "Lincoln",
            "Ezra",
            "Isaiah",
            "Luke",
            "Cameron",
            "Caleb",
            "Isaac",
            "Carson",
            "Samuel",
            "Colton",
            "Maverick",
            "Matthew"
        };

        private Random gen = new Random();

        private List<string> LastNameList = new List<string>
        {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor",
            "Anderson",
            "Thomas",
            "Jackson",
            "White",
            "Harris",
            "Martin",
            "Thompson",
            "Garcia",
            "Martinez",
            "Robinson",
            "Clark",
            "Rodriguez",
            "Lewis",
            "Lee",
            "Walker",
            "Hall",
            "Allen",
            "Young",
            "Hernandez",
            "King",
            "Wright",
            "Lopez",
            "Hill",
            "Scott",
            "Green",
            "Adams",
            "Baker",
            "Gonzalez",
            "Nelson",
            "Carter",
            "Mitchell",
            "Perez",
            "Roberts",
            "Turner",
            "Phillips",
            "Campbell",
            "Parker",
            "Evans",
            "Edwards",
            "Collins",
            "Stewart",
            "Sanchez",
            "Morris",
            "Rogers",
            "Reed",
            "Cook",
            "Morgan",
            "Bell",
            "Murphy",
            "Bailey",
            "Rivera",
            "Cooper",
            "Richardson",
            "Cox",
            "Howard",
            "Ward",
            "Torres",
            "Peterson",
            "Gray",
            "Ramirez",
            "James",
            "Watson",
            "Brooks",
            "Kelly",
            "Sanders",
            "Price",
            "Bennett",
            "Wood",
            "Barnes",
            "Ross",
            "Henderson",
            "Coleman",
            "Jenkins",
            "Perry",
            "Powell",
            "Long",
            "Patterson",
            "Hughes",
            "Flores",
            "Washington",
            "Butler",
            "Simmons",
            "Foster",
            "Gonzales",
            "Bryant ",
            "Alexander",
            "Russell",
            "Griffin ",
            "Diaz",
            "Hayes"
        };

        #endregion Private Fields

        #region Public Methods

        [TestMethod]
        public void TestAddCollectionItems()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = new List<CollectionItem>();

            for (int i = 0; i < 30; i++)
            {
                var firstName = FirstNameList.RandomElement();
                var lastName = LastNameList.RandomElement();
                CollectionItem ci = new CollectionItem()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    FavoriteColor = ColorList.RandomElement(),
                    DateOfBirth = RandomDateGenerator(),
                    Email = firstName + lastName + "@" + RandomStringGenerator(2) + "Email.com"
                };
                list.Add(ci);
            }

            var content = JsonConvert.SerializeObject(list);
            bool wasAdded = dataHandler.AddCollectionItems(content);
            TestGetCollectionItemsFromCommaDelimitedFile();
            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void TestDateFormat()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetCollectionItems("Jeff", "FirstName");
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        [TestMethod]
        public void TestGetAllCollectionItems()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetAllCollectionItems();
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        [TestMethod]
        public void TestGetCollectionItem()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetCollectionItems("bill", "FirstName");
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        [TestMethod]
        public void TestGetCollectionItemsFromBarDelimitedFile()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetCollectionItemsFromFile("Bar");
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void TestGetCollectionItemsFromCommaDelimitedFile()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetCollectionItemsFromFile("Comma");
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());

            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void TestGetCollectionItemsFromTabDelimitedFile()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetCollectionItemsFromFile("Tab");
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void TestGetFilePath()
        {
            var fullPath = new DataHandler().GetDataFilePath("Comma");
            Console.WriteLine(fullPath);
            Assert.IsTrue(fullPath.Contains("CollectionItemsCommaDelimited"));
        }
        [TestMethod]
        public void TestGetSortedList1()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetSortedList(1);
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        [TestMethod]
        public void TestGetSortedList2()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetSortedList(2);
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        [TestMethod]
        public void TestGetSortedList3()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.GetSortedList(3);
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        [TestMethod]
        public void TestSyncAllItemsFile()
        {
            DataHandler dataHandler = new DataHandler();
            List<CollectionItem> list = dataHandler.SyncAllItemsFile();
            list = list.OrderBy(o => o.FirstName).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - Favorite Color: " + item.FavoriteColor + " - dob: " + item.DateOfBirth + " - email: " + item.Email);
            }
            var listCount = list.Count;
            Console.WriteLine(listCount.ToString());
            Assert.IsTrue(listCount > 0);
        }

        #endregion Public Methods

        #region Private Methods

        private string RandomDateGenerator()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range)).ToString("M/d/yyyy");
        }

        private string RandomStringGenerator(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            var returnValue = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return char.ToUpper(returnValue[0]) + returnValue.Substring(1);
        }

        #endregion Private Methods
    }
}
