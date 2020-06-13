using System;
using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Motorbikes.Marks;
using Loppprojekt.Data.Motorbikes.Models;

namespace Loppprojekt.Infra.Motorbikes.BikeDb
{
    public static class BikeDbInitializer
    {

        internal static BikeMarkData bmw = new BikeMarkData
        {
            Name = "BMW",
            Country = "Germany",
            Description = "Bayerische Motoren Werke AG, commonly referred to as BMW, is a German multinational company which produces luxury vehicles and motorcycles. The company was founded in 1916 as a manufacturer of aircraft engines, which it produced from 1917 until 1918 and again from 1933 to 1945.",
            YearOfManufacture = Convert.ToDateTime("20/07/1916")
        };

        internal static BikeMarkData harleyDavidson = new BikeMarkData
        {
            Name = "Harley-Davidson",
            Country = "USA",
            Description = "Harley-Davidson, Inc., H-D, or Harley, is an American motorcycle manufacturer founded in 1903 in Milwaukee, Wisconsin. It was one of two major American motorcycle manufacturers to survive the Great Depression, along with Indian.",
            YearOfManufacture = Convert.ToDateTime("17/05/1903")
        };

        internal static BikeMarkData honda = new BikeMarkData
        {
            Name = "Honda",
            Country = "Japan",
            Description = "Honda Motor Company is a Japanese public multinational conglomerate corporation primarily known as a manufacturer of automobiles, motorcycles, and power equipment. Honda has been the worlds largest motorcycle manufacturer since 1959, reaching a production of 400 million by the end of 2019, as well as the worlds largest manufacturer of internal combustion engines measured by volume, producing more than 14 million internal combustion engines each year. Honda became the second-largest Japanese automobile manufacturer in 2001. Honda was the eighth largest automobile manufacturer in the world in 2015.",
            YearOfManufacture = Convert.ToDateTime("24/09/1948")
        };

        internal static BikeMarkData kawasaki = new BikeMarkData
        {
            Name = "Kawasaki",
            Country = "Japan",
            Description = "Kawasaki Heavy Industries Ltd. (KHI) is a Japanese public multinational corporation primarily known as a manufacturer of motorcycles, heavy equipment, aerospace and defense equipment, rolling stock and ships.",
            YearOfManufacture = Convert.ToDateTime("15/10/1896")
        };

        internal static BikeMarkData yamaha = new BikeMarkData
        {
            Name = "Yamaha",
            Country = "Japan",
            Description = "Yamaha Corporation is a Japanese multinational corporation and conglomerate with a very wide range of products and services. It is one of the constituents of Nikkei 225 and is the world's largest piano manufacturing company. The former motorcycle division was established in 1955 as Yamaha Motor Co., Ltd., which started as an affiliated company but later became independent, although Yamaha Corporation is still a major shareholder.",
            YearOfManufacture = Convert.ToDateTime("12/10/1887")
        };

        internal static List<BikeMarkData> bikeMarks => new List<BikeMarkData>
        {
            honda, bmw, harleyDavidson, kawasaki, yamaha
        };

        internal static BikeModelData s1000RR = new BikeModelData
        {
            BikeMarkId = "BMW",
            Name = "S 1000 RR",
            Country = "Germany",
            BikeBodyType = "Sport",
            BikePower = "152",
            BikeAcceleration = "3.1",
            MaxSpeed = "299",
            Description = "BMW S1000RR is a race oriented sport bike initially made by BMW Motorrad to compete in the 2009 Superbike World Championship, that is now in commercial production. It was introduced in Munich in April 2008, and is powered by a 999 cc (61.0 cu in) four-cylinder engine redlined at 14,200 rpm.",
            YearOfManufacture = Convert.ToDateTime("19/04/2009")
        };

        internal static BikeModelData r1250GS = new BikeModelData
        {
            BikeMarkId = "BMW",
            Name = "R 1250 GS",
            Country = "Germany",
            BikeBodyType = "Enduro",
            BikePower = "100",
            BikeAcceleration = "3.6",
            MaxSpeed = "200",
            Description = "The BMW R1250GS is a motorcycle manufactured in Berlin, Germany by BMW Motorrad, part of the BMW group. It is one of the BMW GS family of dual sport motorcycles. It has a 1,254 cc (76.5 cu in), two-cylinder boxer engine with 4-valves per cylinder and variable valve timing (VVT).",
            YearOfManufacture = Convert.ToDateTime("19/11/2010")
        };

