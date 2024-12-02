using Konyvek_dolgozat;
Random random = new Random();


List<Book> book = [
    new Book() {
        Cim = "Angyalok és Démonok",
        Szerzok = "Aliz Angéla"
    },
    new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Sign of the Invisible Creek",
        KiadasEve = 2009,
        Nyelv = "angol",
        Keszlet = 10,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Rácz Rebeka", "Deák Olivér"]
    },
        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Trials of Fire",
        KiadasEve = 2013,
        Nyelv = "angol",
        Keszlet = 5,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Papp Zsombor", "Németh Albert"]
    },
        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Partner in Crime",
        KiadasEve = 2009,
        Nyelv = "angol",
        Keszlet = 2,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Takács László", "Kovács Árpád"]
    },
        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Szabadság",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Barta Marietta", "Rácz Olivér"]
    },
        new Book() {
        Cim = "Becsavarodottak",
        Szerzok = "Faragó Barna"
    },
        new Book() {
        Cim = "Éjjeli pokol",
        Szerzok = "Vörös Boróka"
    },
        new Book() {
        Cim = "Halálos vihar",
        Szerzok = "Vass Ernő"
    },
        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "A legenda visszatérése",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Varga Bendegúz", "Rácz Olivér", "Balogh Kornél"]
    },
        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Vadnyugat",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = 4900,
        Szerzok = ["Bogdán Rudolf"]
    },

        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Sötétség árnyéka",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Takács Marietta", "Rácz Dalma"]
    },

        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Arany érintés",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Fekete Olivér", "Vörös Ernő"]
    },

        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Hang királyság",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Barta Marietta", "Rácz Olivér"]
    },

        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Shangri-la bukása",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["Szabó Béla", "Illés Johanna"]
    },

        new Book() {
        ISBN = random.Next(0, 999999999),
        Cim = "Gravitációs erő",
        KiadasEve = 2009,
        Nyelv = "magyar",
        Keszlet = 7,
        Ar = random.Next(1000, 10000),
        Szerzok = ["László Vilmos", "Fábián Jázmin", "Fodor Gitta"]
    },
    ];