using HearthstoneAPIClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneAPIClient.Services.DataHandling.Models
{

    public class ClassResponse : IResponse
    {
        public Card[] Property1 { get; set; }
    }

    public class Card
    {
        public string cardId { get; set; }
        public int dbfId { get; set; }
        public string name { get; set; }
        public string cardSet { get; set; }
        public string type { get; set; }
        public string faction { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public string playerClass { get; set; }
        public string locale { get; set; }
        public string rarity { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public Mechanic[] mechanics { get; set; }
        public string img { get; set; }
        public string flavor { get; set; }
        public string armor { get; set; }
        public bool elite { get; set; }
        public int cost { get; set; }
        public string howToGet { get; set; }
        public string howToGetGold { get; set; }
        public string imgGold { get; set; }
        public int attack { get; set; }
        public int durability { get; set; }
        public string spellSchool { get; set; }
        public string race { get; set; }
        public string[] otherRaces { get; set; }
        public string howToGetSignature { get; set; }
        public string multiClassGroup { get; set; }
        public string[] classes { get; set; }
    }

    public class Mechanic
    {
        public string name { get; set; }
    }

}