        internal static BikeModelData r1250RT = new BikeModelData
        {
            BikeMarkId = "BMW",
            Name = "R 1250 RT",
            Country = "Germany",
            BikeBodyType = "Touring",
            BikePower = "100",
            BikeAcceleration = "3.7",
            MaxSpeed = "200",
            Description = "The BMW R1250RT is a touring or sport touring motorcycle that was introduced in 2005 by BMW Motorrad to replace the R1150RT model. It features a 1,170 cc (71 cu in) flat-twin engine with a six-speed gearbox and shaft drive.",
            YearOfManufacture = Convert.ToDateTime("06/03/2005")
        };

        internal static List<BikeModelData> bmwBikeModels => new List<BikeModelData>
        {
            s1000RR, r1250GS, r1250RT
        };

        internal static BikeModelData streetRod = new BikeModelData
        {
            BikeMarkId = "Harley-Davidson",
            Name = "Street Rod",
            Country = "Germany",
            BikeBodyType = "Street",
            BikePower = "77",
            BikeAcceleration = "4.5",
            MaxSpeed = "200",
            Description = "Harley-Davidson has collaborated with Japanese design house Graphers Rock to create a special limited edition Street Rod motorcycle. It features a hand-painted white fuel tank with the ‘Freedom’ name printed in large black font.",
            YearOfManufacture = Convert.ToDateTime("21/08/2019")
        };

        internal static BikeModelData fatBoy114 = new BikeModelData
        {
            BikeMarkId = "Harley-Davidson",
            Name = "Fat Boy 114",
            Country = "Germany",
            BikeBodyType = "Chopper",
            BikePower = "70",
            BikeAcceleration = "5.1",
            MaxSpeed = "150",
            Description = "The Harley-Davidson Fat Boy, is a V-twin softail cruiser motorcycle with solid-cast disc wheels.",
            YearOfManufacture = Convert.ToDateTime("29/07/1990")
        };

        internal static BikeModelData cvoLimited = new BikeModelData
        {
            BikeMarkId = "Harley-Davidson",
            Name = "CVO Limited",
            Country = "Germany",
            BikeBodyType = "Chopper",
            BikePower = "98",
            BikeAcceleration = "4.4",
            MaxSpeed = "180",
            Description = "Harley-Davidson CVO (Custom Vehicle Operations)for motorcycles are a family of models created by Harley-Davidson for the factory custom market. For every model year since the program's inception in 1999, Harley-Davidson has chosen a small selection of its mass-produced motorcycle models and created limited-edition customizations of those platforms with larger-displacement engines, costlier paint designs, and additional accessories not found on the mainstream models.",
            YearOfManufacture = Convert.ToDateTime("17/04/2009")
        };

        internal static List<BikeModelData> harleyBikeModels => new List<BikeModelData>
        {
            streetRod, fatBoy114, cvoLimited
        };

        internal static BikeModelData cbr1000RRRFierblade = new BikeModelData
        {
            BikeMarkId = "Honda",
            Name = "CBR1000RR-R Fireblade",
            Country = "Japan",
            BikeBodyType = "Sport",
            BikePower = "160",
            BikeAcceleration = "3.0",
            MaxSpeed = "299",
            Description = "The CBR1000RR, marketed in some countries as the `Fireblade`, is a 998 cc (60.9 cu in) liquid-cooled inline four-cylinder superbike, introduced by Honda in 2004 as the 7th generation of the CBR series of motorcycles that began with the CBR900RR in 1992.",
            YearOfManufacture = Convert.ToDateTime("28/10/2004")
        };

        internal static BikeModelData cb1000R = new BikeModelData
        {
            BikeMarkId = "Honda",
            Name = "CB1000R",
            Country = "Japan",
            BikeBodyType = "Street",
            BikePower = "106",
            BikeAcceleration = "3.9",
            MaxSpeed = "250",
            Description = "The Honda CB1000R is a CB series 1,000 cc (61 cu in) four-cylinder standard or naked motorcycle made by Honda from 2008 to 2016, and resumed from 2018.",
            YearOfManufacture = Convert.ToDateTime("07/02/2008")
        };

        internal static BikeModelData nc750X = new BikeModelData
        {
            BikeMarkId = "Honda",
            Name = "NC750X",
            Country = "Japan",
            BikeBodyType = "Enduro",
            BikePower = "40",
            BikeAcceleration = "4.3",
            MaxSpeed = "150",
            Description = "The Honda NC700 series is a family of motorcycles produced by Honda since 2012. NC700 series was a 'new concept', being unlike conventional motorcycles, a bike designed for commuters, new or veteran riders.",
            YearOfManufacture = Convert.ToDateTime("05/11/2012")
        };

        internal static List<BikeModelData> hondaBikeModels => new List<BikeModelData>
        {
            cbr1000RRRFierblade, cb1000R, nc750X
        };

