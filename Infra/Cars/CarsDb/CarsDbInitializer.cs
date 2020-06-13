using System;
using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Cars.Generations;
using Loppprojekt.Data.Cars.Marks;
using Loppprojekt.Data.Cars.Models;

namespace Loppprojekt.Infra.Cars.CarsDb
{
    public static class CarsDbInitializer
    {
        internal static MarkData bmw = new MarkData
        {
            Name = "BMW",
            Country = "Germany",
            Description = "Bayerische Motoren Werke AG, commonly referred to as BMW, is a German multinational company which produces luxury vehicles and motorcycles. The company was founded in 1916 as a manufacturer of aircraft engines, which it produced from 1917 until 1918 and again from 1933 to 1945.",
            YearOfManufacture = Convert.ToDateTime("20/07/1916")
        };
        internal static MarkData mercedes = new MarkData
        {
            Name = "Mercedes-Benz",
            Country = "Germany",
            Description = "Mercedes-Benz is a German global automobile marque and a division of Daimler AG. Mercedes-Benz is known for luxury vehicles, vans, trucks, buses, coaches and ambulances. The headquarters is in Stuttgart, Baden-Württemberg. The name first appeared in 1926 under Daimler-Benz. In 2018, Mercedes-Benz was the largest seller of premium vehicles in the world, having sold 2.31 million passenger cars",
            YearOfManufacture = Convert.ToDateTime("18/11/1926")
        };
        internal static MarkData honda = new MarkData
        {
            Name = "Honda",
            Country = "Japan",
            Description = "Honda Motor Company is a Japanese public multinational conglomerate corporation primarily known as a manufacturer of automobiles, motorcycles, and power equipment. Honda has been the worlds largest motorcycle manufacturer since 1959, reaching a production of 400 million by the end of 2019, as well as the worlds largest manufacturer of internal combustion engines measured by volume, producing more than 14 million internal combustion engines each year. Honda became the second-largest Japanese automobile manufacturer in 2001. Honda was the eighth largest automobile manufacturer in the world in 2015.",
            YearOfManufacture = Convert.ToDateTime("24/09/1948")
        };
        internal static MarkData audi = new MarkData
        {
            Name = "Audi",
            Country = "Germany",
            Description = "Audi AG is a German automobile manufacturer that designs, engineers, produces, markets and distributes luxury vehicles. Audi is a member of the Volkswagen Group and has its roots at Ingolstadt, Bavaria, Germany. Audi-branded vehicles are produced in nine production facilities worldwide.",
            YearOfManufacture = Convert.ToDateTime("16/07/1909")
        };
        internal static MarkData lamborghini = new MarkData
        {
            Name = "Lamborghini",
            Country = "Italy",
            Description = "Automobili Lamborghini S.p.A. is an Italian brand and manufacturer of luxury sports cars and SUVs based in Sant'Agata Bolognese. The company is owned by the Volkswagen Group through its subsidiary Audi.",
            YearOfManufacture = Convert.ToDateTime("30/10/1963")
        };
        internal static MarkData mitsubishi = new MarkData
        {
            Name = "Mitsubishi",
            Country = "Japan",
            Description = "Mitsubishi Motors Corporation is a Japanese multinational automotive manufacturer headquartered in Minato, Tokyo, Japan. In 2011, Mitsubishi Motors was the sixth-largest Japanese automaker and the nineteenth-largest worldwide by production. From October 2016 onwards, Mitsubishi has been one-third (34%) owned by Nissan, and thus a part of the Renault–Nissan–Mitsubishi Alliance.",
            YearOfManufacture = Convert.ToDateTime("22/04/1970")
        };
        internal static MarkData porsche = new MarkData
        {
            Name = "Porsche",
            Country = "Germany",
            Description = "Dr.-Ing. h.c. F. Porsche AG, usually shortened to Porsche is a German automobile manufacturer specializing in high-performance sports cars, SUVs and sedans. The headquarters of Porsche AG is in Stuttgart, and is owned by Volkswagen AG, a controlling stake of which is owned by Porsche Automobil Holding SE. Porsche's current lineup includes the 718 Boxster/Cayman, 911, Panamera, Macan, Cayenne and Taycan.",
            YearOfManufacture = Convert.ToDateTime("25/04/1931")
        };
        internal static MarkData subaru = new MarkData
        {
            Name = "Subaru",
            Country = "Japan",
            Description = "Subaru is the automobile manufacturing division of Japanese transportation conglomerate Subaru Corporation (formerly known as Fuji Heavy Industries), the twenty-second largest automaker by production worldwide in 2012. Subaru cars are known for their use of a boxer engine layout in most vehicles above 1500 cc",
            YearOfManufacture = Convert.ToDateTime("15/07/1953")
        };
        internal static MarkData toyota = new MarkData
        {
            Name = "Toyota",
            Country = "Japan",
            Description = "Toyota Motor Corporation is a Japanese multinational automotive manufacturer headquartered in Toyota, Aichi, Japan. In 2017, Toyota's corporate structure consisted of 364,445 employees worldwide and, as of December 2019, was the tenth-largest company in the world by revenue. Toyota is the largest automobile manufacturer in Japan, and the second-largest in the world behind Volkswagen, based on 2018 unit sales. Toyota was the world's first automobile manufacturer to produce more than 10 million vehicles per year.",
            YearOfManufacture = Convert.ToDateTime("28/08/1937")
        };
        internal static MarkData volkswagen = new MarkData
        {
            Name = "Volkswagen",
            Country = "Germany",
            Description = "Volkswagen is a German automaker founded in 1937 by the German Labour Front, known for the iconic Beetle and headquartered in Wolfsburg. It is the flagship marque of the Volkswagen Group, the largest automaker by worldwide sales in 2016 and 2017. The group's biggest market is in China, which delivers 40% of its sales and profits. Volkswagen translates to people's car in German.The company's current international advertising slogan is just Volkswagen, referencing the name's meaning.",
            YearOfManufacture = Convert.ToDateTime("28/05/1937")
        };

        internal static List<MarkData> marks => new List<MarkData>
        {
            bmw, mercedes, honda, audi, lamborghini, mitsubishi, porsche, subaru, toyota, volkswagen
        };

        internal static ModelData series3 = new ModelData
        {
            MarkId = "BMW",
            Name = "3.series",
            Country = "Germany",
            Description = "The BMW 3 Series is a compact executive car manufactured by the German automaker BMW since May 1975. It is the successor to the 02 Series and has been produced in seven different generations. The 3 Series is BMW's best-selling model, accounting for around 30% of the BMW brand's annual total sales (excluding motorbikes).",
            YearOfManufacture = Convert.ToDateTime("27/08/1975")
        };
        internal static ModelData series5 = new ModelData
        {
            MarkId = "BMW",
            Name = "5.series",
            Country = "Germany",
            Description = "The BMW 5 Series is an executive car manufactured by BMW since 1972. It is the successor to the New Class Sedans and is currently in its seventh generation. The 5 Series is BMW's second best-selling model after the 3 Series.",
            YearOfManufacture = Convert.ToDateTime("13/02/1972")
        };
        internal static ModelData x5 = new ModelData
        {
            MarkId = "BMW",
            Name = "X5",
            Country = "Germany",
            Description = "The BMW X5 is a mid-size crossover from the German automaker BMW. The car was introduced in 1999 at the Detroit Auto Show. The letter `X` means that the car has all-wheel drive, and the number `5` means that the 5th series (BMW E39) served as the base, but the X5 is shorter than the E39, but higher and wider. The E53 body resembles the BMW E46 Touring. The machine is adapted for driving on all types of pavement; this is due to its large clearance and permanent all-wheel drive.",
            YearOfManufacture = Convert.ToDateTime("04/03/1999")
        };
        internal static List<ModelData> bmwModels => new List<ModelData>
        {
            series3, series5, x5
        };

        internal static ModelData a4 = new ModelData
        {
            MarkId = "Audi",
            Name = "A4",
            Country = "Germany",
            Description = "The Audi A4 is a line of compact executive cars produced since 1994 by the German car manufacturer Audi, a subsidiary of the Volkswagen Group. The A4 has been built in five generations and is based on the Volkswagen Group B platform. The first generation A4 succeeded the Audi 80.",
            YearOfManufacture = Convert.ToDateTime("26/11/1994")
        };
        internal static ModelData q7 = new ModelData
        {
            MarkId = "Audi",
            Name = "Q7",
            Country = "Germany",
            Description = "The Audi Q7 is a mid-size luxury SUV made by the German manufacturer Audi, unveiled in September 2005 at the Frankfurt Motor Show. Production of this seven-seater SUV began in the autumn of 2005 at the Volkswagen Bratislava Plant in Bratislava, Slovakia. It was the first SUV offering from Audi and went on sale in 2006. Later, Audi's second SUV, the Q5, was unveiled as a 2009 model.",
            YearOfManufacture = Convert.ToDateTime("01/11/2005")
        };
        internal static ModelData tt = new ModelData
        {
            MarkId = "Audi",
            Name = "TT",
            Country = "Germany",
            Description = "The Audi TT is a 2-door sports car marketed by Volkswagen Group subsidiary Audi since 1998, and now in its third generation. The first two generations were assembled by the Audi subsidiary Audi Hungaria Motor Kft. in Győr, Hungary, using bodyshells manufactured and painted at Audi's Ingolstadt plant and parts made entirely by the Hungarian factory for the third generation.",
            YearOfManufacture = Convert.ToDateTime("10/05/1998")
        };
        internal static List<ModelData> audiModels => new List<ModelData>
        {
            a4, q7, tt
        };

