using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace PokemonROMEditor
{
    public class PokemonHandler : System.ComponentModel.INotifyPropertyChanged
    {
        private Pokemon currentpokemon;
        private Pokemon currentvanilla;
        public Pokemon CurrentPokemon
        {
            get { return currentpokemon; }
            set {
                currentpokemon = value;
                Notify("CurrentPokemon");
            }
        }
        public Pokemon CurrentVanilla
        {
            get { return currentvanilla; }
            set {
                currentvanilla = value;
                Notify("CurrentVanilla");
            }
        }
        public ObservableCollection<Pokemon> VanillaList = new ObservableCollection<Pokemon>();

        public PokemonHandler()
        {
            CreateVanillaArray();
            currentpokemon = new Pokemon();
            currentvanilla = VanillaList[1];
        }
        


        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }


        #region VANILLA DATABASE
        public void CreateVanillaArray()
        {
            VanillaList.Add(new Pokemon(0, " ", 0, 0, 0, 0, 0, 0));
            VanillaList.Add(new Pokemon(1, "Bulbasaur", 45, 49, 49, 65, 65, 45)); VanillaList.Add(new Pokemon(2, "Ivysaur", 60, 62, 63, 80, 80, 60)); VanillaList.Add(new Pokemon(3, "Venusaur", 80, 82, 83, 100, 100, 80));
            VanillaList.Add(new Pokemon(4, "Charmander", 39, 52, 43, 60, 50, 65)); VanillaList.Add(new Pokemon(5, "Charmeleon", 58, 64, 58, 80, 65, 80)); VanillaList.Add(new Pokemon(6, "Charizard", 78, 84, 78, 109, 85, 100));
            VanillaList.Add(new Pokemon(7, "Squirtle", 44, 48, 65, 50, 64, 43)); VanillaList.Add(new Pokemon(8, "Wartortle", 59, 63, 80, 65, 80, 58)); VanillaList.Add(new Pokemon(9, "Blastoise", 79, 83, 100, 85, 105, 78));
            VanillaList.Add(new Pokemon(10, "Caterpie", 45, 30, 35, 20, 20, 45)); VanillaList.Add(new Pokemon(11, "Metapod", 50, 20, 55, 25, 25, 30)); VanillaList.Add(new Pokemon(12, "Butterfree", 60, 45, 50, 80, 80, 70));
            VanillaList.Add(new Pokemon(13, "Weedle", 40, 35, 30, 20, 20, 50)); VanillaList.Add(new Pokemon(14, "Kakuna", 45, 25, 50, 25, 25, 35)); VanillaList.Add(new Pokemon(15, "Beedrill", 65, 80, 40, 45, 80, 75));
            VanillaList.Add(new Pokemon(16, "Pidgey", 40, 45, 40, 35, 35, 56)); VanillaList.Add(new Pokemon(17, "Pidgeotto", 63, 60, 55, 50, 50, 71)); VanillaList.Add(new Pokemon(18, "Pidgeot", 83, 80, 75, 70, 70, 91));
            VanillaList.Add(new Pokemon(19, "Rattata", 30, 56, 35, 25, 35, 72)); VanillaList.Add(new Pokemon(20, "Raticate", 55, 81, 60, 50, 70, 97));
            VanillaList.Add(new Pokemon(21, "Spearow", 40, 60, 30, 31, 31, 70)); VanillaList.Add(new Pokemon(22, "Fearow", 65, 90, 65, 61, 61, 100));
            VanillaList.Add(new Pokemon(23, "Ekans", 35, 60, 44, 40, 54, 55)); VanillaList.Add(new Pokemon(24, "Arbok", 60, 85, 69, 65, 79, 80));
            VanillaList.Add(new Pokemon(25, "Pikachu", 35, 55, 30, 50, 40, 90)); VanillaList.Add(new Pokemon(26, "Raichu", 60, 90, 55, 90, 80, 100));
            VanillaList.Add(new Pokemon(27, "Sandshrew", 50, 75, 85, 20, 30, 40)); VanillaList.Add(new Pokemon(28, "Sandslash", 75, 100, 110, 45, 55, 65));
            VanillaList.Add(new Pokemon(29, "Nidoran♀", 55, 47, 52, 40, 40, 41)); VanillaList.Add(new Pokemon(30, "Nidorina", 70, 62, 67, 55, 55, 56)); VanillaList.Add(new Pokemon(31, "Nidoqueen", 90, 82, 87, 75, 85, 76));
            VanillaList.Add(new Pokemon(32, "Nidoran♂", 46, 57, 40, 40, 40, 50)); VanillaList.Add(new Pokemon(33, "Nidorino", 61, 72, 57, 55, 55, 65)); VanillaList.Add(new Pokemon(34, "Nidoking", 81, 92, 77, 85, 75, 85));
            VanillaList.Add(new Pokemon(35, "Clefairy", 70, 45, 48, 60, 65, 35)); VanillaList.Add(new Pokemon(36, "Clefable", 95, 70, 73, 85, 90, 60));
            VanillaList.Add(new Pokemon(37, "Vulpix", 38, 41, 40, 50, 65, 65)); VanillaList.Add(new Pokemon(38, "Ninetales", 73, 76, 75, 81, 100, 100));
            VanillaList.Add(new Pokemon(39, "Jigglypuff", 115, 45, 20, 45, 25, 20)); VanillaList.Add(new Pokemon(40, "Wigglytuff", 140, 70, 45, 75, 50, 45));
            VanillaList.Add(new Pokemon(41, "Zubat", 40, 45, 35, 30, 40, 55)); VanillaList.Add(new Pokemon(42, "Golbat", 75, 80, 70, 65, 75, 90));
            VanillaList.Add(new Pokemon(43, "Oddish", 45, 50, 55, 75, 65, 30)); VanillaList.Add(new Pokemon(44, "Gloom", 60, 65, 70, 85, 75, 40)); VanillaList.Add(new Pokemon(45, "Vileplume", 75, 80, 85, 100, 90, 50));
            VanillaList.Add(new Pokemon(46, "Paras", 35, 70, 55, 45, 55, 25)); VanillaList.Add(new Pokemon(47, "Parasect", 60, 95, 80, 60, 80, 30));
            VanillaList.Add(new Pokemon(48, "Venonat", 60, 55, 50, 40, 55, 45)); VanillaList.Add(new Pokemon(49, "Venomoth", 70, 65, 60, 90, 75, 90));
            VanillaList.Add(new Pokemon(50, "Diglett", 10, 55, 25, 35, 45, 95)); VanillaList.Add(new Pokemon(51, "Dugtrio", 35, 80, 50, 50, 70, 120));
            VanillaList.Add(new Pokemon(52, "Meowth", 40, 45, 35, 40, 40, 90)); VanillaList.Add(new Pokemon(53, "Persian", 65, 70, 60, 65, 65, 115));
            VanillaList.Add(new Pokemon(54, "Psyduck", 50, 52, 48, 65, 50, 55)); VanillaList.Add(new Pokemon(55, "Golduck", 80, 82, 78, 95, 80, 85));
            VanillaList.Add(new Pokemon(56, "Mankey", 40, 80, 35, 35, 45, 70)); VanillaList.Add(new Pokemon(57, "Primeape", 65, 105, 60, 60, 70, 95));
            VanillaList.Add(new Pokemon(58, "Growlithe", 55, 70, 45, 70, 50, 60)); VanillaList.Add(new Pokemon(59, "Arcanine", 90, 110, 80, 100, 80, 95));
            VanillaList.Add(new Pokemon(60, "Poliwag", 40, 50, 40, 40, 40, 90)); VanillaList.Add(new Pokemon(61, "Poliwhirl", 65, 65, 65, 50, 50, 90)); VanillaList.Add(new Pokemon(62, "Poliwrath", 90, 85, 95, 70, 90, 70));
            VanillaList.Add(new Pokemon(63, "Abra", 25, 20, 15, 105, 55, 90)); VanillaList.Add(new Pokemon(64, "Kadabra", 40, 35, 30, 120, 70, 105)); VanillaList.Add(new Pokemon(65, "Alakazam", 55, 50, 45, 135, 85, 120));
            VanillaList.Add(new Pokemon(66, "Machop", 70, 80, 50, 35, 35, 35)); VanillaList.Add(new Pokemon(67, "Machoke", 80, 100, 70, 50, 60, 45)); VanillaList.Add(new Pokemon(68, "Machamp", 90, 130, 80, 65, 85, 55));
            VanillaList.Add(new Pokemon(69, "Bellsprout", 50, 75, 35, 70, 30, 40)); VanillaList.Add(new Pokemon(70, "Weepinbell", 65, 90, 50, 85, 45, 55)); VanillaList.Add(new Pokemon(71, "Victreebel", 80, 105, 65, 100, 60, 70));
            VanillaList.Add(new Pokemon(72, "Tentacool", 40, 40, 35, 50, 100, 70)); VanillaList.Add(new Pokemon(73, "Tentacruel", 80, 70, 65, 80, 120, 100));
            VanillaList.Add(new Pokemon(74, "Geodude", 40, 80, 100, 30, 30, 20)); VanillaList.Add(new Pokemon(75, "Graveler", 55, 95, 115, 45, 45, 35)); VanillaList.Add(new Pokemon(76, "Golem", 80, 110, 130, 55, 65, 45));
            VanillaList.Add(new Pokemon(77, "Ponyta", 50, 85, 55, 65, 65, 90)); VanillaList.Add(new Pokemon(78, "Rapidash", 65, 100, 70, 80, 80, 105));
            VanillaList.Add(new Pokemon(79, "Slowpoke", 90, 65, 65, 40, 40, 15)); VanillaList.Add(new Pokemon(80, "Slowbro", 95, 75, 110, 100, 80, 30));
            VanillaList.Add(new Pokemon(81, "Magnemite", 25, 35, 70, 95, 55, 45)); VanillaList.Add(new Pokemon(82, "Magneton", 50, 60, 95, 120, 70, 70));
            VanillaList.Add(new Pokemon(83, "Farfetch'd", 52, 65, 55, 58, 62, 60));
            VanillaList.Add(new Pokemon(84, "Doduo", 35, 85, 45, 35, 35, 75)); VanillaList.Add(new Pokemon(85, "Dodrio", 60, 110, 70, 60, 60, 100));
            VanillaList.Add(new Pokemon(86, "Seel", 65, 45, 55, 45, 70, 45)); VanillaList.Add(new Pokemon(87, "Dewgong", 90, 70, 80, 70, 95, 70));
            VanillaList.Add(new Pokemon(88, "Grimer", 80, 80, 50, 40, 50, 25)); VanillaList.Add(new Pokemon(89, "Muk", 105, 105, 75, 65, 100, 50));
            VanillaList.Add(new Pokemon(90, "Shellder", 30, 65, 100, 45, 25, 40)); VanillaList.Add(new Pokemon(91, "Cloyster", 50, 95, 180, 85, 45, 70));
            VanillaList.Add(new Pokemon(92, "Gastly", 30, 35, 30, 100, 35, 80)); VanillaList.Add(new Pokemon(93, "Haunter", 45, 50, 45, 115, 55, 95)); VanillaList.Add(new Pokemon(94, "Gengar", 60, 65, 60, 130, 75, 110));
            VanillaList.Add(new Pokemon(95, "Onix", 35, 45, 160, 30, 45, 70));
            VanillaList.Add(new Pokemon(96, "Drowzee", 60, 48, 45, 43, 90, 42)); VanillaList.Add(new Pokemon(97, "Hypno", 85, 73, 70, 73, 115, 67));
            VanillaList.Add(new Pokemon(98, "Krabby", 30, 105, 90, 25, 25, 50)); VanillaList.Add(new Pokemon(99, "Kingler", 55, 130, 115, 50, 50, 75));
            VanillaList.Add(new Pokemon(100, "Voltorb", 40, 30, 50, 55, 55, 100)); VanillaList.Add(new Pokemon(101, "Electrode", 60, 50, 70, 80, 80, 140));
            VanillaList.Add(new Pokemon(102, "Exeggcute", 60, 40, 80, 60, 45, 40)); VanillaList.Add(new Pokemon(103, "Exeggutor", 95, 95, 85, 125, 65, 55));
            VanillaList.Add(new Pokemon(104, "Cubone", 50, 50, 95, 40, 50, 35)); VanillaList.Add(new Pokemon(105, "Marowak", 60, 80, 110, 50, 80, 45));
            VanillaList.Add(new Pokemon(106, "Hitmonlee", 50, 120, 53, 35, 110, 87));
            VanillaList.Add(new Pokemon(107, "Hitmonchan", 50, 105, 79, 35, 110, 76));
            VanillaList.Add(new Pokemon(108, "Lickitung", 90, 55, 75, 60, 75, 30));
            VanillaList.Add(new Pokemon(109, "Koffing", 40, 65, 95, 60, 45, 35)); VanillaList.Add(new Pokemon(110, "Weezing", 65, 90, 120, 85, 70, 60));
            VanillaList.Add(new Pokemon(111, "Rhyhorn", 80, 85, 95, 30, 30, 25)); VanillaList.Add(new Pokemon(112, "Rhydon", 105, 130, 120, 45, 45, 40));
            VanillaList.Add(new Pokemon(113, "Chansey", 250, 5, 5, 35, 105, 50));
            VanillaList.Add(new Pokemon(114, "Tangela", 65, 55, 115, 100, 40, 60));
            VanillaList.Add(new Pokemon(115, "Kangaskhan", 105, 95, 80, 40, 80, 90));
            VanillaList.Add(new Pokemon(116, "Horsea", 30, 40, 70, 70, 25, 60)); VanillaList.Add(new Pokemon(117, "Seadra", 55, 65, 95, 95, 45, 85));
            VanillaList.Add(new Pokemon(118, "Goldeen", 45, 67, 60, 35, 50, 63)); VanillaList.Add(new Pokemon(119, "Seaking", 80, 92, 65, 65, 80, 68));
            VanillaList.Add(new Pokemon(120, "Staryu", 30, 45, 55, 70, 55, 85)); VanillaList.Add(new Pokemon(121, "Starmie", 60, 75, 85, 100, 85, 115));
            VanillaList.Add(new Pokemon(122, "Mr. Mime", 40, 45, 65, 100, 120, 90));
            VanillaList.Add(new Pokemon(123, "Scyther", 70, 110, 80, 55, 80, 105));
            VanillaList.Add(new Pokemon(124, "Jynx", 65, 50, 35, 115, 95, 95));
            VanillaList.Add(new Pokemon(125, "Electabuzz", 65, 83, 57, 95, 85, 105));
            VanillaList.Add(new Pokemon(126, "Magmar", 65, 95, 57, 100, 85, 93));
            VanillaList.Add(new Pokemon(127, "Pinsir", 65, 125, 100, 55, 70, 85));
            VanillaList.Add(new Pokemon(128, "Tauros", 75, 100, 95, 40, 70, 110));
            VanillaList.Add(new Pokemon(129, "Magikarp", 20, 10, 55, 15, 20, 80)); VanillaList.Add(new Pokemon(130, "Gyarados", 95, 125, 79, 60, 100, 81));
            VanillaList.Add(new Pokemon(131, "Lapras", 130, 85, 80, 85, 95, 60));
            VanillaList.Add(new Pokemon(132, "Ditto", 48, 48, 48, 48, 48, 48));
            VanillaList.Add(new Pokemon(133, "Eevee", 55, 55, 50, 45, 65, 55)); VanillaList.Add(new Pokemon(134, "Vaporeon", 130, 65, 60, 110, 95, 65)); VanillaList.Add(new Pokemon(135, "Jolteon", 65, 65, 60, 110, 95, 130)); VanillaList.Add(new Pokemon(136, "Flareon", 65, 130, 60, 95, 110, 65));
            VanillaList.Add(new Pokemon(137, "Porygon", 65, 60, 70, 85, 75, 40));
            VanillaList.Add(new Pokemon(138, "Omanyte", 35, 40, 100, 90, 55, 35)); VanillaList.Add(new Pokemon(139, "Omastar", 70, 60, 125, 115, 70, 55));
            VanillaList.Add(new Pokemon(140, "Kabuto", 30, 80, 90, 55, 45, 55)); VanillaList.Add(new Pokemon(141, "Kabutops", 60, 115, 105, 65, 70, 80));
            VanillaList.Add(new Pokemon(142, "Aerodactyl", 80, 105, 65, 60, 75, 130));
            VanillaList.Add(new Pokemon(143, "Snorlax", 160, 110, 65, 65, 110, 30));
            VanillaList.Add(new Pokemon(144, "Articuno", 90, 85, 100, 95, 125, 85));
            VanillaList.Add(new Pokemon(145, "Zapdos", 90, 90, 85, 125, 90, 100));
            VanillaList.Add(new Pokemon(146, "Moltres", 90, 100, 90, 125, 85, 90));
            VanillaList.Add(new Pokemon(147, "Dratini", 41, 64, 45, 50, 50, 50)); VanillaList.Add(new Pokemon(148, "Dragonair", 61, 84, 65, 70, 70, 70)); VanillaList.Add(new Pokemon(149, "Dragonite", 91, 134, 95, 100, 100, 80));
            VanillaList.Add(new Pokemon(150, "Mewtwo", 106, 110, 90, 154, 90, 130));
            VanillaList.Add(new Pokemon(151, "Mew", 100, 100, 100, 100, 100, 100));
            VanillaList.Add(new Pokemon(152, "Chikorita", 45, 49, 65, 49, 65, 45)); VanillaList.Add(new Pokemon(153, "Bayleef", 60, 62, 80, 63, 80, 60)); VanillaList.Add(new Pokemon(154, "Meganium", 80, 82, 100, 83, 100, 80));
            VanillaList.Add(new Pokemon(155, "Cyndaquil", 39, 52, 43, 60, 50, 65)); VanillaList.Add(new Pokemon(156, "Quilava", 58, 64, 58, 80, 65, 80)); VanillaList.Add(new Pokemon(157, "Typhlosion", 78, 84, 78, 109, 85, 100));
            VanillaList.Add(new Pokemon(158, "Totodile", 50, 65, 64, 44, 48, 43)); VanillaList.Add(new Pokemon(159, "Croconaw", 65, 80, 80, 59, 63, 58)); VanillaList.Add(new Pokemon(160, "Feraligatr", 85, 105, 100, 79, 83, 78));
            VanillaList.Add(new Pokemon(161, "Sentret", 35, 46, 34, 35, 45, 20)); VanillaList.Add(new Pokemon(162, "Furret", 85, 76, 64, 45, 55, 90));
            VanillaList.Add(new Pokemon(163, "Hoothoot", 60, 30, 30, 36, 56, 50)); VanillaList.Add(new Pokemon(164, "Noctowl", 100, 50, 50, 76, 96, 70));
            VanillaList.Add(new Pokemon(165, "Ledyba", 40, 20, 30, 40, 80, 55)); VanillaList.Add(new Pokemon(166, "Ledian", 55, 35, 50, 55, 110, 85));
            VanillaList.Add(new Pokemon(167, "Spinarak", 40, 60, 40, 40, 40, 30)); VanillaList.Add(new Pokemon(168, "Ariados", 70, 90, 70, 60, 60, 40));
            VanillaList.Add(new Pokemon(169, "Crobat", 85, 90, 80, 70, 80, 130));
            VanillaList.Add(new Pokemon(170, "Chinchou", 75, 38, 38, 56, 56, 67)); VanillaList.Add(new Pokemon(171, "Lanturn", 125, 58, 58, 76, 76, 67));
            VanillaList.Add(new Pokemon(172, "Pichu", 20, 40, 15, 35, 35, 60));
            VanillaList.Add(new Pokemon(173, "Cleffa", 50, 25, 28, 45, 55, 15));
            VanillaList.Add(new Pokemon(174, "Igglybuff", 90, 30, 15, 40, 20, 15));
            VanillaList.Add(new Pokemon(175, "Togepi", 35, 20, 65, 40, 65, 20)); VanillaList.Add(new Pokemon(176, "Togetic", 55, 40, 85, 80, 105, 40));
            VanillaList.Add(new Pokemon(177, "Natu", 40, 50, 45, 70, 45, 70)); VanillaList.Add(new Pokemon(178, "Xatu", 65, 75, 70, 95, 70, 95));
            VanillaList.Add(new Pokemon(179, "Mareep", 55, 40, 40, 65, 45, 35)); VanillaList.Add(new Pokemon(180, "Flaaffy", 70, 55, 55, 80, 60, 45)); VanillaList.Add(new Pokemon(181, "Ampharos", 90, 75, 75, 115, 90, 55));
            VanillaList.Add(new Pokemon(182, "Bellossom", 75, 80, 85, 90, 100, 50));
            VanillaList.Add(new Pokemon(183, "Marill", 70, 20, 50, 20, 50, 40)); VanillaList.Add(new Pokemon(184, "Azumarill", 100, 50, 80, 50, 80, 50));
            VanillaList.Add(new Pokemon(185, "Sudowoodo", 70, 100, 115, 30, 65, 30));
            VanillaList.Add(new Pokemon(186, "Politoed", 90, 75, 75, 90, 100, 70));
            VanillaList.Add(new Pokemon(187, "Hoppip", 35, 35, 40, 35, 55, 50)); VanillaList.Add(new Pokemon(188, "Skiploom", 55, 45, 50, 45, 65, 80)); VanillaList.Add(new Pokemon(189, "Jumpluff", 75, 55, 70, 55, 85, 110));
            VanillaList.Add(new Pokemon(190, "Aipom", 55, 70, 55, 40, 55, 85));
            VanillaList.Add(new Pokemon(191, "Sunkern", 30, 30, 30, 30, 30, 30)); VanillaList.Add(new Pokemon(192, "Sunflora", 75, 75, 55, 105, 85, 30));
            VanillaList.Add(new Pokemon(193, "Yanma", 65, 65, 45, 75, 45, 95));
            VanillaList.Add(new Pokemon(194, "Wooper", 55, 45, 45, 25, 25, 15)); VanillaList.Add(new Pokemon(195, "Quagsire", 95, 85, 85, 65, 65, 35));
            VanillaList.Add(new Pokemon(196, "Espeon", 65, 65, 60, 130, 95, 110));
            VanillaList.Add(new Pokemon(197, "Umbreon", 95, 65, 110, 60, 130, 65));
            VanillaList.Add(new Pokemon(198, "Murkrow", 60, 85, 42, 85, 42, 91));
            VanillaList.Add(new Pokemon(199, "Slowking", 95, 75, 80, 100, 110, 30));
            VanillaList.Add(new Pokemon(200, "Misdreavus", 60, 60, 60, 85, 85, 85));
            VanillaList.Add(new Pokemon(201, "Unown", 48, 72, 48, 72, 48, 48));
            VanillaList.Add(new Pokemon(202, "Wobbuffet", 190, 33, 58, 33, 58, 33));
            VanillaList.Add(new Pokemon(203, "Girafarig", 70, 80, 65, 90, 65, 85));
            VanillaList.Add(new Pokemon(204, "Pineco", 50, 65, 90, 35, 35, 15));
            VanillaList.Add(new Pokemon(205, "Forretress", 75, 90, 140, 60, 60, 40));
            VanillaList.Add(new Pokemon(206, "Dunsparce", 100, 70, 70, 65, 65, 45));
            VanillaList.Add(new Pokemon(207, "Gligar", 65, 75, 105, 35, 65, 85));
            VanillaList.Add(new Pokemon(208, "Steelix", 75, 85, 200, 55, 65, 30));
            VanillaList.Add(new Pokemon(209, "Snubbull", 60, 80, 50, 40, 40, 30)); VanillaList.Add(new Pokemon(210, "Granbull", 90, 120, 75, 60, 60, 45));
            VanillaList.Add(new Pokemon(211, "Qwilfish", 65, 95, 75, 55, 55, 85));
            VanillaList.Add(new Pokemon(212, "Scizor", 70, 130, 100, 55, 80, 65));
            VanillaList.Add(new Pokemon(213, "Shuckle", 20, 10, 230, 10, 230, 5));
            VanillaList.Add(new Pokemon(214, "Heracross", 80, 125, 75, 40, 95, 85));
            VanillaList.Add(new Pokemon(215, "Sneasel", 55, 95, 55, 35, 75, 115));
            VanillaList.Add(new Pokemon(216, "Teddiursa", 60, 80, 50, 50, 50, 40));
            VanillaList.Add(new Pokemon(217, "Ursaring", 90, 130, 75, 75, 75, 55));
            VanillaList.Add(new Pokemon(218, "Slugma", 40, 40, 40, 70, 40, 20)); VanillaList.Add(new Pokemon(219, "Magcargo", 50, 50, 120, 80, 80, 30));
            VanillaList.Add(new Pokemon(220, "Swinub", 50, 50, 40, 30, 30, 50)); VanillaList.Add(new Pokemon(221, "Piloswine", 100, 100, 80, 60, 60, 50));
            VanillaList.Add(new Pokemon(222, "Corsola", 55, 55, 85, 65, 85, 35));
            VanillaList.Add(new Pokemon(223, "Remoraid", 35, 65, 35, 65, 35, 65));
            VanillaList.Add(new Pokemon(224, "Octillery", 75, 105, 75, 105, 75, 45));
            VanillaList.Add(new Pokemon(225, "Delibird", 45, 55, 45, 65, 45, 75));
            VanillaList.Add(new Pokemon(226, "Mantine", 65, 40, 70, 80, 140, 70));
            VanillaList.Add(new Pokemon(227, "Skarmory", 65, 80, 140, 40, 70, 70));
            VanillaList.Add(new Pokemon(228, "Houndour", 45, 60, 30, 80, 50, 65)); VanillaList.Add(new Pokemon(229, "Houndoom", 75, 90, 50, 110, 80, 95));
            VanillaList.Add(new Pokemon(230, "Kingdra", 75, 95, 95, 95, 95, 85));
            VanillaList.Add(new Pokemon(231, "Phanpy", 90, 60, 60, 40, 40, 40)); VanillaList.Add(new Pokemon(232, "Donphan", 90, 120, 120, 60, 60, 50));
            VanillaList.Add(new Pokemon(233, "Porygon2", 85, 80, 90, 105, 95, 60));
            VanillaList.Add(new Pokemon(234, "Stantler", 73, 95, 62, 85, 65, 85));
            VanillaList.Add(new Pokemon(235, "Smeargle", 55, 20, 35, 20, 45, 75));
            VanillaList.Add(new Pokemon(236, "Tyrogue", 35, 35, 35, 35, 35, 35));
            VanillaList.Add(new Pokemon(237, "Hitmontop", 50, 95, 95, 35, 110, 70));
            VanillaList.Add(new Pokemon(238, "Smoochum", 45, 30, 15, 85, 65, 65));
            VanillaList.Add(new Pokemon(239, "Elekid", 45, 63, 37, 65, 55, 95));
            VanillaList.Add(new Pokemon(240, "Magby", 45, 75, 37, 70, 55, 83));
            VanillaList.Add(new Pokemon(241, "Miltank", 95, 80, 105, 40, 70, 100));
            VanillaList.Add(new Pokemon(242, "Blissey", 255, 10, 10, 75, 135, 55));
            VanillaList.Add(new Pokemon(243, "Raikou", 90, 85, 75, 115, 100, 115));
            VanillaList.Add(new Pokemon(244, "Entei", 115, 115, 85, 90, 75, 100));
            VanillaList.Add(new Pokemon(245, "Suicune", 100, 75, 115, 90, 115, 85));
            VanillaList.Add(new Pokemon(246, "Larvitar", 50, 64, 50, 45, 50, 41)); VanillaList.Add(new Pokemon(247, "Pupitar", 70, 84, 70, 65, 70, 51)); VanillaList.Add(new Pokemon(248, "Tyranitar", 100, 134, 110, 95, 100, 61));
            VanillaList.Add(new Pokemon(249, "Lugia", 106, 90, 130, 90, 154, 110));
            VanillaList.Add(new Pokemon(250, "Ho-Oh", 106, 130, 90, 110, 154, 90));
            VanillaList.Add(new Pokemon(251, "Celebi", 100, 100, 100, 100, 100, 100));
        }
        #endregion
        /*
#region Hex Functions
public byte[] ReadPokemon(FileStream r, int pokemonNumber)
{
byte[] b = new byte[32];
r.Seek(PokemonNumberToOffset(pokemonNumber), SeekOrigin.Begin);
long x = r.Position;
r.Read(b, 0, 32);
return b;
}
void WritePokemon(FileStream r, Pokemon p)
{
WritePokemon(r, p.PokemonToByteArr(), p.Number);
}
public void WritePokemon(FileStream r, byte[] b, int pokemonNumber)
{
r.Seek(PokemonNumberToOffset(pokemonNumber), SeekOrigin.Begin);
r.Write(b, 0, 32);
}
//334604 is the beginning of the pokemon offsets
//32 is how many bytes long each pokemon is. 
public static int OffsetToPokemonNumber(long offset)
{
return (int)Math.Floor(((Convert.ToDouble(offset) - 334603) / 32) + 1);
}
public static long PokemonNumberToOffset(int num)
{
return ((num - 1) * 32) + 334603;
}
#endregion
*/
    }
}