        internal static BikeModelData ninjaH2SX = new BikeModelData
        {
            BikeMarkId = "Kawasaki",
            Name = "Ninja H2 SX",
            Country = "Japan",
            BikeBodyType = "Sport",
            BikePower = "147",
            BikeAcceleration = "3.3",
            MaxSpeed = "310",
            Description = "The Kawasaki Ninja H2 is a supercharged supersport class motorcycle in the Ninja sportbike series, manufactured by Kawasaki Heavy Industries, featuring a variable-speed centrifugal-type supercharger.",
            YearOfManufacture = Convert.ToDateTime("04/06/2015")
        };

        internal static BikeModelData ninjaZX10R = new BikeModelData
        {
            BikeMarkId = "Kawasaki",
            Name = "Ninja ZX-10R",
            Country = "Japan",
            BikeBodyType = "Sport",
            BikePower = "148",
            BikeAcceleration = "3.5",
            MaxSpeed = "280",
            Description = "The Kawasaki Ninja ZX-10R is a motorcycle in the Ninja sport bike series from the Japanese manufacturer Kawasaki, the successor to the Ninja ZX-9R. It was originally released in 2004 and has been updated and revised throughout the years.",
            YearOfManufacture = Convert.ToDateTime("12/05/2004")
        };

        internal static BikeModelData ninjaH2R = new BikeModelData
        {
            BikeMarkId = "Kawasaki",
            Name = "Ninja H2R",
            Country = "Japan",
            BikeBodyType = "Sport",
            BikePower = "228",
            BikeAcceleration = "2.3",
            MaxSpeed = "380",
            Description = "Kawasaki Ninja H2R - a racing version designed only for the track and issuing 310 hp",
            YearOfManufacture = Convert.ToDateTime("01/09/2014")
        };

        internal static List<BikeModelData> kawasakiBikeModels => new List<BikeModelData>
        {
            ninjaH2R, ninjaH2SX, ninjaZX10R
        };

        internal static BikeModelData mt10 = new BikeModelData
        {
            BikeMarkId = "Yamaha",
            Name = "MT-10",
            Country = "Japan",
            BikeBodyType = "Street",
            BikePower = "117",
            BikeAcceleration = "3.4",
            MaxSpeed = "280",
            Description = "The Yamaha MT-10 (called FZ-10 in North America until 2017) is a MT series naked bike manufactured by Yamaha Motor Company since 2016. It was introduced at the 2015 EICMA in Milan, Italy. It is the flagship member of the MT range from Yamaha.",
            YearOfManufacture = Convert.ToDateTime("03/10/2016")
        };

        internal static BikeModelData yzfR1 = new BikeModelData
        {
            BikeMarkId = "Yamaha",
            Name = "YZF-R1",
            Country = "Japan",
            BikeBodyType = "Sport",
            BikePower = "147",
            BikeAcceleration = "3.1",
            MaxSpeed = "350",
            Description = "The Yamaha YZF-R1, or R1, is an open class sport bike, or superbike, motorcycle made by Yamaha from 1998 through the current 2020 model year.",
            YearOfManufacture = Convert.ToDateTime("17/08/1998")
        };

        internal static BikeModelData xt1200ZE = new BikeModelData
        {
            BikeMarkId = "Yamaha",
            Name = "XT1200ZE",
            Country = "Japan",
            BikeBodyType = "Enduro",
            BikePower = "82",
            BikeAcceleration = "5.6",
            MaxSpeed = "160",
            Description = "The Yamaha XT1200Z Super Ténéré is a motorcycle produced by Yamaha Motor Corporation, that was launched in 2010. The XT1200Z is the largest in a series of dual-sport Yamaha motorcycles named after the Ténéré, a desert region in the south central Sahara.",
            YearOfManufacture = Convert.ToDateTime("11/06/2010")
        };

        internal static List<BikeModelData> yamahaBikeModels => new List<BikeModelData>
        {
            mt10, yzfR1, xt1200ZE
        };

        public static void Initialize(BikeDbContext db)
        {
            initializeBikeMarks(db);
            initializeBikeModels(db);
        }

        private static void initializeBikeModels(BikeDbContext db)
        {
            if (db.BikeModels.Count() != 0) return;
            db.BikeModels.AddRange(yamahaBikeModels);
            db.BikeModels.AddRange(hondaBikeModels);
            db.BikeModels.AddRange(bmwBikeModels);
            db.BikeModels.AddRange(harleyBikeModels);
            db.BikeModels.AddRange(kawasakiBikeModels);
            db.SaveChanges();
        }

        private static void initializeBikeMarks(BikeDbContext db)
        {
            if (db.BikeMarks.Count() != 0) return;
            db.BikeMarks.AddRange(bikeMarks);
            db.SaveChanges();
        }

    }
}