        internal static ModelData accord = new ModelData
        {
            MarkId = "Honda",
            Name = "Accord",
            Country = "Japan",
            Description = "The Honda Accord is a series of automobiles manufactured by Honda since 1976, best known for its four-door sedan variant, which has been one of the best-selling cars in the United States since 1989. The Accord nameplate has been applied to a variety of vehicles worldwide, including coupes, station wagons, hatchbacks and a Honda Crosstour crossover.",
            YearOfManufacture = Convert.ToDateTime("22/03/1976")
        };
        internal static ModelData civic = new ModelData
        {
            MarkId = "Honda",
            Name = "Civic",
            Country = "Japan",
            Description = "The Honda Civic is a line of cars manufactured by Honda. Originally a subcompact, the Civic has gone through several generational changes, becoming both larger and more upscale, moving into the compact car segment. The first generation Civic was introduced in July 1972 as a two-door model, followed by a three-door hatchback that September.",
            YearOfManufacture = Convert.ToDateTime("08/09/1972")
        };
        internal static ModelData crv = new ModelData
        {
            MarkId = "Honda",
            Name = "CR-V",
            Country = "Japan",
            Description = "The Honda CR-V is a compact crossover SUV manufactured by Japanese automaker Honda since 1995 and introduced in the North American market in 1997. It uses the Honda Civic platform with an SUV body design. The CR-V is Honda's mid-range utility vehicle, slotting between the smaller Honda HR-V and the larger North American market Honda Passport. Honda states `CR - V` stands for `Comfortable Runabout Vehicle`, while the term `Compact Recreational Vehicle` is used in a British car review article that was republished by Honda",
            YearOfManufacture = Convert.ToDateTime("16/06/1995")
        };
        internal static List<ModelData> hondaModels => new List<ModelData>
        {
            accord, civic, crv
        };

        internal static ModelData lancer = new ModelData
        {
            MarkId = "Mitsubishi",
            Name = "Lancer",
            Country = "Japan",
            Description = "The Mitsubishi Lancer is a compact car produced by the Japanese manufacturer Mitsubishi since 1973. Mitsubishi ended production of the Lancer in August 2017 worldwide, with the exception of Taiwan and Mainland China.",
            YearOfManufacture = Convert.ToDateTime("21/07/1973")
        };
        internal static ModelData galant = new ModelData
        {
            MarkId = "Mitsubishi",
            Name = "Galant",
            Country = "Japan",
            Description = "The Mitsubishi Galant is an automobile which was produced by Japanese manufacturer Mitsubishi from 1969 to 2012. The model name was derived from the French word galant, meaning `chivalrous`. There have been nine distinct generations with total cumulative sales exceeding five million units.",
            YearOfManufacture = Convert.ToDateTime("05/04/1969")
        };
        internal static ModelData pajero = new ModelData
        {
            MarkId = "Mitsubishi",
            Name = "Pajero",
            Country = "Japan",
            Description = "The Mitsubishi Pajero is a full-size sport utility vehicle manufactured and marketed globally by Mitsubishi.",
            YearOfManufacture = Convert.ToDateTime("18/07/1982")
        };
        internal static List<ModelData> mitsubishiModels => new List<ModelData>
        {
            lancer, galant, pajero
        };

        internal static ModelData camry = new ModelData
        {
            MarkId = "Toyota",
            Name = "Camry",
            Country = "Japan",
            Description = "The Toyota Camry is an automobile sold internationally by the Japanese manufacturer Toyota since 1982, spanning multiple generations. Originally compact in size (narrow-body), later Camry models have grown to fit the mid-size classification (wide-body)—although the two sizes co-existed in the 1990s.",
            YearOfManufacture = Convert.ToDateTime("11/03/1982")
        };
        internal static ModelData hilux = new ModelData
        {
            MarkId = "Toyota",
            Name = "Hilux",
            Country = "Japan",
            Description = "The Toyota Hilux (stylized as HiLux and historically as Hi-Lux) is a series of pickup trucks produced and marketed by the Japanese automobile manufacturer Toyota. The majority of these vehicles were sold as pickup truck or cab chassis variants, although they could be configured in a variety of body styles.",
            YearOfManufacture = Convert.ToDateTime("14/03/1968")
        };
        internal static ModelData supra = new ModelData
        {
            MarkId = "Toyota",
            Name = "Supra",
            Country = "Japan",
            Description = "The Toyota Supra is a sports car and grand tourer manufactured by Toyota Motor Corporation beginning in 1978. The initial four generations of the Supra were produced from 1978 to 2002. The fifth generation has been produced since March 2019 and went on sale in May 2019. The styling of the original Supra was derived from the Toyota Celica, but it was both longer and wider.",
            YearOfManufacture = Convert.ToDateTime("19/04/1978")
        };
        internal static List<ModelData> toyotaModels => new List<ModelData>
        {
            camry, hilux, supra
        };

        internal static ModelData impreza = new ModelData
        {
            MarkId = "Subaru",
            Name = "Impreza",
            Country = "Japan",
            Description = "The Subaru Impreza is a compact car that has been manufactured by Subaru since 1992. It was introduced as a replacement for the Leone, with the predecessor's EA series engines replaced by the new EJ series. It is now in its fifth generation.",
            YearOfManufacture = Convert.ToDateTime("15/08/1992")
        };
        internal static ModelData forester = new ModelData
        {
            MarkId = "Subaru",
            Name = "Forester",
            Country = "Japan",
            Description = "The Subaru Forester is a compact crossover SUV (sport utility vehicle) that's been manufactured since 1997 by Subaru. Available in Japan from 1997, the Forester shares its platform with the Impreza. It has been awarded Motor Trend's 2009 and 2014 SUV of the Year and The Car Connection's Best Car To Buy 2014",
            YearOfManufacture = Convert.ToDateTime("06/07/1997")
        };
        internal static ModelData legacy = new ModelData
        {
            MarkId = "Subaru",
            Name = "Legacy",
            Country = "Japan",
            Description = "The Subaru Legacy is a midsize car built by Japanese automobile manufacturer Subaru since 1989. The maker's flagship car, it is unique in its class for offering all-wheel drive as a standard feature, and Subaru's traditional BOXER engine. The Legacy is sold as the Liberty in Australia out of deference to Legacy Australia, an organisation dedicated to caring for the families of military service veterans.",
            YearOfManufacture = Convert.ToDateTime("13/04/1989")
        };
        internal static List<ModelData> subaruModels => new List<ModelData>
        {
            impreza, forester, legacy
        };

        internal static ModelData eclass = new ModelData
        {
            MarkId = "Mercedes-Benz",
            Name = "E-class",
            Country = "Germany",
            Description = "The Mercedes-Benz E-Class is a range of executive cars manufactured by German automaker Mercedes-Benz in various engine and body configurations. Produced since 1953, the E-Class falls midrange in the Mercedes line-up, and has been marketed worldwide across five generations. By the launch of the facelifted W124 in 1993 fuel-injection was ubiquitous in Mercedes engines, and the E was adopted as a prefix (i.e., E 220) and the model line referred to officially as the E-Class (or E-Klasse).",
            YearOfManufacture = Convert.ToDateTime("22/05/1953")
        };
        internal static ModelData sclass = new ModelData
        {
            MarkId = "Mercedes-Benz",
            Name = "S-class",
            Country = "Germany",
            Description = "The Mercedes-Benz S-Class, formerly known as Sonderklasse (German for `special class`, abbreviated as `S-Klasse`), is a series of full-size luxury sedans and limousines produced by the German automaker Mercedes-Benz, a division of German company Daimler AG. The S-Class designation for top-of-the-line Mercedes-Benz models was officially introduced in 1972 with the W116, and has remained in use ever since.",
            YearOfManufacture = Convert.ToDateTime("27/02/1954")
        };
        internal static ModelData gclass = new ModelData
        {
            MarkId = "Mercedes-Benz",
            Name = "G-class",
            Country = "Germany",
            Description = "The Mercedes-Benz G-Class, sometimes called G-Wagen (short for Geländewagen, `terrain vehicle`), is a mid-size four-wheel drive luxury SUV manufactured by Magna Steyr (formerly Steyr-Daimler-Puch) in Austria and sold by Mercedes-Benz. In certain markets, it has been sold under the Puch name as Puch G.",
            YearOfManufacture = Convert.ToDateTime("14/10/1979")
        };
        internal static List<ModelData> mercedesModels => new List<ModelData>
        {
            eclass, sclass, gclass
        };

        internal static ModelData m911 = new ModelData
        {
            MarkId = "Porsche",
            Name = "911",
            Country = "Germany",
            Description = "JThe Porsche 911 (pronounced Nine Eleven or in German: Neunelfer) is a two-door, 2+2 high performance rear-engined sports car. Introduced in September 1964 by Porsche AG of Stuttgart, Germany. It has a rear-mounted flat-six engine and all round independent suspension. It has undergone continuous development, though the basic concept has remained unchanged.[1] The engines were air-cooled until the introduction of the Type 996 in 1998, with the 993, produced from 1994–1998 model years, being the last of the air-cooled Porsche sports cars",
            YearOfManufacture = Convert.ToDateTime("09/07/1963")
        };
        internal static ModelData cayenne = new ModelData
        {
            MarkId = "Porsche",
            Name = "Cayenne",
            Country = "Germany",
            Description = "The Porsche Cayenne is a mid-size luxury crossover sport utility vehicle produced by the German manufacturer Porsche since 2002, with North American sales beginning in 2003. It is the first V8-engined vehicle built by Porsche since 1995, when the Porsche 928 was discontinued. It is also Porsche's first off-road variant vehicle since its Super and Junior tractors of the 1950s, and the first Porsche with four doors. Since 2008, all engines have featured direct injection technology",
            YearOfManufacture = Convert.ToDateTime("02/04/2002")
        };
        internal static ModelData panamera = new ModelData
        {
            MarkId = "Porsche",
            Name = "Panamera",
            Country = "Germany",
            Description = "The Porsche Panamera is a full-sized luxury vehicle (F-segment in Europe) manufactured by the German automobile manufacturer Porsche. It is front-engined and has a rear-wheel-drive layout, with all-wheel drive versions also available.",
            YearOfManufacture = Convert.ToDateTime("01/04/2009")
        };
        internal static List<ModelData> porscheModels => new List<ModelData>
        {
            m911, cayenne, panamera
        };

        internal static ModelData golf = new ModelData
        {
            MarkId = "Volkswagen",
            Name = "Golf",
            Country = "Germany",
            Description = "The Volkswagen Golf is a compact car produced by the German automotive manufacturer Volkswagen since 1974, marketed worldwide across eight generations, in various body configurations and under various nameplates – such as the Volkswagen Rabbit in the United States and Canada (Mk1 and Mk5), and as the Volkswagen Caribe in Mexico (Mk1). The original Golf Mk1 was a front-engined, front-wheel drive replacement for the air-cooled, rear-engined, rear-wheel drive Volkswagen Beetle. Historically, the Golf is Volkswagen's best-selling model and is among the world's top three best-selling models, with more than thirty million built as of June 2013.",
            YearOfManufacture = Convert.ToDateTime("26/07/1974")
        };
        internal static ModelData passat = new ModelData
        {
            MarkId = "Volkswagen",
            Name = "Passat",
            Country = "Germany",
            Description = "The Volkswagen Passat is a large family car manufactured and marketed by the German automobile manufacturer Volkswagen since 1973, and now in its eighth generation. It has been marketed variously as the Dasher, Santana, Quantum, Magotan, Corsar and Carat. The successive generations of the Passat carry the Volkswagen internal designations B1, B2, etc. In 2008, Volkswagen launched Passat CC, a `four - door coupé` variant of the Passat.",
            YearOfManufacture = Convert.ToDateTime("06/03/1972")
        };
        internal static ModelData transporter = new ModelData
        {
            MarkId = "Volkswagen",
            Name = "Transporter",
            Country = "Germany",
            Description = "The Volkswagen Transporter, based on the Volkswagen Group's T platform, now in its sixth generation, refers to a series of vans produced for over 60 years and marketed worldwide. The T series is now considered an official Volkswagen Group automotive platform and generations are sequentially named T1, T2, T3, T4, T5 and T6. Pre-dating the T platform designations, the first three generations were named Type 2, indicating their relative position to the Type 1, or Beetle. As part of the T platform, the first three generations are retroactively named T1, T2 and T3.",
            YearOfManufacture = Convert.ToDateTime("17/08/1950")
        };
        internal static List<ModelData> volkswagenModels => new List<ModelData>
        {
            golf, passat, transporter
        };

        internal static ModelData diablo = new ModelData
        {
            MarkId = "Lamborghini",
            Name = "Diablo",
            Country = "Italy",
            Description = "The Lamborghini Diablo is a high-performance mid-engine sports car that was built by Italian automotive manufacturer Lamborghini between 1990 and 2001. It is the first production Lamborghini capable of attaining a top speed in excess of 320 kilometres per hour (200 mph). After the end of its production run in 2001, the Diablo was replaced by the Lamborghini Murciélago. The name Diablo means `devil` in Spanish.",
            YearOfManufacture = Convert.ToDateTime("10/09/1990")
        };
        internal static ModelData gallardo = new ModelData
        {
            MarkId = "Lamborghini",
            Name = "Gallardo",
            Country = "Italy",
            Description = "The Lamborghini Gallardo is a sports car built by the Italian automotive manufacturer Lamborghini from 2003 to 2013. It is Lamborghini's best-selling model with 14,022 built throughout its production run. Named after a famous breed of fighting bull, the V10 powered Gallardo has been Lamborghini's sales leader and stable-mate to a succession of V12 flagship models—first to the Murciélago (4,099 built between 2001 and 2010), then to the current flagship, the Aventador. On 25 November 2013, the last Gallardo was rolled off the production line. The Gallardo was replaced by the Huracán in 2014.",
            YearOfManufacture = Convert.ToDateTime("12/03/2003")
        };
        internal static ModelData murcielago = new ModelData
        {
            MarkId = "Lamborghini",
            Name = "Murcielago",
            Country = "Italy",
            Description = "The Lamborghini Murciélago is a sports car produced by Italian automotive manufacturer Lamborghini between 2001 and 2010. Successor to the Diablo and flagship of the automaker's lineup, the Murciélago was introduced as a coupé in 2001. The car was first available in North America for the 2002 model year. The manufacturer's first new design in eleven years, the car was also the brand's first new model under the ownership of German parent company Audi, which is owned by Volkswagen.",
            YearOfManufacture = Convert.ToDateTime("19/11/2001")
        };
        internal static List<ModelData> lamborghiniModels => new List<ModelData>
        {
            diablo, gallardo, murcielago
        };

        internal static GenerationData b5 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "A4",
            Name = "B5",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "The first generation with minor changes was produced until 2001. At first, only the sedan version was available, the station wagon version (Avant) appeared a year later. The car was based on the same platform as the fifth-generation Volkswagen Passat. In dimensions and internal dimensions, the A4 is practically no different from the Audi 80.",
            YearOfManufacture = Convert.ToDateTime("01/11/1995")
        };
        internal static GenerationData b7 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "A4",
            Name = "B7",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Audi A4 B7 - the third generation of the mid-size Audi A4, lineup from 2004 to 2007. Represents an updated model B6.",
            YearOfManufacture = Convert.ToDateTime("19/07/2004")
        };
        internal static GenerationData b9 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "A4",
            Name = "B9",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "Audi A4 V (B9) - D-class sedan, front-wheel drive and four-wheel drive. Robot, mechanics and automatic. Gasoline and diesel engines with power from 122 to 272 horsepower.",
            YearOfManufacture = Convert.ToDateTime("22/05/2011")
        };
        internal static List<GenerationData> a4Generation => new List<GenerationData>
        {
            b5, b7, b9
        };

        internal static GenerationData firstGen = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "Q7",
            Name = "Q7 1st gen",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The full-size crossover Audi Q7, which became the brand's first off-road model, made its debut as a production model in 2005. The production of cars was organized at a factory in Bratislava (Slovakia), and screwdriver assembly of cars for the Russian market since 2010 was carried out in Kaluga.",
            YearOfManufacture = Convert.ToDateTime("14/06/2006")
        };
        internal static GenerationData secondGen = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "Q7",
            Name = "Q7 2nd gen",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The second generation of the Audi Q7 model has been produced in Slovakia since 2015; cars for the Russian market are assembled at a plant in Kaluga. In the spring of 2020, sales of restyled cars began, while gasoline versions left the Russian market. The most powerful crossover modification is called the Audi SQ7.",
            YearOfManufacture = Convert.ToDateTime("28/06/2015")
        };
        internal static List<GenerationData> q7Generation => new List<GenerationData>
        {
            firstGen, secondGen
        };

        internal static GenerationData n8 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "TT",
            Name = "8N",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "Serial production of the first generation of the model began in 1998, followed by the roadster in 1999. In 1998, Audi representatives produced the experimental TT (8N) series, which did not have reverse gear. This was a protest against German law, which gave German drivers permission to drive at a speed of 12 km / h in reverse along the technical (black) lane of German autobahns. But since it was an experimental model, such Audi TTs were produced in only 320 pieces.",
            YearOfManufacture = Convert.ToDateTime("08/04/1998")
        };
        internal static GenerationData j8 = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "TT",
            Name = "8J",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "The next generation car, the Audi TT Coupe (8J), was introduced at the 2005 Tokyo Motor Show. In addition to visual changes to the exterior and interior, the Audi Magnetic Ride adaptive damping system (offered as an option) was also used for the first time on this car.",
            YearOfManufacture = Convert.ToDateTime("23/02/2006")
        };
        internal static GenerationData j8Face = new GenerationData
        {
            MarkId = "Audi",
            ModelsId = "TT",
            Name = "8J (facelift)",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "AWD",
            Description = "Audi TT II (8J facelift) - S-Class Coupe, front-wheel drive and four-wheel drive. Robot and mechanics. Gasoline and diesel engines with power from 160 to 250 horsepower.",
            YearOfManufacture = Convert.ToDateTime("02/09/2010")
        };
        internal static List<GenerationData> ttGeneration => new List<GenerationData>
        {
            n8, j8, j8Face
        };

        internal static GenerationData e36 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "3.series",
            Name = "E36",
            Country = "Germany",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "The BMW E36 is the third generation of the BMW 3 Series range of compact executive cars, and was produced from 1990 to 2000. The initial models were of the four-door sedan body style, followed by the coupe, convertible, wagon (`Touring`) and hatchback (`Compact`) bodystyles in later years.",
            YearOfManufacture = Convert.ToDateTime("26/06/1990")
        };
        internal static GenerationData e46 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "3.series",
            Name = "E46",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "RWD",
            Description = "The BMW E46 is the fourth generation of the BMW 3 Series, which was produced from 1997 to 2006.",
            YearOfManufacture = Convert.ToDateTime("18/01/1997")
        };
        internal static GenerationData f30 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "3.series",
            Name = "F30",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The sixth generation of the BMW 3 Series consists of the BMW F30 (sedan version), BMW F31 (wagon version, marketed as 'Touring') and BMW F34 (fastback version, marketed as 'Gran Turismo') compact executive cars. The F30/F31/F34 generation was produced from 2011 to 2019 and is often collectively referred to as the F30.",
            YearOfManufacture = Convert.ToDateTime("19/10/2011")
        };
        internal static List<GenerationData> series3Generation => new List<GenerationData>
        {
            e36, e46, f30
        };

        internal static GenerationData e34 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "5.series",
            Name = "E34",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The BMW E34 is the third generation of the BMW 5 Series, which was produced from November 2, 1987 until 1996. Initially launched as a sedan in January 1988, the E34 also saw a `Touring` station wagon (estate) body style added in September 1992, a first for the 5 Series. BMW replaced the E34 with the E39 5 Series in December 1995, although E34 Touring models remained in production until June 1996.",
            YearOfManufacture = Convert.ToDateTime("07/01/1988")
        };
        internal static GenerationData e60 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "5.series",
            Name = "E60",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The fifth generation of the BMW 5 Series consists of the BMW E60 (sedan version) and BMW E61 (wagon version, marketed as 'Touring') executive cars. The E60/E61 generation was produced from 2003 to 2010 and is often collectively referred to as the E60.",
            YearOfManufacture = Convert.ToDateTime("12/08/2003")
        };
        internal static GenerationData f10 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "5.series",
            Name = "F10",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The sixth generation of the BMW 5 Series consists of the BMW F10 (sedan version), BMW F11 (wagon version, marketed as 'Touring') and BMW F07 (fastback version, marketed as 'Gran Turismo') executive cars. The F10/F11/F07 was produced from 2010 to 2017 and is often collectively referred to as the F10.",
            YearOfManufacture = Convert.ToDateTime("29/04/2010")
        };
        internal static List<GenerationData> series5Generation => new List<GenerationData>
        {
            e34, e60, f10
        };

        internal static GenerationData e53 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "X5",
            Name = "E53",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The BMW E53 is the first-generation BMW X5 mid-sized luxury crossover SUV. It was produced from 1999-2006[2] and was replaced by the BMW E70. The E53 was developed at a time when BMW still owned Land Rover and as such shares many components and designs with both the Land Rover Range Rover L322 model (specifically the Hill Descent System and Off Road Engine Management system) and the BMW E39 5 Series (specifically engines and electronic systems).",
            YearOfManufacture = Convert.ToDateTime("01/09/1999")
        };
        internal static GenerationData e70 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "X5",
            Name = "E70",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The BMW E70 is the second-generation BMW X5 mid-size luxury crossover SUV. It replaced the BMW X5 (E53) in July 2006. It was manufactured alongside the BMW X6 at BMW's Greer, South Carolina plant in the U.S. and BMW's facility in Toluca, Mexico.",
            YearOfManufacture = Convert.ToDateTime("15/07/2006")
        };
        internal static GenerationData f15 = new GenerationData
        {
            MarkId = "BMW",
            ModelsId = "X5",
            Name = "F15",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The BMW X5 (F15) is a mid-size luxury SUV manufactured and marketed worldwide by BMW since 2013. The car was unveiled in the 2013 Frankfurt International Motor Show.[5] Early X5 models include xDrive50i, xDrive30d, M50d. BMW xDrive40d, xDrive35i, xDrive25d, sDrive25d were to be added in December 2013.",
            YearOfManufacture = Convert.ToDateTime("01/08/2013")
        };
        internal static List<GenerationData> x5Generation => new List<GenerationData>
        {
            e53, e70, f15
        };

        internal static GenerationData w124 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "E-class",
            Name = "W124",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "W124 is the Mercedes-Benz internal chassis-designation for the 1985 to 1995/96 version of the Mercedes-Benz E-Class, as well as the first generation to be officially referred to as E-Class. The W124 models replaced the W123 models after 1985 and were succeeded by the W210 E-Class after 1995.",
            YearOfManufacture = Convert.ToDateTime("07/11/1984")
        };
        internal static GenerationData w211 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "E-class",
            Name = "W211",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The Mercedes-Benz W211 is a chassis designation for the Mercedes-Benz E-Class, produced from 2002 through 2009. The W211 models replaced the W210 E-Class models and were superseded by the Mercedes-Benz W212 in 2009. The car was available in two body types: Sedan and Estate (Estate models were sold in the US/Canada as Wagon).",
            YearOfManufacture = Convert.ToDateTime("03/01/2002")
        };
        internal static GenerationData w212 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "E-class",
            Name = "W212",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The W212 and S212 Mercedes-Benz E-Class series is the fourth-generation of the E-Class range of executive cars which was produced by Mercedes-Benz between 2009 and 2016 as the successor to the W211 E-Class. The body styles of the range are: 4-door sedan / saloon(W212) and 5 - door estate / wagon(S212)",
            YearOfManufacture = Convert.ToDateTime("21/05/2009")
        };
        internal static List<GenerationData> eClassGeneration => new List<GenerationData>
        {
            w124, w211, w212
        };

        internal static GenerationData w140 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "S-class",
            Name = "W140",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "RWD",
            Description = "The Mercedes-Benz W140 is a series of flagship vehicles that were manufactured by the German automotive company Mercedes-Benz from 1991 to 1998. Mercedes-Benz unveiled the W140 S-Class at Geneva Motor Show in March 1991 with sales launch in April 1991 and North American launch in August 1991. The W140 represented the last of old school German engineering from Mercedes-Benz that leaned on overengineering principle, namely `engineer's car`. As with each generation of S-Class, a plethora of innovations in technology, climate protection, and creature comfort was introduced. Those innovations later trickled down to smaller C-Class and E-Class models over time.",
            YearOfManufacture = Convert.ToDateTime("17/04/1991")
        };
        internal static GenerationData w221 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "S-class",
            Name = "W221",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "The Mercedes-Benz W221 is a chassis code of S-Class, the successor of the Mercedes-Benz S-Class (W220) and the predecessor of the Mercedes-Benz S-Class (W222). The S-Class are the flagship vehicles of Mercedes-Benz and each generation typically introduces a range of technical innovations and developments that over time will find their way into smaller cars",
            YearOfManufacture = Convert.ToDateTime("18/08/2005")
        };
        internal static GenerationData w222 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "S-class",
            Name = "W222",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "The Mercedes-Benz W222 is the version of the Mercedes-Benz S-Class produced since 2013, and the successor of the Mercedes-Benz W221. The W222 was designed during 2009. The original design proposal of the car was created by Il-hun Yoon, a Korean designer, who was inspired by the Mercedes-Benz F700 concept car. The exterior design was developed by a team of designers under the direction of Robert Lešnik. W222 has a similar design theme to the CLA-Class and E-Class (W213).",
            YearOfManufacture = Convert.ToDateTime("04/06/2013")
        };
        internal static List<GenerationData> sClassGeneration => new List<GenerationData>
        {
            w140, w221, w222
        };

        internal static GenerationData w463 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "G-class",
            Name = "W463",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Mercedes-Benz W463 - the second generation of G-Class SUVs of the German brand Mercedes-Benz. Introduced in 1990 to replace the Mercedes-Benz W460 and manufactured until 2018. Compared with its predecessor, the new generation has received quite a few updates: a complete revision of the chassis, equipped with permanent all-wheel drive, the introduction of an anti-lock system and three electrically locked differentials, the installation of a completely new interior with wooden inserts and the possibility of using leather trim in the cabin.",
            YearOfManufacture = Convert.ToDateTime("06/06/1990")
        };
        internal static GenerationData w463Face = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "G-class",
            Name = "W463 (facelift)",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Mercedes-Benz W463 facelifted - the second generation of G-Class SUVs of the German brand Mercedes-Benz. Introduced in 1990 to replace the Mercedes-Benz W460 and manufactured until 2018. Compared with its predecessor, the new generation has received quite a few updates: a complete revision of the chassis, equipped with permanent all-wheel drive, the introduction of an anti-lock system and three electrically locked differentials, the installation of a completely new interior with wooden inserts and the possibility of using leather trim in the cabin.",
            YearOfManufacture = Convert.ToDateTime("13/03/2008")
        };
        internal static GenerationData w463Face2 = new GenerationData
        {
            MarkId = "Mercedes-Benz",
            ModelsId = "G-class",
            Name = "W463 (facelift 2)",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Mercedes-Benz W463 2nd facelift - the second generation of G-Class SUVs of the German brand Mercedes-Benz. Introduced in 1990 to replace the Mercedes-Benz W460 and manufactured until 2018. Compared with its predecessor, the new generation has received quite a few updates: a complete revision of the chassis, equipped with permanent all-wheel drive, the introduction of an anti-lock system and three electrically locked differentials, the installation of a completely new interior with wooden inserts and the possibility of using leather trim in the cabin.",
            YearOfManufacture = Convert.ToDateTime("23/10/2014")
        };
        internal static List<GenerationData> gClassGeneration => new List<GenerationData>
        {
            w463, w463Face, w463Face2
        };

        internal static GenerationData p996 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "911",
            Name = "996",
            Country = "Germany",
            BodyType = "Targa",
            DrivenWheel = "RWD",
            Description = "The Porsche 996 is the internal designation for the 911 model manufactured from 1997 to 2006[1] It was replaced by the 997 in 2004 but the high performance Turbo S, GT2 and GT3 variants remained in production until 2006.",
            YearOfManufacture = Convert.ToDateTime("05/05/1997")
        };
        internal static GenerationData p997 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "911",
            Name = "997",
            Country = "Germany",
            BodyType = "Convertible",
            DrivenWheel = "AWD",
            Description = "Porsche 997 is the internal designation for the Porsche 911 sports car manufactured and sold by German manufacturer Porsche between 2004 (as Model Year 2005) and 2012. Production of the Carrera and Carrera S coupés began in early 2004, all-wheel drive Carrera 4 and Carrera 4S began to be delivered to customers in November 2005, the Turbo and GT3 derivatives went on sale in late 2006 and the GT2 in 2007. ",
            YearOfManufacture = Convert.ToDateTime("15/12/2004")
        };
        internal static GenerationData p991 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "911",
            Name = "991",
            Country = "Germany",
            BodyType = "Convertible",
            DrivenWheel = "RWD",
            Description = "The Porsche 991 was the internal designation for the seventh generation of the Porsche 911 sports car, which was unveiled at the 2011 Frankfurt Motor Show on 15 September as the replacement for the 997. The 991 was an entirely new platform, only the third since the original 911 launched in 1963 (the 996 of 1999 was the second new platform). Production of the 991 generation ended on December 20, 2019, with 233,540 units produced",
            YearOfManufacture = Convert.ToDateTime("08/09/2011")
        };
        internal static List<GenerationData> p911Generation => new List<GenerationData>
        {
            p991, p996, p997
        };

        internal static GenerationData p955 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Cayenne",
            Name = "955",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The Porsche Cayenne 955 entered the market with mixed anticipation. However, it soon proved that it was the performance vehicle among SUVs and was praised for its excellent handling and powerful engines.[3] The lineup initially consisted of the V8-powered Cayenne S and Cayenne Turbo. Later in the model cycle, VR6 and diesel-powered versions joined the lineup",
            YearOfManufacture = Convert.ToDateTime("19/04/2002")
        };
        internal static GenerationData p957 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Cayenne",
            Name = "957",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "In appearance Porsche Cayenne with the index 957 immediately traced a certain article. The crossover looks sporty-looking, powerful and beautiful, and its appearance immediately recognizes belonging to this brand: teardrop-shaped optics for head lighting, embossed bumpers with aerodynamic elements and “inflated” wheel arches.",
            YearOfManufacture = Convert.ToDateTime("27/11/2008")
        };
        internal static GenerationData p958 = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Cayenne",
            Name = "958",
            Country = "Germany",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The current, second, generation of the Porsche Cayenne sports utility vehicle “appeared on the road” in 2010 - confidently continuing the successes of its predecessor (which, in its time, became the first all-terrain vehicle in the Porsche sports car model line)",
            YearOfManufacture = Convert.ToDateTime("03/08/2010")
        };
        internal static List<GenerationData> cayenneGeneration => new List<GenerationData>
        {
            p955, p957, p958
        };

        internal static GenerationData e2b = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Panamera",
            Name = "E2B",
            Country = "Germany",
            BodyType = "Fastback",
            DrivenWheel = "AWD",
            Description = "The luxury Porsche Panamera hatchback made its debut at the Shanghai Motor Show in April 2009. Initially, the model was planned to be presented at the Motor Show in Geneva in March, but the manufacturer's leadership came to the conclusion that the Asian market at that time needed it much more. The car got its name after the Carrera Panamericana race, which took place in the 50s of the last century, where Porsche cars performed very well.",
            YearOfManufacture = Convert.ToDateTime("16/04/2009")
        };
        internal static GenerationData e2bFace = new GenerationData
        {
            MarkId = "Porsche",
            ModelsId = "Panamera",
            Name = "E2B (facelift)",
            Country = "Germany",
            BodyType = "Fastback",
            DrivenWheel = "AWD",
            Description = "The luxury Porsche Panamera hatchback made its debut at the Shanghai Motor Show in April 2009. Initially, the model was planned to be presented at the Motor Show in Geneva in March, but the manufacturer's leadership came to the conclusion that the Asian market at that time needed it much more. The car got its name after the Carrera Panamericana race, which took place in the 50s of the last century, where Porsche cars performed very well.",
            YearOfManufacture = Convert.ToDateTime("16/02/2018")
        };
        internal static List<GenerationData> panameraGeneration => new List<GenerationData>
        {
           e2b, e2bFace
        };

        internal static GenerationData firstGener = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Golf",
            Name = "Golf 1st gen",
            Country = "Germany",
            BodyType = "Hatchback",
            DrivenWheel = "FWD",
            Description = "The Volkswagen Golf Mk1 is the first generation of a small family car manufactured and marketed by Volkswagen. It was noteworthy for signalling Volkswagen's shift of its major car lines from rear-wheel drive and rear-mounted air-cooled engines to front-wheel drive with front-mounted, water-cooled engines that were often transversely-mounted.",
            YearOfManufacture = Convert.ToDateTime("02/05/1974")
        };
        internal static GenerationData fifthGener = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Golf",
            Name = "Golf 5th gen",
            Country = "Germany",
            BodyType = "Hatchback",
            DrivenWheel = "FWD",
            Description = "The Volkswagen Golf Mk5 (codenamed Typ 1K) is a compact car, the fifth generation of the Volkswagen Golf and the successor to the Volkswagen Golf Mk4. Built on the Volkswagen Group A5 (PQ35) platform, it was unveiled at the Frankfurt Motor Show in October 2003 and went on sale in Europe one month later.",
            YearOfManufacture = Convert.ToDateTime("04/04/2003")
        };
        internal static GenerationData sixthGener = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Golf",
            Name = "Golf 6th gen",
            Country = "Germany",
            BodyType = "Hatchback",
            DrivenWheel = "FWD",
            Description = "The Volkswagen Golf Mk6 (or VW Typ 5K or MK VI) is a compact car, the sixth generation of the Volkswagen Golf and the successor to the Volkswagen Golf Mk5. It was unveiled at the Paris Motor Show in October 2008.",
            YearOfManufacture = Convert.ToDateTime("14/10/2008")
        };
        internal static List<GenerationData> golfGeneration => new List<GenerationData>
        {
            firstGener, fifthGener, sixthGener
        };

        internal static GenerationData b3 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Passat",
            Name = "Passat B3",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "The third generation Passat was introduced in March 1988 in Europe, 1990 in North America, and 1995 in South America. The lack of a grille made the car's front end styling reminiscent of older, rear-engined Volkswagens, such as the 411, and also doubled as a modern styling trend. The styling was developed from the 1981 aerodynamic (cd 0.25) Auto 2000 concept car.",
            YearOfManufacture = Convert.ToDateTime("19/03/1988")
        };
        internal static GenerationData b6 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Passat",
            Name = "Passat B6",
            Country = "Germany",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "The B6 Passat was first displayed at the Geneva Motor Show in March 2005, and launched in Europe in the summer of 2005. Unlike its predecessor, the B6 Passat no longer shared its platform with Audi's equivalent model (the Audi A4). Based on a modified version of the Mk5 Golf's PQ46 platform, the B6 featured a transverse rather than longitudinal engine layout of its predecessor, like the previous B3 and B4 generations, which were related to the A2 (Golf) platform",
            YearOfManufacture = Convert.ToDateTime("01/03/2005")
        };
        internal static GenerationData b7w = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Passat",
            Name = "Passat B7",
            Country = "Germany",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "The B6 Passat was facelifted by Klaus Bischoff and Walter de Silva and was unveiled at the Paris Motor Show in September 2010. Although designated `B7`,  the car is not an all - new model.The facelift resulted in new external body panels except for the roof and glasshouse, with the prominent changes to the grille and headlights.Overall height and width dimensions are unchanged from the B6 Passat.",
            YearOfManufacture = Convert.ToDateTime("06/06/2009")
        };
        internal static List<GenerationData> passatGeneration => new List<GenerationData>
        {
            b3, b6, b7w
        };

        internal static GenerationData t4 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Transporter",
            Name = "Transporter 1st gen",
            Country = "Germany",
            BodyType = "Van",
            DrivenWheel = "FWD",
            Description = "The Volkswagen Type 2, known officially (depending on body type) as the Transporter, Kombi or Microbus, or, informally, as the Bus (US) or Camper (UK), Pão de Forma (Loaf of Bread) (Portugal) is a forward control light commercial vehicle introduced in 1950 by the German automaker Volkswagen as its second car model.",
            YearOfManufacture = Convert.ToDateTime("15/11/1949")
        };
        internal static GenerationData t5 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Transporter",
            Name = "Transporter 5th gen",
            Country = "Germany",
            BodyType = "Van",
            DrivenWheel = "AWD",
            Description = "The Volkswagen Transporter T5 range is the fifth generation of Volkswagen Commercial Vehicles (VWCV/VWN) 'Transporter' series of medium-sized light commercial vehicles and the people mover Caravelle/Multivan range. It was launched 6 October 2002, and went into full production on 25 April 2003, replacing the fourth generation T4 Transporter range.",
            YearOfManufacture = Convert.ToDateTime("25/04/2003")
        };
        internal static GenerationData t6 = new GenerationData
        {
            MarkId = "Volkswagen",
            ModelsId = "Transporter",
            Name = "Transporter 6th gen",
            Country = "Germany",
            BodyType = "Van",
            DrivenWheel = "AWD",
            Description = "The Volkswagen Transporter T6 is the fifth generation of the Volkswagen Transporter vans. It is the successor to the T5 Transporter.",
            YearOfManufacture = Convert.ToDateTime("24/06/2016")
        };
        internal static List<GenerationData> caravelleGeneration => new List<GenerationData>
        {
            t4, t5, t6
        };

        internal static GenerationData firstG = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Diablo",
            Name = "Diablo 1st gen",
            Country = "Italy",
            BodyType = "Roadster",
            DrivenWheel = "RWD",
            Description = "The Diablo was presented to the public for sale on 21 January 1990. Its power came from a 5.7 L (348 cu in) dual overhead cam, 4 valves per cylinder version of the existing V12 engine and computer-controlled multi-point fuel injection, producing a maximum output of 492 PS (362 kW; 485 hp) and 580 N⋅m (428 lbf⋅ft) of torque. The vehicle could reach 0-100 km/h (62 mph) in about 4.5 seconds, with a top speed of 325 km/h (202 mph).",
            YearOfManufacture = Convert.ToDateTime("21/01/1990")
        };
        internal static GenerationData secondG = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Diablo",
            Name = "Diablo 2nd gen",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "The Diablo VT was introduced in 1993. Although the VT differed from the standard Diablo in a number of ways, by far the most notable change was the addition of all wheel drive, which made use of a viscous center differential (a modified version of LM002's 4WD system). This provided the new nomenclature for the car (VT stands for viscous traction). The new drivetrain could direct up to 25% of the torque to the front wheels to aid traction during rear wheel slip, thus significantly improving the handling characteristics of the car.",
            YearOfManufacture = Convert.ToDateTime("02/03/1993")
        };
        internal static GenerationData segondGFace = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Diablo",
            Name = "Diablo 2nd gen(facelift)",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "AWD",
            Description = "The Diablo received a mid-cycle facelift in 1999. Lamborghini simplified the model range by eliminating the `base` Diablo (since the SV model had become the new entry-level trim) and applied universal revisions across the lineup. The most immediately noticeable exterior change was the replacement of the previous Diablo's pop-up headlamp units with fixed composite lenses, borrowed under license from their original application in the Nissan 300ZX (Z32). All models were also fitted with new 18 inch wheels.",
            YearOfManufacture = Convert.ToDateTime("15/09/1999")
        };

        internal static List<GenerationData> diabloGeneration => new List<GenerationData>
        {
            firstG, secondG, segondGFace
        };

        internal static GenerationData firstGenerat = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Gallardo",
            Name = "Gallardo 1st gen",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "The first generation of the Gallardo was powered with an even firing 4,993 cc (5.0 L) 90 degree V10 engine generating a maximum power output of 500 PS (368 kW; 493 hp) at 7500 rpm and 510 N⋅m (376 lb⋅ft) of torque at 4500 rpm. The Gallardo offers two choices of transmissions, a conventional (H-pattern) six-speed manual transmission, and a more advanced six-speed electro-hydraulically actuated single-clutch automated manual transmission, similar to a Formula One style single-clutch sequential gearbox, which Lamborghini abbreviates to `E - gear`. The `E - gear` allows the driver to change gears much faster than they could with a manual transmission.",
            YearOfManufacture = Convert.ToDateTime("05/04/2003")
        };
        internal static GenerationData firstGeneratFace = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Gallardo",
            Name = "Gallardo 1st gen(facelift)",
            Country = "Italy",
            BodyType = "Convertible",
            DrivenWheel = "RWD",
            Description = "Presented at the 2008 Geneva Motor Show, the Gallardo LP 560-4 was a significant update of the Gallardo, powered by a new, uneven firing 5.2 L (5,200 cc; 320 cu in) V10 engine that produces 560 PS (412 kW; 552 hp) at 8,000 rpm and 540 N⋅m (398 lb⋅ft) of torque at 6,500 rpm. Featuring `Iniezione Diretta Stratificata` direct fuel injection system to improve efficiency; fuel consumption and CO2 emissions have been reduced by 18% despite the increase in performance. The car was redesigned, inspired by the Murciélago LP 640 and Reventón.",
            YearOfManufacture = Convert.ToDateTime("06/06/2008")
        };
        internal static List<GenerationData> gallardoGeneration => new List<GenerationData>
        {
            firstGenerat, firstGeneratFace
        };

        internal static GenerationData firstGenerati = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Murcielago",
            Name = "Murcielago 1st gen",
            Country = "Italy",
            BodyType = "Roadster",
            DrivenWheel = "AWD",
            Description = "The Murciélago is an all-wheel drive, mid-engine sports car. With an angular design and an exceptionally low slung body, the highest point of the roof is just under 4 feet (1.2 m) above the ground. One of the vehicle's most distinguishing features are its scissor doors which lend to the extreme image. The First-generation of the Murciélago was produced between 2001 and 2006 and was powered by a Lamborghini V12 that traces its roots back to the company's beginnings in the 1960s.",
            YearOfManufacture = Convert.ToDateTime("02/06/2001")
        };
        internal static GenerationData secondGenerati = new GenerationData
        {
            MarkId = "Lamborghini",
            ModelsId = "Murcielago",
            Name = "Murcielago 2nd gen",
            Country = "Italy",
            BodyType = "Coupe",
            DrivenWheel = "AWD",
            Description = "At the 2009 Geneva Motor Show, Lamborghini unveiled a high performance variant of the Murciélago, the LP 670–4 SuperVeloce. The SV moniker had previously appeared on the Diablo SV, and Miura. The SV variants are more track-oriented than the normal production variants and are usually produced in limited numbers.",
            YearOfManufacture = Convert.ToDateTime("10/08/2009")
        };
        internal static List<GenerationData> murcielagoGeneration => new List<GenerationData>
        {
            firstGenerati, secondGenerati
        };

        internal static GenerationData seventhG = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Accord",
            Name = "Accord 7th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "The seventh generation of the Accord was launched in 2002 (2003 model year in North America), and consists of two separate models; one for the Japanese and European markets, and the other for North America, with the Japanese and European model being sold in North America as the Acura TSX. However, both were in fact sold in many other markets, fueled by the popular Cog advertisement for the Accord. Euro R trim continued into this generation as performance model for Japanese market, making use of K20 engine producing 220 hp (164 kW), however, European performance model was renamed Type S and used a larger K24 engine tuned to produce 190 hp (142 kW).",
            YearOfManufacture = Convert.ToDateTime("11/08/2002")
        };
        internal static GenerationData eightG = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Accord",
            Name = "Accord 8th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "he updated Accord for the Japanese and European markets went on sale in mid-2008. It is also sold as the Accord Euro in the Australia and New Zealand markets, and as the Acura TSX in North America. It is available as both a sedan and a station wagon. In the People's Republic of China, a version of the sedan is sold as the Honda Spirior which later on developed an independent second generation. Production began in August 2009 in China, by Dongfeng Honda. Production ended at the end of February 2015 for Australia and New Zealand spec models.",
            YearOfManufacture = Convert.ToDateTime("15/06/2008")
        };
        internal static GenerationData ninthG = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Accord",
            Name = "Accord 9th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "For the ninth generation Accord, Honda appointed Shoji Matsui, who served as an engineer on the Accord platform from 1985 to 1996, as lead project manager. It is the first Honda vehicle to be completely developed under the administration of Honda CEO Takanobu Ito.",
            YearOfManufacture = Convert.ToDateTime("14/09/2013")
        };

        internal static List<GenerationData> accordGeneration => new List<GenerationData>
        {
            seventhG, eightG, ninthG
        };

        internal static GenerationData fifthGen = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Civic",
            Name = "Civic 5th gen",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "Introduced in September 1991 for the 1992 model year, the redesigned Civic featured increased dimensions, as well as more aerodynamic styling. The wagon variant was now only available in the Japanese market where the previous generation wagon was carried over until 1995. The efficiency of the previous HF model was replaced by the VX hatchback which, with an EPA rating of 48/55 MPG, was Honda's most fuel efficient model sold at the time.",
            YearOfManufacture = Convert.ToDateTime("02/09/1991")
        };
        internal static GenerationData sevenhtGen = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Civic",
            Name = "Civic 7th gen",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "FWD",
            Description = "The seventh generation was released in September 2000, for the 2001 model year. While the redesign retained the previous generation's exterior dimensions, interior space was improved in part by using a flat rear floor thus bumping up Civic to a compact car size segment. The front suspension was changed from that of a double wishbone to a MacPherson strut, in order to lower costs, as well as allow more engine bay room for the newly introduced Honda K-series engine. Power was also increased on some trim levels.",
            YearOfManufacture = Convert.ToDateTime("28/05/2000")
        };
        internal static GenerationData ninthGen = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "Civic",
            Name = "Civic 9th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "On 13 December 2010, Honda unveiled a sketch of the new ninth generation Civic which was described as `energetic, sleek and aerodynamic`. Both coupe and sedan concepts were shown on 10 January 2011 at the 2011 North American International Auto Show. The production version of the ninth generation Civic (previewed by the concept) went on sale in the U.S. on 20 April 2011. In late 2012, Honda updated its Civic model with new exterior and interior trims for the 2013 year.",
            YearOfManufacture = Convert.ToDateTime("12/02/2011")
        };

        internal static List<GenerationData> civicGeneration => new List<GenerationData>
        {
            fifthGen, sevenhtGen, ninthGen
        };

        internal static GenerationData secondGene = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "CR-V",
            Name = "CR-V 2nd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The second generation CR-V was a full redesign, based on the seventh generation Civic, and powered by the K24A1 engine. Southeast Asian models produced 150 hp (112 kW) of power and 190 N⋅m (140 lbf⋅ft) while the North American versions of the new engine produced 160 hp (119 kW) and 190 N⋅m (140 lbf⋅ft) of torque. Per new SAE regulations, the same North American K24A1 engine is now rated at 156 hp (116 kW) and 160 lb⋅ft (217 N⋅m).",
            YearOfManufacture = Convert.ToDateTime("08/04/2002")
        };
        internal static GenerationData thirdGene = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "CR-V",
            Name = "CR-V 3rd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The third generation CR-V went on sale in the U.S. in late September 2006 for the 2007 model year. Unlike preceding models, it features a rear liftgate rather than a side-opening rear door and no longer has the spare tire mounted on the rear door.",
            YearOfManufacture = Convert.ToDateTime("22/09/2006")
        };
        internal static GenerationData fourthGene = new GenerationData
        {
            MarkId = "Honda",
            ModelsId = "CR-V",
            Name = "CR-V 4th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The CR-V Concept debuted at the Orange County International Auto Show in September 2011, the production 2012 CR-V debuted at the 2011 Los Angeles Auto Show. The CR-V went on sale in the U.S. on 15 December 2011",
            YearOfManufacture = Convert.ToDateTime("14/09/2011")
        };

        internal static List<GenerationData> crvGeneration => new List<GenerationData>
        {
            secondGene, thirdGene, fourthGene
        };

        internal static GenerationData m4G = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Lancer",
            Name = "Lancer 4th gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "FWD",
            Description = "In 1982, the launch of a new model, called the Lancer Fiore, also known as the third version, based on the Mitsubishi Mirage, was launched. Fiore was often sold on world markets like the Lancer and Mirage Sedan, as well as a five-door hatchback modification that remained in production for most of the 1980s. In Australia, the third version of the Lancer was sometimes sold under the name Mitsubishi Colt Sedan, which underwent only cosmetic changes. Thus, Mitsubishi had two models of the same class competing in the same market segment.",
            YearOfManufacture = Convert.ToDateTime("07/05/1982")
        };
        internal static GenerationData m5G = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Lancer",
            Name = "Lancer 5th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "In 1988, Lancer received a new, more aerodynamic body shape, made in the style of the Galant model. A five-door hatchback was added to the program. The division into Mirage and Lancer continued. The station wagon was still produced on the old platform and in the old case, presented in some markets as a five-door version of Mirage.",
            YearOfManufacture = Convert.ToDateTime("06/07/1988")
        };
        internal static GenerationData m6G = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Lancer",
            Name = "Lancer 6th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "May 2000 saw the release in Japan of the Lancer Cedia (meaning CEntury DIAmond); though in most markets the previous 1995 vintage Mirage-based Lancer continued on, built at Mitsubishi's Mizushima plant in Japan. The new model was available in sedan and station wagon forms. In Europe, the Lancer was not offered in some countries, being too close to the size of the Dutch-built Mitsubishi Carisma, so the Evo VII model sold there bore the Carisma name. This series of Lancer is still sold in Japan where the 2007 onwards generation Lancer is known as `Galant Fortis`.",
            YearOfManufacture = Convert.ToDateTime("06/06/2000")
        };

        internal static List<GenerationData> lancerGeneration => new List<GenerationData>
        {
            m4G, m5G, m6G
        };

        internal static GenerationData g5m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Galant",
            Name = "Galant 5th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "A fifth-generation model shifted to front-wheel drive in August 1983 as a four-door sedan and four-door hardtop (with different styling). The design continued the direction started with the Tredia, albeit with more harmonious proportions. Drag resistance was down to an average 0.36. All new chassis numbers, from E11A to E19A, marked the change. External dimensions all grew, but only marginally, while the wheelbase was 7 cm (2.8 in) longer.",
            YearOfManufacture = Convert.ToDateTime("01/08/1983")
        };
        internal static GenerationData g6m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Galant",
            Name = "Galant 6th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "In 1987 the same platform was used for a sixth-generation model which adopted taller, rounded styling. This generation won the Car of the Year Japan award in 1987 and the GS model became Motor Trend's Import Car of the Year in 1989. This Galant began American sales in 1989 side by side with the previous generation Sigma.",
            YearOfManufacture = Convert.ToDateTime("02/04/1987")
        };
        internal static GenerationData g7m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Galant",
            Name = "Galant 7th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "A new Galant debuted in September 1992 at the Tokyo Motor Show (model year 1994 in the US), originally only available as a four-door sedan (which was the only model to be sold in the US). A five-door liftback derivative made its world premiere at the February 1993 Dutch Motor Show.[47] A Japan-only hardtop derivative called the (Japanese: Emeraude) (French for emerald) was also launched in 1992. The width dimensions of the model sold in Japan no longer complied with Japanese Government dimension regulations, and buyers were now liable for additional taxes, which affected sales.",
            YearOfManufacture = Convert.ToDateTime("05/08/1992")
        };

        internal static List<GenerationData> galantGeneration => new List<GenerationData>
        {
            g5m, g6m, g7m
        };

        internal static GenerationData ge3m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Pajero",
            Name = "Pajero 3rd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Mitsubishi redesigned the Pajeros for a second generation, which debuted in January 1991, although exports did not commence until later in the year. Just about everything was now new and further enhanced. A new, larger body was available in four different versions; Metal Top, Canvas Top Convertible (short wheelbase), Semi High Roof Wagon and High Roof Wagon (long wheelbase).",
            YearOfManufacture = Convert.ToDateTime("30/01/1991")
        };
        internal static GenerationData ge4m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Pajero",
            Name = "Pajero 4th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "Designed in house, the third generation Pajero debuted in the Japanese domestic market in 1999, and in other markets in late 2000 as a 2001 model — and in the Philippines and other developing nations in 2003.",
            YearOfManufacture = Convert.ToDateTime("17/09/1999")
        };
        internal static GenerationData ge5m = new GenerationData
        {
            MarkId = "Mitsubishi",
            ModelsId = "Pajero",
            Name = "Pajero 5th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The fourth generation debuted at the Paris Motor Show on 30 September 2006 with the series code `NS`. Revised interior and exterior styling were accompanied by dual-stage SRS front airbags as well as new side-impact and curtain airbags. The chassis was a mildy improved monocoque with Mitsubishi's RISE technology as featured in the previous generation.",
            YearOfManufacture = Convert.ToDateTime("30/09/2006")
        };

        internal static List<GenerationData> pajeroGeneration => new List<GenerationData>
        {
            ge3m, ge4m, ge5m
        };

        internal static GenerationData s1G = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Impreza",
            Name = "Impreza 1st gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Announced on 22 October 1992, the Impreza was released in Japan in November and offered in either front-wheel drive (FWD) or all-wheel drive (AWD) versions and as a four-door sedan or five-door hatchback/wagon (Touring). The car used a shortened version of the Legacy's floor pan. According to a Motor Trend article written March 1992 on page 26, the name of Subaru's new compact was, initially, to be called the Loyale, displaying an official photograph of the four-door sedan.",
            YearOfManufacture = Convert.ToDateTime("22/10/1992")
        };
        internal static GenerationData s2G = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Impreza",
            Name = "Impreza 2nd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Subaru introduced the `New Age` Impreza to Japan in August 2000. Larger in size compared to the previous iteration, the sedan increased its width by 40 millimetres (1.6 in), while the wagon notably increased by just 5 millimetres (0.2 in)—placing the two variants in different Japanese classification categories. The coupe body style from the first generation did not reappear for the new series, and the off-road appearance package that included contrasting-colored bumpers did carry over forward. Marketed as a separate model line, this North America-only variant was, as before, badged the Outback Sport.",
            YearOfManufacture = Convert.ToDateTime("14/08/2002")
        };
        internal static GenerationData s3G = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Impreza",
            Name = "Impreza 3rd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Subaru revealed the third generation Impreza at the New York Auto Show on 2 April 2007—both the standard naturally aspirated Impreza and turbocharged WRX versions were revealed. The 3rd generation of the high performance WRX STI debuted in October 2007. Initially, the new Impreza was offered as a five-door hatchback (designated GH), with the four-door sedan (designated GE) introduced in 2008.",
            YearOfManufacture = Convert.ToDateTime("02/04/2007")
        };

        internal static List<GenerationData> imprezaGeneration => new List<GenerationData>
        {
            s1G, s2G, s3G
        };

        internal static GenerationData s2Ge = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Forester",
            Name = "Forester 2nd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The second generation was introduced as a 2003 model at the 2002 Chicago Auto Show, based on the new Impreza platform, featuring several fine-tune improvements over the past model. The 2003 Forester features weight-saving refinements such as an aluminum hood, perforated rails, and a hydro-formed front sub-frame. The most noticeable change was the offering of 2.5 L versions (normally aspirated and turbocharged) and in the U.S. the introduction of the turbo charged 2.5-liter model.",
            YearOfManufacture = Convert.ToDateTime("25/10/2002")
        };
        internal static GenerationData s3Ge = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Forester",
            Name = "Forester 3rd gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The third generation Forester began to move away from a traditional wagon design towards becoming a crossover SUV. It was larger in nearly every dimension and featured a sloping roof line with more cargo space. Subaru unveiled the model year 2008 Forester in Japan on December 25, 2007. The North American version made its debut at the 2008 North American International Auto Show in Detroit.",
            YearOfManufacture = Convert.ToDateTime("21/02/2008")
        };
        internal static GenerationData s4Ge = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Forester",
            Name = "Forester 4th gen",
            Country = "Japan",
            BodyType = "SUV",
            DrivenWheel = "AWD",
            Description = "The fourth-generation Forester was unveiled in the 2012 Guangzhou Motor Show, followed by the 2013 New York International Auto Show.",
            YearOfManufacture = Convert.ToDateTime("09/04/2012")
        };

        internal static List<GenerationData> foresterGeneration => new List<GenerationData>
        {
            s2Ge, s3Ge, s4Ge
        };

        internal static GenerationData s2Gen = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Legacy",
            Name = "Legacy 2nd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Second generation sales in Japan began October 7, 1993, and an introductory price of ¥2,753,000 for the twin turbo GT (approx US$25,250 at 1993 yen exchange rate), with an introduction for model year 1995 in North America with a full body and chassis revision. The exterior was designed by Olivier Boulay, who was hired by Subaru on a short-term basis. The tail light appearance on both the sedan and wagon was influenced by the taillights on the SVX.",
            YearOfManufacture = Convert.ToDateTime("07/10/1993")
        };
        internal static GenerationData s3Gen = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Legacy",
            Name = "Legacy 3rd gen",
            Country = "Japan",
            BodyType = "Wagon",
            DrivenWheel = "AWD",
            Description = "Subaru launched the third generation Japanese and world-market Legacy in June 1998, while the North American model started production in late 1999 as a 2000 model, also known as the BE for sedan models and BH for wagons. European-market and Japanese models ranged from a normally aspirated 2.0 L flat-4 to the EZ30 flat-6 in the 3.0R model (European and Japanese trim level designation), with the twin turbo that was offered in the previous generation still offered on performance models.",
            YearOfManufacture = Convert.ToDateTime("17/06/1998")
        };
        internal static GenerationData s4Gen = new GenerationData
        {
            MarkId = "Subaru",
            ModelsId = "Legacy",
            Name = "Legacy 4th gen",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "AWD",
            Description = "On May 23, 2003, Fuji Heavy Industries debuted the redesigned Legacy, known as the BL for sedan models and BP for wagons. It was released worldwide in 2004, with Subaru Indiana Automotive commencing production in February 2004 for the North American markets for 2005 model year. The Legacy was presented the 2003–2004 Japan Car of the Year, Subaru's first win for the award after fighting off stiff competition from Toyota Prius and Mazda RX-8.",
            YearOfManufacture = Convert.ToDateTime("23/05/2003")
        };

        internal static List<GenerationData> legacyGeneration => new List<GenerationData>
        {
            s2Gen, s3Gen, s4Gen
        };

        internal static GenerationData xv40 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Camry",
            Name = "XV40",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "This generation of Camry saw even greater differentiation between `regular` model sold internationally (including Japan) and the `prestige` Camry sold in the rest of Asia. The regular Camry, fitted with four-cylinder engines sold alongside the V6-engined prestige Camry in Oceania and the Middle East as the Toyota Aurion.",
            YearOfManufacture = Convert.ToDateTime("15/11/2006")
        };
        internal static GenerationData xv50 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Camry",
            Name = "XV50",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "The XV50 Camry was produced from 21 August 2011, introduced on 23 August 2011, and began U.S. sales in September 2011. The interior received a major restyling, while the exterior received all-new sheet metal and more angular styling.",
            YearOfManufacture = Convert.ToDateTime("21/08/2011")
        };
        internal static GenerationData t8G = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Camry",
            Name = "XV70",
            Country = "Japan",
            BodyType = "Sedan",
            DrivenWheel = "FWD",
            Description = "he latest Camry, which is the eighth generation of the global Camry model,[148] and known as the XV70 was introduced at the January 2017 North American International Auto Show.[147] It was launched in Japan on 10 July 2017 and in Australia on 21 November 2017. North American production started in June 2017 and sales began in late July 2017.[149] Due to the need to equip Toyota Motor Manufacturing Kentucky with new equipment for Toyota New Global Architecture, a small portion of the initial North American production was sourced from the Tsutsumi plant in Japan.",
            YearOfManufacture = Convert.ToDateTime("10/07/2017")
        };

        internal static List<GenerationData> camryGeneration => new List<GenerationData>
        {
            xv40, xv50, t8G
        };

        internal static GenerationData t5Ge = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Hilux",
            Name = "Hilux 5th gen",
            Country = "Japan",
            BodyType = "Pickup",
            DrivenWheel = "AWD",
            Description = "The next redesign, in 1988, introduced a longer-wheelbase option, 3,099 mm (122 in) rather than 2,616 mm (103 in) for the regular wheelbase. Its one-piece cargo-box walls eliminated the rust-prone seams that were found in earlier models. The V6 Xtracab SR5 earned Motor Trend magazine's Truck of the Year award that year. The Xtra Cabs now featured more room behind the front seats than the last generation which allowed optional jump-seats for rear passengers, a feature more in line with competitors of the time.",
            YearOfManufacture = Convert.ToDateTime("15/05/1988")
        };
        internal static GenerationData t7Ge = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Hilux",
            Name = "Hilux 7th gen",
            Country = "Japan",
            BodyType = "Pickup",
            DrivenWheel = "AWD",
            Description = "The seventh generation of the Hilux (designated the AN10/AN20/AN30), part of the IMV program, started production in Thailand during August 2004.[24] Three pickup truck body variants were initially produced: a two-door Single Cab (referred to by Toyota as IMV1), a two-door Xtra Cab (IMV2), and four-door Double Cab (IMV3). In September 2008, Toyota introduced the Smart Cab, a four-door with hidden rear suicide doors.",
            YearOfManufacture = Convert.ToDateTime("06/08/2004")
        };
        internal static GenerationData t8Ge = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Hilux",
            Name = "Hilux 8th gen",
            Country = "Japan",
            BodyType = "Pickup",
            DrivenWheel = "AWD",
            Description = "The eighth generation of the Toyota Hilux was officially introduced simultaneously on 21 May 2015 in Bangkok, Thailand and Sydney, Australia. However, the pickup truck was available for sale in the showrooms from October, 5 months after its official introduction.",
            YearOfManufacture = Convert.ToDateTime("21/05/2015")
        };
        internal static List<GenerationData> hiluxGeneration => new List<GenerationData>
        {
            t5Ge, t7Ge, t8Ge
        };

        internal static GenerationData a70 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Supra",
            Name = "A70",
            Country = "Japan",
            BodyType = "Targa",
            DrivenWheel = "RWD",
            Description = "In February 1986, the bonds between the Celica and the Supra were cut; they were now two completely different models. The Celica changed to a front-wheel drive layout, using the Toyota `T` platform associated with the Corona, while the Supra kept its rear-wheel-drive layout. The engine was updated to a more powerful 2,954 cc (3.0 L) inline-six engine rated at 149 kW (200 hp; 203 PS). Although initially only available with naturally aspirated engines, a turbocharged version was added in the 1987 model year. The Supra was now mechanically related to the Soarer for the Japanese market.",
            YearOfManufacture = Convert.ToDateTime("09/02/1986")
        };
        internal static GenerationData a80 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Supra",
            Name = "A80",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "The A80 program began in February 1989 under various teams for design, product planning, and engineering led by Isao Tsuzuki. By the middle of 1990, a final A80 design concept from Toyota Technical Centre Aichi was approved and frozen for production in late 1990. The first test mules were hand-built in A70 bodies during late 1990, followed by the first A80 prototypes being hand-assembled in 1991. Again using subframe, suspension, and drivetrain assemblies from the Z30 Soarer (Lexus SC300/400), pre-production of the test models started in December 1992 with 20 units made,[21] and official mass production began in April 1993.",
            YearOfManufacture = Convert.ToDateTime("01/04/1993")
        };
        internal static GenerationData a90 = new GenerationData
        {
            MarkId = "Toyota",
            ModelsId = "Supra",
            Name = "A90",
            Country = "Japan",
            BodyType = "Coupe",
            DrivenWheel = "RWD",
            Description = "The fifth generation of the Supra was unveiled at the 2019 North American International Auto Show held in January. The car is a collaboration between Toyota and BMW and is based on the Z4. The Supra went on sale in Japan on 17 May 2019. In the United States, sales began on 22 July 2019.",
            YearOfManufacture = Convert.ToDateTime("17/05/2019")
        };
        internal static List<GenerationData> supraGeneration => new List<GenerationData>
        {
            a70, a80, a90
        };
        public static void Initialize(CarsDbContext db)
        {
            initializeMarks(db);
            initializeModels(db);
            initializeGenerations(db);
        }
        private static void initializeModels(CarsDbContext db)
        {
            if (db.Models.Count() != 0) return;
            db.Models.AddRange(bmwModels);
            db.Models.AddRange(mercedesModels);
            db.Models.AddRange(hondaModels);
            db.Models.AddRange(toyotaModels);
            db.Models.AddRange(lamborghiniModels);
            db.Models.AddRange(porscheModels);
            db.Models.AddRange(subaruModels);
            db.Models.AddRange(mitsubishiModels);
            db.Models.AddRange(volkswagenModels);
            db.Models.AddRange(audiModels);

            db.SaveChanges();
        }

        private static void initializeMarks(CarsDbContext db)
        {
            if (db.Marks.Count() != 0) return;
            db.Marks.AddRange(marks);
            db.SaveChanges();
        }

        private static void initializeGenerations(CarsDbContext db)
        {
            if (db.Generations.Count() != 0) return;
            db.Generations.AddRange(ttGeneration);
            db.Generations.AddRange(a4Generation);
            db.Generations.AddRange(q7Generation);
            db.Generations.AddRange(series3Generation);
            db.Generations.AddRange(series5Generation);
            db.Generations.AddRange(x5Generation);
            db.Generations.AddRange(accordGeneration);
            db.Generations.AddRange(civicGeneration); 
            db.Generations.AddRange(crvGeneration);
            db.Generations.AddRange(diabloGeneration);
            db.Generations.AddRange(gallardoGeneration);
            db.Generations.AddRange(murcielagoGeneration);
            db.Generations.AddRange(eClassGeneration);
            db.Generations.AddRange(sClassGeneration);
            db.Generations.AddRange(gClassGeneration);
            db.Generations.AddRange(lancerGeneration);
            db.Generations.AddRange(galantGeneration);
            db.Generations.AddRange(pajeroGeneration);
            db.Generations.AddRange(p911Generation);
            db.Generations.AddRange(cayenneGeneration);
            db.Generations.AddRange(panameraGeneration);
            db.Generations.AddRange(imprezaGeneration);
            db.Generations.AddRange(foresterGeneration);
            db.Generations.AddRange(legacyGeneration);
            db.Generations.AddRange(camryGeneration);
            db.Generations.AddRange(hiluxGeneration);
            db.Generations.AddRange(supraGeneration);
            db.Generations.AddRange(golfGeneration);
            db.Generations.AddRange(passatGeneration);
            db.Generations.AddRange(caravelleGeneration);
            db.SaveChanges();
        }

    }
}
